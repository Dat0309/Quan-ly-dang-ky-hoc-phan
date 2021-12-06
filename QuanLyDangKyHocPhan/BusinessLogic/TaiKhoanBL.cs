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

        private static TaiKhoanBL instance;

        private TaiKhoanBL()
        {

        }

        public static TaiKhoanBL getInstance()
        {
            if(instance == null)
                instance = new TaiKhoanBL();
            return instance;
        }

        public List<TaiKhoan> GetAll()
        {
            return tkDA.GetAll();
        }

        public TaiKhoan GetById(int id)
        {
            List<TaiKhoan> list = GetAll();
            foreach (var tk in list)
                if(tk.Id == id)
                    return tk;
            return null;
        }
        public List<TaiKhoan> Find(string key)
        {
            List<TaiKhoan> list = GetAll();
            List<TaiKhoan> result = new List<TaiKhoan>();

            foreach (var tk in list)
            {
                if (tk.UserName.Contains(key)||tk.FullName.Contains(key))
                    result.Add(tk);
            }
            return result;
        }
        public List<TaiKhoan> FindtheoQuyen(string quyen)
        {
            List<TaiKhoan> list = GetAll();
            List<TaiKhoan> result = new List<TaiKhoan>();

            foreach (var tk in list)
            {
                if (tk.IDQuyen .ToString().CompareTo(quyen) == 0)
                    result.Add(tk);
            }
            return result;
        }
        public bool Authentication(string username, string password)
        {
            List<TaiKhoan> list = GetAll();
            foreach (var tk in list)
                if (tk.UserName == username && tk.Password == password)
                    return true;
            return false;
        }

        public bool isCorrectPass(string password)
        {
            List<TaiKhoan> list = GetAll();
            foreach (var tk in list)
                if (tk.Password == password)
                    return true;
            return false;
        }

        public int GetRoleID(string username)
        {
            List<TaiKhoan> list = GetAll();
            foreach (var tk in list)
                if (tk.UserName == username)
                    return tk.IDQuyen;
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

        public int UpdatePass(string username, string pass)
        {
            return tkDA.UpdatePassword(username, pass);
        }
    }
}
