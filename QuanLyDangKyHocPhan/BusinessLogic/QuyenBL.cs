using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    /// <summary>
    /// Các phương thức xử lý bảng quyền
    /// </summary>
    public class QuyenBL
    {
        private static QuyenBL instance;
        private QuyenBL()
        {

        }
        public static QuyenBL getInstance()
        {
            if (instance == null)
            {
                return instance = new QuyenBL();
            }
            return instance;
        }
        QuyenDA qDA = new QuyenDA();
        /// <summary>
        /// Lấy danh sách quyền
        /// </summary>
        /// <returns></returns>
        public List<Quyen> GetAll()
        {
            return qDA.GetAll();
        }

        public Quyen GetByMSSV(int id)
        {
            List<Quyen> list = GetAll();

            foreach (Quyen s in list)
            {
                if (s.Id == id)
                    return s;
            }
            return null;
        }
        public List<Quyen> Find(string key)
        {
            List<Quyen> list = GetAll();
            List<Quyen> result = new List<Quyen>();

            foreach (var q in list)
            {
                if (q.Id.ToString().Contains(key))
                    result.Add(q);
            }
            return result;
        }
        /// <summary>
        /// Thêm quyền
        /// </summary>
        /// <param name="q"></param>
        /// <returns></returns>
        public int Insert(Quyen q)
        {
            return qDA.Insert_Update_Delete(q, 0);
        }
        /// <summary>
        /// Cập nhật quyền
        /// </summary>
        /// <param name="q"></param>
        /// <returns></returns>
        public int Update(Quyen q)
        {
            return qDA.Insert_Update_Delete(q, 1);
        }
        /// <summary>
        /// Xóa quyền
        /// </summary>
        /// <param name="q"></param>
        /// <returns></returns>
        public int Delete(Quyen q)
        {
            return qDA.Insert_Update_Delete(q, 2);
        }
    }
}
