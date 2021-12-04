
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    /// <summary>
    /// Lớp ánh xạ bảng Học Phần
    /// </summary>
    public class HocPhan
    {
        /// <summary>
        /// Mã học phàn
        /// </summary>
        public string MaHP { get; set; }

        /// <summary>
        /// Tên Học phần
        /// </summary>
        public string TenHP { get; set; }

        /// <summary>
        /// Loại học phần
        /// </summary>
        public string LoaiHP { get; set; }
        /// <summary>
        /// Học kỳ được mở dạy
        /// </summary>
        public int HocKy { get; set; }
        /// <summary>
        /// Năm được mở dạy vd: năm nhất học kỳ 1
        /// </summary>
        public int Nam { get; set; }
        /// <summary>
        /// Học phần thuộc khoa
        /// </summary>
        public string Khoa { get; set; }

        /// <summary>
        /// Tổng số tín chỉ
        /// </summary>
        public int TongSoTC { get; set; }


        /// <summary>
        /// TC Ly thuyet
        /// </summary>
        public int TCLT { get; set; }

        /// <summary>
        /// TC thuc hanh
        /// </summary>
        public int TCTH { get; set; }
        /// <summary>
        /// Giới hạn đăng đăng ký
        /// </summary>
        public int TCLT { get; set; }
        public int TCTH { get; set; }
        public int GioiHan { get; set; }
    }
}
