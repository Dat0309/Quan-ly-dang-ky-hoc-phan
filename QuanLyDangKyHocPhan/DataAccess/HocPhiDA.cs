using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class HocPhiDA
    {
        public List<HocPhi> GetAll()
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.HocPhi_GetAll;

            SqlDataReader reader = cmd.ExecuteReader();
            List<HocPhi> list = new List<HocPhi>();
            while (reader.Read())
            {
                HocPhi phi = new HocPhi();
                phi.id = int.Parse(reader["Id"].ToString());
                phi.MSSV = int.Parse(reader["MSSV"].ToString());
                phi.HocKy = int.Parse(reader["HocKy"].ToString());
                phi.NamHoc = reader["NamHoc"].ToString();
                phi.SoTien = int.Parse(reader["SoTien"].ToString());
                phi.CapNhat = DateTime.Parse(reader["CapNhat"].ToString()).ToShortDateString();
                phi.TinhTrang = reader["TinhTrang"].ToString() == "true" ? true : false;

                list.Add(phi);
            }
            conn.Close();
            return list;
        }

        public int Insert_Update_Delete(HocPhi hp, int action)
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.HocPhi_InsertUpdateDelete;

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = hp.id;
            cmd.Parameters.Add("@MSSV", SqlDbType.Int).Value = hp.MSSV;
            cmd.Parameters.Add("@HocKy", SqlDbType.Int).Value = hp.HocKy;
            cmd.Parameters.Add("@NamHoc", SqlDbType.NVarChar, 20).Value = hp.NamHoc;
            cmd.Parameters.Add("@SoTien", SqlDbType.Int).Value = hp.SoTien;
            cmd.Parameters.Add("@CapNhat", SqlDbType.SmallDateTime).Value = hp.CapNhat;
            cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit).Value = hp.TinhTrang;

            cmd.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
                return 1;
            return 0;
            conn.Close();
        }
    }
}
