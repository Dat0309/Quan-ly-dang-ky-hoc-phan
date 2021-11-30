using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    /// <summary>
    /// Các phương thức xử lý bảng học phần
    /// </summary>
    public class HocPhanBL
    {
        HocPhanDA hpDA = new HocPhanDA();

        private static HocPhanBL instance;

        private HocPhanBL()
        {

        }

        public static HocPhanBL getInstance()
        {
            if(instance == null)
                instance = new HocPhanBL();
            return instance;
        }

        /// <summary>
        /// Hàm lấy danh sách học phần
        /// </summary>
        /// <returns></returns>
        public List<HocPhan> GetAll()
        {
            return hpDA.GetAll();
        }

        /// <summary>
        /// Hàm tìm học phần theo mã
        /// </summary>
        /// <param name="mahp"></param>
        /// <returns></returns>
        public HocPhan GetByMaHP(string mahp)
        {
            List<HocPhan> list = GetAll();
            foreach (HocPhan hp in list)
            {
                if (hp.MaHP == mahp)
                    return hp;
            }
            return null;
        }

        /// <summary>
        /// Hàm tìm kiếm theo từ khoá
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public List<HocPhan> Find(string key)
        {
            List<HocPhan> list = GetAll();
            List<HocPhan> result = new List<HocPhan>();

            foreach (var hp in list)
            {
                if(hp.MaHP.Contains(key)
                    || hp.TenHP.Contains(key)
                    || hp.Khoa.Contains(key))
                    result.Add(hp);
            }
            return result;
        }

        /// <summary>
        /// Hàm thêm
        /// </summary>
        /// <param name="hp"></param>
        /// <returns></returns>
        public int Insert(HocPhan hp)
        {
            return hpDA.Insert_Update_Delete(hp, 0);
        }

        /// <summary>
        /// Hàm cập nhật
        /// </summary>
        /// <param name="hp"></param>
        /// <returns></returns>
        public int Update(HocPhan hp)
        {
            return hpDA.Insert_Update_Delete(hp, 1);
        }

        /// <summary>
        /// Hàm xoá
        /// </summary>
        /// <param name="hp"></param>
        /// <returns></returns>
        public int Delete(HocPhan hp)
        {
            return hpDA.Insert_Update_Delete(hp, 2);
        }

        /// <summary>
        /// Lấy danh sách học phần chưua tích luỹ của sinh viên
        /// </summary>
        /// <param name="mssv"></param>
        /// <returns></returns>
        public List<HocPhan> GetHPChuaTL(int mssv)
        {
            return hpDA.GetHPChuaTichLuy(mssv);
        }

        /// <summary>
        /// Lấy danh sách học phần đăng ký theo kế hoạch
        /// </summary>
        /// <param name="mssv"></param>
        /// <param name="nam"></param>
        /// <param name="hocky"></param>
        /// <returns></returns>
        public List<HocPhan> GetHPTheoKeHoach(int mssv, int nam, int hocky, string khoa)
        {
            return hpDA.GetHPTheoKH(mssv, nam, hocky, khoa);
        }

        /// <summary>
        /// Lấy danh sách học phần ngoài kế hoạch đào tạo
        /// </summary>
        /// <param name="mssv"></param>
        /// <param name="hocky"></param>
        /// <param name="khoa"></param>
        /// <returns></returns>
        public List<HocPhan> GetHPNgoaiKeHoach(int mssv,int hocky, string khoa)
        {
            return hpDA.GetHPNgoaiKH(mssv,hocky, khoa);
        }

        /// <summary>
        /// Xuất kết quả đăng ký học phần
        /// </summary>
        /// <param name="mssv"></param>
        /// <returns></returns>
        public List<HocPhan> GetKQDK(int mssv)
        {
            return hpDA.GetKQDK(mssv);
        }


        /// <summary>
        /// Xuất kế quả đăng ký học phần của học kỳ này, năm học này
        /// </summary>
        /// <param name="mssv"></param>
        /// <param name="hocky"></param>
        /// <param name="namhoc"></param>
        /// <returns></returns>
        public List<HocPhan> GetCurrentKQHP(int mssv, int hocky, string namhoc)
        {
            return hpDA.GetCurrentKQDK(mssv, hocky, namhoc);
        }
    }
}
