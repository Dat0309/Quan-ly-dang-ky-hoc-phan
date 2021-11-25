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
        SinhVien currentSV;
        string user;
        public DKHPForm(string user)
        {
            this.user = user;
            InitializeComponent();
        }

        #region

        private int GetNam(string user)
        {
            int curYear = DateTime.Now.Year;
            SinhVienBL svBL = new SinhVienBL();
            currentSV = svBL.GetByMSSV(int.Parse(user));

            return curYear - 2000 - int.Parse(user.Substring(1, 2)) + 1;
        }

        private void LoadHPToLV()
        {
            HocPhanBL hpBL = new HocPhanBL();
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
            LoadHPToLV();
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
