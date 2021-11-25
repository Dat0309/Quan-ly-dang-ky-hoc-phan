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
    }
}
