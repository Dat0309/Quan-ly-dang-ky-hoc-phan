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
    public partial class SinhVienForm : Form
    {
        SinhVienBL svBL = SinhVienBL.getInstance();
        List<SinhVien> listSV;
        public SinhVienForm()
        {
            InitializeComponent();
        }

        #region

        private void LoadSinhVienToListView()
        {
            listSV = svBL.GetAll();
            lvSV.Items.Clear();
            foreach (var sv in listSV)
            {
                ListViewItem item = lvSV.Items.Add(sv.MSSV.ToString());
                item.SubItems.Add(sv.HoLot);
                item.SubItems.Add(sv.Ten);
                item.SubItems.Add(sv.GioiTinh == true ? "Nam" : "Nữ");
                item.SubItems.Add(sv.NgaySinh);
                item.SubItems.Add(sv.TenLop);
                item.SubItems.Add(sv.Khoa);
                item.SubItems.Add(sv.DiaChi);
            }
            
        }

        #endregion

        private void SinhVienForm_Load(object sender, EventArgs e)
        {
            LoadSinhVienToListView();
        }
    }
}
