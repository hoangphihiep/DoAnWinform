using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class HoSoDAO
    {
        Connection_to_SQL connection = new Connection_to_SQL();
        public void Add(HoSo acc, string TenQuanHe)
        {
            string sqlStr = string.Format("INSERT INTO {0} (MAKS, TK ,TENCHUKS,SODIENTHOAI, EMAIL,DIACHI,TENTHANHPHO,TINH,THEDIENTU,NGANHANG) VALUES ('{1}','{2}',N'{3}','{4}','{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}')", TenQuanHe, acc.MAKS, acc.TK, acc.TENCHUKS, acc.SODIENTHOAI, acc.EMAIL, acc.DIACHI, acc.TENTHANHPHO, acc.TINH,acc.THEDIENTU, acc.NGANHANG);
            //connection.ThucThi(acc, sqlStr);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    cmd.Parameters.AddWithValue("@MAKS", acc.MAKS);
                    cmd.Parameters.AddWithValue("@TK", acc.TK);
                    cmd.Parameters.AddWithValue("@TENCHUKS", acc.TENCHUKS);
                    cmd.Parameters.AddWithValue("@SODIENTHOAI", acc.SODIENTHOAI);
                    cmd.Parameters.AddWithValue("@EMAIL", acc.EMAIL);
                    cmd.Parameters.AddWithValue("@DIACHI", acc.DIACHI);
                    cmd.Parameters.AddWithValue("@TENTHANHPHO", acc.TENTHANHPHO);
                    cmd.Parameters.AddWithValue("@TINH", acc.TINH);
                    cmd.Parameters.AddWithValue("@THEDIENTU", acc.THEDIENTU);
                    cmd.Parameters.AddWithValue("@NGANHANG", acc.NGANHANG);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public void Update(HoSo acc, string TenQuanHe)
        {
            string SQL = string.Format("UPDATE {0} SET TENCHUKS = '{1}', SODIENTHOAI = '{2}', EMAIL = '{3}', DIACHI = '{4}', TENTHANHPHO = '{5}', TINH = '{6}', THEDIENTU = '{7}', NGANHANG = '{8}' WHERE MAKS = '{9}' AND TK = '{10}'", TenQuanHe, acc.TENCHUKS, acc.SODIENTHOAI, acc.EMAIL, acc.DIACHI, acc.TENTHANHPHO, acc.TINH, acc.THEDIENTU, acc.NGANHANG, acc.MAKS, acc.TK);
            //connection.ThucThi(acc, SQL);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(SQL, conn))
                {
                    cmd.Parameters.AddWithValue("@MAKS", acc.MAKS);
                    cmd.Parameters.AddWithValue("@TK", acc.TK);
                    cmd.Parameters.AddWithValue("@TENCHUKS", acc.TENCHUKS);
                    cmd.Parameters.AddWithValue("@SODIENTHOAI", acc.SODIENTHOAI);
                    cmd.Parameters.AddWithValue("@EMAIL", acc.EMAIL);
                    cmd.Parameters.AddWithValue("@DIACHI", acc.DIACHI);
                    cmd.Parameters.AddWithValue("@TENTHANHPHO", acc.TENTHANHPHO);
                    cmd.Parameters.AddWithValue("@TINH", acc.TINH);
                    cmd.Parameters.AddWithValue("@THEDIENTU", acc.THEDIENTU);
                    cmd.Parameters.AddWithValue("@NGANHANG", acc.NGANHANG);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
