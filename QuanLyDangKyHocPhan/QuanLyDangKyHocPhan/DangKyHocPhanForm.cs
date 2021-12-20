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
    public partial class DangKyHocPhanForm : Form
    {
        string userName;
        public DangKyHocPhanForm(string user)
        {
            InitializeComponent();
            userName = user;
        }

        #region các hàm chức năng

        /// <summary>
        /// Hiện giao diện trên container
        /// </summary>
        /// <param name="_form"></param>
        private void setContent(object _form)
        {
            if (Container.Controls.Count > 0) Container.Controls.Clear();

            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            Container.Controls.Add(fm);
            Container.Tag = fm;
            fm.Show();
        }

        #endregion

        private void btnDKHP_Click(object sender, EventArgs e)
        {
            setContent(new DKHPForm(userName));
        }

        private void btnHocPhi_Click(object sender, EventArgs e)
        {
            setContent(new HocPhiForm(userName));
        }

        private void btnLichThi_Click(object sender, EventArgs e)
        {
            setContent(new LichThiForm(userName));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginUI DangNhap = new LoginUI();
            this.Hide();
            DangNhap.ShowDialog();
            this.Close();
        }

        private void btnTaIKhoan_Click(object sender, EventArgs e)
        {
            setContent(new ThongTinSVForm(userName));
        }
    }
}
