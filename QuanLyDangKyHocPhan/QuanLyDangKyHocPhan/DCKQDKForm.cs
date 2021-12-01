using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;
using OfficeOpenXml;

namespace QuanLyDangKyHocPhan
{
    public partial class DCKQDKForm : Form
    {
        List<HocPhan> listHP;
        List<HocPhan> listKQ;
        SinhVien currentSV;
        SinhVienBL svBL = SinhVienBL.getInstance();
        int nam, soLuongDangKy;
        string currentYear = DateTime.Now.Year.ToString() + " - " + (DateTime.Now.Year + 1).ToString();

        public DCKQDKForm(string mssv)
        {
            currentSV = svBL.GetByMSSV(int.Parse(mssv));
            nam = GetNam(mssv);

            InitializeComponent();
        }

        #region

        /// <summary>
        /// Hàm tính năm học của sinh viên: vd
        /// 1914775 -> sinh viên năm 3
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private int GetNam(string user)
        {
            int curYear = DateTime.Now.Year;
            currentSV = svBL.GetByMSSV(int.Parse(user));

            return curYear - 2000 - int.Parse(user.Substring(0, 2)) + 1;
        }

        /// <summary>
        /// Hàm lấy danh sách các môn học đã đăng ký trong học kỳ này
        /// </summary>
        private void LoadCurrent_DSKQ()
        {
            HocPhanBL hpBL = HocPhanBL.getInstance();
            listKQ = hpBL.GetCurrentKQHP(currentSV.MSSV, int.Parse(cbbHK.Text == "" ? "0" : cbbHK.Text), currentYear);
            lvKQDK.Items.Clear();

            foreach (var hp in listKQ)
            {
                lbTitle.Text = String.Format("Danh sách học phần sinh viên {0} đã đăng ký trong học kỳ {1}",
                    currentSV.HoLot + " " + currentSV.Ten, hp.HocKy);

                soLuongDangKy += hp.TongSoTC;
                txtQuantity.Text = soLuongDangKy.ToString();

                ListViewItem item = lvKQDK.Items.Add(hp.MaHP.ToString());
                item.SubItems.Add(hp.TenHP);
                item.SubItems.Add(hp.LoaiHP);
                item.SubItems.Add(hp.TongSoTC.ToString());

            }
        }

        /// <summary>
        /// Xuất kết quả đăng ký học phần
        /// </summary>
        /// <param name="hocphans"></param>
        private void LoadKQHP(List<HocPhan> hocphans)
        {
            int soLuongDangKy = 0;
            txtQuantity.Text = soLuongDangKy.ToString();
            lvKQDK.Items.Clear();

            foreach (var hp in hocphans)
            {
                ListViewItem item = lvKQDK.Items.Add(hp.MaHP);
                item.SubItems.Add(hp.TenHP);
                item.SubItems.Add(hp.LoaiHP);
                item.SubItems.Add(hp.TongSoTC.ToString());

                if (soLuongDangKy <= 25)
                {
                    soLuongDangKy += hp.TongSoTC;
                    txtQuantity.Text = soLuongDangKy.ToString();
                }
                else if (soLuongDangKy > 25)
                    MessageBox.Show("Số lượng đăng ký không được quá 25 tín chỉ");
            }
        }

        /// <summary>
        /// Xuất danh sách học phần đã được lên kế hoạch giảng dạy cho từng học kì
        /// Tương ứng với học kỳ và năm học của sinh viên đăng nhập
        /// sẽ xuất ra danh sách học phần tương ứng.
        /// </summary>
        private void LoadDSHP()
        {
            HocPhanBL hpBL = HocPhanBL.getInstance();
            listHP = hpBL.GetHPTheoKeHoach(currentSV.MSSV, nam, int.Parse(cbbHK.Text == "" ? "0" : cbbHK.Text), currentSV.Khoa);
            lvHP.Items.Clear();

            foreach (var hp in listHP)
            {
                ListViewItem item = lvHP.Items.Add(hp.MaHP.ToString());
                item.SubItems.Add(hp.TenHP);
                item.SubItems.Add(hp.LoaiHP);
                item.SubItems.Add(hp.TongSoTC.ToString());
            }
        }

        /// <summary>
        /// Lấy thông tin của học phần trên listview
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private HocPhan GetHPLV(ListViewItem item)
        {
            HocPhan hp = new HocPhan();
            hp.MaHP = item.SubItems[0].Text;
            hp.TenHP = item.SubItems[1].Text;
            hp.LoaiHP = item.SubItems[2].Text;
            hp.TongSoTC = int.Parse(item.SubItems[3].Text);

            return hp;
        }

        private int DieuChinhKQHP()
        {
            ChiTietDangKy ct = new ChiTietDangKy();
            if (lvKQDK.Items.Count < 0)
                MessageBox.Show("Chưa chọn học phần để đăng ký, vui lòng chọn học phần");
            else
            {

                foreach (var item in listKQ)
                {
                    ct.MSSV = currentSV.MSSV;
                    ct.MaHP = item.MaHP;
                    ct.NgayDangKy = DateTime.Now.ToShortDateString();
                    ct.HocKy = int.Parse(cbbHK.Text);
                    ct.NamHoc = DateTime.Now.Year.ToString() + " - " + (DateTime.Now.Year + 1).ToString();

                    ChiTietDKBL ctBL = ChiTietDKBL.getInstance();

                    ctBL.DieuChinhHocPhan(ct);
                }
                return 1;
            }
            return -1;
        }

