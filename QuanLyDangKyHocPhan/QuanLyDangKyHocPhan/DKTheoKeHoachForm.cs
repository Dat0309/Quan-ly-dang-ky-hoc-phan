using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using BusinessLogic;

namespace QuanLyDangKyHocPhan
{
    public partial class DKTheoKeHoachForm : Form
    {

        List<HocPhan> listHP;
        SinhVien currentSV;
        int nam;
        SinhVienBL svBL = SinhVienBL.getInstance();

        public DKTheoKeHoachForm(string user)
        {
            currentSV = svBL.GetByMSSV(int.Parse(user));
            nam = GetNam(user);
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
        /// Xuất danh sách học phần đã được lên kế hoạch giảng dạy cho từng học kì
        /// Tương ứng với học kỳ và năm học của sinh viên đăng nhập
        /// sẽ xuất ra danh sách học phần tương ứng.
        /// </summary>
        private void LoadDSHP()
        {
            HocPhanBL hpBL = HocPhanBL.getInstance();
            listHP = hpBL.GetHPTheoKeHoach(currentSV.MSSV, nam, int.Parse(cbbHK.Text == "" ? "0" : cbbHK.Text));
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
        /// Load danh sách kết quả đăng ký học phần
        /// </summary>
        /// <param name="hocphans"></param>
        private void LoadKQHP(List<HocPhan> hocphans)
        {
            lvKQDK.Items.Clear();

            foreach (var hp in hocphans)
            {
                ListViewItem item = lvKQDK.Items.Add(hp.MaHP);
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

        /// <summary>
        /// Đăng ký học phần
        /// </summary>
        /// <returns></returns>
        private int InsertChiTietDK()
        {
            ChiTietDangKy ct = new ChiTietDangKy();
            if (lvKQDK.Items.Count < 0)
                MessageBox.Show("Chưa chọn học phần để đăng ký, vui lòng chọn học phần");
            else
            {
                List<HocPhan> kqhp = new List<HocPhan>();
                int i = this.lvHP.CheckedItems.Count - 1;
                while (i >= 0)
                {
                    kqhp.Add(GetHPLV(this.lvHP.CheckedItems[i]));
                    i--;

                }

                foreach (var item in kqhp)
                {
                    ct.MSSV = currentSV.MSSV;
                    ct.MaHP = item.MaHP;
                    ct.NgayDangKy = DateTime.Now.ToShortDateString();
                    ct.HocKy = int.Parse(cbbHK.Text);
                    ct.NamHoc = DateTime.Now.Year.ToString() + " - " + (DateTime.Now.Year + 1).ToString();

                    ChiTietDKBL ctBL = ChiTietDKBL.getInstance();

                    ctBL.Insert(ct);
                }
                return 1;
            }
            return -1;
        }

        private void LoadKQHP()
        {

        }

        #endregion

        private void cbbHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbHK.Text == "") return;
            LoadDSHP();
        }

        private void DKTheoKeHoachForm_Load(object sender, EventArgs e)
        {
            LoadDSHP();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            int result = InsertChiTietDK();
            if (result > 0)
            {
                MessageBox.Show("Đăng ký học phần thành công !!");
                LoadDSHP();
            }
            else MessageBox.Show("Thêm dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu nhập");
        }

        private void lvHP_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            List<HocPhan> kqhp = new List<HocPhan>();
            int i = this.lvHP.CheckedItems.Count - 1;
            while (i >= 0)
            {
                kqhp.Add(GetHPLV(this.lvHP.CheckedItems[i]));
                i--;

            }
            LoadKQHP(kqhp);
        }
    }
}
