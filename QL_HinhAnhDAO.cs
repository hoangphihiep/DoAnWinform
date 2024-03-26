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
            string sqlStr = string.Format("INSERT INTO {0} (MAKS, TENANH, ADDRESS) VALUES (@MAKS, @TENANH, @ADDRESS)", TenQuanHe);
            //connection.ThucThi(acc, sqlStr);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    cmd.Parameters.AddWithValue("@MAKS", acc.MAKS);
                    cmd.Parameters.AddWithValue("@TENANH", acc.TENANH);

                    // Handle null value for ADDRESS
                    SqlParameter addressParam = new SqlParameter("@ADDRESS", acc.ADDRESS ?? (object)DBNull.Value);
                    cmd.Parameters.Add(addressParam);

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
