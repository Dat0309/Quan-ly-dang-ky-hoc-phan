
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
        /// Số tín chir lý thuyết
        /// </summary>
        public int TCLT { get; set; }

        /// <summary>
        /// Số tín chỉ thực hành
        /// </summary>
        public int TCTH { get; set; }

        /// <summary>
        /// Tổng số tín chỉ
        /// </summary>
        public int TongSoTC { get; set; }
    }
}
