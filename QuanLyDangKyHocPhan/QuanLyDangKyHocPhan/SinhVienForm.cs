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
        List<SinhVien> listSV ;
        SinhVien svcurrent;
       
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var svInFo = new SinhVienInfo();
            if (svInFo.ShowDialog() == DialogResult.OK)
            {
                LoadSinhVienToListView();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            svcurrent = new SinhVien();
            if (MessageBox.Show("Bạn chắc chứ", "Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ListViewItem item = lvSV.SelectedItems[0];
                svcurrent.MSSV = int.Parse(item.SubItems[0].Text);
                svcurrent.HoLot = item.SubItems[1].Text;
                svcurrent.Ten = item.SubItems[2].Text;
                svcurrent.GioiTinh = item.SubItems[3].Text == "Nam" ? true : false;
                svcurrent.NgaySinh = item.SubItems[4].Text;
                svcurrent.TenLop = item.SubItems[5].Text;
                svcurrent.Khoa = item.SubItems[6].Text;
                svcurrent.DiaChi = item.SubItems[7].Text;
                if (svBL.Delete(svcurrent) > 0)
                {                   
                    MessageBox.Show("Xóa sinh viên thành công");
                    LoadSinhVienToListView();
                }
                else MessageBox.Show("Xóa thất bại");
            }
        }
    }
}
