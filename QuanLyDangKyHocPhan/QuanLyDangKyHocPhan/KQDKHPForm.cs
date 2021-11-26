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
    public partial class KQDKHPForm : Form
    {
        List<HocPhan> listHP;
        SinhVien currentSV;
        SinhVienBL svBL = SinhVienBL.getInstance();

        public KQDKHPForm(string user)
        {
            currentSV = svBL.GetByMSSV(int.Parse(user));
            InitializeComponent();
            LoadDSHP();
            LoadDetail();
        }

        #region

        private void LoadDSHP()
        {
            HocPhanBL hpBL = HocPhanBL.getInstance();
            listHP = hpBL.GetKQDK(currentSV.MSSV);
            lvHP.Items.Clear();

            foreach (var hp in listHP)
            {
                ListViewItem item = lvHP.Items.Add(hp.MaHP.ToString());
                item.SubItems.Add(hp.TenHP);
                item.SubItems.Add(hp.LoaiHP);
                item.SubItems.Add(hp.TongSoTC.ToString());
            }
        }

        private void LoadDetail()
        {
            int SoLuongTC = 0;
            lbName.Text = currentSV.HoLot +" "+ currentSV.Ten + " Lớp: " + currentSV.TenLop + " Khoa: "+currentSV.Khoa;
            foreach (var item in listHP)
            {
                SoLuongTC += item.TongSoTC;
            }
            txtQuantity.Text = SoLuongTC.ToString();
        }

        #endregion
    }
}
