using BusinessLogic;
using DataAccess;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDangKyHocPhan
{
    public partial class ChiTietDangKyHocPhan : Form
    {
        string MaHP;
        List<SinhVien> listSV;
        ChiTietDKBL ctBL = ChiTietDKBL.getInstance();
        public ChiTietDangKyHocPhan(string MaHP)
        {
            this.MaHP = MaHP;
            InitializeComponent();
        }
        #region

        /// <summary>
        /// Load lich thi
        /// </summary>
        private void LoadSVToLV()
        {
            listSV = ctBL.CheckSVDangKyHocPhan(MaHP);
            lvCTHP.Items.Clear();
            foreach (var sv in listSV)
            {
                ListViewItem item = lvCTHP.Items.Add(sv.MSSV.ToString());
                item.SubItems.Add(sv.HoLot);
                item.SubItems.Add(sv.Ten);
                item.SubItems.Add(sv.TenLop);
                item.SubItems.Add(sv.Khoa);
                item.SubItems.Add(sv.GioiTinh == true ? "Nam" : "Nữ");
                item.SubItems.Add(sv.NgaySinh);
                item.SubItems.Add(sv.DiaChi);
            }
        }

        /// <summary>
        /// Xuất kêt quả đăng ký
        /// </summary>
        /// <param name="lv"></param>
        /// <param name="listKQDK"></param>
        /// <param name="path"></param>
        private void WriteToExcel(ListView lv, List<SinhVien> listKQDK, string path)
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
                foreach (var item in listKQDK)
                {
                    colIndex = 1;
                    rowIndex++;
                    ws.Cells[rowIndex, colIndex++].Value = item.MSSV;
                    ws.Cells[rowIndex, colIndex++].Value = item.HoLot;
                    ws.Cells[rowIndex, colIndex++].Value = item.Ten;
                    ws.Cells[rowIndex, colIndex++].Value = item.TenLop;
                    ws.Cells[rowIndex, colIndex++].Value = item.Khoa;
                    ws.Cells[rowIndex, colIndex++].Value = item.GioiTinh == true? "Nam" : "Nữ";
                    ws.Cells[rowIndex, colIndex++].Value = item.NgaySinh;
                    ws.Cells[rowIndex, colIndex++].Value = item.DiaChi;
                }
                //save file
                Byte[] bin = p.GetAsByteArray();
                File.WriteAllBytes(path, bin);
            }
        }

        #endregion

        private void lvCTHP_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ChiTietDangKyHocPhan_Load(object sender, EventArgs e)
        {
            LoadSVToLV();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            saveFileDialog1.FileName = string.Format("Danh sách thi học phần {0} năm học {1}",
                HocPhanBL.getInstance().GetByMaHP(MaHP).TenHP,DateTime.Now.Year.ToString() + " - " + (DateTime.Now.Year + 1).ToString());
            saveFileDialog1.InitialDirectory = @"E:\";
            saveFileDialog1.DefaultExt = "xlsx";
            saveFileDialog1.Filter = "Excel 2007 files(xlsx) (*.xlsx)|*.xlsx";

            DialogResult dlg = saveFileDialog1.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                string path = string.Format(@"{0}", saveFileDialog1.FileName);
                WriteToExcel(lvCTHP, listSV, path);
                MessageBox.Show("Xuất danh sách thi thành công!");
            }
        }
    }
}
