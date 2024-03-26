using System;
using System.Collections.Generic;
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
        public string[] tenTinh { get; set; }
        public string[] tenThanhPho { get; set; }
        public string[] tenKhachSan { get; set; }
        public string[] soTien { get; set; }
        public string[] khoangCachTP { get; set; }
        public string[] khoangCachSanBay { get; set; }
        public string[] danhGia { get; set; }
        public string[] maKS { get; set; }
        public string[] address { get; set; }
        public TruyenDuLieu()
        {
            // Khởi tạo các mảng
            tenTinh = new string[100]; // Định danh kích thước của mảng, bạn có thể điều chỉnh nó tùy thuộc vào số lượng dữ liệu bạn dự định truy xuất
            tenThanhPho = new string[100];
            tenKhachSan = new string[100];
            soTien = new string[100];
            khoangCachTP = new string[100];
            khoangCachSanBay = new string[100];
            danhGia = new string[100];
            address = new string[100];
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
            string query1 = string.Format("SELECT MIN(GIA) FROM PHONG,QLPHONG,ViTri WHERE TINH = @diadiem AND ViTri.MAKS = QLPHONG.MAKS AND QLPHONG.MAPHONG = PHONG.MAPHONG GROUP BY ViTri.MAKS");
            SqlConnection conn1 = Connection_to_SQL.getConnection();
            conn1.Open();
            SqlCommand command1 = new SqlCommand(query1, conn1);
            command1.Parameters.AddWithValue("@diadiem", diaDiem);
            SqlDataReader reader1 = command1.ExecuteReader();
            string query = string.Format("SELECT * FROM ThongTinCanBan inner join ViTri ON ThongTinCanBan.MAKS = ViTri.MAKS WHERE TINH = @diadiem AND ThongTinCanBan.GIA >= {0} AND ThongTinCanBan.GIA <= {1} ", min,max);
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@diadiem", diaDiem);
            SqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read() && reader1.Read())
            {
                tenTinh[i] = reader.GetString(reader.GetOrdinal("TINH"));
                tenThanhPho[i] = reader.GetString(reader.GetOrdinal("TENTHANHPHO"));
                tenKhachSan[i] = reader.GetString(reader.GetOrdinal("TENKH"));
                address[i] = reader.GetString(reader.GetOrdinal("AnhBia"));
                MessageBox.Show(address[i]);
                int giaColumnIndex = reader1.GetOrdinal("GIA");
                if (!reader1.IsDBNull(giaColumnIndex))
                {
                    int gia = reader1.GetInt32(giaColumnIndex);
                    soTien[i] = gia.ToString() + " VNĐ";
                }
                int khoangCachTPColumnIndex = reader.GetOrdinal("KCTHANHPHO");
                if (!reader.IsDBNull(khoangCachTPColumnIndex))
                {
                    int khoangCach = reader.GetInt32(khoangCachTPColumnIndex);
                    khoangCachTP[i] = tenThanhPho[i] + " " + khoangCach.ToString() + " km đến trung tâm";
                }
                int khoangCachSanBayColumnIndex = reader.GetOrdinal("KCSANBAY");
                if (!reader.IsDBNull(khoangCachSanBayColumnIndex))
                {
                    int khoangCach = reader.GetInt32(khoangCachSanBayColumnIndex);
                    khoangCachSanBay[i] = khoangCach.ToString() + " km đến sân bay gần nhất";
                }
                int danhGiaColumnIndex = reader.GetOrdinal("SAO");
                if (!reader.IsDBNull(danhGiaColumnIndex))
                {
                    int danhgia = reader.GetInt32(danhGiaColumnIndex);
                    danhGia[i] = "Đánh giá: " + danhgia.ToString();
                }
                soLuong++;
                i++;
            }
            conn.Close();
            conn1.Close();
        }
        public void Truyen (string diaDiem, string sapXep)
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
            string query1 = string.Format("SELECT MIN(GIA) as MinGia FROM PHONG,QLPHONG,ViTri WHERE TINH = @diadiem AND ViTri.MAKS = QLPHONG.MAKS AND QLPHONG.MAPHONG = PHONG.MAPHONG GROUP BY ViTri.MAKS");
            SqlConnection conn1 = Connection_to_SQL.getConnection();
            conn1.Open();
            SqlCommand command1 = new SqlCommand(query1, conn1);
            command1.Parameters.AddWithValue("@diadiem", diaDiem);
            SqlDataReader reader1 = command1.ExecuteReader();
            string query = string.Format("SELECT * FROM ThongTinCanBan inner join ViTri ON ThongTinCanBan.MAKS = ViTri.MAKS WHERE ViTri.TINH = @diadiem ORDER BY {0} ASC ", sapXep);
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@diadiem", diaDiem);
            command.CommandTimeout = 120;
            SqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read() && reader1.Read())
            {
                tenTinh[i] = reader.GetString(reader.GetOrdinal("TINH"));
                tenThanhPho[i] = reader.GetString(reader.GetOrdinal("TENTHANHPHO"));
                tenKhachSan[i] = reader.GetString(reader.GetOrdinal("TENKH"));    
                int giaColumnIndex = reader1.GetOrdinal("MinGia");
                if (!reader1.IsDBNull(giaColumnIndex))
                {
                    double gia = reader1.GetDouble(giaColumnIndex);
                    soTien[i] = gia.ToString() + " VNĐ";
                }
                int khoangCachTPColumnIndex = reader.GetOrdinal("KCTHANHPHO");
                if (!reader.IsDBNull(khoangCachTPColumnIndex))
                {
                    int khoangCach = reader.GetInt32(khoangCachTPColumnIndex);
                    khoangCachTP[i] = tenThanhPho[i] + " " + khoangCach.ToString() + " km đến trung tâm";
                }
                int khoangCachSanBayColumnIndex = reader.GetOrdinal("KCSANBAY");
                if (!reader.IsDBNull(khoangCachSanBayColumnIndex))
                {
                    int khoangCach = reader.GetInt32(khoangCachSanBayColumnIndex);
                    khoangCachSanBay[i] = khoangCach.ToString() + " km đến sân bay gần nhất";
                }
                int danhGiaColumnIndex = reader.GetOrdinal("SAO");
                if (!reader.IsDBNull(danhGiaColumnIndex))
                {
                    int danhgia = reader.GetInt32(danhGiaColumnIndex);
                    danhGia[i] = "Đánh giá: " + danhgia.ToString();
                }
                address[i] = reader.GetString(reader.GetOrdinal("AnhBia"));
                soLuong++;
                i++;
            }
            conn.Close();
            conn1.Close();
        }

    }
}
