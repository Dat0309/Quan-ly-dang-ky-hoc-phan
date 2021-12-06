using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccess
{
    /// <summary>
    /// Lớp quản lý quyền
    /// </summary>
    public class QuyenDA
    {
        /// <summary>
        /// Hàm lấy dữ liệu trong bảng quền
        /// </summary>
        /// <returns></returns>
        public List<Quyen>GetAll()
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.Quyen_GetAll;

            SqlDataReader reader = cmd.ExecuteReader();
            List<Quyen> list = new List<Quyen>();
            while (reader.Read())
            {
                Quyen q = new Quyen();
                q.Id = int.Parse(reader["id"].ToString());
                q.TenQuyen = reader["TenQuyen"].ToString();
                q.MoTa = reader["Mota"].ToString();
                list.Add(q);
            }
            conn.Close();
            return list;
        }
        /// <summary>
        /// hàm thêm, xóa, sửa thông tin quyền
        /// </summary>
        /// 0 thêm quyền
        /// 1 sửa quyền
        /// 2 xóa quyền
        /// <param name="q"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public int Insert_Update_Delete(Quyen q, int action)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = Ultilities.Quyen_InsertUpdateDelete;

                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = q.Id;
                cmd.Parameters.Add("@TenQuyen", SqlDbType.NVarChar, 50).Value = q.TenQuyen;
                cmd.Parameters.Add("@Mota", SqlDbType.NVarChar, 3000).Value = q.MoTa;

                cmd.Parameters.Add("@Action", SqlDbType.Int).Value = action;

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    return (int)cmd.Parameters["@Id"].Value;
                return 0;
                conn.Close();
            }
            catch (Exception ex) { return -1; }
        }
    }
}
