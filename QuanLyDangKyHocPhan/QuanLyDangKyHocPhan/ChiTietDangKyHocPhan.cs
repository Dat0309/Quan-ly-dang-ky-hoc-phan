using BusinessLogic;
using DataAccess;
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
    public partial class ChiTietDangKyHocPhan : Form
    {
        string MaHP;
        List<SinhVien> listSV;
        ChiTietDKBL ctBL = ChiTietDKBL.getInstance();
        public ChiTietDangKyHocPhan(string MaHP)
        {
            this.MaHP = MaHP;
            InitializeComponent();
            LoadSVToLV();
        }
        private void LoadSVToLV()
        {
            listSV = ctBL.CheckSVDangKyHocPhan(MaHP);
            lvCTHP.Items.Clear();
            foreach (var sv in listSV)
            {
                ListViewItem item = lvCTHP.Items.Add(sv.MSSV.ToString());
                item.SubItems.Add(sv.HoLot);
                item.SubItems.Add(sv.Ten);
                item.SubItems.Add(sv.GioiTinh == true ? "Nam" : "Nữ");
                item.SubItems.Add(sv.NgaySinh);
                item.SubItems.Add(sv.TenLop);
                item.SubItems.Add(sv.Khoa);
                item.SubItems.Add(sv.DiaChi);
            }
        }

        private void lvCTHP_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
