using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    /// <summary>
    /// Lớp định nghĩa học phí của sinh viên
    /// </summary>
    public class HocPhi
    {
        /// <summary>
        /// Mã hoá đơn
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Mã sinh viên
        /// </summary>
        public int MSSV { get; set; }
        /// <summary>
        /// Học kỳ
        /// </summary>
        public int HocKy {get;set;}
        /// <summary>
        /// Năm học
        /// </summary>
        public string NamHoc { get; set;}
        /// <summary>
        /// Số tiền
        /// </summary>
        public int SoTien { get; set;}
        /// <summary>
        /// Chi tiết cập nhật
        /// </summary>
        public string CapNhat { get; set; }
        /// <summary>
        /// Tình trạng đóng tiền
        /// </summary>
        public bool TinhTrang { get; set; }


    }
}
