using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class HocPhiBL
    {
        HocPhiDA hpDA = new HocPhiDA();

        private static HocPhiBL instance;

        private HocPhiBL() { }
        public static HocPhiBL getInstance()
        {
            if(instance == null)
                return instance = new HocPhiBL();
            return instance;
        }

        /// <summary>
        /// Lấy danh sách học phí của sinh viên
        /// </summary>
        /// <returns></returns>
        public List<HocPhi> GetAll()
        {
            return hpDA.GetAll();
        }

        /// <summary>
        /// Lấy theo mã sinh viên
        /// </summary>
        /// <param name="mssv"></param>
        /// <returns></returns>
        public List<HocPhi> GetByMSSV(int mssv)
        {
            List<HocPhi> list = GetAll();
            List<HocPhi> result = new List<HocPhi>();
            foreach (HocPhi s in list)
            {
                if (s.MSSV == mssv)
                    result.Add(s);
            }
            return result;
        }

        /// <summary>
        /// thêm học phí
        /// </summary>
        /// <param name="sv"></param>
        /// <returns></returns>
        public int Insert(HocPhi hp)
        {
            return hpDA.Insert_Update_Delete(hp, 0);
        }

        /// <summary>
        ///  Sửa học phí
        /// </summary>
        /// <param name="sv"></param>
        /// <returns></returns>
        public int Update(HocPhi hp)
        {
            return hpDA.Insert_Update_Delete(hp, 1);
        }

        /// <summary>
        /// Xoá học phí
        /// </summary>
        /// <param name="sv"></param>
        /// <returns></returns>
        public int Delete(HocPhi hp)
        {
            return hpDA.Insert_Update_Delete(hp, 2);
        }

        /// <summary>
        /// Kiểm tra xem sinh viên có nợ học phí của năm trước không
        /// </summary>
        /// <param name="mssv"></param>
        /// <param name="namHoc"></param>
        /// <returns></returns>
        public int KiemTraHocPhi(string mssv, string namHoc)
        {
            return hpDA.KiemTraHocPhi(mssv, namHoc);
        }
    }
}
