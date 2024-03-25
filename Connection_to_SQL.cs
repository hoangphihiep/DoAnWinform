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
        
<<<<<<< HEAD
        private static string Connection = @"Data Source=LAPTOP-NJM7CAI2;Initial Catalog=Account;Integrated Security=True;Encrypt=False";
=======
        private static string Connection = @"Data Source=DESKTOP-OOU6GPH;Initial Catalog=Account;Integrated Security=True";
>>>>>>> 8638f98138e96a5f3595d2f0c1ef917bb18cb436

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
