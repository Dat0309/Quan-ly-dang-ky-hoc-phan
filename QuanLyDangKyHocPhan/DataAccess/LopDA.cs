using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    /// <summary>
    /// Lớp quản lý lớp
    /// </summary>
    public class LopDA
    {
        public List<Lop> GetAll()
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.Lop_GetAll;

            SqlDataReader reader = cmd.ExecuteReader();
            List<Lop> list = new List<Lop>();
            while (reader.Read())
            {
                Lop k = new Lop();
                k.TenLop = reader["TenLop"].ToString();
                k.TenKhoa = reader["TenKhoa"].ToString();
                list.Add(k);
            }
            conn.Close();
            return list;
        }
    }
}
