using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    /// <summary>
    /// Lớp ánh xạ bảng Sinh Viên
    /// </summary>
    public class SinhVien
    {
        /// <summary>
        /// Mã số sinh viên
        /// </summary>
        public int MSSV { get; set; }

        /// <summary>
        /// Họ lọt của sinh viên
        /// </summary>
        public string HoLot { get; set; }

        /// <summary>
        /// Tên của sinh viên
        /// </summary>
        public string Ten { get; set; }

        /// <summary>
        /// Giới tính sinh viên
        /// </summary>
        public bool GioiTinh { get; set; }

        /// <summary>
        /// Ngày sinh sinh viên
        /// </summary>
        public DateTime NgaySinh { get; set; }

        /// <summary>
        /// Tên lớp
        /// </summary>
        public string TenLop { get; set; }

        /// <summary>
        /// Tên khoa
        /// </summary>
        public string Khoa { get; set; }

        /// <summary>
        /// Địa chi
        /// </summary>
        public string DiaChi { get; set; }

        /// <summary>
        /// Số điện thoại
        /// </summary>
        public string SDT { get; set; }
    }
}
