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
        public string TenTaiKhoan;
        int madatphong;
        int soLuongPhongTong;
        int makhachhang;
        public void AddDatPhong( DatPhong datPhong )
        {
            MessageBox.Show(TenTaiKhoan);
            string query1 = string.Format("SELECT MAX(MADAT) as maxKS, MAX(MAKH) as maxmakh FROM DATPHONG");
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
                int makhColumnIndex = reader1.GetOrdinal("maxmakh");
                if (!reader1.IsDBNull(makhColumnIndex))
                {
                    makhachhang = reader1.GetInt32(makhColumnIndex) + 1;
                }
            }
            conn1.Close();
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
                string sqlString = "INSERT INTO DATPHONG (MADAT,MAKS, CHECKIN, CHECKOUT, SOLUONG, MAPHONG, TENDANGNHAP, MAKH, THANHTOAN) VALUES (@madat,@maks, @checkIn, @checkOut, @soluong, @maphong, @tendangnhap, @makh, @thanhtoan)";
                using(SqlCommand cmd = new SqlCommand(sqlString, conn))
                {
                    cmd.Parameters.AddWithValue("@madat", madatphong);
                    cmd.Parameters.AddWithValue("@maks", datPhong.KS.MAKS);
                    cmd.Parameters.AddWithValue("@checkIn", datPhong.NgayNhan);
                    cmd.Parameters.AddWithValue("@checkOut", datPhong.NgayTra);
                    cmd.Parameters.AddWithValue("@soluong", datPhong.SoPhong);
                    cmd.Parameters.AddWithValue("@maphong", datPhong.Phong.MAPHONG);
                    MessageBox.Show(TenTaiKhoan);
                    cmd.Parameters.AddWithValue("@tendangnhap", TenTaiKhoan);
                    cmd.Parameters.AddWithValue("@makh", makhachhang);
                    cmd.Parameters.AddWithValue("@thanhtoan", datPhong.TongThanhToan);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            KhachHangDAO khachHangDAO = new KhachHangDAO();
            khachHangDAO.AddKhachHang(datPhong.KhachHang,makhachhang);
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
                double gia = reader.GetDouble(reader.GetOrdinal("THANHTOAN"));
                string trangthai = reader.GetString(reader.GetOrdinal("TRANGTHAI"));
                string mahanhtrinh = reader.GetString(reader.GetOrdinal("MAHANHTRINH"));
                DatPhong dp = new DatPhong(maDat, kh, ks, phong, checkin, checkout, soluong, gia, trangthai, mahanhtrinh);
                list.Add(dp);
            }
            return list;
        }
            
    }
}
