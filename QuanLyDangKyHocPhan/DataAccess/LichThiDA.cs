using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccess
{
    public class LichThiDA
    {
        public List<LichThi> GetAll()
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.LichThi_GetAll;

            SqlDataReader reader = cmd.ExecuteReader();
            List<LichThi> list = new List<LichThi>();
            // ***************************************
            List<HocPhan> listHP = new List<HocPhan>();
            while (reader.Read())
            {
                LichThi lich = new LichThi();
                //***************************
                HocPhan hp = new HocPhan();
                lich.id = Convert.ToInt32(reader["id"]);
                lich.MaHP = reader["MaHp"].ToString();
                hp.TenHP = reader["TenHP"].ToString();
                lich.HocKy = Convert.ToInt32(reader["HocKy"]);
                lich.NamHoc = Convert.ToInt32(reader["NamHoc"]);
                lich.NgayThi = DateTime.Parse(reader["NgayThi"].ToString()).ToShortDateString();
                lich.GioThi = DateTime.Parse(reader["GioThi"].ToString()).ToShortTimeString();
                lich.ThoiLuong = Convert.ToInt32(reader["ThoiLuong"]);
                lich.PhongThi = reader["PhongThi"].ToString();
                lich.DiaDiem = reader["DiaDiem"].ToString();
                lich.GhiChu = reader["GhiChu"].ToString();
                list.Add(lich);
                listHP.Add(hp);
            }
            conn.Close();
            return list;
        }

        public int Insert_Update_Delete(LichThi lich, int action)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = Ultilities.LichThi_InsertUpdatedelete;

                SqlParameter idPara = new SqlParameter("@id", SqlDbType.Int);
                idPara.Direction = ParameterDirection.InputOutput;
                cmd.Parameters.Add(idPara).Value = lich.id;

                cmd.Parameters.Add("@MaHP", SqlDbType.NVarChar, 20).Value = lich.MaHP;
                cmd.Parameters.Add("@HocKy", SqlDbType.Int).Value = lich.HocKy;
                cmd.Parameters.Add("@NamHoc", SqlDbType.Int).Value = lich.NamHoc;
                cmd.Parameters.Add("@NgayThi", SqlDbType.SmallDateTime).Value = lich.NgayThi;
                cmd.Parameters.Add("@GioThi", SqlDbType.Time).Value = lich.GioThi;
                cmd.Parameters.Add("@ThoiLuong", SqlDbType.Int).Value = lich.ThoiLuong;
                cmd.Parameters.Add("@PhongThi", SqlDbType.NVarChar, 100).Value = lich.PhongThi;
                cmd.Parameters.Add("@DiaDiem", SqlDbType.NVarChar, 1000).Value = lich.DiaDiem;
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar, 3000).Value = lich.GhiChu;
                cmd.Parameters.Add("@Action", SqlDbType.Int).Value = action;

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                    return (int)cmd.Parameters["@id"].Value;
                return 0;

            }
            catch (Exception)
            {
                throw;
            }
        }
        public SqlDataReader LoadLichThi(string namHoc, int hocKy)
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.LoadLichThi;

            cmd.Parameters.Add("@NamHoc", SqlDbType.NVarChar, 20).Value = namHoc;
            cmd.Parameters.Add("@HocKy", SqlDbType.Int).Value=hocKy;

            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
            dr.Close();
        }
    }
}
