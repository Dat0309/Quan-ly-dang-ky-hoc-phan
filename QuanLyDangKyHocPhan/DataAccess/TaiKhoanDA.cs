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
    /// lớp quản lý tài khoản
    /// </summary>   
    public class TaiKhoanDA
    {
        /// </summary>
        /// <returns></returns>
        public List<TaiKhoan> GetAll()
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.TaiKhoan_GetAll;

            SqlDataReader reader = cmd.ExecuteReader();
            List<TaiKhoan> list = new List<TaiKhoan>();
            while (reader.Read())
            {
                TaiKhoan tk = new TaiKhoan();
                tk.Id = int.Parse(reader["Id"].ToString());
                tk.UserName = reader["UserName"].ToString();
                tk.Password = reader["Password"].ToString();
                tk.Active = bool.Parse(reader["Active"].ToString());
                tk.IDQuyen = int.Parse(reader["IDQuyen"].ToString());
                tk.CreateDate = DateTime.Parse(reader["CreateDate"].ToString()).ToShortDateString();
                tk.FullName = reader["FullName"].ToString();

                list.Add(tk);
            }
            conn.Close();
            return list;
        }

        /// <summary>
        /// Hàm thêm, xoá, sửa tài khoản
        /// </summary>
        /// <param name="tk"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public int Insert_Update_Delete(TaiKhoan tk, int action)
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.TaiKhoan_InsertUpdateDelete;

            SqlParameter IDPara = new SqlParameter("@Id", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(IDPara).Value = tk.Id;
            cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 100).Value = tk.UserName;
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 100).Value = tk.Password;
            cmd.Parameters.Add("@Active", SqlDbType.Bit).Value = tk.Active;
            cmd.Parameters.Add("@IDQuyen", SqlDbType.Int).Value = tk.IDQuyen;
            cmd.Parameters.Add("@CreateDate", SqlDbType.SmallDateTime).Value = tk.CreateDate;

            cmd.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
                return (int)cmd.Parameters["@Id"].Value;
            return 0;
            conn.Close();
        }
    }
}

