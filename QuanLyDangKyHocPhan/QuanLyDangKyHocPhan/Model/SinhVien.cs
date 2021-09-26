using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDangKyHocPhan.Model
{
    public class SinhVien
    {
        public string mssv { get; set; }
        public string ho { get; set; }
        public string ten { get; set; }
        public DateTime ngaySinh { get; set; }
        public string diaChi { get; set; }
        public string lop { get; set; }

        public SinhVien()
        {
        }

        public SinhVien(string mssv, string ho, string ten, DateTime ngaySinh, string diaChi, string lop)
        {
            this.mssv = mssv;
            this.ho = ho;
            this.ten = ten;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.lop = lop;
        }
    }
}
