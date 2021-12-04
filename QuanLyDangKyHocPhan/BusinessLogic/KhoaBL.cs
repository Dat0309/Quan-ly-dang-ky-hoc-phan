using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class KhoaBL
    {
        KhoaDA kDA = new KhoaDA();
        private static KhoaBL instance;
        private KhoaBL()
        {
        }
        public static KhoaBL getInstance()
        {
            if (instance == null)
                instance = new KhoaBL();
            return instance;
        }
        /// <summary>
        /// lấy danh sách khoa
        /// </summary>
        /// <returns></returns>
        public List<Khoa> GetAll()
        {
            return kDA.GetAll();
        }
    }
}
