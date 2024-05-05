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
        SqlConnection conn = Connection_to_SQL.getConnection();
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
        public void Delete(QL_TN acc, string TenQuanHe)
        {
            string sqlStr = string.Format("DELETE INTO {0} WHERE MAKS = @MAKS AND MATN = @MATN", TenQuanHe, acc.MAKS, acc.MATN);
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
        public List<string> GetListTienNghi(int maks, int maltn)
        {
            string sqlString = string.Format("SELECT * FROM QL_TN INNER JOIN TN ON " +
                "QL_TN.MATN = TN.MATN WHERE MAKS = {0} AND MALTN = {1}", maks, maltn);
            conn.Open();
            List<string> list=  new List<string>();
            try
            {
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    string tn = reader.GetString(reader.GetOrdinal("TENTN"));
                    list.Add(tn);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return list;
        }
    }
}
