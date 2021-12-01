using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    /// <summary>
    /// Các phương thức xử lý bảng sinh viên
    /// </summary>
    public class SinhVienBL
    {
        private static SinhVienBL instance;
        private SinhVienBL()
        {

        }

        public static SinhVienBL getInstance()
        {
            if(instance == null)
            {
                return instance = new SinhVienBL();
            }
            return instance;
        }
        SinhVienDA svDA = new SinhVienDA();

        /// <summary>
        /// Lấy danh sách sinh viên
        /// </summary>
        /// <returns></returns>
        public List<SinhVien> GetAll()
        {
            return svDA.GetAll();
        }

        /// <summary>
        /// Lấy theo mã sinh viên
        /// </summary>
        /// <param name="mssv"></param>
        /// <returns></returns>
        public SinhVien GetByMSSV(int mssv)
        {
            List<SinhVien> list = GetAll();

            foreach (SinhVien s in list)
            {
                if (s.MSSV == mssv)
                    return s;
            }
            return null;
        }

        /// <summary>
        /// Tìm kiếm sinh viên theo từ khoá
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public List<SinhVien> Find(string key)
        {
            List<SinhVien> list = GetAll();
            List<SinhVien> result = new List<SinhVien>();

            foreach (var sv in list)
            {
                if(sv.MSSV.ToString().Contains(key)
                    || sv.Ten.Contains(key)
                    || sv.TenLop.Contains(key)
                    || sv.Khoa.Contains(key))
                    result.Add(sv);
            }
            return result;
        }

        /// <summary>
        /// thêm sinh viên
        /// </summary>
        /// <param name="sv"></param>
        /// <returns></returns>
        public int Insert(SinhVien sv)
        {
            return svDA.Insert_Update_Delete(sv, 0);
        }

        /// <summary>
        ///  Sửa sinh viên
        /// </summary>
        /// <param name="sv"></param>
        /// <returns></returns>
        public int Update(SinhVien sv)
        {
            return svDA.Insert_Update_Delete(sv, 1);
        }

        /// <summary>
        /// Xoá sinh viên
        /// </summary>
        /// <param name="sv"></param>
        /// <returns></returns>
        public int Delete(SinhVien sv)
        {
            return svDA.Insert_Update_Delete(sv, 2);
        }
    }
}
