using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DuLich
{
    public class TruyenDuLieu
    {
        public void Truyen3 (string tenTaiKhoan, List<PhongDaDat> listPhongDat)
        {
            string query = string.Format("SELECT * FROM DATPHONG WHERE TENDANGNHAP = @taiKhoan");
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@taiKhoan", tenTaiKhoan);
            SqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                int maDat = reader.GetInt32(reader.GetOrdinal("MADAT"));
                int soLuongPhong = reader.GetInt32(reader.GetOrdinal("SOLUONG"));
                double soTienTong = reader.GetDouble(reader.GetOrdinal("THANHTOAN"));
                DateTime ngayDen = reader.GetDateTime(reader.GetOrdinal("CHECKIN"));
                DateTime ngayDi = reader.GetDateTime(reader.GetOrdinal("CHECKOUT"));
                string tenTinh = "";
                string tenThanhPho = "";
                string tenKhachSan = "";
                string diaChi = "";
                int maks = 0;
                int maphong = 0;
                string tenPhong = "";
                string address = "";
                int soKhach = 0; ;
                int maksColumnIndex = reader.GetOrdinal("MAKS");
                if (!reader.IsDBNull(maksColumnIndex))
                {
                    int ma = reader.GetInt32(maksColumnIndex);
                    maks = ma;
                    string query1 = string.Format("SELECT * FROM ThongTinCanBan inner join ViTri ON ThongTinCanBan.MAKS = ViTri.MAKS WHERE ViTri.MAKS = @maks");
                    SqlConnection conn1 = Connection_to_SQL.getConnection();
                    conn1.Open();
                    SqlCommand command1 = new SqlCommand(query1, conn1);
                    command1.Parameters.AddWithValue("@maks", maks);
                    SqlDataReader reader1 = command1.ExecuteReader();
                    while (reader1.Read())
                    {
                        tenTinh = reader1.GetString(reader1.GetOrdinal("TINH"));
                        tenThanhPho = reader1.GetString(reader1.GetOrdinal("TENTHANHPHO"));
                        tenKhachSan = reader1.GetString(reader1.GetOrdinal("TENKH"));
                        diaChi = reader1.GetString(reader1.GetOrdinal("DIACHI"));
                    }
                    conn1.Close();
                }
                int maPhongColumnIndex = reader.GetOrdinal("MAPHONG");
                if (!reader.IsDBNull(maPhongColumnIndex))
                {
                    int ma = reader.GetInt32(maPhongColumnIndex);
                    maphong = ma;
                    string query1 = string.Format("SELECT * FROM PHONG WHERE MAPHONG = @maphong");
                    SqlConnection conn1 = Connection_to_SQL.getConnection();
                    conn1.Open();
                    SqlCommand command1 = new SqlCommand(query1, conn1);
                    command1.Parameters.AddWithValue("@maphong", maphong);
                    SqlDataReader reader1 = command1.ExecuteReader();
                    while (reader1.Read())
                    {
                        tenPhong = reader1.GetString(reader1.GetOrdinal("TENPHONG"));
                        address = reader1.GetString(reader1.GetOrdinal("ANH"));
                        soKhach = reader1.GetInt32(reader1.GetOrdinal("SOKHACH"));
                    }
                    conn1.Close();
                }
                i++;
                PhongDaDat phongDD = new PhongDaDat(maDat, maks, maphong, tenPhong, tenKhachSan, tenTinh, tenThanhPho, diaChi, soLuongPhong, soTienTong, address, soKhach, ngayDen, ngayDi);
                listPhongDat.Add(phongDD);
            }
            conn.Close();
        }
        public void Truyen2 (string diaDiem, int min, int max,int soLuong1, List<KHACHSAN> listKS, DateTime ngayDen, DateTime ngayDi)
        {
            string query = string.Format("SELECT * FROM ThongTinCanBan, ViTri,(SELECT MIN (PHONG.SOKHACH) as MinKhach, ViTri.MAKS as VMaKS FROM PHONG,QLPHONG,ViTri WHERE TINH = @diadiem AND ViTri.MAKS = QLPHONG.MAKS AND QLPHONG.MAPHONG = PHONG.MAPHONG AND PHONG.SOKHACH >= @soLuong1 GROUP BY ViTri.MAKS) as QLKhach WHERE TINH = @diadiem AND QLKhach. VMaKS  = ViTri.MAKS AND ThongTinCanBan.MAKS = ViTri.MAKS AND ThongTinCanBan.GIA >= {0} AND ThongTinCanBan.GIA <= {1}", min,max);
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@diadiem", diaDiem);
            command.Parameters.AddWithValue("@soLuong1", soLuong1);
            SqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                string tenTinh = reader.GetString(reader.GetOrdinal("TINH"));
                string tenThanhPho = reader.GetString(reader.GetOrdinal("TENTHANHPHO"));
                string tenKhachSan = reader.GetString(reader.GetOrdinal("TENKH"));
                string diaChi = reader.GetString(reader.GetOrdinal("DIACHI"));
                int soKhachMin = reader.GetInt32(reader.GetOrdinal("MinKhach"));
                double giaNhoNhat = reader.GetDouble(reader.GetOrdinal("GIA"));
                int maks = reader.GetInt32(reader.GetOrdinal("VMaKS"));
                int khoangCachTP = reader.GetInt32(reader.GetOrdinal("KCTHANHPHO"));
                int khoangCacchSanBay = reader.GetInt32(reader.GetOrdinal("KCSANBAY"));
                int danhGia = reader.GetInt32(reader.GetOrdinal("SAO"));
                string anh = reader.GetString(reader.GetOrdinal("AnhBia"));
                MessageBox.Show(giaNhoNhat.ToString());
                KHACHSAN ks = new KHACHSAN(maks, tenKhachSan, tenTinh, tenThanhPho, danhGia, giaNhoNhat, diaChi, soKhachMin, khoangCachTP, khoangCacchSanBay, anh, ngayDen, ngayDi);
                listKS.Add(ks);
                i++;
            }
            conn.Close();
        }
        public void Truyen (string diaDiem, string sapXep, int soLuong1, List<KHACHSAN> listKS, DateTime ngayDen, DateTime ngayDi)
        {
            string query1 = string.Format("SELECT MIN(GIA) as MinGia, ViTri.MAKS as VMaKS  FROM PHONG,QLPHONG,ViTri WHERE ViTri.TINH = @diadiem AND ViTri.MAKS = QLPHONG.MAKS AND QLPHONG.MAPHONG = PHONG.MAPHONG GROUP BY ViTri.MAKS");
            SqlConnection conn1 = Connection_to_SQL.getConnection();
            conn1.Open();
            SqlCommand command1 = new SqlCommand(query1, conn1);
            command1.Parameters.AddWithValue("@diadiem", diaDiem);
            int i = 0;
            SqlDataReader reader1 = command1.ExecuteReader(); 
            while (reader1.Read())
            {
                int giaColumnIndex = reader1.GetOrdinal("MinGia");
                int maColumnIndex = reader1.GetOrdinal("VMaKS");
                if (!reader1.IsDBNull(giaColumnIndex) && !reader1.IsDBNull(maColumnIndex))
                {
                    double gia = reader1.GetDouble(giaColumnIndex);
                    int ma = reader1.GetInt32(maColumnIndex);
                    string sqlStr = "UPDATE ThongTinCanBan SET GIA = @GIA WHERE MAKS = @MAKS";
                    using (SqlConnection conn2 = Connection_to_SQL.getConnection())
                    {
                        conn2.Open();
                        using (SqlCommand cmd2 = new SqlCommand(sqlStr, conn2))
                        {
                            cmd2.Parameters.AddWithValue("@GIA", gia);
                            cmd2.Parameters.AddWithValue("@MAKS", ma);
                            cmd2.ExecuteNonQuery();
                        }
                        conn2.Close();
                    }
                }
                i++;
            }    
            string query = string.Format("SELECT * FROM ThongTinCanBan inner join ViTri ON ThongTinCanBan.MAKS = ViTri.MAKS,(SELECT MIN (PHONG.SOKHACH) as MinKhach, ViTri.MAKS as VMaKS FROM PHONG,QLPHONG,ViTri WHERE TINH = @diadiem AND ViTri.MAKS = QLPHONG.MAKS AND QLPHONG.MAPHONG = PHONG.MAPHONG AND PHONG.SOKHACH >= @soLuong1 GROUP BY ViTri.MAKS) as QLKhach WHERE TINH = @diadiem AND QLKhach. VMaKS  = ViTri.MAKS ORDER BY {0} ASC ", sapXep);
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@diadiem", diaDiem);
            command.Parameters.AddWithValue("@soLuong1", soLuong1);
            command.CommandTimeout = 120;
            SqlDataReader reader = command.ExecuteReader();
            int j = 0;
            while (reader.Read())
            {
                string tenTinh = reader.GetString(reader.GetOrdinal("TINH"));
                string  tenThanhPho = reader.GetString(reader.GetOrdinal("TENTHANHPHO"));
                string tenKhachSan = reader.GetString(reader.GetOrdinal("TENKH"));
                string diaChi = reader.GetString(reader.GetOrdinal("DIACHI"));
                int soKhachMin = reader.GetInt32(reader.GetOrdinal("MinKhach"));
                double giaNhoNhat = reader.GetDouble(reader.GetOrdinal("GIA"));
                int maks = reader.GetInt32(reader.GetOrdinal("VMaKS"));
                int khoangCachTP = reader.GetInt32(reader.GetOrdinal("KCTHANHPHO"));
                int khoangCacchSanBay = reader.GetInt32(reader.GetOrdinal("KCSANBAY"));
                int danhGia = reader.GetInt32(reader.GetOrdinal("SAO"));
                string anh = reader.GetString(reader.GetOrdinal("AnhBia"));
                KHACHSAN ks = new KHACHSAN(maks, tenKhachSan, tenTinh, tenThanhPho, danhGia, giaNhoNhat, diaChi, soKhachMin, khoangCachTP, khoangCacchSanBay, anh, ngayDen, ngayDi);
                listKS.Add(ks);
                j++;
            }
            conn.Close();
            conn1.Close();
        }

    }
}
