using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class TruyenDuLieu
    {
        public int soLuong { get; set; }
        public int soLuong2 { get; set; }
        public string[] tenTinh { get; set; }
        public string[] tenThanhPho { get; set; }
        public string[] tenKhachSan { get; set; }
        public double[] soTien { get; set; }
        public int[] khoangCachTP { get; set; }
        public int[] khoangCachSanBay { get; set; }
        public int[] danhGia { get; set; }
        public int[] maKS { get; set; }
        public int[] maPhong { get; set; }
        public string[] address { get; set; }
        public int[] soKhach { get; set; }
        public string[] diaChi { get; set; }
        public string[] tenPhong { get; set; }
        public int[] soLuongPhong { get; set; }
        public double[] soTienThanhToan { get; set; }
        public TruyenDuLieu()
        {
            // Khởi tạo các mảng
            tenTinh = new string[100]; // Định danh kích thước của mảng, bạn có thể điều chỉnh nó tùy thuộc vào số lượng dữ liệu bạn dự định truy xuất
            tenThanhPho = new string[100];
            tenKhachSan = new string[100];
            soTien = new double[100];
            khoangCachTP = new int[100];
            khoangCachSanBay = new int[100];
            danhGia = new int[100];
            address = new string[100];
            soKhach = new int[100];
            maKS = new int[100];
            diaChi = new string[100];
            maPhong = new int[100];
            tenPhong = new string[100];
            soLuongPhong = new int[100];
            soTienThanhToan = new double[100];
        }
        public void Truyen3 (string tenTaiKhoan)
        {
            soLuong = 0;
            Array.Clear(tenTinh, 0, tenTinh.Length);
            Array.Clear(tenThanhPho, 0, tenThanhPho.Length);
            Array.Clear(tenKhachSan, 0, tenKhachSan.Length);
            Array.Clear(maKS, 0, maKS.Length);
            Array.Clear(maPhong, 0, maPhong.Length);
            Array.Clear(tenPhong, 0, tenPhong.Length);
            Array.Clear(diaChi, 0, diaChi.Length);
            Array.Clear(soLuongPhong, 0, soLuongPhong.Length);
            Array.Clear(soTienThanhToan, 0, soTienThanhToan.Length);
            Array.Clear(address, 0, address.Length);
            Array.Clear(soKhach, 0, soKhach.Length);
            string query = string.Format("SELECT * FROM DATPHONG WHERE TENDANGNHAP = @taiKhoan");
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@taiKhoan", tenTaiKhoan);
            SqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                address[i] = reader.GetString(reader.GetOrdinal("ANHPHONG"));
                int soLuongPhongColumnIndex = reader.GetOrdinal("SOLUONG");
                if (!reader.IsDBNull(soLuongPhongColumnIndex))
                {
                    int soPhong = reader.GetInt32(soLuongPhongColumnIndex);
                    soLuongPhong[i] = soPhong;
                }
                int soTienTongColumnIndex = reader.GetOrdinal("THANHTOAN");
                if (!reader.IsDBNull(soTienTongColumnIndex))
                {
                    double soTien = reader.GetDouble(soTienTongColumnIndex);
                    soTienThanhToan[i] = soTien;
                }
                int maksColumnIndex = reader.GetOrdinal("MAKS");
                if (!reader.IsDBNull(maksColumnIndex))
                {
                    int ma = reader.GetInt32(maksColumnIndex);
                    maKS[i] = ma;
                    string query1 = string.Format("SELECT * FROM ThongTinCanBan inner join ViTri ON ThongTinCanBan.MAKS = ViTri.MAKS WHERE ViTri.MAKS = @maks");
                    SqlConnection conn1 = Connection_to_SQL.getConnection();
                    conn1.Open();
                    SqlCommand command1 = new SqlCommand(query1, conn1);
                    command1.Parameters.AddWithValue("@maks", maKS[i]);
                    SqlDataReader reader1 = command1.ExecuteReader();
                    while (reader1.Read())
                    {
                        MessageBox.Show(i.ToString());
                        MessageBox.Show(maKS[i].ToString());
                        tenTinh[i] = reader1.GetString(reader1.GetOrdinal("TINH"));
                        tenThanhPho[i] = reader1.GetString(reader1.GetOrdinal("TENTHANHPHO"));
                        tenKhachSan[i] = reader1.GetString(reader1.GetOrdinal("TENKH"));
                        diaChi[i] = reader1.GetString(reader1.GetOrdinal("DIACHI"));
                    }
                    conn1.Close();
                }
                int maPhongColumnIndex = reader.GetOrdinal("MAPHONG");
                if (!reader.IsDBNull(maPhongColumnIndex))
                {
                    int ma = reader.GetInt32(maPhongColumnIndex);
                    maPhong[i] = ma;
                    string query1 = string.Format("SELECT * FROM PHONG WHERE MAPHONG = @maphong");
                    SqlConnection conn1 = Connection_to_SQL.getConnection();
                    conn1.Open();
                    SqlCommand command1 = new SqlCommand(query1, conn1);
                    command1.Parameters.AddWithValue("@maphong", maPhong[i]);
                    SqlDataReader reader1 = command1.ExecuteReader();
                    while (reader1.Read())
                    {
                        tenPhong[i] = reader1.GetString(reader1.GetOrdinal("TENPHONG"));
                        int soKhachColumnIndex = reader1.GetOrdinal("SOKHACH");
                        if (!reader1.IsDBNull(soKhachColumnIndex))
                        {
                            int sokhach = reader1.GetInt32(soKhachColumnIndex);
                            soKhach[i] = sokhach;
                        }
                    }
                    conn1.Close();
                }
                soLuong++;
                i++;
                
            }
            conn.Close();
        }
        public void Truyen2 (string diaDiem, int min, int max)
        {
            soLuong = 0;
            Array.Clear(tenTinh, 0, tenTinh.Length);
            Array.Clear(tenThanhPho, 0, tenThanhPho.Length);
            Array.Clear(tenKhachSan, 0, tenKhachSan.Length);
            Array.Clear(soTien, 0, soTien.Length);
            Array.Clear(khoangCachTP, 0, khoangCachTP.Length);
            Array.Clear(khoangCachSanBay, 0, khoangCachSanBay.Length);
            Array.Clear(danhGia, 0, danhGia.Length);
            Array.Clear(address, 0, address.Length);
            Array.Clear(soKhach, 0, soKhach.Length);
            Array.Clear(maKS, 0, maKS.Length);
            Array.Clear(diaChi, 0, diaChi.Length);
            string query = string.Format("SELECT * FROM ThongTinCanBan inner join ViTri ON ThongTinCanBan.MAKS = ViTri.MAKS WHERE TINH = @diadiem AND ThongTinCanBan.GIA >= {0} AND ThongTinCanBan.GIA <= {1} ", min,max);
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@diadiem", diaDiem);
            SqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                tenTinh[i] = reader.GetString(reader.GetOrdinal("TINH"));
                tenThanhPho[i] = reader.GetString(reader.GetOrdinal("TENTHANHPHO"));
                tenKhachSan[i] = reader.GetString(reader.GetOrdinal("TENKH"));
                address[i] = reader.GetString(reader.GetOrdinal("AnhBia"));
                diaChi[i] = reader.GetString(reader.GetOrdinal("DIACHI"));
                int giaColumnIndex = reader.GetOrdinal("GIA");
                if (!reader.IsDBNull(giaColumnIndex))
                {
                    double gia = reader.GetDouble(giaColumnIndex);
                    soTien[i] = gia;
                }
                int khoangCachTPColumnIndex = reader.GetOrdinal("KCTHANHPHO");
                if (!reader.IsDBNull(khoangCachTPColumnIndex))
                {
                    int khoangCach = reader.GetInt32(khoangCachTPColumnIndex);
                    khoangCachTP[i] = khoangCach;
                }
                int khoangCachSanBayColumnIndex = reader.GetOrdinal("KCSANBAY");
                if (!reader.IsDBNull(khoangCachSanBayColumnIndex))
                {
                    int khoangCach = reader.GetInt32(khoangCachSanBayColumnIndex);
                    khoangCachSanBay[i] = khoangCach;
                }
                int danhGiaColumnIndex = reader.GetOrdinal("SAO");
                if (!reader.IsDBNull(danhGiaColumnIndex))
                {
                    int danhgia = reader.GetInt32(danhGiaColumnIndex);
                    danhGia[i] = danhgia;
                }
                soLuong++;
                i++;
            }
            conn.Close();
        }
        public void Truyen (string diaDiem, string sapXep, int soLuong1)
        {
            soLuong = 0;
            Array.Clear(tenTinh, 0, tenTinh.Length);
            Array.Clear(tenThanhPho, 0, tenThanhPho.Length);
            Array.Clear(tenKhachSan, 0, tenKhachSan.Length);
            Array.Clear(soTien, 0, soTien.Length);
            Array.Clear(khoangCachTP, 0, khoangCachTP.Length);
            Array.Clear(khoangCachSanBay, 0, khoangCachSanBay.Length);
            Array.Clear(danhGia, 0, danhGia.Length);
            Array.Clear(address, 0, address.Length);
            Array.Clear(soKhach, 0, soKhach.Length);
            Array.Clear(maKS, 0, maKS.Length);
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
                tenTinh[j] = reader.GetString(reader.GetOrdinal("TINH"));
                tenThanhPho[j] = reader.GetString(reader.GetOrdinal("TENTHANHPHO"));
                tenKhachSan[j] = reader.GetString(reader.GetOrdinal("TENKH"));
                diaChi[j] = reader.GetString(reader.GetOrdinal("DIACHI"));
                int soKhachColumnIndex = reader.GetOrdinal("MinKhach");
                if (!reader.IsDBNull(soKhachColumnIndex))
                {
                    int gia = reader.GetInt32(soKhachColumnIndex);
                    soKhach[j] = gia;
                }
                int giaNhoCachTPColumnIndex = reader.GetOrdinal("GIA");
                if (!reader.IsDBNull(giaNhoCachTPColumnIndex))
                {
                    double gia = reader.GetDouble(giaNhoCachTPColumnIndex);
                    soTien[j] = gia;
                }
                int maksColumnIndex = reader.GetOrdinal("VMaKS");
                if (!reader.IsDBNull(maksColumnIndex))
                {
                    int ma = reader.GetInt32(maksColumnIndex);
                    maKS[j] = ma;
                }
                int khoangCachTPColumnIndex = reader.GetOrdinal("KCTHANHPHO");
                if (!reader.IsDBNull(khoangCachTPColumnIndex))
                {
                    int khoangCach = reader.GetInt32(khoangCachTPColumnIndex);
                    khoangCachTP[j] = khoangCach;
                }
                int khoangCachSanBayColumnIndex = reader.GetOrdinal("KCSANBAY");
                if (!reader.IsDBNull(khoangCachSanBayColumnIndex))
                {
                    int khoangCach = reader.GetInt32(khoangCachSanBayColumnIndex);
                    khoangCachSanBay[j] = khoangCach;
                }
                int danhGiaColumnIndex = reader.GetOrdinal("SAO");
                if (!reader.IsDBNull(danhGiaColumnIndex))
                {
                    int danhgia = reader.GetInt32(danhGiaColumnIndex);
                    danhGia[j] = danhgia;
                }
                address[j] = reader.GetString(reader.GetOrdinal("AnhBia"));
                soLuong++;
                j++;
            }
            conn.Close();
            conn1.Close();
        }

    }
}
