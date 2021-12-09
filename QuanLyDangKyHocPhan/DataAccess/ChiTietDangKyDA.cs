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
            try
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
            catch (Exception)
            {
                return 0;
            }
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


        /// <summary>
        /// Hàm điều chỉnh học phần
        /// </summary>
        /// <param name="ctdk"></param>
        /// <returns></returns>
        public int DieuChinhHP(ChiTietDangKy ctdk)
        {
            int result = 0;
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.UpdateCTDKHP;

            cmd.Parameters.Add("@mssv", SqlDbType.Int).Value = ctdk.MSSV;
            cmd.Parameters.Add("@mahp", SqlDbType.NVarChar, 20).Value = ctdk.MaHP;
            cmd.Parameters.Add("@ngaydk", SqlDbType.DateTime).Value = ctdk.NgayDangKy;
            cmd.Parameters.Add("@hocky", SqlDbType.Int).Value = ctdk.HocKy;
            cmd.Parameters.Add("@namhoc", SqlDbType.NVarChar, 20).Value = ctdk.NamHoc;

            result = cmd.ExecuteNonQuery();


            if (result > 0)
                return 1;
            return 0;
            conn.Close();
        }

        /// <summary>
        /// Xoá theo mã sinh viên và mã học phần
        /// </summary>
        /// <param name="mssv"></param>
        /// <param name="mahp"></param>
        /// <returns></returns>
        public int DeleteByKey(int mssv, string mahp)
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.DeleteByKey;

            cmd.Parameters.Add("@mssv", SqlDbType.Int).Value = mssv;
            cmd.Parameters.Add("@mahp", SqlDbType.NVarChar, 20).Value = mahp;

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
                return 1;
            return 0;

            conn.Close();
        }

        /// <summary>
        /// Lấy danh sách đăng ký học phần của cá sinh viên, sắp xếp theo mã học phần
        /// Liệt kê số lượng sinh viên đăng ký của mỗi học phần
        /// </summary>
        /// <returns></returns>
        public SqlDataReader GetChiTietDKHP()
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.QLChiTietDKHP;

            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
            dr.Close();
        }

        /// <summary>
        /// Lấy danh sách học phần đăng ký theo năm học và học kỳ tương ứng
        /// </summary>
        /// <param name="hocky"></param>
        /// <param name="nam"></param>
        /// <returns></returns>
        public SqlDataReader GetChiTietDKHPTheeoHocKy(int hocky, string nam)
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.GetChiTietTheoHocKyVaNam;

            cmd.Parameters.Add("@hocky", SqlDbType.Int).Value = hocky;
            cmd.Parameters.Add("@nam", SqlDbType.VarChar, 20).Value = nam;

            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
            dr.Close();
        }
        public SqlDataReader GetHocPhanTheoHocKyVaNam(int hocKy, string nam)
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.GetHocPhanTheoHocKyVaNam;

            cmd.Parameters.Add("@NamHoc", SqlDbType.VarChar, 20).Value = nam;
            cmd.Parameters.Add("@HocKy", SqlDbType.Int).Value = hocKy;

            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
            dr.Close();
        }
        public SqlDataReader QLChiTietHP()
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.QLChiTietHP;

            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
            dr.Close();

        }
        public List<SinhVien> CheckSVDangKyHocPhan(string MaHP)
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.CheckSVDangKyHocPhan;
            cmd.Parameters.Add("@MaHP",SqlDbType.NVarChar,20).Value=MaHP;

            List<SinhVien> listSV = new List<SinhVien>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SinhVien sv = new SinhVien();
                sv.MSSV = int.Parse(dr["MSSV"].ToString());
                sv.HoLot = dr["HoLot"].ToString();
                sv.Ten = dr["Ten"].ToString();
                sv.TenLop = dr["TenLop"].ToString();
                sv.Khoa = dr["Khoa"].ToString();
                sv.GioiTinh = bool.Parse(dr["GioiTinh"].ToString());
                sv.NgaySinh = dr["NgaySinh"].ToString();
                sv.DiaChi = dr["DiaChi"].ToString();
                listSV.Add(sv);
            }
            conn.Close();
            dr.Close();
            return listSV;
        }

    }
}
