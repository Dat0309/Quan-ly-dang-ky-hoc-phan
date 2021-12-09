using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDangKyHocPhan
{
    public partial class LichThiInfo : Form
    {
        string namHoc;
        int hocKy;
        public LichThiInfo()
        {
            InitializeComponent();
        }
        public void LoadHocPhan(HocPhan hp, string nam, int hocKy)
        {
            this.namHoc = nam;
            this.hocKy = hocKy;
            txtMaHP.Text = hp.MaHP;
            mtxtTenHP.Text = hp.TenHP;
        }
        
        public void LoadHocPhanUpdate(HocPhan hp,LichThi lt, string nam, int hocKy)
        {
            this.namHoc = nam;
            this.hocKy = hocKy;

            txtMaHP.Text = hp.MaHP;
            mtxtTenHP.Text = hp.TenHP;
            mtxtGioThi.Text = lt.GioThi;
            dtpNgayThi.Value = DateTime.Parse(lt.NgayThi);
            cbbPhongThi.Text = lt.PhongThi;
            txtThoiLuong.Text = lt.ThoiLuong.ToString();
            cbbLocation.Text = lt.DiaDiem;
            txtGhiChu.Text = lt.GhiChu;
        }
        public void LoadLichThi(LichThi lt)
        {
            mtxtGioThi.Text = lt.GioThi;
            dtpNgayThi.Text = lt.NgayThi;
            cbbPhongThi.Text = lt.PhongThi;
            txtThoiLuong.Text = lt.ThoiLuong.ToString();
            cbbLocation.Text = lt.DiaDiem;
            txtGhiChu.Text = lt.GhiChu;
        }
        public void LoadStatusAdd()
        {
            btnCapNhat.Enabled = false;
            btnThem.Enabled = true;
        }
        public void LoadStatusUpdate()
        {
            btnCapNhat.Enabled = true;
            btnThem.Enabled = false;
        }

        public int InsertLichThi()
        {
            LichThi lich = new LichThi();
            lich.MaHP = "";
            if (mtxtGioThi.Text == "" || cbbLocation.Text == "")
            {
                MessageBox.Show("Không thể thêm lịch thi, vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lich.MaHP = txtMaHP.Text;
                lich.NgayThi = dtpNgayThi.Text;
                lich.HocKy = hocKy;
                lich.NamHoc = namHoc;
                lich.GioThi = mtxtGioThi.Text;
                lich.ThoiLuong = int.Parse(txtThoiLuong.Text);
                lich.PhongThi = cbbPhongThi.Text;
                lich.DiaDiem = cbbLocation.Text;
                lich.GhiChu = txtGhiChu.Text;

                LichThiBL ltBL = LichThiBL.Instance();
                return ltBL.Insert(lich);
            }
            return -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int result = InsertLichThi();
            if (result > 0)
            {
                MessageBox.Show("Thêm lịch thi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Thêm thất bại, vui lòng nhập lại");
            DialogResult = DialogResult.OK;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
