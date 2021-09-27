using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDangKyHocPhan.CustomControl
{
    public partial class frmGiaoVu : Form
    {
        public frmGiaoVu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gunaTextBoxMSGV_Enter(object sender, EventArgs e)
        {
            if (gunaTextBoxMSGV.Text == "Mã số giáo vụ....")
            {
                gunaTextBoxMSGV.Text = "";
                gunaTextBoxMSGV.ForeColor = Color.Black;
            }

           
        }

        private void gunaTextBoxMSGV_Leave(object sender, EventArgs e)
        {
            if (gunaTextBoxMSGV.Text == "")
            {
                gunaTextBoxMSGV.Text = "Mã số giáo vụ....";
                gunaTextBoxMSGV.ForeColor = Color.White;
            }
        }

        private void gunaTextBoxMKGV_Enter(object sender, EventArgs e)
        {
            if (gunaTextBoxMKGV.Text == "Nhập mật khẩu...")
            {
                gunaTextBoxMKGV.Text = "";
                gunaTextBoxMKGV.ForeColor = Color.Black;
            }
        }

        private void gunaTextBoxMKGV_Leave(object sender, EventArgs e)
        {
            if (gunaTextBoxMKGV.Text == "")
            {
                gunaTextBoxMKGV.Text = "Nhập mật khẩu...";
                gunaTextBoxMKGV.ForeColor = Color.White;
            }
        }
    }
}
