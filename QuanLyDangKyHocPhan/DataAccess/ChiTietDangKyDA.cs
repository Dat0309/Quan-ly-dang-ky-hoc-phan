using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ChiTietDangKyDA
    {
        public List<ChiTietDangKy> GetAll()
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.ChiTietDK_GetAll;

            SqlDataReader reader = cmd.ExecuteReader();
            List<ChiTietDangKy> list = new List<ChiTietDangKy>();
            while (reader.Read())
            {
                ChiTietDangKy ctdk = new ChiTietDangKy();
                ctdk.MSSV = int.Parse(reader["MSSV"].ToString());
                ctdk.MaHP = reader["MaHP"].ToString();
                ctdk.NgayDangKy = reader["NgayDK"].ToString();
                ctdk.HocKy = int.Parse(reader["HocKy"].ToString());
                ctdk.NamHoc = reader["NamHoc"].ToString();

                list.Add(ctdk);
            }
            conn.Close();
            return list;
        }

        public int Insert_Update_Delete(ChiTietDangKy ctdk, int action)
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.CTDK_InsertUpdateDelete;

            cmd.Parameters.Add("@MSSV", SqlDbType.Int).Value = ctdk.MSSV;
            cmd.Parameters.Add("@MaHP", SqlDbType.NVarChar, 20).Value = ctdk.MaHP;
            cmd.Parameters.Add("@NgayDangKy", SqlDbType.DateTime).Value = ctdk.NgayDangKy;
            cmd.Parameters.Add("@HocKy", SqlDbType.Int).Value = ctdk.HocKy;
            cmd.Parameters.Add("@NamHoc", SqlDbType.NVarChar, 20).Value = ctdk.NamHoc;

            cmd.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
                return 1;
            return 0;
            conn.Close();
        }

        public int InsertMulti(List<ChiTietDangKy> ctdks, int action)
        {
            int result = 0;
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.CTDK_InsertUpdateDelete;

            foreach (var ctdk in ctdks)
            {
                cmd.Parameters.Add("@MSSV", SqlDbType.Int).Value = ctdk.MSSV;
                cmd.Parameters.Add("@MaHP", SqlDbType.NVarChar, 20).Value = ctdk.MaHP;
                cmd.Parameters.Add("@NgayDangKy", SqlDbType.DateTime).Value = ctdk.NgayDangKy;
                cmd.Parameters.Add("@HocKy", SqlDbType.Int).Value = ctdk.HocKy;
                cmd.Parameters.Add("@NamHoc", SqlDbType.NVarChar, 20).Value = ctdk.NamHoc;

                cmd.Parameters.Add("@Action", SqlDbType.Int).Value = action;

                result = cmd.ExecuteNonQuery();
            }
            
            if (result > 0)
                return 1;
            return 0;
            conn.Close();
        }
    }
}
