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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        #region

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


        private void AdminForm_Load(object sender, EventArgs e)
        {
            setContent(new SinhVienForm());
        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            setContent(new SinhVienForm());
        }

        private void btnQLHP_Click(object sender, EventArgs e)
        {
            setContent(new HocPhanForm());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRole_Click(object sender, EventArgs e)
        {

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            setContent(new TaiKhoanForm());
        }

        private void btnQLDKHP_Click(object sender, EventArgs e)
        {
            setContent(new QLDKHPForm());
        }
    }
}
