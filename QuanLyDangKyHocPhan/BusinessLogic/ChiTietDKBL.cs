using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    /// <summary>
    /// Các phương thức xử lý bảng chi tiết đăng ký
    /// </summary>
    public class ChiTietDKBL
    {
        ChiTietDangKyDA ctdkDA = new ChiTietDangKyDA();

        private static ChiTietDKBL instance;
        private ChiTietDKBL()
        {

        }

        public static ChiTietDKBL getInstance()
        {
            if (instance == null)
                instance = new ChiTietDKBL();
            return instance;
        }

        public List<ChiTietDangKy> GetAll()
        {
            return ctdkDA.GetAll();
        }

        public ChiTietDangKy GetByMSSV(int mssv)
        {
            List<ChiTietDangKy> list = GetAll();
            foreach (var item in list)
            {
                if (item.MSSV == mssv)
                    return item;
            }
            return null;
        }

        public ChiTietDangKy GetByMaHP(string mahp)
        {
            List<ChiTietDangKy> list = GetAll();
            foreach (var item in list)
            {
                if (item.MaHP == mahp)
                    return item;
            }
            return null;
        }

        public List<ChiTietDangKy> Find(string key)
        {
            List<ChiTietDangKy> list = GetAll();
            List<ChiTietDangKy> result = new List<ChiTietDangKy>();

            foreach (var hp in list)
            {
                if (hp.MaHP.Contains(key) || hp.NamHoc.Contains(key)||hp.HocKy.ToString().Contains(key))
                    result.Add(hp);
            }
            return result;
        }
        public int Insert(ChiTietDangKy ct)
        {
            return ctdkDA.Insert_Update_Delete(ct, 0);
        }

        public int Update(ChiTietDangKy ct)
        {
            return ctdkDA.Insert_Update_Delete(ct, 1);
        }

        public int Delete(ChiTietDangKy ct)
        {
            return ctdkDA.Insert_Update_Delete(ct, 2);
        }

        public int InsertMulti(List<ChiTietDangKy> list)
        {
            return ctdkDA.InsertMulti(list, 0);
        }

        public int DieuChinhHocPhan(ChiTietDangKy ct)
        {
            return ctdkDA.DieuChinhHP(ct);
        }

        public int DeleteByKey(int mssv, string mahp)
        {
            return ctdkDA.DeleteByKey(mssv, mahp);
        }

        public SqlDataReader GetChiTietDKHP()
        {
            return ctdkDA.GetChiTietDKHP();
        }

        public SqlDataReader GetChiTietDKHPTheoHocKy(int hocky, string nam)
        {
            return ctdkDA.GetChiTietDKHPTheeoHocKy(hocky, nam);
        }

        public SqlDataReader QLChiTietHP()
        {
            return ctdkDA.QLChiTietHP();
        }

        public SqlDataReader GetHocPhanTheoHocKyVaNam(int hocKy, string nam)
        {
            return ctdkDA.GetHocPhanTheoHocKyVaNam(hocKy, nam);
        }
        public List<SinhVien> CheckSVDangKyHocPhan(string MaHP)
        {
            return ctdkDA.CheckSVDangKyHocPhan(MaHP);
        }
    }
}
