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
            string sqlString = string.Format("SELECT * FROM ThongTinCanBan INNER JOIN ViTri ON ThongTinCanBan.MAKS= ViTri.MAKS WHERE MAKS = {0}", maks);
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(sqlString, conn);
            command.CommandTimeout = 120;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string tenks = reader.GetString(reader.GetOrdinal("TENKS"));
                string tinh = reader.GetString(reader.GetOrdinal("TINH"));
                string tp = reader.GetString(reader.GetOrdinal("THANHPHO"));
                int sao = reader.GetInt32(reader.GetOrdinal("SAO"));
                double gia = reader.Getdouble(reader.GetOrdinal("GIA"));
                string diachi = reader.GetString(reader.GetOrdinal("DIACHI"));
                KHACHSAN ks = new KHACHSAN(maks, tenks, tinh, tp, sao, gia, diachi);
                return ks;
            }
            return null;
        }
        /*Connection_to_SQL connection = new Connection_to_SQL();
        public void Add(KHACHSAN acc, string TenQuanHe)
        {
            string sqlStr = string.Format("INSERT INTO {0} (TENKS, TINH ,THANHPHO,SAO, DANHGIA,GIA,DIACHI) VALUES (@TENKS, @TINH, @THANHPHO, @SAO, @DANHGIA, @GIA, @DIACHI)", TenQuanHe);
            //connection.ThucThi(acc, sqlStr);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    cmd.Parameters.AddWithValue("@TENKS", acc.TENKS);
                    cmd.Parameters.AddWithValue("@TINH", acc.TINH);
                    cmd.Parameters.AddWithValue("@THANHPHO", acc.THANHPHO);
                    cmd.Parameters.AddWithValue("@SAO", acc.SAO);
                    cmd.Parameters.AddWithValue("@DANHGIA", acc.DANHGIA);
                    cmd.Parameters.AddWithValue("@GIA", acc.GIA);
                    cmd.Parameters.AddWithValue("@DIACHI", acc.DIACHI);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public void UpdateFromThongTinCanBan(KHACHSAN acc, string TenQuanHe)
        {
            string SQL = string.Format("UPDATE {0} SET TENKS = '{1}', SAO = '{2}', DANHGIA = '{3}',GIA = '{4}'  WHERE MAKS = '{5}'", TenQuanHe, acc.TENKS, acc.SAO, acc.DANHGIA,acc.GIA, acc.MAKS );
            //connection.ThucThi(acc, SQL);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(SQL, conn))
                {
                    cmd.Parameters.AddWithValue("@TENKS", acc.TENKS);
                    cmd.Parameters.AddWithValue("@SAO", acc.SAO);
                    cmd.Parameters.AddWithValue("@DANHGIA", acc.DANHGIA);
                    cmd.Parameters.AddWithValue("@GIA", acc.GIA);
                    cmd.Parameters.AddWithValue("@MAKS", acc.MAKS);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public void UpdateFromViTri(KHACHSAN acc, string TenQuanHe)
        {
            string SQL = string.Format("UPDATE {0} SET TINH = '{1}', THANHPHO = '{2}', DIACHI = '{3}'  WHERE MAKS = '{4}'", TenQuanHe, acc.TINH, acc.THANHPHO, acc.DIACHI, acc.MAKS);
            //connection.ThucThi(acc, SQL);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(SQL, conn))
                {
                    cmd.Parameters.AddWithValue("@TINH", acc.TENKS);
                    cmd.Parameters.AddWithValue("@THANHPHO", acc.SAO);
                    cmd.Parameters.AddWithValue("@DIACHI", acc.DANHGIA);
                    cmd.Parameters.AddWithValue("@MAKS", acc.MAKS);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }*/
    }
}
