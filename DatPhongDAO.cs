using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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

        public List<DatPhong> Get(int maks)
        {
            string sqlString = string.Format("SELECT * FROM DATPHONG WHERE MAKS= '{0}'", maks);
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(sqlString, conn);
            command.CommandTimeout = 120;
            SqlDataReader reader = command.ExecuteReader();
            List<DatPhong> list = new List<DatPhong>();
            while(reader.Read())
            {
                int maDat = reader.GetInt32(reader.GetOrdinal("MADAT"));
                KHACHSAN ks = (new KHACHSAN_DAO().Get(maks));
                DateTime checkin = reader.GetDateTime(reader.GetOrdinal("CHECKIN"));
                DateTime checkout = reader.GetDateTime(reader.GetOrdinal("CHECKOUT"));
                int soluong = reader.GetInt32(reader.GetOrdinal("SOLUONG"));
                int maphong = reader.GetInt32(reader.GetOrdinal("MAPHONG"));
                Room phong = new Room_DAO().Get(maphong);
                string tendangnhap = reader.GetString(reader.GetOrdinal("TENDANGNHAP"));
                int makh = reader.GetInt32(reader.GetOrdinal("MAKH"));
                KhachHang kh = new KhachHangDAO().Get(makh);
                double gia = reader.Getdouble(reader.GetOrdinal("THANHTOAN"));
                string trangthai = reader.GetString(reader.GetOrdinal("TRANGTHAI"));
                string mahanhtrinh = reader.GetString(reader.GetOrdinal("MAHANHTRINH"));
                DatPhong dp = new DatPhong(maDat, kh, ks, phong, checkin, checkout, soluong, gia, trangthai, mahanhtrinh);
                list.Add(dp);
            }
            return list;
        }
            
    }
}
