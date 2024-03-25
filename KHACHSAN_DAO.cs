using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class KHACHSAN_DAO
    {
        Connection_to_SQL connection = new Connection_to_SQL();
        public void Add(KHACHSAN acc, string TenQuanHe)
        {
            string sqlStr = string.Format("INSERT INTO {0} (TENKS, TINH ,THANHPHO,SAO, DANHGIA,GIA,DIACHI,MAKS) VALUES ('{1}','{2}',N'{3}','{4}','{5}',N'{6}',N'{7}',N'{8}')", TenQuanHe, acc.TENKS, acc.TINH, acc.THANHPHO, acc.SAO, acc.DANHGIA,acc.GIA, acc.DIACHI, acc.MAKS);
            //connection.ThucThi(acc, sqlStr);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    cmd.Parameters.AddWithValue("@TENKS", acc.TENKS);
                    cmd.Parameters.AddWithValue("@TINH", acc.TINH);
                    cmd.Parameters.AddWithValue("@THANHPHO", acc.THANHPHO);
                    cmd.Parameters.AddWithValue("@SAO", acc.SAO);
                    cmd.Parameters.AddWithValue("@DANHGIA", acc.DANHGIA);
                    cmd.Parameters.AddWithValue("@GIA", acc.GIA);
                    cmd.Parameters.AddWithValue("@DIACHI", acc.DIACHI);
                    cmd.Parameters.AddWithValue("@MAKS", acc.MAKS);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
