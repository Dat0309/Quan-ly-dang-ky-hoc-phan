using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class LichThiBL
    {
        LichThiDA lichThiDA = new LichThiDA();
        private static LichThiDA instance;
        public LichThiBL()
        {

        }
        public static LichThiDA Instance()
        {
            if(instance == null)
                instance= new LichThiDA();
            return instance;
        }
        public List<LichThi> GetAll()
        {
            return lichThiDA.GetAll();
        }
        public LichThi GetByMaHP(string maHP)
        {
            List<LichThi>list =GetAll();
            foreach(LichThi lt in list)
            {
                if (lt.MaHP == maHP)
                    return lt;
            }
            return null;
        }

        public List<LichThi>Find(string key)
        {
            List<LichThi> list = GetAll();
            List<LichThi>result=new List<LichThi>();
            foreach (var lt in list)
            {
                if (lt.id.ToString().Contains(key)
                || lt.MaHP.Contains(key)
                || lt.HocKy.ToString().Contains(key)
                || lt.NamHoc.ToString().Contains(key)
                || lt.NgayThi.Contains(key)
                || lt.GioThi.Contains(key)
                || lt.ThoiLuong.ToString().Contains(key)
                || lt.PhongThi.Contains(key)
                || lt.DiaDiem.Contains(key)
                || lt.GhiChu.Contains(key))
                    result.Add(lt);
            }
            return result;
        }

        public int Insert(LichThi lichThi)
        {
            return lichThiDA.Insert_Update_Delete(lichThi, 0);
        }

        public int Update(LichThi lichThi)
        {
            return lichThiDA.Insert_Update_Delete(lichThi, 1);
        }
        public int Delete(LichThi lichThi)
        {
            return lichThiDA.Insert_Update_Delete(lichThi, 2);
        }
        public SqlDataReader LoadLichThi(string namHoc, int hocKy)
        {
            return lichThiDA.LoadLichThi(namHoc, hocKy);
        }
    }
}
