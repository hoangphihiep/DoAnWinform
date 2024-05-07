using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class KHACHSAN_DAO
    {

        public KHACHSAN Get(int maks)
        {
            string sqlString = string.Format("SELECT * FROM ThongTinCanBan INNER JOIN ViTri ON ThongTinCanBan.MAKS= ViTri.MAKS WHERE ViTri.MAKS = {0}", maks);
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(sqlString, conn);
            command.CommandTimeout = 120;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string tenks = reader.GetString(reader.GetOrdinal("TENKH"));
                string tinh = reader.GetString(reader.GetOrdinal("TINH"));
                string tp = reader.GetString(reader.GetOrdinal("TENTHANHPHO"));
                int sao = reader.GetInt32(reader.GetOrdinal("SAO"));
                double gia = reader.GetDouble(reader.GetOrdinal("GIA"));
                string diachi = reader.GetString(reader.GetOrdinal("DIACHI"));
                KHACHSAN ks = new KHACHSAN(maks, tenks, tinh, tp, sao, gia, diachi);
                return ks;
            }
            return null;
        }
       
    }
}
