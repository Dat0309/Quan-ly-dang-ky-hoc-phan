using System;
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
                hp.TCLT = int.Parse(reader["TCLT"].ToString());
                hp.TCTH = int.Parse(reader["TCTH"].ToString());
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
            cmd.Parameters.Add("@TCLT", SqlDbType.Int).Value = hp.TCLT;
            cmd.Parameters.Add("@TCTH", SqlDbType.Int).Value = hp.TCTH;
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
                hp.TCLT = int.Parse(reader["TCLT"].ToString());
                hp.TCTH = int.Parse(reader["TCTH"].ToString());
                hp.GioiHan = int.Parse(reader["GioiHan"].ToString());

                list.Add(hp);
            }
            conn.Close();
            return list;
        }

        /// <summary>
        /// Lấy danh sách học phần theo kế hoạch
        /// Học phần theo kế hoạch giảng dạy do khoa đề ra, 
        /// được chỉ định được mở dạy vào học kỳ nào
        /// </summary>
        /// <param name="mssv"></param>
        /// <param name="nam"></param>
        /// <param name="hocky"></param>
        /// <returns></returns>
        public List<HocPhan> GetHPTheoKH(int mssv, int nam, int hocky, string khoa)
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.GetHPTheoKeHoach;

            cmd.Parameters.Add("@mssv", SqlDbType.Int).Value = mssv;
            cmd.Parameters.Add("@nam", SqlDbType.Int).Value = nam;
            cmd.Parameters.Add("@hocky", SqlDbType.Int).Value = hocky;
            cmd.Parameters.Add("@khoa", SqlDbType.NVarChar, 100).Value = khoa;

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
                hp.TCLT = int.Parse(reader["TCLT"].ToString());
                hp.TCTH = int.Parse(reader["TCTH"].ToString());
                hp.GioiHan = int.Parse(reader["GioiHan"].ToString());

                list.Add(hp);
            }
            conn.Close();
            return list;
        }

        /// <summary>
        /// Lấy danh sách học phần ngoài kế hoạch đăng ký của trường đề ra
        /// Dành cho sinh viên có nhu cầu đăng ký học lại, học cải thiện.
        /// </summary>
        /// <param name="mssv"></param>
        /// <param name="khoa"></param>
        /// <returns></returns>
        public List<HocPhan> GetHPNgoaiKH(int mssv,int hocky,string khoa)
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.GetHPNgoaiKeHoach;

            cmd.Parameters.Add("@mssv", SqlDbType.Int).Value = mssv;
            cmd.Parameters.Add("@hocky", SqlDbType.Int).Value = hocky;
            cmd.Parameters.Add("@khoa", SqlDbType.NVarChar, 100).Value = khoa;

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
                hp.TCLT = int.Parse(reader["TCLT"].ToString());
                hp.TCTH = int.Parse(reader["TCTH"].ToString());
                hp.GioiHan = int.Parse(reader["GioiHan"].ToString());

                list.Add(hp);
            }
            conn.Close();
            return list;
        }

        /// <summary>
        /// Xuất kết quả đăng ký học phần của sinh viên
        /// </summary>
        /// <param name="mssv"></param>
        /// <returns></returns>
        public List<HocPhan> GetKQDK(int mssv)
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.GetKQDK;

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
                hp.TCLT = int.Parse(reader["TCLT"].ToString());
                hp.TCTH = int.Parse(reader["TCTH"].ToString());
                hp.GioiHan = int.Parse(reader["GioiHan"].ToString());

                list.Add(hp);
            }
            conn.Close();
            return list;
        }

        /// <summary>
        /// Hàm lấy danh sách đăng ký học phần của sinh viên trong học kỳ hiện tại
        /// </summary>
        /// <param name="mssv"></param>
        /// <param name="hocky"></param>
        /// <param name="namhoc"></param>
        /// <returns></returns>
        public List<HocPhan> GetCurrentKQDK(int mssv, int hocky, string namhoc)
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.GetKQDK_HienTai;

            cmd.Parameters.Add("@mssv", SqlDbType.Int).Value = mssv;
            cmd.Parameters.Add("@hocky", SqlDbType.Int).Value = hocky;
            cmd.Parameters.Add("@namhoc", SqlDbType.VarChar, 20).Value = namhoc;

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
                hp.TCLT = int.Parse(reader["TCLT"].ToString());
                hp.TCTH = int.Parse(reader["TCTH"].ToString());
                hp.GioiHan = int.Parse(reader["GioiHan"].ToString());

                list.Add(hp);
            }
            conn.Close();
            return list;
        }
        public List<HocPhan> GetCurrentKQDKHP(int hocky, string namhoc)
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.GetHocPhanTheoHocKyVaNam;

            cmd.Parameters.Add("@HocKy", SqlDbType.Int).Value = hocky;
            cmd.Parameters.Add("@NamHoc", SqlDbType.VarChar, 20).Value = namhoc;

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
                hp.TCLT = int.Parse(reader["TCLT"].ToString());
                hp.TCTH = int.Parse(reader["TCTH"].ToString());
                hp.GioiHan = int.Parse(reader["GioiHan"].ToString());
                list.Add(hp);
            }
            conn.Close();
            return list;
        }
    }
}
