using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDangKyHocPhan.Model;

namespace QuanLyDangKyHocPhan.CustomControl
{
    public partial class ControlStudentManagerment : UserControl
    {
        public Context context;
        private List<SinhVien> dssv;
        QLSV qlsv;
        public ControlStudentManagerment()
        {
            InitializeComponent();
        }
        public ControlStudentManagerment(Context context)
        {
            this.context = context;
            dssv = context.GetSV();
            InitializeComponent();
        }
        #region Các hàm xử lý chức năng
        //Thêm Sinh viên vào ListView
        private void ThemSV(SinhVien sv)
        {
            ListViewItem item = new ListViewItem(sv.mssv);
            item.SubItems.Add(sv.ho);
            item.SubItems.Add(sv.ten);
            item.SubItems.Add(sv.ngaySinh.ToShortDateString());
            item.SubItems.Add(sv.diaChi);
            item.SubItems.Add(sv.lop);
            lvDSSV.Items.Add(item);
        }

        //Hiển thị DSSV ra ListView
        private void LoadSVToLV(List<SinhVien> danhsach)
        {
            lvDSSV.Items.Clear();
            foreach (SinhVien item in danhsach)
            {
                ThemSV(item);
            }
        }

        //Lấy thông tin sv khi chọn
        private SinhVien GetSinhVienLV(ListViewItem item)
        {
            SinhVien sv = new SinhVien();
            sv.mssv = item.SubItems[0].Text;
            sv.ho = item.SubItems[1].Text;
            sv.ten = item.SubItems[2].Text;
            sv.ngaySinh = DateTime.Parse(item.SubItems[3].Text);
            sv.diaChi = item.SubItems[4].Text;
            sv.lop = item.SubItems[5].Text;

            return sv;
        }

        //Thiết lập thông tin sinh viên lên control khi chọn
        private void ThietLapLenControl(SinhVien sv)
        {
            txtMSSV.Text = sv.mssv;
            txtHo.Text = sv.ho;
            txtTen.Text = sv.ten;
            dtpNS.Value = sv.ngaySinh;
            txtDiaChi.Text = sv.diaChi;
            cbbLop.Text = sv.lop;
        }

        //Thêm SV từ control
        private SinhVien GetSVFromControl()
        {
            SinhVien sv = new SinhVien();

            sv.mssv = txtMSSV.Text;
            sv.ho = txtHo.Text;
            sv.ten = txtTen.Text;
            sv.ngaySinh = dtpNS.Value;
            sv.diaChi = txtDiaChi.Text;
            sv.lop = cbbLop.Text;

            return sv;
        }


        #endregion

        private void ControlStudentManagerment_Load(object sender, EventArgs e)
        {
            qlsv = new QLSV(context);
            LoadSVToLV(qlsv.dssv);
        }

        private void lvDSSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = lvDSSV.SelectedItems.Count;
            if(count > 0)
            {
                ListViewItem item = lvDSSV.SelectedItems[0];
                ThietLapLenControl(GetSinhVienLV(item));
            }
        }


    }
}
