using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DuLich
{
    public class QLPHONG_DAO
    {
        Connection_to_SQL connection = new Connection_to_SQL();
        public void Add(QLPHONG acc, string TenQuanHe)
        {
            string sqlStr = string.Format("INSERT INTO {0} (MAKS, SOPHONG ,SOPHONG_DD) VALUES (@MAKS, @SOPHONG, @SOPHONG_DD)", TenQuanHe);
            //connection.ThucThi(acc, sqlStr);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    cmd.Parameters.AddWithValue("@MAKS", acc.MAKS);
                    cmd.Parameters.AddWithValue("@SOPHONG", acc.SOPHONG);
                    cmd.Parameters.AddWithValue("@SOPHONG_DD", acc.SOPHONG_DD);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();

            }
        }
    }
}
