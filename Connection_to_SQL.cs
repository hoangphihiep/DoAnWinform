using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DuLich
{
    public class Connection_to_SQL
    {
        
        private static string Connection = @"Data Source=MSI;Initial Catalog=Account;Integrated Security=True";

        public static SqlConnection getConnection() 
        {
            return new SqlConnection(Connection);
        }
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        public void ThucThi(Account account, string sql)
        {
            try
            {
                // Ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
