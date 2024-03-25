using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class QL_HinhAnhDAO
    {
        public void Add(QL_HinhAnh acc, string TenQuanHe)
        {
            string sqlStr = string.Format("INSERT INTO {0} (MAKS, TENANH ,ADDRESS,MAANH) VALUES ('{1}','{2}','{3}','{4}')", TenQuanHe, acc.MAKS, acc.TENANH, acc.ADDRESS, acc.MAANH);
            //connection.ThucThi(acc, sqlStr);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    cmd.Parameters.AddWithValue("@MAKS", acc.MAKS);
                    cmd.Parameters.AddWithValue("@TENANH", acc.TENANH);
                    cmd.Parameters.AddWithValue("@ADDRESS", acc.ADDRESS);
                    cmd.Parameters.AddWithValue("@MAANH", acc.MAANH);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