        /// <summary>
        /// Xuất kêt quả đăng ký
        /// </summary>
        /// <param name="lv"></param>
        /// <param name="listKQDK"></param>
        /// <param name="path"></param>
        private void WriteToExcel(ListView lv, List<HocPhan> listKQDK, string path)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (ExcelPackage p = new ExcelPackage())
            {
                p.Workbook.Worksheets.Add("sheet 1");
                ExcelWorksheet ws = p.Workbook.Worksheets[0];
                ws.Name = "sheet 1";
                ws.Cells.Style.Font.Size = 11;
                ws.Cells.Style.Font.Name = "Calibri";

                List<string> arrCollumHeader = new List<string>();
                foreach (ColumnHeader item in lv.Columns)
                {
                    arrCollumHeader.Add(item.Text);
                }
                var countColHeader = arrCollumHeader.Count();

                int colIndex = 1;
                int rowIndex = 1;
                //Tao cac Header
                foreach (var item in arrCollumHeader)
                {
                    var cell = ws.Cells[rowIndex, colIndex];
                    var style = cell.Style.Font;
                    style.Bold = true;

                    cell.Value = item;
                    colIndex++;
                }

                //Lay danh sach sinh vien
                foreach (var item in listKQDK)
                {
                    colIndex = 1;
                    rowIndex++;
                    ws.Cells[rowIndex, colIndex++].Value = item.MaHP;
                    ws.Cells[rowIndex, colIndex++].Value = item.TenHP;
                    ws.Cells[rowIndex, colIndex++].Value = item.LoaiHP;
                    ws.Cells[rowIndex, colIndex++].Value = item.TongSoTC;
                }
                //save file
                Byte[] bin = p.GetAsByteArray();
                File.WriteAllBytes(path, bin);
            }
        }

        /// <summary>
        /// Xoá học phần vừa đăng ký ra khỏi phiếu học phần
        /// </summary>
        /// <param name="mssv"></param>
        /// <param name="mahp"></param>
        /// <returns></returns>
        private int Delete(int mssv, string mahp)
        {
            ChiTietDKBL ctdkBL = ChiTietDKBL.getInstance();
            return ctdkBL.DeleteByKey(mssv, mahp);
        }
        #endregion

        private void cbbHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbHK.Text == "") return;
            LoadCurrent_DSKQ();
            LoadDSHP();
        }

        private void DCKQDKForm_Load(object sender, EventArgs e)
        {
            LoadDSHP();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            int result = DieuChinhKQHP();
            if (result > 0)
            {
                MessageBox.Show("Điều chỉnh học phần thành công !!");
                LoadDSHP();
                cbbHK.Enabled = false;
            }
            else MessageBox.Show("Cập nhật dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu nhập");
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = string.Format("DangKyHP SV{0} Hoc Ky {1} {2}", currentSV.MSSV.ToString(), cbbHK.Text, DateTime.Now.Year.ToString() + " - " + (DateTime.Now.Year + 1).ToString());
            saveFileDialog1.InitialDirectory = @"E:\";
            saveFileDialog1.DefaultExt = "xlsx";
            saveFileDialog1.Filter = "Excel 2007 files(xlsx) (*.xlsx)|*.xlsx";

            List<HocPhan> kqhp = new List<HocPhan>();
            int i = this.lvKQDK.Items.Count - 1;
            while (i >= 0)
            {
                kqhp.Add(GetHPLV(this.lvKQDK.Items[i]));
                i--;
            }

            DialogResult dlg = saveFileDialog1.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                string path = string.Format(@"{0}", saveFileDialog1.FileName);
                WriteToExcel(lvKQDK, kqhp, path);
                MessageBox.Show("Xuất phiếu đăng ký thành công!");
            }
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            ListViewItem item;
            int count = lvKQDK.Items.Count - 1;
            for (int i = count; i >= 0; i--)
            {
                item = lvKQDK.Items[i];
                if (item.Selected)
                {
                    int result = Delete(currentSV.MSSV, item.SubItems[0].Text.ToString().Trim());
                    if (result > 0)
                    {
                        lvKQDK.Items.Remove(item);
                        LoadDSHP();
                    }
                    else MessageBox.Show("Cập nhật dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu nhập");
                }
            }
        }

        private void lvHP_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            HocPhanBL hpBL = HocPhanBL.getInstance();
            listKQ = hpBL.GetCurrentKQHP(currentSV.MSSV, int.Parse(cbbHK.Text == "" ? "0" : cbbHK.Text), currentYear);
            int i = this.lvHP.CheckedItems.Count - 1;
            while (i >= 0)
            {
                listKQ.Add(GetHPLV(this.lvHP.CheckedItems[i]));
                i--;
            }
            LoadKQHP(listKQ);
        }
    }
}
