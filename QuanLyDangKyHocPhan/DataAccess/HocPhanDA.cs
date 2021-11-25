﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class HocPhanDA
    {
        public List<HocPhan> GetAll()
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.HocPhan_GetAll;

            SqlDataReader reader = cmd.ExecuteReader();
            List<HocPhan> list = new List<HocPhan>();
            while (reader.Read())
            {
                HocPhan hp = new HocPhan();
                hp.MaHP = reader["MaHP"].ToString();
                hp.TenHP = reader["TenHP"].ToString();
                hp.LoaiHP = reader["LoaiHP"].ToString();
                hp.HocKy = int.Parse(reader["HocKy"].ToString());
                hp.Nam = int.Parse(reader["Nam"].ToString());
                hp.Khoa = reader["Khoa"].ToString();
                hp.TongSoTC = int.Parse(reader["STC"].ToString());
                hp.GioiHan = int.Parse(reader["GioiHan"].ToString());

                list.Add(hp);
            }
            conn.Close();
            return list;
        }

        public int Insert_Update_Delete(HocPhan hp, int action)
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.HocPhan_InsertUpdateDelete;

            cmd.Parameters.Add("@MaHP", SqlDbType.NVarChar,20).Value = hp.MaHP;
            cmd.Parameters.Add("@TenHP", SqlDbType.NVarChar, 100).Value = hp.TenHP;
            cmd.Parameters.Add("@LoaiHP", SqlDbType.NVarChar, 20).Value = hp.LoaiHP;
            cmd.Parameters.Add("@HocKy", SqlDbType.Int).Value = hp.HocKy;
            cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = hp.Nam;
            cmd.Parameters.Add("@Khoa", SqlDbType.NVarChar,100).Value = hp.Khoa;
            cmd.Parameters.Add("@STC", SqlDbType.Int).Value = hp.TongSoTC;
            cmd.Parameters.Add("@GioiHan", SqlDbType.Int).Value = hp.GioiHan;

            cmd.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
                return 1; 
            return 0;
            conn.Close();
        }

        /// <summary>
        /// Lấy danh sách học phần chưa tích luỹ của sinh viên
        /// </summary>
        /// <param name="mssv"></param>
        /// <returns></returns>
        public List<HocPhan> GetHPChuaTichLuy(int mssv)
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.GetHPChuaTichLuy;

            cmd.Parameters.Add("@mssv", SqlDbType.Int).Value = mssv;

            SqlDataReader reader = cmd.ExecuteReader();
            List<HocPhan> list = new List<HocPhan>();
            while (reader.Read())
            {
                HocPhan hp = new HocPhan();
                hp.MaHP = reader["MaHP"].ToString();
                hp.TenHP = reader["TenHP"].ToString();
                hp.LoaiHP = reader["LoaiHP"].ToString();
                hp.HocKy = int.Parse(reader["HocKy"].ToString());
                hp.Nam = int.Parse(reader["Nam"].ToString());
                hp.Khoa = reader["Khoa"].ToString();
                hp.TongSoTC = int.Parse(reader["STC"].ToString());
                hp.GioiHan = int.Parse(reader["GioiHan"].ToString());

                list.Add(hp);
            }
            conn.Close();
            return list;
        }

        /// <summary>
        /// Lấy danh sách học phần theo kế hoạch
        /// </summary>
        /// <param name="mssv"></param>
        /// <param name="nam"></param>
        /// <param name="hocky"></param>
        /// <returns></returns>
        public List<HocPhan> GetHPTheoKH(int mssv, int nam, int hocky)
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.GetHPTheoKeHoach;

            cmd.Parameters.Add("@mssv", SqlDbType.Int).Value = mssv;
            cmd.Parameters.Add("@nam", SqlDbType.Int).Value = nam;
            cmd.Parameters.Add("@hocky", SqlDbType.Int).Value = hocky;

            SqlDataReader reader = cmd.ExecuteReader();
            List<HocPhan> list = new List<HocPhan>();
            while (reader.Read())
            {
                HocPhan hp = new HocPhan();
                hp.MaHP = reader["MaHP"].ToString();
                hp.TenHP = reader["TenHP"].ToString();
                hp.LoaiHP = reader["LoaiHP"].ToString();
                hp.HocKy = int.Parse(reader["HocKy"].ToString());
                hp.Nam = int.Parse(reader["Nam"].ToString());
                hp.Khoa = reader["Khoa"].ToString();
                hp.TongSoTC = int.Parse(reader["STC"].ToString());
                hp.GioiHan = int.Parse(reader["GioiHan"].ToString());

                list.Add(hp);
            }
            conn.Close();
            return list;
        }
    }
}