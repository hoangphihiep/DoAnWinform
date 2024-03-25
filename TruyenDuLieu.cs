using System;
using System.Collections.Generic;
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
            string query = string.Format("SELECT * FROM ThongTinCanBan inner join ViTri ON ThongTinCanBan.MAKS = ViTri.MAKS WHERE ViTri.Tinh = @diadiem AND ThongTinCanBan.GIA >= {0} AND ThongTinCanBan.GIA <= {1} ", min,max);
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
                //maKS[i] = reader.GetString(reader.GetOrdinal("TK"));
                address[i] = reader.GetString(reader.GetOrdinal("AnhBia"));
                MessageBox.Show(address[i]);
                int giaColumnIndex = reader.GetOrdinal("GIA");
                if (!reader.IsDBNull(giaColumnIndex))
                {
                    int gia = reader.GetInt32(giaColumnIndex);
                    soTien[i] = gia.ToString() + " VNĐ";
                }
                int khoangCachTPColumnIndex = reader.GetOrdinal("KCTHANHPHO");
                if (!reader.IsDBNull(giaColumnIndex))
                {
                    int khoangCach = reader.GetInt32(khoangCachTPColumnIndex);
                    khoangCachTP[i] = tenThanhPho[i] + " " + khoangCach.ToString() + " km đến trung tâm";
                }
                int khoangCachSanBayColumnIndex = reader.GetOrdinal("KCSANBAY");
                if (!reader.IsDBNull(giaColumnIndex))
                {
                    int khoangCach = reader.GetInt32(khoangCachSanBayColumnIndex);
                    khoangCachSanBay[i] = khoangCach.ToString() + " km đến sân bay gần nhất";
                }
                int danhGiaColumnIndex = reader.GetOrdinal("SAO");
                if (!reader.IsDBNull(giaColumnIndex))
                {
                    int danhgia = reader.GetInt32(danhGiaColumnIndex);
                    danhGia[i] = "Đánh giá: " + danhgia.ToString();
                }
                soLuong++;
                i++;
            }
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
            string query = string.Format("SELECT * FROM ThongTinCanBan inner join ViTri ON ThongTinCanBan.MAKS = ViTri.MAKS WHERE ViTri.Tinh = @diadiem ORDER BY {0} ASC ", sapXep);
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@diadiem", diaDiem);
            command.CommandTimeout = 120;
            SqlDataReader reader = command.ExecuteReader();
            int i = 1;
            while (reader.Read())
            {
                tenTinh[i] = reader.GetString(reader.GetOrdinal("TINH"));
                tenThanhPho[i] = reader.GetString(reader.GetOrdinal("TENTHANHPHO"));
                tenKhachSan[i] = reader.GetString(reader.GetOrdinal("TENKH"));
                
                //maKS[i] = reader.GetString(reader.GetOrdinal("TK"));
                //byte[] hinhanh = (byte[])reader["HinhAnh"];    
                int giaColumnIndex = reader.GetOrdinal("GIA");
                if (!reader.IsDBNull(giaColumnIndex))
                {
                    int gia = reader.GetInt32(giaColumnIndex);
                    soTien[i] = gia.ToString() + " VNĐ";
                }
                int khoangCachTPColumnIndex = reader.GetOrdinal("KCTHANHPHO");
                if (!reader.IsDBNull(giaColumnIndex))
                {
                    int khoangCach = reader.GetInt32(khoangCachTPColumnIndex);
                    khoangCachTP[i] = tenThanhPho[i] + " " + khoangCach.ToString() + " km đến trung tâm";
                }
                int khoangCachSanBayColumnIndex = reader.GetOrdinal("KCSANBAY");
                if (!reader.IsDBNull(giaColumnIndex))
                {
                    int khoangCach = reader.GetInt32(khoangCachSanBayColumnIndex);
                    khoangCachSanBay[i] = khoangCach.ToString() + " km đến sân bay gần nhất";
                }
                int danhGiaColumnIndex = reader.GetOrdinal("SAO");
                if (!reader.IsDBNull(giaColumnIndex))
                {
                    int danhgia = reader.GetInt32(danhGiaColumnIndex);
                    danhGia[i] = "Đánh giá: " + danhgia.ToString();
                }
                address[i] = reader.GetString(reader.GetOrdinal("AnhBia"));
                soLuong++;
                i++;
            }
        }

    }
}
