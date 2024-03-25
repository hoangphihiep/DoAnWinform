using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class HinhAnhDAO
    {
        Connection_to_SQL connection = new Connection_to_SQL();
        public void Add(HinhAnh acc, string TenQuanHe)
        {
            string sqlStr = string.Format("INSERT INTO {0} (TenDangNhap,PHONG, AnhBia ,Anh1,Anh2, Anh3,Anh4,Anh5,Anh6) VALUES ('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", TenQuanHe,acc.TaiKhoan ,acc.Phong, acc.AnhBia, acc.Anh1, acc.Anh2,acc.Anh3,acc.Anh4,acc.Anh5,acc.Anh6);
            //connection.ThucThi(acc, sqlStr);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", acc.TaiKhoan);
                    cmd.Parameters.AddWithValue("@Phong", acc.Phong);
                    cmd.Parameters.AddWithValue("@AnhBia", acc.AnhBia);
                    cmd.Parameters.AddWithValue("@Anh1", acc.Anh1);
                    cmd.Parameters.AddWithValue("@Anh2", acc.Anh2);
                    cmd.Parameters.AddWithValue("@Anh3", acc.Anh3);
                    cmd.Parameters.AddWithValue("@Anh4", acc.Anh4);
                    cmd.Parameters.AddWithValue("@Anh5", acc.Anh5);
                    cmd.Parameters.AddWithValue("@Anh6", acc.Anh6);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public void Update(HinhAnh acc, string TenQuanHe)
        {
            string SQL = string.Format("UPDATE {0} SET AnhBia = '{1}', Anh1 = '{2}', Anh2 = '{3}', Anh3 = '{4}', Anh4 = '{5}', Anh5 = '{6}', Anh6 = '{7}' WHERE PHONG = '{8}' AND TenDangNhap = '{9}'", TenQuanHe, acc.AnhBia, acc.Anh1, acc.Anh2, acc.Anh3, acc.Anh4, acc.Anh5, acc.Anh6, acc.Phong,acc.TaiKhoan);
            //connection.ThucThi(acc, SQL);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(SQL, conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", acc.TaiKhoan);
                    cmd.Parameters.AddWithValue("@Phong", acc.Phong);
                    cmd.Parameters.AddWithValue("@AnhBia", acc.AnhBia);
                    cmd.Parameters.AddWithValue("@Anh1", acc.Anh1);
                    cmd.Parameters.AddWithValue("@Anh2", acc.Anh2);
                    cmd.Parameters.AddWithValue("@Anh3", acc.Anh3);
                    cmd.Parameters.AddWithValue("@Anh4", acc.Anh4);
                    cmd.Parameters.AddWithValue("@Anh5", acc.Anh5);
                    cmd.Parameters.AddWithValue("@Anh6", acc.Anh6);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
