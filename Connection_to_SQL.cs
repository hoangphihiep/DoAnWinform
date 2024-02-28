using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DuLich
{
    public class Connection_to_SQL
    {
        private static string Connection = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QLHocSinh;Integrated Security=True";

        public static SqlConnection getConnection() 
        {
            return new SqlConnection(Connection);
        }

    }
}
