using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace QuanLyDangKyHocPhan
{
    public partial class SinhVienForm : Form
    {
        SinhVienBL svBL = SinhVienBL.getInstance();
        List<SinhVien> listSV;
        SinhVien svcurrent;
        private DataTable BangSV;
        public SinhVienForm()
        {
            InitializeComponent();
        }

        #region
        private void LoadSinhVienToListView()
        {
            listSV = svBL.GetAll();
            lvSV.Items.Clear();
            foreach (var sv in listSV)
            {
                ListViewItem item = lvSV.Items.Add(sv.MSSV.ToString());
                item.SubItems.Add(sv.HoLot);
                item.SubItems.Add(sv.Ten);
                item.SubItems.Add(sv.GioiTinh == true ? "Nam" : "Nữ");
                item.SubItems.Add(sv.NgaySinh);
                item.SubItems.Add(sv.TenLop);
                item.SubItems.Add(sv.Khoa);
                item.SubItems.Add(sv.DiaChi);
            }
        }

        /// <summary>
        /// Hàm đọc danh sách sinh viên từ excel
        /// </summary>
        /// <param name="path"></param>
        private void ReadFromExcel(string path)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            try
            {
                // mo file excel
                var package = new ExcelPackage(new System.IO.FileInfo(path));
                using (package)
                {
                    // lay ra tuan sheet dau tien
                    ExcelWorksheet workSheet = package.Workbook.Worksheets[0];
                    for (int i = workSheet.Dimension.Start.Row + 1; i <= workSheet.Dimension.End.Row; i++)
                    {
                        try
                        {
                            // column
                            int j = 1;

                            string MSSV = workSheet.Cells[i, j++].Value.ToString();
                            string HoLot = workSheet.Cells[i, j++].Value.ToString();
                            string Ten = workSheet.Cells[i, j++].Value.ToString();
                            bool GioiTinh = workSheet.Cells[i, j++].Value.ToString() == "Nam" ? true : false;
                            string NgaySinh = DateTime.Now.ToShortDateString();
                            j++;
                            string TenLop = workSheet.Cells[i, j++].Value.ToString();
                            string Khoa = workSheet.Cells[i, j++].Value.ToString();
                            string DiaChi = "";

                            SinhVien sv = new SinhVien()
                            {
                                MSSV = int.Parse(MSSV),
                                HoLot = HoLot,
                                Ten = Ten,
                                GioiTinh = GioiTinh,
                                NgaySinh = NgaySinh,
                                TenLop = TenLop,
                                Khoa = Khoa,
                                DiaChi = DiaChi
                            };

                            listSV.Add(sv);
                        }
                        catch (Exception ex) { }
                    }
                }
                lvSV.Items.Clear();
                foreach (var sv in listSV)
                {
                    ListViewItem item = lvSV.Items.Add(sv.MSSV.ToString());
                    item.SubItems.Add(sv.HoLot);
                    item.SubItems.Add(sv.Ten);
                    item.SubItems.Add(sv.GioiTinh == true ? "Nam" : "Nữ");
                    item.SubItems.Add(sv.NgaySinh);
                    item.SubItems.Add(sv.TenLop);
                    item.SubItems.Add(sv.Khoa);
                    item.SubItems.Add(sv.DiaChi);
                }

            }
            catch (Exception ex) { }
        }

        private void SaveData()
        {
            foreach (var sv in listSV)
            {
                Thread.Sleep(10);
                svBL.Insert(sv);
            }
        }
        #endregion

        private void SinhVienForm_Load(object sender, EventArgs e)
        {
            LoadSinhVienToListView();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var svInFo = new SinhVienInfo();
            svInFo.LoadStatusAdd();
            if (svInFo.ShowDialog() == DialogResult.OK)
            {
                LoadSinhVienToListView();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            svcurrent = new SinhVien();
            if (MessageBox.Show("Bạn chắc chứ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ListViewItem item = lvSV.SelectedItems[0];
                svcurrent.MSSV = int.Parse(item.SubItems[0].Text);
                svcurrent.HoLot = item.SubItems[1].Text;
                svcurrent.Ten = item.SubItems[2].Text;
                svcurrent.GioiTinh = item.SubItems[3].Text == "Nam" ? true : false;
                svcurrent.NgaySinh = item.SubItems[4].Text;
                svcurrent.TenLop = item.SubItems[5].Text;
                svcurrent.Khoa = item.SubItems[6].Text;
                svcurrent.DiaChi = item.SubItems[7].Text;
                if (svBL.Delete(svcurrent) > 0)
                {
                    MessageBox.Show("Xóa sinh viên thành công");
                    LoadSinhVienToListView();
                }
                else MessageBox.Show("Xóa thất bại");
            }
        }

        private void lvSV_DoubleClick(object sender, EventArgs e)
        {
            var svInFo = new SinhVienInfo();
            svcurrent = new SinhVien();
            ListViewItem item = lvSV.SelectedItems[0];
            svcurrent.MSSV = int.Parse(item.SubItems[0].Text);
            svcurrent.HoLot = item.SubItems[1].Text;
            svcurrent.Ten = item.SubItems[2].Text;
            svcurrent.GioiTinh = item.SubItems[3].Text == "Nam" ? true : false;
            svcurrent.NgaySinh = item.SubItems[4].Text;
            svcurrent.TenLop = item.SubItems[5].Text;
            svcurrent.Khoa = item.SubItems[6].Text;
            svcurrent.DiaChi = item.SubItems[7].Text;
            svInFo.LoadSinhVien(svcurrent);
            svInFo.LoadStatusUpdate();
            if (svInFo.ShowDialog() == DialogResult.OK)
            {
                LoadSinhVienToListView();
            }
        }
        private void LoadSinhVien(string key = "")
        {
            listSV = svBL.Find(key);
            lvSV.Items.Clear();
            foreach (var sv in listSV)
            {
                ListViewItem item = lvSV.Items.Add(sv.MSSV.ToString());
                item.SubItems.Add(sv.HoLot);
                item.SubItems.Add(sv.Ten);
                item.SubItems.Add(sv.GioiTinh == true ? "Nam" : "Nữ");
                item.SubItems.Add(sv.NgaySinh);
                item.SubItems.Add(sv.TenLop);
                item.SubItems.Add(sv.Khoa);
                item.SubItems.Add(sv.DiaChi);
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                LoadSinhVien(txtSearch.Text.ToString());
            }
        }

        private void btnAddFromFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"E:\";
            openFileDialog1.DefaultExt = "xlsx";
            openFileDialog1.Filter = "Excel 2007 files(xlsx) (*.xlsx)|*.xlsx";

            DialogResult dlg = openFileDialog1.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                string path = string.Format(@"{0}", openFileDialog1.FileName);
                ReadFromExcel(path);
                btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using(LoadingFrm frm = new LoadingFrm(SaveData))
            {
                frm.ShowDialog(this);
                btnSave.Enabled = false;
                MessageBox.Show("Đã lưu danh sách sinh viên!!");
            }

        }
    }
}
