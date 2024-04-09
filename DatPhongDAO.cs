using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class DatPhongDAO
    {
        public int soLuongPhongTong;
        DatPhong datPhong;
        int madatphong;
        public string TenTaiKhoan;
        public int soLuongPhong;
        public void AddDatPhong( DatPhong datPhong )
        {
            /*MessageBox.Show(TenTaiKhoan);
            string query1 = string.Format("SELECT MAX(MADAT) as maxKS FROM DATPHONG");
            SqlConnection conn1 = Connection_to_SQL.getConnection();
            conn1.Open();
            SqlCommand command1 = new SqlCommand(query1, conn1);
            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                int giaColumnIndex = reader1.GetOrdinal("maxKS");
                if (!reader1.IsDBNull(giaColumnIndex))
                {
                    madatphong = reader1.GetInt32(giaColumnIndex) + 1;
                }
            }
            conn1.Close();*/
            string query2 = "SELECT SOPHONG FROM QLPHONG WHERE MAPHONG = @MAPHONG";
            SqlConnection conn3 = Connection_to_SQL.getConnection();
            conn3.Open();
            SqlCommand command2 = new SqlCommand(query2, conn3);
            command2.Parameters.AddWithValue("@MAPHONG", datPhong.Phong.MAPHONG);
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                int giaColumnIndex = reader2.GetOrdinal("SOPHONG");
                if (!reader2.IsDBNull(giaColumnIndex))
                {
                    soLuongPhongTong = reader2.GetInt32(giaColumnIndex);
                }
            }
            conn3.Close();
            string sqlStr = "UPDATE QLPHONG SET SOPHONG = @SOPHONG WHERE MAPHONG = @MAPHONG";
            using (SqlConnection conn2 = Connection_to_SQL.getConnection())
            {
                conn2.Open();
                using (SqlCommand cmd2 = new SqlCommand(sqlStr, conn2))
                {
                    cmd2.Parameters.AddWithValue("@SOPHONG", soLuongPhongTong - datPhong.SoPhong);
                    cmd2.Parameters.AddWithValue("@MAPHONG", datPhong.Phong.MAPHONG);
                    cmd2.ExecuteNonQuery();
                }
                conn2.Close();
            }
            SqlConnection conn = Connection_to_SQL.getConnection();
            try
            {
                conn.Open();
                string sqlString = "INSERT INTO DATPHONG (MAKS, CHECKIN, CHECKOUT, SOLUONG, MAPHONG, TENDANGNHAP, MAKH, THANHTOAN) VALUES (@maks, @checkIn, @checkOut, @soluong, @maphong, @tendangnhap, @maks, @thanhtoan)";
                using(SqlCommand cmd = new SqlCommand(sqlString, conn))
                {
                    //cmd.Parameters.AddWithValue("@madat", madatphong);
                    cmd.Parameters.AddWithValue("@maks", datPhong.KS.MAKS);
                    cmd.Parameters.AddWithValue("@checkIn", datPhong.NgayNhan);
                    cmd.Parameters.AddWithValue("@checkOut", datPhong.NgayTra);
                    cmd.Parameters.AddWithValue("@soluong", datPhong.SoPhong);
                    cmd.Parameters.AddWithValue("@maphong", datPhong.Phong.MAPHONG);
                    cmd.Parameters.AddWithValue("@tendangnhap", datPhong.KhachHang.TENTAIKHOAN);
                    cmd.Parameters.AddWithValue("@thanhtoan", datPhong.TongThanhToan);
                    cmd.ExecuteNonQuery();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
            
    }
}
