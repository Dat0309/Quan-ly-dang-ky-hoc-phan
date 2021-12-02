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
    public partial class HocPhiForm : Form
    {
        List<HocPhi> listHocPhi;
        SinhVien currentSV;
        public HocPhiForm(string userName)
        {
            currentSV = SinhVienBL.getInstance().GetByMSSV(int.Parse(userName));
            InitializeComponent();
        }

        #region

        private void GetItem()
        {
            int TongTien = 0;
            HocPhiBL hpBL = HocPhiBL.getInstance();
            listHocPhi = hpBL.GetByMSSV(currentSV.MSSV);

            lvHP.Items.Clear();
            foreach (var hp in listHocPhi)
            {
                ListViewItem item = lvHP.Items.Add(hp.id.ToString());
                item.SubItems.Add(String.Format("Học phí học kỳ {0} năm học {1}", hp.HocKy, hp.NamHoc));
                item.SubItems.Add(hp.SoTien.ToString());
                item.SubItems.Add(DateTime.Now.ToShortDateString());

                TongTien += hp.SoTien;
            }
            txtHocPhi.Text = String.Format("{0} đồng", TongTien);
            if(TongTien == 0)
                txtSoTienBangChu.Text = "Sinh viên đã thanh toán học phí";
            else
                txtSoTienBangChu.Text = Utils.NumberToText(TongTien);
        }

        #endregion

        private void HocPhiForm_Load(object sender, EventArgs e)
        {
            GetItem();
        }
    }
}
