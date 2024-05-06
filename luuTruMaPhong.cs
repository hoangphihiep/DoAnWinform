using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class luuTruMaPhong
    {
        public void luuMaPhong (string tentk, List<int> maPhongList)
        {
            using (SqlConnection connection = new SqlConnection(Connection_to_SQL.getConnnection()))
            {
                connection.Open();
                string query1 = "SELECT DISTINCT QLPHONG.MAPHONG " +
                               "FROM QLPHONG " +
                               "JOIN ThongTinCanBan ON QLPHONG.MAKS = ThongTinCanBan.MAKS " +
                               "WHERE ThongTinCanBan.TK = @TaiKhoan";
                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    command.Parameters.AddWithValue("@TaiKhoan", tentk);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int maPhong = reader.GetInt32(0);
                            maPhongList.Add(maPhong);
                        }
                    }
                }
            }
        }
    }
}
