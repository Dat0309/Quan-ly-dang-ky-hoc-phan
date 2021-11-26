using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccess
{
    public class Ultilities
    {
        private static string StrName = "ConnectionStringName";
        public static string ConnectionString = ConfigurationManager
            .ConnectionStrings[StrName].ConnectionString;

        /// <summary>
        /// Sinh vien
        /// </summary>
        public static string SinhVien_GetAll = "SinhVien_GetAll";
        public static string SinhVien_InsertUpdateDelete = "SinhVien_InsertUpdateDelete";

        public static string HocPhan_GetAll = "HocPhan_GetAll";
        public static string HocPhan_InsertUpdateDelete = "HocPhan_InsertUpdateDelete";
        public static string GetHPChuaTichLuy = "GetHPChuaTichLuy";
        public static string GetHPTheoKeHoach = "GetHPTheoKeHoach";
        public static string GetHPNgoaiKeHoach = "GetHPNgoaiKeHoach";
        public static string GetKQDK = "GetKQDK";

        public static string TaiKhoan_GetAll = "TaiKhoan_GetAll";
        public static string TaiKhoan_InsertUpdateDelete = "TaiKhoan_InsertUpdateDelete";

        public static string Quyen_GetAll = "Quyen_GetAll";
        public static string Quyen_InsertUpdateDelete = "Quyen_InsertUpdateDelete";

        public static string ChiTietDK_GetAll = "ChiTietDK_GetAll";
        public static string CTDK_InsertUpdateDelete = "CTDK_InsertUpdateDelete";
    }
}
