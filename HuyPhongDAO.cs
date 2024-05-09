using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class HuyPhongDAO
    {
        public void Add(int madat)
        {
            SqlConnection conn = Connection_to_SQL.getConnection();
            try
            {
                conn.Open();
                string sqlString = "INSERT INTO HUYPHONG (MADAT,TRANGTHAI) VALUES (@madat,@trangthai)";
                using (SqlCommand cmd = new SqlCommand(sqlString, conn))
                {
                    cmd.Parameters.AddWithValue("@madat", madat);
                    cmd.Parameters.AddWithValue("@trangthai", "Chưa đặt");
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void getPhongMuonHuy(string tentk, List<DatPhong> listPhongDat)
        {
            using (SqlConnection connection = new SqlConnection(Connection_to_SQL.getConnnection()))
            {
                connection.Open();
                string query1 = "SELECT DATPHONG.MADAT as madatphong, KHACHHANG.MAKH as makh,PHONG.MAPHONG as maphong,ThongTinCanBan.TENKH as tenKS, PHONG.TENPHONG as tenphong, DATPHONG.CHECKIN as ngayDen, DATPHONG.CHECKOUT as ngayDi, KHACHHANG.TENKH as tenKH, DATPHONG.SOLUONG as soPhong, DATPHONG.THANHTOAN as tienTT, PHONG.ANH as anhPhong FROM DATPHONG, HUYPHONG, KHACHSAN_THUOC_TAIKHOAN, ThongTinCanBan,PHONG,KHACHHANG WHERE ThongTinCanBan.MAKS = KHACHSAN_THUOC_TAIKHOAN.MAKS AND DATPHONG.MADAT = HUYPHONG.MADAT AND DATPHONG.MAKS = KHACHSAN_THUOC_TAIKHOAN.MAKS AND DATPHONG.MAPHONG = PHONG.MAPHONG AND DATPHONG.MAKH = KHACHHANG.MAKH AND KHACHSAN_THUOC_TAIKHOAN.TaiKhoan = @tk";
                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    command.Parameters.AddWithValue("@tk", tentk);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int maDatPhong = reader.GetInt32(reader.GetOrdinal("madatphong"));
                            int makhachhang = reader.GetInt32(reader.GetOrdinal("makh"));
                            int maPhong = reader.GetInt32(reader.GetOrdinal("maphong"));
                            string TENKS = reader.GetString(reader.GetOrdinal("tenKS"));
                            MessageBox.Show(TENKS.ToString());
                            string TENPHONG = reader.GetString(reader.GetOrdinal("tenphong"));
                            DateTime ngayDen = reader.GetDateTime("ngayDen");
                            DateTime ngayDi = reader.GetDateTime("ngayDi");
                            string tenKH = reader.GetString(reader.GetOrdinal("tenKH"));
                            int soLuongPhong = reader.GetInt32(reader.GetOrdinal("soPhong"));
                            double tongThanhToan = reader.GetDouble(reader.GetOrdinal("tienTT"));
                            MessageBox.Show(tongThanhToan.ToString());
                            string anhPhong = reader.GetString(reader.GetOrdinal("anhPhong"));
                            DatPhong dp = new DatPhong(maDatPhong, makhachhang, maPhong, TENKS, TENPHONG, tenKH, ngayDen, ngayDi, soLuongPhong, tongThanhToan, anhPhong);
                            listPhongDat.Add(dp);
                        }
                    }
                }
            }
        }
    }
}
