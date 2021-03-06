using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDangKyHocPhan
{
    public partial class ThongKeFrm : Form
    {
        public ThongKeFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Xuất biểu đồ thống kê số lượng đăng ký từng học phần của sinh viên
        /// </summary>
        /// <param name="rd"></param>
        /// <param name="namHoc"></param>
        /// <param name="hocKy"></param>
        public void LoadChart(SqlDataReader rd, string namHoc, string hocKy)
        {
            chart1.Titles.Add(string.Format("Số lượng sinh viên đăng ký học phần học kỳ {0}, năm học {1}", hocKy, namHoc));
            chart1.Series["s1"].IsValueShownAsLabel = true;
            while (rd.Read())
            {
                chart1.Series["s1"].Points.AddXY(rd["TenHP"].ToString(), rd["sldk"].ToString());
            }
        }

        private void ThongKeFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
