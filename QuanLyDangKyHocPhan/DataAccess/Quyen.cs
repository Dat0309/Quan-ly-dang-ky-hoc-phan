using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    /// <summary>
    /// Lớp ánh xạ bảng Quyền người dùng
    /// </summary>
    public class Quyen
    {
        /// <summary>
        /// id của quyền
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Tên quyền của người dùng
        /// </summary>
        public string TenQuyen { get; set; }

        /// <summary>
        /// Mô tả quyền người dùng
        /// </summary>
        public string MoTa { get; set; }

    }
}
