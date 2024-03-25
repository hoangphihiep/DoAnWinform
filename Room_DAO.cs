using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class Room_DAO
    {
        Connection_to_SQL connection = new Connection_to_SQL();
        public void Add(Room acc, string TenQuanHe)
        {
            string sqlStr = string.Format("INSERT INTO {0} (SOKHACH, SOGIUONG ,GIA,TENPHONG, MAPHONG) VALUES ('{1}','{2}','{3}','{4}','{5}')", TenQuanHe, acc.SOKHACH, acc.SOGIUONG, acc.GIA, acc.TENPHONG, acc.MAPHONG);
            //connection.ThucThi(acc, sqlStr);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    cmd.Parameters.AddWithValue("@SOKHACH", acc.SOKHACH);
                    cmd.Parameters.AddWithValue("@SOGIUONG", acc.SOGIUONG);
                    cmd.Parameters.AddWithValue("@GIA", acc.GIA);
                    cmd.Parameters.AddWithValue("@TENPHONG", acc.TENPHONG);
                    cmd.Parameters.AddWithValue("@MAPHONG", acc.MAPHONG);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
