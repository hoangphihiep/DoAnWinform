using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class ViTriDao
    {
        Connection_to_SQL connection = new Connection_to_SQL();
        public void Add(ViTri acc, string TenQuanHe)
        {
            string sqlStr = string.Format("INSERT INTO {0} (MAKS, TK ,DIACHI, TENTHANHPHO,TINH) VALUES ('{1}','{2}',N'{3}',N'{4}',N'{5}')", TenQuanHe, acc.MAKS, acc.TK, acc.DIACHI, acc.TENTHANHPHO, acc.TINH);
            //connection.ThucThi(acc, sqlStr);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    cmd.Parameters.AddWithValue("@MAKS", acc.MAKS);
                    cmd.Parameters.AddWithValue("@TK", acc.TK);
                    cmd.Parameters.AddWithValue("@DIACHI", acc.DIACHI);
                    cmd.Parameters.AddWithValue("@TENTHANHPHO", acc.TENTHANHPHO);
                    cmd.Parameters.AddWithValue("@TINH", acc.TINH);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public void Update(ViTri acc, string TenQuanHe)
        {
            string SQL = string.Format("UPDATE {0} SET DIACHI = '{1}', TENTHANHPHO = '{2}', TINH = '{3}' WHERE MAKS = '{4}' AND TK = '{5}'", TenQuanHe,acc.DIACHI, acc.TENTHANHPHO, acc.TINH, acc.MAKS, acc.TK);
            //connection.ThucThi(acc, SQL);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(SQL, conn))
                {
                    cmd.Parameters.AddWithValue("@MAKS", acc.MAKS);
                    cmd.Parameters.AddWithValue("@TK", acc.TK);
                    cmd.Parameters.AddWithValue("@DIACHI", acc.DIACHI);
                    cmd.Parameters.AddWithValue("@TENTHANHPHO", acc.TENTHANHPHO);
                    cmd.Parameters.AddWithValue("@TINH", acc.TINH);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
