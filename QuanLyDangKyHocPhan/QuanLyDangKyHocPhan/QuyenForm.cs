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
    public partial class QuyenForm : Form
    {
        QuyenBL qBL = QuyenBL.getInstance();
        List<Quyen> listQ;
        Quyen qcurrent;
        public QuyenForm()
        {
            InitializeComponent();
        }

        private void QuyenForm_Load(object sender, EventArgs e)
        {
            LoadQuyenToListView();
        }
        private void LoadQuyenToListView()
        {
            listQ = qBL.GetAll();
            lvQuyen.Items.Clear();
            foreach (var sv in listQ)
            {
                ListViewItem item = lvQuyen.Items.Add(sv.Id.ToString());
                item.SubItems.Add(sv.TenQuyen);
                item.SubItems.Add(sv.MoTa);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var quyeninfo = new QuyenInfo();
            quyeninfo.LoadStatusAdd();
            if (quyeninfo.ShowDialog() == DialogResult.OK)
            {
                LoadQuyenToListView();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            qcurrent = new Quyen();
            if (MessageBox.Show("Bạn chắc chứ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ListViewItem item = lvQuyen.SelectedItems[0];
                qcurrent.Id = int.Parse(item.SubItems[0].Text);
                qcurrent.TenQuyen = item.SubItems[1].Text;
                qcurrent.MoTa = item.SubItems[2].Text;
                if (qBL.Delete(qcurrent) > 0)
                {
                    MessageBox.Show("Xóa quyền thành công");
                    LoadQuyenToListView();
                }
                else MessageBox.Show("Xóa thất bại");
            }
        }
        private void LoadQuyen(string key = "")
        {
            listQ = qBL.Find(key);
            lvQuyen.Items.Clear();
            foreach (var sv in listQ)
            {
                ListViewItem item = lvQuyen.Items.Add(sv.Id.ToString());
                item.SubItems.Add(sv.TenQuyen);
                item.SubItems.Add(sv.MoTa);
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            LoadQuyenToListView();
            LoadQuyen(txtSearch.Text.ToString());
        }
        private void lvQuyen_DoubleClick(object sender, EventArgs e)
        {
            var qInFo = new QuyenInfo();
            qcurrent = new Quyen();
            ListViewItem item = lvQuyen.SelectedItems[0];
            qcurrent.Id = int.Parse(item.SubItems[0].Text);
            qcurrent.TenQuyen = item.SubItems[1].Text;
            qcurrent.MoTa = item.SubItems[2].Text;
            qInFo.LoadQuyen(qcurrent);
            qInFo.LoadStatusUpdate();
            if (qInFo.ShowDialog() == DialogResult.OK)
            {
                LoadQuyenToListView();
            }
        }
    }
}
