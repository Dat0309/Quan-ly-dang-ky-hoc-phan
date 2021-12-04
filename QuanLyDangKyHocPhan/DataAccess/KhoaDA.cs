using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class KhoaDA
    {
        public List<Khoa> GetAll()
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.Khoa_GetAll;

            SqlDataReader reader = cmd.ExecuteReader();
            List<Khoa> list = new List<Khoa>();
            while (reader.Read())
            {
                Khoa k = new Khoa();
                k.TenKhoa = reader["TenKhoa"].ToString();
                list.Add(k);
            }
            conn.Close();
            return list;
        }
    }
}
