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
    public partial class ThongTinSVForm : Form
    {
        SinhVien currentSV;
        SinhVienBL svBL = SinhVienBL.getInstance();

        public ThongTinSVForm(string user)
        {
            currentSV = svBL.GetByMSSV(int.Parse(user));
            InitializeComponent();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            DoiMKForm frm = new DoiMKForm(currentSV.MSSV.ToString());
            frm.ShowDialog();
        }

        private void ThongTínVForm_Load(object sender, EventArgs e)
        {
            lbHT.Text = currentSV.HoLot + " " + currentSV.Ten;
            lbMSSV.Text = currentSV.MSSV.ToString();
            lbLop.Text = currentSV.TenLop;
            lbKhoa.Text = currentSV.Khoa;
        }
    }
}
