using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    /// <summary>
    /// Lớp ánh xạ bảng Tài khoản người dùng
    /// </summary>
    public class TaiKhoan
    {
        /// <summary>
        /// Mã tài khoản
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Tài khoản
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Mật khẩu
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Kích hoạt
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Quyền của tài khoản
        /// </summary>
        public int IDQuyen { get; set; }

        /// <summary>
        /// Ngày lập
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Tên chủ tài khoản
        /// </summary>
        public string FullName { get; set; }
    }
}
