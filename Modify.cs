using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class Modify
    {
        public Modify() { }
        SqlCommand cmd;
        SqlDataReader data;
        public List<Account> accounts(string table)
        {
            List<Account> accounts = new List<Account>();
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                cmd = new SqlCommand(table, conn);
                data = cmd.ExecuteReader();
                while(data.Read())
                {
                    accounts.Add(new Account(data.GetString(0), data.GetString(1), data.GetString(2), data.GetString(3), data.GetDateTime(4), data.GetString(5), data.GetString(6), data.GetString(7)));
                }
                conn.Close();
            }
            return accounts;
        }
    }
}
