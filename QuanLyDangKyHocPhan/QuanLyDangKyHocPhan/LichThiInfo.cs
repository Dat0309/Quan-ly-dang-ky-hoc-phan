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
        public LichThiInfo()
        {
            InitializeComponent();
        }
        public void LoadHocPhan(HocPhan hp)
        {
            txtMaHP.Text = hp.MaHP;
            mtxtTenHP.Text = hp.TenHP;
        }
        public void LoadLichThi(LichThi lt)
        {
            mtxtGioThi.Text = lt.GioThi;
            dtpNgayThi.Text = lt.NgayThi;
            cbbPhongThi.Text = lt.PhongThi;
            txtThoiLuong.Text = lt.ThoiLuong.ToString();
            txtDiaDiem.Text = lt.DiaDiem;
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
            if (mtxtGioThi.Text == "" || txtDiaDiem.Text == "")
            {
                MessageBox.Show("Không thể thêm lịch thi, vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lich.MaHP = txtMaHP.Text;
                lich.NgayThi = dtpNgayThi.Text;
                lich.GioThi = mtxtGioThi.Text;
                lich.ThoiLuong = int.Parse(txtThoiLuong.Text);
                lich.PhongThi = cbbPhongThi.Text;
                lich.DiaDiem = txtDiaDiem.Text;
                lich.GhiChu = txtGhiChu.Text;
                LichThiBL ltBL = new LichThiBL();
                return ltBL.Insert(lich);
            }
            return -1;
        }
        public int UpdateLichThi()
        {
            LichThi lich = new LichThi();
            lich.MaHP = "";
            if (mtxtGioThi.Text == "" || txtDiaDiem.Text == "")
            {
                MessageBox.Show("Không thể thêm lịch thi, vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lich.MaHP = txtMaHP.Text;
                lich.NgayThi = dtpNgayThi.Text;
                lich.GioThi = mtxtGioThi.Text;
                lich.ThoiLuong = int.Parse(txtThoiLuong.Text);
                lich.PhongThi = cbbPhongThi.Text;
                lich.DiaDiem = txtDiaDiem.Text;
                lich.GhiChu = txtGhiChu.Text;
                LichThiBL ltBL = new LichThiBL();
                return ltBL.Update(lich);
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int result = UpdateLichThi();
            if (result > 0)
            {
                MessageBox.Show("Cập nhật học phần thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("Cập nhật thất bại, vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
