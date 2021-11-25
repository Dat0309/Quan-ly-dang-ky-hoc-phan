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
    public partial class LoginUI : Form
    {
        public string userName;
        TaiKhoanBL tkBL = new TaiKhoanBL();
        public LoginUI()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tkBL.Authentication(txtUser.Text, txtPass.Text))
            {
                userName = txtUser.Text;
                if(tkBL.GetRoleID(txtUser.Text) == 1)
                {
                    AdminForm frm = new AdminForm();
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
                else if(tkBL.GetRoleID(txtUser.Text) == 2)
                {
                    DangKyHocPhanForm frm = new DangKyHocPhanForm(userName);
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai, vui lòng nhập lại");
            }
        }
    }
}
