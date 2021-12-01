using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using BusinessLogic;
using System.Data.SqlClient;

namespace QuanLyDangKyHocPhan
{
    public partial class QLDKHPForm : Form
    {
        ChiTietDKBL ctdkBL = ChiTietDKBL.getInstance();
        public QLDKHPForm()
        {
            InitializeComponent();
        }

        #region

        private void LoadItem()
        {
            lvQL.Items.Clear();
            SqlDataReader reader = ctdkBL.GetChiTietDKHP();
            while (reader.Read())
            {
                ListViewItem item = lvQL.Items.Add(reader["MSSV"].ToString());
                item.SubItems.Add(reader["MaHP"].ToString());
                item.SubItems.Add(reader["HoLot"].ToString());
                item.SubItems.Add(reader["Ten"].ToString());
                item.SubItems.Add(reader["TenHP"].ToString());
                item.SubItems.Add(reader["TenLop"].ToString());
                item.SubItems.Add(reader["LoaiHP"].ToString());
                item.SubItems.Add(reader["Khoa"].ToString());
                item.SubItems.Add(reader["STC"].ToString());
                item.SubItems.Add(reader["SLDK"].ToString());
            }
        }

        #endregion

        private void QLDKHPForm_Load(object sender, EventArgs e)
        {
            LoadItem();
        }
    }
}
