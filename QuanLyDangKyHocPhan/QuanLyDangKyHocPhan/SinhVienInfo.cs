using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;

namespace QuanLyDangKyHocPhan
{
    public partial class SinhVienInfo : Form
    {
        KhoaBL khoaBL = KhoaBL.getInstance();
        List<Khoa> listkhoa;
        LopBL lopBL = LopBL.getInstance();
        List<Lop> listLop;
        public SinhVienInfo()
        {
            InitializeComponent();
        }
        private void SinhVienInfo_Load(object sender, EventArgs e)
        {

        }

        public void LoadStatusAdd()
        {
            LoadcomboboxKhoa();
            btnCapNhat.Enabled = false;
            btnThem.Enabled = true;
        }

        public void LoadStatusUpdate()
        {
            btnCapNhat.Enabled = true;
            btnThem.Enabled = false;
        }
        public void LoadcomboboxKhoa()
        {
            listkhoa = khoaBL.GetAll();
            cbbKhoa.DataSource = listkhoa;
            cbbKhoa.ValueMember = "TenKhoa";
            cbbKhoa.DisplayMember = "TenKhoa";
        }
        private void LoadcomboboxLop(string key)
        {
            listLop = lopBL.Find(key);
            cbbLop.DataSource = listLop;
            cbbLop.ValueMember = "TenLop";
            cbbLop.DisplayMember = "TenLop";
        }
        public int InsertSV()
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = 0;
            if (txtMSSV.Text == "" || txtHolot.Text == "" || txtTen.Text == "" || (rdbtnNam.Checked == false && rdbtnNu.Checked == false) || cbbLop.Text == "" || cbbKhoa.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu các ô, vui lòng nhập lại");
            else
            {
                sv.MSSV = int.Parse(txtMSSV.Text);
                sv.HoLot = txtHolot.Text;
                sv.Ten = txtTen.Text;
                sv.GioiTinh = rdbtnNam.Checked == true ? true : false;
                sv.NgaySinh = dtpNgaySinh.Value.ToString();
                sv.TenLop = cbbLop.Text;
                sv.Khoa = cbbKhoa.Text;
                sv.DiaChi = txtDiachi.Text;
                SinhVienBL svbl = SinhVienBL.getInstance();
                return svbl.Insert(sv);
            }
            return -1;
        }
        public int UpdateSV()
        {
            SinhVien sv = new SinhVien();
            if (txtMSSV.Text == "" || txtHolot.Text == "" || txtTen.Text == "" || (rdbtnNam.Checked == false && rdbtnNu.Checked == false) || cbbLop.Text == "" || cbbKhoa.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu các ô, vui lòng nhập lại");
            else
            {
                sv.MSSV = int.Parse(txtMSSV.Text);
                sv.HoLot = txtHolot.Text;
                sv.Ten = txtTen.Text;
                sv.GioiTinh = rdbtnNam.Checked == true ? true : false;
                sv.NgaySinh = dtpNgaySinh.Value.ToString();
                sv.TenLop = cbbLop.Text;
                sv.Khoa = cbbKhoa.Text;
                sv.DiaChi = txtDiachi.Text;
                SinhVienBL svbl = SinhVienBL.getInstance();
                return svbl.Update(sv);
            }
            return -1;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            int result = InsertSV();
            if (result > 0)
            {
                MessageBox.Show("Thêm sinh viên thành công");
            }
            else MessageBox.Show("Thêm thất bại, vui lòng nhập lại");
            DialogResult = DialogResult.OK;
        }

        private void cbbKhoa_TextChanged(object sender, EventArgs e)
        {
            LoadcomboboxLop(cbbKhoa.Text);
        }
        public void LoadSinhVien(SinhVien sv)
        {
            LoadcomboboxKhoa();
            txtMSSV.Text = sv.MSSV.ToString();
            txtHolot.Text = sv.HoLot;
            txtTen.Text = sv.Ten;
            rdbtnNam.Checked = sv.GioiTinh ? true : false;
            rdbtnNu.Checked = sv.GioiTinh == false ? true : false;
            dtpNgaySinh.Text = sv.NgaySinh;
            cbbLop.Text = sv.TenLop;
            cbbKhoa.Text = sv.Khoa;
            txtDiachi.Text = sv.DiaChi;
            cbbKhoa.Enabled = false;
            cbbLop.Enabled = false;
            txtMSSV.Enabled = false;
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int result = UpdateSV();
            if (result > 0)
            {
                MessageBox.Show("Cập nhật sinh viên thành công");
                DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("Cập nhật thất bại, vui lòng nhập lại");
        }
    }
}
