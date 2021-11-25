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
    /// Lớp quản lý Sinh viên
    /// </summary>
    public class SinhVienDA
    {
        /// <summary>
        /// Hàm lấy tất cả dữ liệu trong bảng sinh viên
        /// </summary>
        /// <returns></returns>
        public List<SinhVien> GetAll()
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.SinhVien_GetAll;

            SqlDataReader reader = cmd.ExecuteReader();
            List<SinhVien> list = new List<SinhVien>();
            while (reader.Read())
            {
                SinhVien sv = new SinhVien();
                sv.MSSV = int.Parse(reader["MSSV"].ToString());
                sv.HoLot = reader["HoLot"].ToString();
                sv.Ten = reader["Ten"].ToString();
                sv.GioiTinh = bool.Parse(reader["GioiTinh"].ToString());
                sv.NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString()).ToShortDateString();
                sv.TenLop = reader["TenLop"].ToString();
                sv.Khoa = reader["Khoa"].ToString();
                sv.DiaChi = reader["DiaChi"].ToString();

                list.Add(sv);
            }

            conn.Close();
            return list;
        }

        /// <summary>
        /// Hàm thêm, xoá, sửa thông tin sinh viên
        /// </summary>
        /// <param name="sv">Sinh viên</param>
        /// <param name="action"> Hành động: 
        /// 0: Thêm sinh viên
        /// 1: Sửa sinh viên
        /// 2: Xoá sinh viên
        /// </param>
        /// <returns></returns>
        public int Insert_Update_Delete(SinhVien sv, int action)
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.SinhVien_InsertUpdateDelete;

            cmd.Parameters.Add("@MSSV", SqlDbType.Int).Value = sv.MSSV;
            cmd.Parameters.Add("@HoLot", SqlDbType.NVarChar, 100).Value = sv.HoLot;
            cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 50).Value = sv.Ten;
            cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = sv.GioiTinh;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime).Value = sv.NgaySinh;
            cmd.Parameters.Add("@TenLop", SqlDbType.NVarChar, 20).Value = sv.TenLop;
            cmd.Parameters.Add("@Khoa", SqlDbType.NVarChar, 100).Value = sv.Khoa;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 1000).Value = sv.DiaChi;


            cmd.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
                return (int)cmd.Parameters["@MSSV"].Value;
            return 0;
            conn.Close();
        }
    }
}
