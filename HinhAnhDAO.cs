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
            string sqlStr = string.Format("INSERT INTO {0} (TenDangNhap,PHONG ,Anh1,Anh2, Anh3,Anh4,Anh5,Anh6,MaKS) VALUES (N'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", TenQuanHe,acc.TaiKhoan ,acc.Phong, acc.Anh1, acc.Anh2,acc.Anh3,acc.Anh4,acc.Anh5,acc.Anh6,acc.MaKS);
            //connection.ThucThi(acc, sqlStr);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", acc.TaiKhoan);
                    cmd.Parameters.AddWithValue("@Phong", acc.Phong);
                    cmd.Parameters.AddWithValue("@Anh1", acc.Anh1);
                    cmd.Parameters.AddWithValue("@Anh2", acc.Anh2);
                    cmd.Parameters.AddWithValue("@Anh3", acc.Anh3);
                    cmd.Parameters.AddWithValue("@Anh4", acc.Anh4);
                    cmd.Parameters.AddWithValue("@Anh5", acc.Anh5);
                    cmd.Parameters.AddWithValue("@Anh6", acc.Anh6);
                    cmd.Parameters.AddWithValue("@MaKS", acc.MaKS);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public void Update(HinhAnh acc, string TenQuanHe)
        {
            string SQL = string.Format("UPDATE {0} SET Anh1 = '{1}', Anh2 = '{2}', Anh3 = '{3}', Anh4 = '{4}', Anh5 = '{5}', Anh6 = '{6}' WHERE PHONG = '{7}' AND TenDangNhap = '{8}' AND MaKS = '{9}'", TenQuanHe, acc.Anh1, acc.Anh2, acc.Anh3, acc.Anh4, acc.Anh5, acc.Anh6, acc.Phong,acc.TaiKhoan,acc.MaKS);
            //connection.ThucThi(acc, SQL);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(SQL, conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", acc.TaiKhoan);
                    cmd.Parameters.AddWithValue("@Phong", acc.Phong);
                    cmd.Parameters.AddWithValue("@Anh1", acc.Anh1);
                    cmd.Parameters.AddWithValue("@Anh2", acc.Anh2);
                    cmd.Parameters.AddWithValue("@Anh3", acc.Anh3);
                    cmd.Parameters.AddWithValue("@Anh4", acc.Anh4);
                    cmd.Parameters.AddWithValue("@Anh5", acc.Anh5);
                    cmd.Parameters.AddWithValue("@Anh6", acc.Anh6);
                    cmd.Parameters.AddWithValue("@MaKS", acc.MaKS);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
