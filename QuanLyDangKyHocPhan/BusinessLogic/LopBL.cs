using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class LopBL
    {
        LopDA kL = new LopDA();
        private static LopBL instance;
        private LopBL()
        {
        }
        public static LopBL getInstance()
        {
            if (instance == null)
                instance = new LopBL();
            return instance;
        }
        /// <summary>
        /// lấy danh lớp
        /// </summary>
        /// <returns></returns>
        public List<Lop> GetAll()
        {
            return kL.GetAll();
        }
        public List<Lop> Find(string key)
        {
            List<Lop> list = GetAll();
            List<Lop> result = new List<Lop> ();
            foreach(var lop in list)
            {
                if (lop.TenKhoa.ToString().CompareTo(key.Trim())==0)
                    result.Add(lop);
            }
            return result;
        }
    }
}
