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
    public partial class LoginUI : Form
    {

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
            if(txtUser.Text == "1")
            {
                AdminForm frm = new AdminForm();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
            else if(txtUser.Text == "2")
            {
                DangKyHocPhanForm frm = new DangKyHocPhanForm();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}
