using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class Room_DAO
    {
        Connection_to_SQL connection = new Connection_to_SQL();
        public void Add(Room acc, string TenQuanHe)
        {
            string sqlStr = string.Format("INSERT INTO {0} (SOKHACH, SOGIUONG, GIA, TENPHONG, MAPHONG,ANH) VALUES (@SOKHACH, @SOGIUONG, @GIA, @TENPHONG,@MAPHONG,@ANH)", TenQuanHe);
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
                    string relativePath = ExtractRelativePath(acc.HinhAnh);
                    cmd.Parameters.AddWithValue("@ANH", relativePath);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public void Update(Room acc, string TenQuanHe)
        {
            string sqlStr = string.Format("UPDATE {0} SET SOKHACH = @SOKHACH, SOGIUONG = @SOGIUONG, GIA = @GIA, TENPHONG = @TENPHONG, ANH = @ANH WHERE MAPHONG = @MAPHONG", TenQuanHe);

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
                    string relativePath = ExtractRelativePath(acc.HinhAnh);
                    cmd.Parameters.AddWithValue("@ANH", relativePath);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        static string ExtractRelativePath(string fullPath)
        {
            if (fullPath.Contains("hinhanh"))
            {
                int index = fullPath.IndexOf(@"hinhanh\");
                return fullPath.Substring(index);
            }
            else if (fullPath.Contains("Image"))
            {
                int index = fullPath.IndexOf(@"Image\");
                return fullPath.Substring(index);
            }
            return "Không chứa chuỗi 'hinhanh' hoặc 'Image'.";

        }

        public Room Get(int maphong)
        {
            string sqlString = string.Format("SELECT * FROM PHONG WHERE MAPHONG = {0}", maphong);
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(sqlString, conn);
            command.CommandTimeout = 120;
            SqlDataReader reader = command.ExecuteReader();
            int sokhach = reader.GetInt32(reader.GetOrdinal("SOKHACH"));
            int sogiuong = reader.GetInt32(reader.GetOrdinal("SOGIUONG"));
            double gia = reader.Getdouble(reader.GetOrdinal("GIA"));
            string tenphong = reader.GetString(reader.GetOrdinal("TENPHONG"));
            string anh = reader.GetString(reader.GetOrdinal("ANH"));
            string maks = reader.GetString(reader.GetOrdinal("MAKS"));
            Room phong = new Room(sokhach, sogiuong, gia, tenphong, maphong, anh);
            return phong;
        }
        

    }
}
