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

        /// <summary>
        /// HocPhan procedure
        /// </summary>
        public static string HocPhan_GetAll = "HocPhan_GetAll";
        public static string HocPhan_InsertUpdateDelete = "HocPhan_InsertUpdateDelete";
        public static string GetHPChuaTichLuy = "GetHPChuaTichLuy";
        public static string GetHPTheoKeHoach = "GetHPTheoKeHoach";
        public static string GetHPNgoaiKeHoach = "GetHPNgoaiKeHoach";
        public static string GetKQDK = "GetKQDK";
        public static string GetKQDK_HienTai = "GetKQDK_HienTai";

        /// <summary>
        /// TaiKhoan procedure
        /// </summary>
        public static string TaiKhoan_GetAll = "TaiKhoan_GetAll";
        public static string TaiKhoan_InsertUpdateDelete = "TaiKhoan_InsertUpdateDelete";

        /// <summary>
        /// Quyen procedure
        /// </summary>
        public static string Quyen_GetAll = "Quyen_GetAll";
        public static string Quyen_InsertUpdateDelete = "Quyen_InsertUpdateDelete";

        /// <summary>
        /// CTDK procedure
        /// </summary>
        public static string ChiTietDK_GetAll = "ChiTietDK_GetAll";
        public static string CTDK_InsertUpdateDelete = "CTDK_InsertUpdateDelete";
        public static string UpdateCTDKHP = "UpdateCTDKHP";
        public static string DeleteByKey = "DeleteByKey";
    }
}
