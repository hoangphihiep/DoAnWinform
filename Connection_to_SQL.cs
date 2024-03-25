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
        
        private static string Connection = @"Data Source=LAPTOP-NJM7CAI2;Initial Catalog = Account; Integrated Security = True; Encrypt=False";

        public static SqlConnection getConnection() 
        {
            return new SqlConnection(Connection);
        }
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        public void ThucThi<T>(T account, string sql)
        {
            try
            {
                // Ket noi
                //conn.Open();
                //SqlCommand cmd = new SqlCommand(sql, conn);
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
        public static string getConnnection()
        {
            return Connection;
        }
    }
}
