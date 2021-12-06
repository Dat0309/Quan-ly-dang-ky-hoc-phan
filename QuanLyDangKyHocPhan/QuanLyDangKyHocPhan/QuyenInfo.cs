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
    public partial class QuyenInfo : Form
    {
        public QuyenInfo()
        {
            InitializeComponent();
        }
        public void LoadStatusAdd()
        {
            btnCapNhat.Enabled = false;
            btnThem.Enabled = true;
        }
        public void LoadStatusUpdate()
        {
            btnCapNhat.Enabled = true;
            btnThem.Enabled = false;
        }
        public void LoadQuyen(Quyen q)
        {            
            txtIDQuyen.Text = q.Id.ToString();
            txtTenQuyen.Text = q.TenQuyen;
            txtMoTa.Text = q.MoTa;
        }
        public int UpdateQ()
        {
            Quyen q = new Quyen();
            if (txtTenQuyen.Text == "" ||txtMoTa.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu các ô, vui lòng nhập lại");
            else
            {
                q.Id = int.Parse(txtIDQuyen.Text);
                q.TenQuyen = txtTenQuyen.Text;
                q.MoTa = txtMoTa.Text;
                QuyenBL qbl = QuyenBL.getInstance();
                return qbl.Update(q);
            }
            return -1;
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int result = UpdateQ();
            if (result > 0)
            {
                MessageBox.Show("Cập nhật quyền thành công");
                DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("Cập nhật thất bại, vui lòng nhập lại");
        }
        public int InsertQ()
        {
            Quyen q = new Quyen();
            q.Id = 0;
            if (txtTenQuyen.Text == "" || txtMoTa.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu các ô, vui lòng nhập lại");
            else
            {
                q.TenQuyen = txtTenQuyen.Text;
                q.MoTa = txtMoTa.Text;
                QuyenBL qbl = QuyenBL.getInstance();
                return qbl.Insert(q);
            }
            return -1;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            int result = InsertQ();
            if (result > 0)
            {
                MessageBox.Show("Thêm Quyền thành công");
            }
            else MessageBox.Show("Thêm thất bại, vui lòng nhập lại");
            DialogResult = DialogResult.OK;
        }
    }
}
