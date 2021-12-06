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
    public partial class TaiKhoanInfo : Form
    {
        QuyenBL quyenBL = QuyenBL.getInstance();
        List<Quyen> listQ;
        public TaiKhoanInfo()
        {
            InitializeComponent();
            
        }
        public void LoadComboboxQuyen()
        {
            listQ = quyenBL.GetAll();
            cbbIDQuyen.DataSource = listQ;
            cbbIDQuyen.ValueMember = "Id";
            cbbIDQuyen.DisplayMember = "TenQuyen";
        }
        public void LoadStatusAdd()
        {
            LoadComboboxQuyen();
            btnCapNhat.Enabled = false;
            btnThem.Enabled = true;
        }

        public void LoadStatusUpdate()
        {
            btnCapNhat.Enabled = true;
            btnThem.Enabled = false;
        }
        public int InsertTK()
        {
            TaiKhoan tk = new TaiKhoan();
            tk.Id = 0;
            if ( txtTaikhoan.Text == ""  || (rdbtnTrue.Checked == false && rdbtnFalse.Checked == false) || cbbIDQuyen.Text == "" || txtHoTenNguoiLap.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu các ô, vui lòng nhập lại");
            else
            {
                tk.UserName = txtTaikhoan.Text;
                tk.Password = txtMatKhau.Text;
                tk.Active = rdbtnTrue.Checked == true ? true : false;              
                tk.IDQuyen = int.Parse(cbbIDQuyen.SelectedValue.ToString());
                tk.CreateDate = dtpNgayLapTK.Value.ToString();
                tk.FullName = txtHoTenNguoiLap.Text;
                TaiKhoanBL tkbl = TaiKhoanBL.getInstance();
                return tkbl.Insert(tk);
            }
            return -1;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            int result = InsertTK();
            if (result > 0)
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else MessageBox.Show("Thêm thất bại, vui lòng nhập lại");
            DialogResult = DialogResult.OK;
        }
        public int UpdateTK()
        {
            TaiKhoan tk = new TaiKhoan();
            if (txtTaikhoan.Text == "" || (rdbtnTrue.Checked == false && rdbtnFalse.Checked == false) || cbbIDQuyen.Text == "" || txtHoTenNguoiLap.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu các ô, vui lòng nhập lại");
            else
            {
                tk.Id = int.Parse(txtIDTaiKhoan.Text);
                tk.UserName = txtTaikhoan.Text;
                tk.Password = txtMatKhau.Text;
                tk.Active = rdbtnTrue.Checked == true ? true : false;
                tk.IDQuyen = int.Parse(cbbIDQuyen.SelectedValue.ToString());
                tk.CreateDate = dtpNgayLapTK.Value.ToString();
                tk.FullName = txtHoTenNguoiLap.Text;
                TaiKhoanBL tkbl = TaiKhoanBL.getInstance();
                return tkbl.Insert(tk);
            }
            return -1;
        }
        public void LoadTaiKhoan(TaiKhoan tk)
        {
            LoadComboboxQuyen();
            txtIDTaiKhoan.Text = tk.Id.ToString();
            txtTaikhoan.Text = tk.UserName;
            txtMatKhau.Text = tk.Password;
            rdbtnTrue.Checked = tk.Active ? true : false;
            rdbtnFalse.Checked = tk.Active == false ? true : false;
            cbbIDQuyen.Text = tk.IDQuyen.ToString();
            dtpNgayLapTK.Text = tk.CreateDate;
            txtHoTenNguoiLap.Text = tk.FullName;
            txtIDTaiKhoan.Enabled = false;
            txtHoTenNguoiLap.Enabled = false;
            dtpNgayLapTK.Enabled = false;
            txtTaikhoan.Enabled = false;
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int result = UpdateTK();
            if (result > 0)
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
                DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("Cập nhật thất bại, vui lòng nhập lại");
        }
    }
}
