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
    public partial class Form1 : Form
    {
        StartUpControl startUp = new StartUpControl();
        public Form1()
        {
            InitializeComponent();
            slidePanel.Height = btnHome.Height;
            startUp.BringToFront();
            ddmQuanLy.IsMainMenu = true;
            ddmHocVu.IsMainMenu = true;
            ddmThongKe.IsMainMenu = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnHome.Height;
            slidePanel.Location = btnHome.Location;
            startUp.BringToFront();
        }

        private void btnQL_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnQL.Height;
            slidePanel.Location = btnQL.Location;
            ddmQuanLy.Show(btnQL, btnQL.Width, 0);
        }

        private void btnHocVu_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnHocVu.Height;
            slidePanel.Location = btnHocVu.Location;
            ddmHocVu.Show(btnHocVu, btnHocVu.Width, 0);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnThongKe.Height;
            slidePanel.Location = btnThongKe.Location;
            ddmThongKe.Show(btnThongKe, btnThongKe.Width, 0);
        }

        private void btnHocPhi_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnHocPhi.Height;
            slidePanel.Location = btnHocPhi.Location;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnUser.Height;
            slidePanel.Location = btnUser.Location;
        }
    }
}
