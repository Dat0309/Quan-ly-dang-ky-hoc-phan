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
    public partial class DoiMKForm : Form
    {
        string userName;
        TaiKhoanBL tkBL = TaiKhoanBL.getInstance();
        public DoiMKForm(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void Validation()
        {
            if (tkBL.isCorrectPass(txtMK.Text))
            {
                if (txtNewMK.Text == txtReNewMK.Text)
                {
                    tkBL.UpdatePass(userName, txtNewMK.Text);
                    MessageBox.Show("Đổi mật khẩu thành công");
                    this.Close();
                }
                else
                    MessageBox.Show("Mật khẩu nhập lại không khớp");
            }
            else
                MessageBox.Show("Sai mật khẩu");
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            Validation();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
                txtMK.UseSystemPasswordChar = false;
            else
                txtMK.UseSystemPasswordChar = true;
        }

        private void cbShowNewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowNewPass.Checked)
                txtNewMK.UseSystemPasswordChar = false;
            else
                txtNewMK.UseSystemPasswordChar = true;
        }

        private void cbShowRePass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowRePass.Checked)
                txtReNewMK.UseSystemPasswordChar = false;
            else
                txtReNewMK.UseSystemPasswordChar = true;
        }

        private void DoiMKForm_Load(object sender, EventArgs e)
        {
            txtMK.UseSystemPasswordChar = true;
            txtNewMK.UseSystemPasswordChar = true;
            txtReNewMK.UseSystemPasswordChar = true;
        }
    }
}
