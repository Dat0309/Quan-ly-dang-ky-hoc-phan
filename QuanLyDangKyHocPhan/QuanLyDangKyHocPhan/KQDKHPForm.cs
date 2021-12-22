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
using System.IO;
using OfficeOpenXml;

namespace QuanLyDangKyHocPhan
{
    public partial class KQDKHPForm : Form
    {
        List<HocPhan> listHP;
        SinhVien currentSV;
        SinhVienBL svBL = SinhVienBL.getInstance();

        public KQDKHPForm(string user)
        {
            currentSV = svBL.GetByMSSV(int.Parse(user));
            InitializeComponent();
            LoadDSHP();
            LoadDetail();
        }

        #region các hàm xử lý

        private void LoadDSHP()
        {
            HocPhanBL hpBL = HocPhanBL.getInstance();
            listHP = hpBL.GetKQDK(currentSV.MSSV);
            lvHP.Items.Clear();

            foreach (var hp in listHP)
            {
                ListViewItem item = lvHP.Items.Add(hp.MaHP.ToString());
                item.SubItems.Add(hp.TenHP);
                item.SubItems.Add(hp.LoaiHP);
                item.SubItems.Add(hp.TongSoTC.ToString());
            }
        }

        private void LoadDetail()
        {
            int SoLuongTC = 0;
            lbName.Text = currentSV.HoLot + " " + currentSV.Ten + " Lớp: " + currentSV.TenLop + " Khoa: " + currentSV.Khoa;
            foreach (var item in listHP)
            {
                SoLuongTC += item.TongSoTC;
            }
            txtQuantity.Text = SoLuongTC.ToString();
        }

        /// <summary>
        /// Xuất kêt quả đăng ký
        /// </summary>
        /// <param name="lv"></param>
        /// <param name="listKQDK"></param>
        /// <param name="path"></param>
        private void WriteToExcel(ListView lv, List<HocPhan> listKQDK, string path)
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
                    ws.Cells[rowIndex, colIndex++].Value = item.MaHP;
                    ws.Cells[rowIndex, colIndex++].Value = item.TenHP;
                    ws.Cells[rowIndex, colIndex++].Value = item.LoaiHP;
                    ws.Cells[rowIndex, colIndex++].Value = item.TongSoTC;
                    ws.Cells[rowIndex, colIndex++].Value = item.TCLT;
                    ws.Cells[rowIndex, colIndex++].Value = item.TCTH;
                }
                //save file
                Byte[] bin = p.GetAsByteArray();
                File.WriteAllBytes(path, bin);
            }
        }
        #endregion

        private void btnXuat_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = string.Format("KQDangKyHP SV{0}", currentSV.MSSV.ToString());
            saveFileDialog1.InitialDirectory = @"E:\";
            saveFileDialog1.DefaultExt = "xlsx";
            saveFileDialog1.Filter = "Excel 2007 files(xlsx) (*.xlsx)|*.xlsx";

            DialogResult dlg = saveFileDialog1.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                string path = string.Format(@"{0}", saveFileDialog1.FileName);
                WriteToExcel(lvHP, listHP, path);
                MessageBox.Show("Xuất phiếu đăng ký thành công!");
            }
        }
    }
}
