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
    public partial class DKHPForm : Form
    {
        public DKHPForm()
        {
            InitializeComponent();
        }

        private void DKHPForm_Load(object sender, EventArgs e)
        {

        }

        private void btnKeHoach_Click(object sender, EventArgs e)
        {
            DKTheoKeHoachForm frm = new DKTheoKeHoachForm();
            frm.ShowDialog(this);
        }

        private void btnCaiThien_Click(object sender, EventArgs e)
        {
            DKNgoaiKHForm frm = new DKNgoaiKHForm();
            frm.ShowDialog(this);
        }
    }
}
