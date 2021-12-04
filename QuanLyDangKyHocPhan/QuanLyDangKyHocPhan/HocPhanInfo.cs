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
    public partial class HocPhanInfo : Form
    {
        KhoaBL khoaBL = KhoaBL.getInstance();
        List<Khoa> listKhoa;
        HocPhanBL hocPhanBL = HocPhanBL.getInstance();
        List<HocPhan> listHP;
        public HocPhanInfo()
        {
            InitializeComponent();
            LoadcomboboxKhoa();
        }
        public void LoadcomboboxKhoa()
        {
            listKhoa = khoaBL.GetAll();
            cbbKhoa.DataSource = listKhoa;
            cbbKhoa.ValueMember = "TenKhoa";
            cbbKhoa.DisplayMember = "TenKhoa";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn thực hiện thao tác này?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
        public int InsertHocPhan()
        {
            HocPhan hocPhan = new HocPhan();
            hocPhan.MaHP = "";
            if (mtxtMaHP.Text == "" || txtTenHP.Text == "" || cbbLoai.Text == "" || cbbNam.Text == "" || cbbHK.Text == "")
            {
                MessageBox.Show("Không thể thêm môn học, vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                hocPhan.MaHP = mtxtMaHP.Text;
                hocPhan.TenHP = txtTenHP.Text;
                hocPhan.LoaiHP = cbbLoai.Text;
                hocPhan.HocKy = int.Parse(cbbHK.Text);
                hocPhan.Nam = int.Parse(cbbNam.Text);
                hocPhan.TongSoTC = int.Parse(nbSTC.Text);
                hocPhan.TCLT = int.Parse(nbTCLT.Text);
                hocPhan.TCTH = int.Parse(nbTCTH.Text);
                hocPhan.Khoa = cbbKhoa.Text;
                hocPhan.GioiHan = int.Parse(nbGioiHan.Text);
                HocPhanBL hpbl = HocPhanBL.getInstance();
                return hpbl.Insert(hocPhan);
            }
            return -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int result = InsertHocPhan();
            if (result > 0)
            {
                MessageBox.Show("Thêm học phần thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Thêm thất bại, vui lòng nhập lại");
            DialogResult = DialogResult.OK;
        }
        public void LoadStatusAdd()
        {
            LoadcomboboxKhoa();
            btnCapNhat.Enabled = false;
            btnThem.Enabled = true;
        }

        public void LoadStatusUpdate()
        {
            btnCapNhat.Enabled = true;
            btnThem.Enabled = false;
        }
        public int UpdateHocPhan()
        {
            HocPhan hocPhan = new HocPhan();
            if (mtxtMaHP.Text == "" || txtTenHP.Text == "" || cbbLoai.Text == "" || cbbNam.Text == "" || cbbHK.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu các ô, vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                hocPhan.MaHP = mtxtMaHP.Text;
                hocPhan.TenHP = txtTenHP.Text;
                hocPhan.LoaiHP = cbbLoai.Text;
                hocPhan.HocKy = int.Parse(cbbHK.Text);
                hocPhan.Nam = int.Parse(cbbNam.Text);
                hocPhan.TongSoTC = int.Parse(nbSTC.Text);
                hocPhan.TCLT = int.Parse(nbTCLT.Text);
                hocPhan.TCTH = int.Parse(nbTCTH.Text);
                hocPhan.Khoa = cbbKhoa.Text;
                hocPhan.GioiHan = int.Parse(nbGioiHan.Text);
                HocPhanBL hpbl = HocPhanBL.getInstance();
                return hpbl.Update(hocPhan);
            }
            return -1;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            {
                int result = UpdateHocPhan();
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật học phần thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else MessageBox.Show("Cập nhật thất bại, vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadHocPhan(HocPhan hocPhan)
        {
            LoadcomboboxKhoa();
            mtxtMaHP.Text = hocPhan.MaHP;
            txtTenHP.Text = hocPhan.TenHP;
            cbbLoai.Text = hocPhan.LoaiHP;
            cbbHK.Text = hocPhan.HocKy.ToString();
            cbbNam.Text = hocPhan.Nam.ToString();
            cbbKhoa.Text = hocPhan.Khoa;
            nbSTC.Text = hocPhan.TongSoTC.ToString();
            nbTCLT.Text = hocPhan.TCLT.ToString();
            nbTCTH.Text = hocPhan.TCTH.ToString();
            nbGioiHan.Text = hocPhan.GioiHan.ToString();
            cbbKhoa.Enabled = false;
            mtxtMaHP.Enabled = false;
        }
    }
}
