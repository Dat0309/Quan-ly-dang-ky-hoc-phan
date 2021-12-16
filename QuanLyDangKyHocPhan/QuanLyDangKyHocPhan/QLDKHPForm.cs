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
        KhoaBL khoaBL = KhoaBL.getInstance();
        List<Khoa> listkhoa;
        LopBL lopBL = LopBL.getInstance();
        List<Lop> listLop;
        ChiTietDKBL ctdkBL = ChiTietDKBL.getInstance();

        public QLDKHPForm()
        {
            InitializeComponent();
        }

        #region

        public void LoadcomboboxKhoa()
        {
            listkhoa = khoaBL.GetAll();
            cbbKhoa.DataSource = listkhoa;
            cbbKhoa.ValueMember = "TenKhoa";
            cbbKhoa.DisplayMember = "TenKhoa";
        }
        private void LoadcomboboxLop(string key)
        {
            listLop = lopBL.Find(key);
            cbbLop.DataSource = listLop;
            cbbLop.ValueMember = "TenLop";
            cbbLop.DisplayMember = "TenLop";
        }
        private void LoadcbbCourse()
        {
            cbbCourse.DataSource = GetCourse();
        }

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
            }
        }

        /// <summary>
        /// Lọc danh sách đăng ký học phần theo các tiêu chí
        /// </summary>
        /// <param name="hocky"></param>
        /// <param name="nam"></param>
        /// <param name="khoa"></param>
        /// <param name="lop"></param>
        private void LoadItemWithCourse(int hocky, string nam)
        {
            lvQL.Items.Clear();
            SqlDataReader reader = ctdkBL.GetChiTietDKHPTheoHocKy(hocky, nam);
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
            var items = this.lvQL.Items.Cast<ListViewItem>()
                .Where(x => (
                x.SubItems[3].Text.Contains(key) ||
                x.SubItems[4].Text.Contains(key) ||
                x.SubItems[5].Text.Contains(key) ||
                x.SubItems[7].Text.Contains(key)))
                .ToList();

            lvQL.Items.Clear();
            foreach (var ct in items)
            {
                ListViewItem item = lvQL.Items.Add(ct.SubItems[0].Text);
                item.SubItems.Add(ct.SubItems[1].Text);
                item.SubItems.Add(ct.SubItems[2].Text);
                item.SubItems.Add(ct.SubItems[3].Text);
                item.SubItems.Add(ct.SubItems[4].Text);
                item.SubItems.Add(ct.SubItems[5].Text);
                item.SubItems.Add(ct.SubItems[6].Text);
                item.SubItems.Add(ct.SubItems[7].Text);
                item.SubItems.Add(ct.SubItems[8].Text);
                item.SubItems.Add(ct.SubItems[9].Text);
            }
        }

        /// <summary>
        /// Lấy danh sách 6 khoá còn học trong năm nay
        /// </summary>
        /// <returns></returns>
        private List<int> GetCourse()
        {
            List<int> result = new List<int>();
            int i = 0;
            int yearOld = 1976;
            while (i < 6)
            {
                result.Add(DateTime.Now.Year - yearOld);
                yearOld++;
                i++;
            }
            return result;
        }

        /// <summary>
        /// Xuất danh sách theo khoa
        /// </summary>
        /// <param name="khoa"></param>
        private void GetByKhoa(string khoa)
        {
            LoadItem();
            var items = this.lvQL.Items.Cast<ListViewItem>()
                .Where(x => (
                x.SubItems[7].Text.Equals(khoa.Trim())
                ))
                .ToList();

            lvQL.Items.Clear();
            foreach (var ct in items)
            {
                ListViewItem item = lvQL.Items.Add(ct.SubItems[0].Text);
                item.SubItems.Add(ct.SubItems[1].Text);
                item.SubItems.Add(ct.SubItems[2].Text);
                item.SubItems.Add(ct.SubItems[3].Text);
                item.SubItems.Add(ct.SubItems[4].Text);
                item.SubItems.Add(ct.SubItems[5].Text);
                item.SubItems.Add(ct.SubItems[6].Text);
                item.SubItems.Add(ct.SubItems[7].Text);
                item.SubItems.Add(ct.SubItems[8].Text);
                item.SubItems.Add(ct.SubItems[9].Text);
            }
        }

        /// <summary>
        /// Xuất danh sách theo lớp
        /// </summary>
        /// <param name="lop"></param>
        private void GetByLop(string lop)
        {
            LoadItem();
            var items = this.lvQL.Items.Cast<ListViewItem>()
                .Where(x => (
                x.SubItems[5].Text.Equals(lop.Trim())
                ))
                .ToList();

            lvQL.Items.Clear();
            foreach (var ct in items)
            {
                ListViewItem item = lvQL.Items.Add(ct.SubItems[0].Text);
                item.SubItems.Add(ct.SubItems[1].Text);
                item.SubItems.Add(ct.SubItems[2].Text);
                item.SubItems.Add(ct.SubItems[3].Text);
                item.SubItems.Add(ct.SubItems[4].Text);
                item.SubItems.Add(ct.SubItems[5].Text);
                item.SubItems.Add(ct.SubItems[6].Text);
                item.SubItems.Add(ct.SubItems[7].Text);
                item.SubItems.Add(ct.SubItems[8].Text);
                item.SubItems.Add(ct.SubItems[9].Text);
            }
        }

        /// <summary>
        /// Xuất danh sách theo khoá học
        /// </summary>
        /// <param name="course"></param>
        private void GetByCourse(int course)
        {
            LoadItem();
            var items = this.lvQL.Items.Cast<ListViewItem>()
                .Where(x => (
                (2000 + int.Parse(x.SubItems[0].Text.Substring(0, 2)) - 1976).Equals(course)
                ))
                .ToList();

            lvQL.Items.Clear();
            foreach (var ct in items)
            {
                ListViewItem item = lvQL.Items.Add(ct.SubItems[0].Text);
                item.SubItems.Add(ct.SubItems[1].Text);
                item.SubItems.Add(ct.SubItems[2].Text);
                item.SubItems.Add(ct.SubItems[3].Text);
                item.SubItems.Add(ct.SubItems[4].Text);
                item.SubItems.Add(ct.SubItems[5].Text);
                item.SubItems.Add(ct.SubItems[6].Text);
                item.SubItems.Add(ct.SubItems[7].Text);
                item.SubItems.Add(ct.SubItems[8].Text);
                item.SubItems.Add(ct.SubItems[9].Text);
            }
        }

        /// <summary>
        /// Lấy năm học
        /// </summary>
        /// <param name="year"></param>
        private void AddYears(string year)
        {
            years.Add(year);
        }

        /// <summary>
        /// Lấy học kỳ
        /// </summary>
        /// <param name="course"></param>
        private void AddCourses(string course)
        {
            courses.Add(course);
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
                for (int i = 0; i < lvQL.Items.Count; i++)
                {
                    ListViewItem item = lvQL.Items[i];
                    colIndex = 1;
                    rowIndex++;
                    ws.Cells[rowIndex, colIndex++].Value = item.SubItems[0].Text;
                    ws.Cells[rowIndex, colIndex++].Value = item.SubItems[1].Text;
                    ws.Cells[rowIndex, colIndex++].Value = item.SubItems[2].Text;
                    ws.Cells[rowIndex, colIndex++].Value = item.SubItems[3].Text;
                    ws.Cells[rowIndex, colIndex++].Value = item.SubItems[4].Text;
                    ws.Cells[rowIndex, colIndex++].Value = item.SubItems[5].Text;
                    ws.Cells[rowIndex, colIndex++].Value = item.SubItems[6].Text;
                    ws.Cells[rowIndex, colIndex++].Value = item.SubItems[7].Text;
                    ws.Cells[rowIndex, colIndex++].Value = item.SubItems[8].Text;
                    ws.Cells[rowIndex, colIndex++].Value = item.SubItems[9].Text;
                }
                //save file
                Byte[] bin = p.GetAsByteArray();
                File.WriteAllBytes(path, bin);
            }
        }
        #endregion

        private void QLDKHPForm_Load(object sender, EventArgs e)
        {
            LoadcomboboxKhoa();
            LoadcomboboxLop(cbbKhoa.Text);
            LoadcbbCourse();
            LoadItem();
            cbbNamHoc.DataSource = years;
            cbbHK.DataSource = courses;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = string.Format("Danh Sach Dang Ky Hoc Phan Hoc ky {0} Nam hoc {1}", cbbHK.Text, DateTime.Now.Year.ToString() + " - " + (DateTime.Now.Year + 1).ToString());
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
            LoadItemWithCourse(hocKy, nam);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                LoadItem();
            SearchByKey(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                LoadItem();
        }

        private void cbbKhoa_TextChanged(object sender, EventArgs e)
        {
            LoadcomboboxLop(cbbKhoa.Text);
            GetByKhoa(cbbKhoa.Text);
        }

        private void cbbLop_TextChanged(object sender, EventArgs e)
        {
            GetByLop(cbbLop.Text);
        }

        private void cbbCourse_TextChanged(object sender, EventArgs e)
        {
            GetByCourse(int.Parse(cbbCourse.Text));
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = LichThiBL.Instance().LoadLichThi(cbbNamHoc.Text, int.Parse(cbbHK.Text));
            ThongKeFrm frm = new ThongKeFrm();
            frm.LoadChart(reader, cbbNamHoc.Text, cbbHK.Text);
            frm.ShowDialog();
        }
    }
}
