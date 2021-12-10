using BusinessLogic;
using DataAccess;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace QuanLyDangKyHocPhan
{
    public partial class HocPhanForm : Form
    {
        HocPhanBL hocPhanBL = HocPhanBL.getInstance();
        List<HocPhan> listHP;
        HocPhan hocPhanCurrent;
        public HocPhanForm()
        {
            InitializeComponent();
        }
        private void LoadMHToLV()
        {
            listHP = hocPhanBL.GetAll();
            lvHP.Items.Clear();
            foreach (var hp in listHP)
            {
                ListViewItem item = lvHP.Items.Add(hp.MaHP.ToString());
                item.SubItems.Add(hp.TenHP);
                item.SubItems.Add(hp.LoaiHP);
                item.SubItems.Add(hp.HocKy.ToString());
                item.SubItems.Add(hp.Nam.ToString());
                item.SubItems.Add(hp.TongSoTC.ToString());
                item.SubItems.Add(hp.TCLT.ToString());
                item.SubItems.Add(hp.TCTH.ToString());
                item.SubItems.Add(hp.Khoa);
                item.SubItems.Add(hp.GioiHan.ToString());

            }
        }
        private void gunaButton3_Click(object sender, EventArgs e)
        {
            var hocPhanInfo = new HocPhanInfo();
            hocPhanInfo.LoadStatusAdd();
            if (hocPhanInfo.ShowDialog() == DialogResult.OK)
            {
                LoadMHToLV();
            }
        }

        private void HocPhanForm_Load(object sender, EventArgs e)
        {
            LoadMHToLV();
        }


        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            hocPhanCurrent = new HocPhan();
            if (MessageBox.Show("Bạn có muốn xoá môn học này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ListViewItem item = lvHP.SelectedItems[0];
                hocPhanCurrent.MaHP = item.SubItems[0].Text;
                hocPhanCurrent.TenHP = item.SubItems[1].Text;
                hocPhanCurrent.LoaiHP = item.SubItems[2].Text;
                hocPhanCurrent.HocKy = int.Parse(item.SubItems[3].Text);
                hocPhanCurrent.Nam = int.Parse(item.SubItems[4].Text);
                hocPhanCurrent.TongSoTC = int.Parse(item.SubItems[5].Text);
                hocPhanCurrent.TCLT = int.Parse(item.SubItems[6].Text);
                hocPhanCurrent.TCTH = int.Parse(item.SubItems[7].Text);
                hocPhanCurrent.Khoa = item.SubItems[8].Text;
                hocPhanCurrent.GioiHan = int.Parse(item.SubItems[9].Text);
                if (hocPhanBL.Delete(hocPhanCurrent) > 0)
                {
                    MessageBox.Show("Xóa sinh viên thành công");
                    LoadMHToLV();
                }
                else MessageBox.Show("Xóa thất bại");
            }
        }

        private void LoadHocPhan(string key = "")
        {
            listHP = hocPhanBL.Find(key);
            lvHP.Items.Clear();
            foreach (var hp in listHP)
            {
                ListViewItem item = lvHP.Items.Add(hp.MaHP);
                item.SubItems.Add(hp.TenHP);
                item.SubItems.Add(hp.LoaiHP);
                item.SubItems.Add(hp.HocKy.ToString());
                item.SubItems.Add(hp.Nam.ToString());
                item.SubItems.Add(hp.TongSoTC.ToString());
                item.SubItems.Add(hp.TCLT.ToString());
                item.SubItems.Add(hp.TCTH.ToString());
                item.SubItems.Add(hp.Khoa);
                item.SubItems.Add(hp.GioiHan.ToString());
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                LoadMHToLV();
            LoadHocPhan(txtSearch.Text.ToString());
        }

        private void ReadFromExcel(string path)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            try
            {
                var package = new ExcelPackage(new System.IO.FileInfo(path));
                using (package)
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    for (int i = worksheet.Dimension.Start.Row + 1; i <= worksheet.Dimension.End.Row; i++)
                    {
                        try
                        {
                            int j = 1;

                            string MaHP = worksheet.Cells[i, j++].Value.ToString();
                            string TenHP = worksheet.Cells[i, j++].Value.ToString();
                            string LoaiHP = worksheet.Cells[i, j++].Value.ToString();
                            string HK = worksheet.Cells[i, j++].Value.ToString();
                            string Nam = worksheet.Cells[i, j++].Value.ToString();
                            string Khoa = worksheet.Cells[i, j++].Value.ToString();
                            string STC = worksheet.Cells[i, j++].Value.ToString();
                            string TCLT = worksheet.Cells[i, j++].Value.ToString();
                            string TCTH = worksheet.Cells[i, j++].Value.ToString();
                            string GioiHan = worksheet.Cells[i, j++].Value.ToString();

                            HocPhan hocPhan = new HocPhan()
                            {
                                MaHP = MaHP,
                                TenHP = TenHP,
                                LoaiHP = LoaiHP,
                                HocKy = int.Parse(HK),
                                Nam = int.Parse(Nam),
                                Khoa = Khoa,
                                TongSoTC = int.Parse(STC),
                                TCLT = int.Parse(TCLT),
                                TCTH = int.Parse(TCTH),
                                GioiHan = int.Parse(GioiHan)
                            };
                            listHP.Add(hocPhan);
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
                lvHP.Items.Clear();
                foreach (var hp in listHP)
                {
                    ListViewItem item = lvHP.Items.Add(hp.MaHP);
                    item.SubItems.Add(hp.TenHP);
                    item.SubItems.Add(hp.LoaiHP);
                    item.SubItems.Add(hp.HocKy.ToString());
                    item.SubItems.Add(hp.Nam.ToString());
                    item.SubItems.Add(hp.TongSoTC.ToString());
                    item.SubItems.Add(hp.TCLT.ToString());
                    item.SubItems.Add(hp.TCTH.ToString());
                    item.SubItems.Add(hp.Khoa);
                    item.SubItems.Add(hp.GioiHan.ToString());
                }
            }
            catch (Exception)
            {
            }
        }
        private void btnThemExcel_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"E:\";
            openFileDialog1.DefaultExt = "xlsx";
            openFileDialog1.Filter = "Excel 2007 files(xlsx) (*.xlsx)|*.xlsx";

            DialogResult dlg = openFileDialog1.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                string path = string.Format(@"{0}", openFileDialog1.FileName);
                ReadFromExcel(path);
                btnSave.Enabled = true;
            }
        }

        private void SaveData()
        {
            foreach (var hocPhan in listHP)
            {
                Thread.Sleep(10);
                hocPhanBL.Insert(hocPhan);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (LoadingFrm frm = new LoadingFrm(SaveData))
            {
                frm.ShowDialog(this);
                btnSave.Enabled = false;
                MessageBox.Show("Bạn đã thêm dữ liệu môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SuaHP_Click(object sender, EventArgs e)
        {
            if (lvHP.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn môn học cần sửa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var hocPhanInFo = new HocPhanInfo();
                hocPhanCurrent = new HocPhan();
                ListViewItem item = lvHP.SelectedItems[0];
                hocPhanCurrent.MaHP = item.SubItems[0].Text;
                hocPhanCurrent.TenHP = item.SubItems[1].Text;
                hocPhanCurrent.LoaiHP = item.SubItems[2].Text;
                hocPhanCurrent.HocKy = int.Parse(item.SubItems[3].Text);
                hocPhanCurrent.Nam = int.Parse(item.SubItems[4].Text);
                hocPhanCurrent.TongSoTC = int.Parse(item.SubItems[5].Text);
                hocPhanCurrent.TCLT = int.Parse(item.SubItems[6].Text);
                hocPhanCurrent.TCTH = int.Parse(item.SubItems[7].Text);
                hocPhanCurrent.Khoa = item.SubItems[8].Text;
                hocPhanCurrent.GioiHan = int.Parse(item.SubItems[9].Text);
                hocPhanInFo.LoadHocPhan(hocPhanCurrent);
                hocPhanInFo.LoadStatusUpdate();
                if (hocPhanInFo.ShowDialog() == DialogResult.OK)
                {
                    LoadMHToLV();
                }
            }
        }
    }
}
