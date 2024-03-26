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
            string sqlStr = string.Format("INSERT INTO {0} (TENKS, TINH ,THANHPHO,SAO, DANHGIA,GIA,DIACHI) VALUES (@TENKS, @TINH, @THANHPHO, @SAO, @DANHGIA, @GIA, @DIACHI)", TenQuanHe);
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
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

    }
}
