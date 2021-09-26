using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDangKyHocPhan.CustomControl;
using QuanLyDangKyHocPhan.Model;

namespace QuanLyDangKyHocPhan
{
    public partial class Form1 : Form
    {

        public Form1(Context context)
        {
            InitializeComponent();
            startUpControl1.BringToFront();
            this.context = context;

            ddmQuanLy.IsMainMenu = true;
            ddmHocVu.IsMainMenu = true;
            ddmThongKe.IsMainMenu = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnHome.Height;
            slidePanel.Location = btnHome.Location;
            //UCstartUp.Dock = DockStyle.Fill;
            //pnShow.Controls["UCstartUp"].BringToFront();
            startUpControl1.BringToFront();
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
            ucHocPhi1.BringToFront();
        }


        private void tsmiQLSV_Click(object sender, EventArgs e)
        {
            //controlStudentManagerment1.BringToFront();
            var item = new ControlStudentManagerment(context);
            item.Dock = DockStyle.Fill;
            pnShow.Controls["controlStudentManagerment1"].BringToFront();
        }

        private void tsmiQLHP_Click(object sender, EventArgs e)
        {
            ucqlhp1.BringToFront();
        }


        private void tsmiLichThi_Click(object sender, EventArgs e)
        {
            ucLichThi1.BringToFront();
        }

        private void btnDKHP_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnDKHP.Height;
            slidePanel.Location = btnDKHP.Location;
            uddkhp1.BringToFront();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnUser.Height;
            slidePanel.Location = btnUser.Location;
        }

        private void tsmiLKDSSV_Click(object sender, EventArgs e)
        {
            uC_LKDSSVDangKy1.BringToFront();
        }

        private void tsmiLKDSHP_Click(object sender, EventArgs e)
        {
            uC_LKDSHP1.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void ucHocPhi1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
