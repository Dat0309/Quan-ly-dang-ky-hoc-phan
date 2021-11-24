using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class SinhVienBL
    {
        SinhVienDA svDA = new SinhVienDA();

        public List<SinhVien> GetAll()
        {
            return svDA.GetAll();
        }

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

        public int Insert(SinhVien sv)
        {
            return svDA.Insert_Update_Delete(sv, 0);
        }

        public int Update(SinhVien sv)
        {
            return svDA.Insert_Update_Delete(sv, 1);
        }

        public int Delete(SinhVien sv)
        {
            return svDA.Insert_Update_Delete(sv, 2);
        }
    }
}
