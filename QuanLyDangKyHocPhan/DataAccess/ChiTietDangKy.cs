using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    /// <summary>
    /// Lớp ánh xạ bảng Chi tiết đăng ký học phần
    /// </summary>
    public class ChiTietDangKy
    {
        /// <summary>
        /// Mã số sinh viên đăng ký học phần
        /// </summary>
        public int MSSV { get; set; }

        /// <summary>
        /// Mã số học phần được sinh viên đăng ký
        /// </summary>
        public string MaHP { get; set; }

        /// <summary>
        /// Ngày đăng ký học phần
        /// </summary>
        public DateTime NgayDangKy { get; set; }

        /// <summary>
        /// Học kỳ
        /// </summary>
        public int HocKy { get; set; }

        /// <summary>
        /// Năm học
        /// </summary>
        public int NamHoc { get; set; }
    }
}
