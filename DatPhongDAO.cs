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
        DatPhong datPhong;

        public void AddDatPhong( DatPhong datPhong )
        {
            SqlConnection conn = Connection_to_SQL.getConnection();
            try
            {
                conn.Open();
                string sqlString = "INSERT INTO DATPHONG (MAKS, CHECKIN, CHECKOUT, SOLUONG, MAPHONG, TENDANGNHAP, MAKH, THANHTOAN) VALUES (@maks, @checkIn, @checkOut, @soluong, @maphong, @tendangnhap, @maks, @thanhtoan)";
                using(SqlCommand cmd = new SqlCommand(sqlString, conn))
                {
                    cmd.Parameters.AddWithValue("@maks", datPhong.KS.MAKS);
                    cmd.Parameters.AddWithValue("@checkIn", datPhong.NgayNhan);
                    cmd.Parameters.AddWithValue("@checkOut", datPhong.NgayTra);
                    cmd.Parameters.AddWithValue("@soluong", 1);
                    cmd.Parameters.AddWithValue("@maphong", datPhong.Phong.MAPHONG);
                    cmd.Parameters.AddWithValue("@tendangnhap", "123");
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
