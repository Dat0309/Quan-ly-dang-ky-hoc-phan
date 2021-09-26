using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDangKyHocPhan.Model
{
    public class HocPhan
    {
        public string mahp { get; set; }
        public string tenhp { get; set; }
        public int tongTC { get; set; }
        public int tclt { get; set; }
        public int tcth { get; set; }
        public string loaiTC { get; set; }

        public HocPhan()
        {
        }
        public HocPhan(string mahp, string tenhp, int tongTC, int tclt, int tcth, string loaiTC)
        {
            this.mahp = mahp;
            this.tenhp = tenhp;
            this.tongTC = tongTC;
            this.tclt = tclt;
            this.tcth = tcth;
            this.loaiTC = loaiTC;
        }
    }
}
