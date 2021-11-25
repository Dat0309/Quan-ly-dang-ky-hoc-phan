using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class TaiKhoanBL
    {
        TaiKhoanDA tkDA = new TaiKhoanDA();

        public List<TaiKhoan> GetAll()
        {
            return tkDA.GetAll();
        }

        public TaiKhoan GetById(int id)
        {
            List<TaiKhoan> list = GetAll();
            foreach (var tk in list)
            {
                if(tk.Id == id)
                    return tk;
            }
            return null;
        }

        public bool Authentication(string username, string password)
        {
            List<TaiKhoan> list = GetAll();
            foreach (var tk in list)
            {
                if (tk.UserName == username && tk.Password == password)
                    return true;
            }
            return false;
        }

        public int GetRoleID(string username)
        {
            List<TaiKhoan> list = GetAll();
            foreach (var tk in list)
            {
                if (tk.UserName == username)
                    return tk.IDQuyen;
            }
            return -1;
        }

        public int Insert(TaiKhoan tk)
        {
            return tkDA.Insert_Update_Delete(tk, 0);
        }

        public int Update(TaiKhoan tk)
        {
            return tkDA.Insert_Update_Delete(tk, 1);
        }

        public int Delete(TaiKhoan tk)
        {
            return tkDA.Insert_Update_Delete(tk, 2);
        }
    }
}
