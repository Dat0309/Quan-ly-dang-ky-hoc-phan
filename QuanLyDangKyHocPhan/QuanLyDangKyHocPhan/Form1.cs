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
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnHome.Height;
            startUp.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
