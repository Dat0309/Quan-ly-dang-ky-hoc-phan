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
    public partial class TaiKhoanForm : Form
    {
        TaiKhoanBL taikhoanBL = TaiKhoanBL.getInstance();
        List<TaiKhoan> listTK;
        TaiKhoan tkscurret;
        QuyenBL quyenBL = QuyenBL.getInstance();
        List<Quyen> listQ;
        public TaiKhoanForm()
        {
            InitializeComponent();
            LoadComboboxQuyen();
        }
        public void LoadComboboxQuyen()
        {
            listQ = quyenBL.GetAll();
            cbbLoc.DataSource= listQ;
            cbbLoc.ValueMember = "Id";
            cbbLoc.DisplayMember = "TenQuyen";
        }
        public void LoadTaiKhoantoListView()
        {
            listTK = taikhoanBL.GetAll();
            lvTaiKhoan.Items.Clear();
            foreach (var sv in listTK)
            {
                ListViewItem item = lvTaiKhoan.Items.Add(sv.Id.ToString());
                item.SubItems.Add(sv.UserName);
                item.SubItems.Add(sv.Active == true ? "True" : "False");
                item.SubItems.Add(sv.IDQuyen.ToString());
                item.SubItems.Add(sv.CreateDate);
                item.SubItems.Add(sv.FullName);
            }
        }
        public void LoadTaiKhoan(string key = "")
        {
            listTK = taikhoanBL.Find(key);
            lvTaiKhoan.Items.Clear();
            foreach (var sv in listTK)
            {
                ListViewItem item = lvTaiKhoan.Items.Add(sv.Id.ToString());
                item.SubItems.Add(sv.UserName);
                item.SubItems.Add(sv.Active == true ? "True" : "False");
                item.SubItems.Add(sv.IDQuyen.ToString());
                item.SubItems.Add(sv.CreateDate);
                item.SubItems.Add(sv.FullName);
            }
        }
        public void LoadTaiKhoantheocbb(string quyen )
        {
            listTK = taikhoanBL.FindtheoQuyen(quyen);
            lvTaiKhoan.Items.Clear();
            foreach (var sv in listTK)
            {
                ListViewItem item = lvTaiKhoan.Items.Add(sv.Id.ToString());
                item.SubItems.Add(sv.UserName);
                item.SubItems.Add(sv.Active == true ? "True" : "False");
                item.SubItems.Add(sv.IDQuyen.ToString());
                item.SubItems.Add(sv.CreateDate);
                item.SubItems.Add(sv.FullName);
            }
        }
        private void cbbLoc_TextChanged(object sender, EventArgs e)
        {
            LoadTaiKhoantheocbb(cbbLoc.SelectedValue.ToString());
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            LoadTaiKhoantoListView();
            LoadTaiKhoan(txtSearch.Text.ToString());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var tkInFo = new TaiKhoanInfo();
            tkInFo.LoadStatusAdd();
            if (tkInFo.ShowDialog() == DialogResult.OK)
            {
               LoadTaiKhoantoListView();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tkscurret = new TaiKhoan();
            if (MessageBox.Show("Bạn chắc chứ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ListViewItem item = lvTaiKhoan.SelectedItems[0];
                tkscurret.Id = int.Parse(item.SubItems[0].Text); 
                tkscurret.UserName = item.SubItems[1].Text;
                tkscurret.Active = item.SubItems[2].Text == "True" ? true : false;
                tkscurret.IDQuyen = int.Parse(item.SubItems[3].Text);
                tkscurret.CreateDate = item.SubItems[4].Text;
                tkscurret.FullName = item.SubItems[5].Text;
                if (taikhoanBL.Delete(tkscurret) > 0)
                {
                    MessageBox.Show("Xóa tài khoản thành công");
                }
                else MessageBox.Show("Xóa thất bại");
            }
        }

        private void lvTaiKhoan_DoubleClick(object sender, EventArgs e)
        {
            var tkinfo = new TaiKhoanInfo();
            tkscurret = new TaiKhoan();
            ListViewItem item = lvTaiKhoan.SelectedItems[0];
            tkscurret.Id = int.Parse(item.SubItems[0].Text);
            tkscurret.UserName = item.SubItems[1].Text;
            tkscurret.Active = item.SubItems[2].Text == "True" ? true : false;
            tkscurret.IDQuyen = int.Parse(item.SubItems[3].Text);
            tkscurret.CreateDate = item.SubItems[4].Text;
            tkscurret.FullName = item.SubItems[5].Text;
            tkinfo.LoadTaiKhoan(tkscurret);
            tkinfo.LoadStatusUpdate();
            if (tkinfo.ShowDialog() == DialogResult.OK)
            {
                LoadTaiKhoantoListView();
            }
        }

        private void TaiKhoanForm_Load(object sender, EventArgs e)
        {
            LoadTaiKhoantoListView();
        }
    }
}
