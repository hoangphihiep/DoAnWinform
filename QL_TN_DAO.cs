using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class QL_TN_DAO
    {
        Connection_to_SQL connection = new Connection_to_SQL();
        public void Add(QL_TN acc, string TenQuanHe)
        {
            string sqlStr = string.Format("INSERT INTO {0} (MAKS, MATN) VALUES ('{1}','{2}')", TenQuanHe, acc.MAKS, acc.MATN);
            //connection.ThucThi(acc, sqlStr);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    cmd.Parameters.AddWithValue("@MAKS", acc.MAKS);
                    cmd.Parameters.AddWithValue("@MATN", acc.MATN);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
