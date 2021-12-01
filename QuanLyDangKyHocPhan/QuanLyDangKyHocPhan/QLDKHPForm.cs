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
using OfficeOpenXml;
using System.IO;

namespace QuanLyDangKyHocPhan
{
    public partial class QLDKHPForm : Form
    {
        List<string> years = new List<string>();
        List<string> courses = new List<string>();
        List<string> listKhoa = new List<string>();
        List<string> listLop = new List<string>();

        ChiTietDKBL ctdkBL = ChiTietDKBL.getInstance();
        public QLDKHPForm()
        {
            InitializeComponent();
        }

        #region

        /// <summary>
        /// Hàm xuất thông tin học phần đăng ký
        /// </summary>
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

                if (!years.Contains(reader["NamHoc"].ToString()))
                    AddYears(reader["NamHoc"].ToString());
                if (!courses.Contains(reader["HocKy"].ToString()))
                    AddCourses(reader["HocKy"].ToString());
                if (!listKhoa.Contains(reader["Khoa"].ToString()))
                    AddKhoa(reader["Khoa"].ToString());
                if (!listLop.Contains(reader["TenLop"].ToString()))
                    AddLop(reader["TenLop"].ToString());
            }
        }

        private void LoadItemWithCourse(int hocky, string nam, string khoa, string lop)
        {
            lvQL.Items.Clear();
            SqlDataReader reader = ctdkBL.GetChiTietDKHPTheoHocKy(hocky, nam, khoa, lop);
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

        /// <summary>
        /// Hàm tìm kiếm
        /// </summary>
        /// <param name="key"></param>
        private void SearchByKey(string key)
        {
            
        }

        private void AddYears(string year)
        {
            years.Add(year);
        }

        private void AddCourses(string course)
        {
            courses.Add(course);
        }

        private void AddKhoa(string khoa)
        {
            listKhoa.Add(khoa);
        }

        private void AddLop(string lop)
        {
            listLop.Add(lop);
        }

        /// <summary>
        /// Xuất kêt quả đăng ký
        /// </summary>
        /// <param name="lv"></param>
        /// <param name="listKQDK"></param>
        /// <param name="path"></param>
        private void WriteToExcel(ListView lv, string path)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (ExcelPackage p = new ExcelPackage())
            {
                p.Workbook.Worksheets.Add("sheet 1");
                ExcelWorksheet ws = p.Workbook.Worksheets[0];
                ws.Name = "sheet 1";
                ws.Cells.Style.Font.Size = 11;
                ws.Cells.Style.Font.Name = "Calibri";

                List<string> arrCollumHeader = new List<string>();
                foreach (ColumnHeader item in lv.Columns)
                {
                    arrCollumHeader.Add(item.Text);
                }
                var countColHeader = arrCollumHeader.Count();

                int colIndex = 1;
                int rowIndex = 1;
                //Tao cac Header
                foreach (var item in arrCollumHeader)
                {
                    var cell = ws.Cells[rowIndex, colIndex];
                    var style = cell.Style.Font;
                    style.Bold = true;

                    cell.Value = item;
                    colIndex++;
                }

                //Lay danh sach sinh vien
                for(int i = 0; i< lvQL.Items.Count; i++)
                {
                    ListViewItem item = lvQL.Items[i];
                    colIndex = 1;
                    rowIndex++;
                    ws.Cells[rowIndex, colIndex++].Value = item.SubItems["MSSV"].Text;
                    ws.Cells[rowIndex, colIndex++].Value = item.SubItems["MaHP"].Text;
                    ws.Cells[rowIndex, colIndex++].Value = item.SubItems["HoLot"].Text;
                    ws.Cells[rowIndex, colIndex++].Value = item.SubItems["Ten"].Text;
                    ws.Cells[rowIndex, colIndex++].Value = item.SubItems["TenHP"].Text;
                    ws.Cells[rowIndex, colIndex++].Value = item.SubItems["TenLop"].Text;
                    ws.Cells[rowIndex, colIndex++].Value = item.SubItems["LoaiHP"].Text;
                    ws.Cells[rowIndex, colIndex++].Value = item.SubItems["Khoa"].Text;
                    ws.Cells[rowIndex, colIndex++].Value = item.SubItems["STC"].Text;
                    ws.Cells[rowIndex, colIndex++].Value = item.SubItems["SLDK"].Text;
                }
                //save file
                Byte[] bin = p.GetAsByteArray();
                File.WriteAllBytes(path, bin);
            }
        }
        #endregion

        private void QLDKHPForm_Load(object sender, EventArgs e)
        {
            LoadItem();
            cbbNamHoc.DataSource = years;
            cbbHK.DataSource = courses;
            cbbKhoa.DataSource = listKhoa;
            cbbLop.DataSource = listLop;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = string.Format("DanhSach DangKyHocPhan Nam hoc {0}", DateTime.Now.Year.ToString() + " - " + (DateTime.Now.Year + 1).ToString());
            saveFileDialog1.InitialDirectory = @"E:\";
            saveFileDialog1.DefaultExt = "xlsx";
            saveFileDialog1.Filter = "Excel 2007 files(xlsx) (*.xlsx)|*.xlsx";

            DialogResult dlg = saveFileDialog1.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                string path = string.Format(@"{0}", saveFileDialog1.FileName);
                WriteToExcel(lvQL, path);
                MessageBox.Show("Xuất phiếu đăng ký thành công!");
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int hocKy = int.Parse(cbbHK.Text == "" ? "0" : cbbHK.Text);
            string nam = cbbNamHoc.Text;
            string khoa = cbbKhoa.Text;
            string lop = cbbLop.Text;

            LoadItemWithCourse(hocKy, nam, khoa, lop);
        }
    }
}
