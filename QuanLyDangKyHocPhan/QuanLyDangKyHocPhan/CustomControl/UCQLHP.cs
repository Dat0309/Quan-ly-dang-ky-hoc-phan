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
    public partial class UCQLHP : UserControl
    {
        public static Data.IDataSource dataSource = new Data.SVDataSource("Data\\DSSV.txt");
        public static Data.IDataSourceHP dataSourceHP = new Data.HPDataSource("Data\\DSHP.txt");
        Context context = new Context(dataSource, dataSourceHP);
        private List<HocPhan> dshp;
        QLHP qlhp;
        public UCQLHP()
        {
            dshp = context.GetHP();
            InitializeComponent();
        }


        #region Các hàm xử lý chức năng
        //Thêm học phần vào listview
        private void ThemHP(HocPhan hp)
        {
            ListViewItem item = new ListViewItem(hp.mahp);
            item.SubItems.Add(hp.tenhp);
            item.SubItems.Add(hp.tclt.ToString());
            item.SubItems.Add(hp.tcth.ToString());
            item.SubItems.Add(hp.tongTC.ToString());
            item.SubItems.Add(hp.loaiTC);
            lvDSHP.Items.Add(item);
        }

        //Hiển thị DSSV ra listview
        private void LoadSVToLV(List<HocPhan> danhsach)
        {
            lvDSHP.Items.Clear();
            foreach (HocPhan item in danhsach)
            {
                ThemHP(item);
            }
        }
        //Lấy thông tin sv khi chọn
        private HocPhan GetHPLV(ListViewItem item)
        {
            HocPhan hp = new HocPhan(); 
            hp.mahp = item.SubItems[0].Text;
            hp.tenhp = item.SubItems[1].Text;
            hp.tclt = int.Parse(item.SubItems[2].Text);
            hp.tcth = int.Parse(item.SubItems[3].Text);
            hp.tongTC = int.Parse(item.SubItems[4].Text);
            hp.loaiTC = item.SubItems[5].Text;

            return hp;
        }
        //Thiết lập thông tin sinh viên lên control khi chọn
        private void ThietLapLenControl(HocPhan hp)
        {
            txtMahp.Text = hp.mahp;
            txtTenHP.Text = hp.tenhp;
            txtSoTC.Text = hp.tongTC.ToString();
            cbbLT.Text = hp.tclt.ToString();
            cbbTH.Text = hp.tcth.ToString();
            txtLoaiHP.Text = hp.loaiTC.ToString();
        }
        //thêm sv từ control
        private HocPhan GetHPFromControl()
        {
            HocPhan hp = new HocPhan();
            hp.mahp = txtMahp.Text;
            hp.tenhp = txtTenHP.Text;
            hp.tongTC = int.Parse(txtSoTC.Text);
            hp.tclt = int.Parse(cbbLT.Text);
            hp.tcth = int.Parse(cbbTH.Text);
            hp.loaiTC = txtLoaiHP.Text;
            return hp;
        }
        #endregion

        private void UCQLHP_Load(object sender, EventArgs e)
        {
            qlhp = new QLHP(context);
            LoadSVToLV(qlhp.dshp);
        }

        private void lvDSHP_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = lvDSHP.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem item = lvDSHP.SelectedItems[0];
                ThietLapLenControl(GetHPLV(item));
            }
        }
    }
}
