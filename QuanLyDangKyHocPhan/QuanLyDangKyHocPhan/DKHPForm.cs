using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using BusinessLogic;

namespace QuanLyDangKyHocPhan
{
    public partial class DKHPForm : Form
    {
        List<HocPhan> listHP;
        string user;

        public DKHPForm(string user)
        {
            this.user = user;
            InitializeComponent();
        }

        #region các hàm xử lý
        /// <summary>
        /// Xuất danh sách các học phần chưa tích luỹ
        /// </summary>
        private void LoadHPToLV()
        {
            HocPhanBL hpBL = HocPhanBL.getInstance();
            listHP = hpBL.GetHPChuaTL(int.Parse(user));
            lvHP.Items.Clear();

            foreach (var hp in listHP)
            {
                ListViewItem item = lvHP.Items.Add(hp.MaHP.ToString());
                item.SubItems.Add(hp.TenHP);
                item.SubItems.Add(hp.LoaiHP);
                item.SubItems.Add(hp.TongSoTC.ToString());
            }
        }

        #endregion

        private void DKHPForm_Load(object sender, EventArgs e)
        {
            string preYear = (DateTime.Now.Year - 1).ToString() + " - " + DateTime.Now.Year.ToString();
            LoadHPToLV();
            if (HocPhiBL.getInstance().KiemTraHocPhi(user, preYear) == 1)
            {
                MessageBox.Show("Sinh viên vui lòng hoàn thành học phí còn nợ trước khi đăng ký học phần");
                btnKeHoach.Enabled = false;
                btnCaiThien.Enabled = false;
                btnDCHP.Enabled = false;
            }
        }

        private void btnKeHoach_Click(object sender, EventArgs e)
        {
            DKTheoKeHoachForm frm = new DKTheoKeHoachForm(user);
            frm.ShowDialog(this);
            LoadHPToLV();
        }

        private void btnCaiThien_Click(object sender, EventArgs e)
        {
            DKNgoaiKHForm frm = new DKNgoaiKHForm(user);
            frm.ShowDialog(this);
            LoadHPToLV();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            KQDKHPForm frm = new KQDKHPForm(user);
            frm.ShowDialog(this);
        }

        private void btnDCHP_Click(object sender, EventArgs e)
        {
            DCKQDKForm frm = new DCKQDKForm(user);
            frm.ShowDialog(this);
        }
    }
}
