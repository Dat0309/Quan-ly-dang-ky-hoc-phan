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
    public partial class DKTheoKeHoachForm : Form
    {

        List<HocPhan> listHP;
        SinhVien currentSV;
        int nam;
        SinhVienBL svBL = SinhVienBL.getInstance();

        public DKTheoKeHoachForm(string user)
        {
            currentSV = svBL.GetByMSSV(int.Parse(user));
            nam = GetNam(user);
            InitializeComponent();
        }

        #region

        /// <summary>
        /// Hàm tính năm học của sinh viên: vd
        /// 1914775 -> sinh viên năm 3
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private int GetNam(string user)
        {
            int curYear = DateTime.Now.Year;
            currentSV = svBL.GetByMSSV(int.Parse(user));

            return curYear - 2000 - int.Parse(user.Substring(0, 2)) + 1;
        }

        private void LoadDSHP()
        {
            HocPhanBL hpBL = new HocPhanBL();
            listHP = hpBL.GetHPTheoKeHoach(currentSV.MSSV, nam, int.Parse(cbbHK.Text == ""?"0": cbbHK.Text));
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

        private void cbbHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbHK.Text == "") return;
            LoadDSHP();
        }

        private void DKTheoKeHoachForm_Load(object sender, EventArgs e)
        {
            LoadDSHP();
        }

    }
}
