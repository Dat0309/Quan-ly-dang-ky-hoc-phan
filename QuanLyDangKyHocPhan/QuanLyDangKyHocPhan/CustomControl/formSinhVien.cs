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
    public partial class formSinhVien : Form
    {
        public formSinhVien()
        {
            InitializeComponent();
        }

        private void gnbtnExitsv_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gunaTextBoxMSSV_Enter(object sender, EventArgs e)
        {
            if (gunaTextBoxMSSV.Text == "Mã số sinh viên....")
            {
                gunaTextBoxMSSV.Text = "";
                gunaTextBoxMSSV.ForeColor = Color.Black;
            }
        }

        private void gunaTextBoxMSSV_Leave(object sender, EventArgs e)
        {
            if (gunaTextBoxMSSV.Text == "")
            {
                gunaTextBoxMSSV.Text = "Mã số sinh viên....";
                gunaTextBoxMSSV.ForeColor = Color.White;
            }
        }



        private void gunaTextBoxMKSV_Enter_1(object sender, EventArgs e)
        {
            if(gunaTextBoxMKSV.Text == "Nhập mật khẩu...")
            {
                gunaTextBoxMKSV.Text = "";
                gunaTextBoxMKSV.ForeColor = Color.Black;
            }
        }

        private void gunaTextBoxMKSV_Leave(object sender, EventArgs e)
        {
            if(gunaTextBoxMKSV.Text == "")
            {
                gunaTextBoxMKSV.Text = "Nhập mật khẩu...";
                gunaTextBoxMKSV.ForeColor = Color.White;
            }
        }
    }
}
