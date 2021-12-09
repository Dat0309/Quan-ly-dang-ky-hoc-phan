using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;

namespace QuanLyDangKyHocPhan
{
    public partial class LichThiForm : Form
    {
        SinhVien currentSV;
        List<LichThi> lichThiList;
        string currentYear = DateTime.Now.Year.ToString() + " - " + (DateTime.Now.Year + 1).ToString();

        public LichThiForm(string userName)
        {
            currentSV = SinhVienBL.getInstance().GetByMSSV(int.Parse(userName));
            InitializeComponent();
        }

        #region Các hàm xử lý

        private void GetItem()
        {
            HocPhanBL hpBL = HocPhanBL.getInstance();
            LichThiBL ltBL = LichThiBL.Instance();
            lichThiList = ltBL.GetLichThiSV(currentSV.MSSV, int.Parse(cbbHocky.Text == ""? "1" : cbbHocky.Text));

            lvLichThi.Items.Clear();
            foreach (var lt in lichThiList)
            {
                string tenHP = hpBL.GetByMaHP(lt.MaHP).TenHP;
                int STC = hpBL.GetByMaHP(lt.MaHP).TongSoTC;
                lbLichThi.Text = String.Format("Lịch thi học kỳ {0} năm học {1} của sinh viên {2}, lớp {3}, khoa {4}",
                    cbbHocky.Text, currentYear, currentSV.HoLot + " " + currentSV.Ten, currentSV.TenLop, currentSV.Khoa);
                ListViewItem item = lvLichThi.Items.Add(lt.MaHP);
                item.SubItems.Add(tenHP);
                item.SubItems.Add(STC.ToString());
                item.SubItems.Add(lt.NgayThi);
                item.SubItems.Add(lt.GioThi);
                item.SubItems.Add(lt.ThoiLuong.ToString());
                item.SubItems.Add(lt.PhongThi);
                item.SubItems.Add(lt.DiaDiem);
                item.SubItems.Add(lt.GhiChu);

            }
        }

        #endregion

        private void LichThiForm_Load(object sender, EventArgs e)
        {
            GetItem();
        }

        private void cbbHocky_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetItem();
        }
    }
}
