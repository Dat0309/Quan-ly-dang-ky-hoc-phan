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

namespace QuanLyDangKyHocPhan
{
    public partial class StartUpControl : UserControl
    {
        public StartUpControl()
        {
            InitializeComponent();
        }

        private void btnGiaoVu_Click(object sender, EventArgs e)
        {
            frmGiaoVu frm = new frmGiaoVu();
            frm.ShowDialog();

        }

        private void btnSV_Click(object sender, EventArgs e)
        {
            formSinhVien frm = new formSinhVien();
            frm.ShowDialog();
        }
    }
}
