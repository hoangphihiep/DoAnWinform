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
using static System.Net.Mime.MediaTypeNames;

namespace DuLich
{
    public class TruyenDuLieu
    {
        private List<KHACHSAN> LayDanhSachKhachSan(string query, string[] parameters, object[] values, DateTime ngayDen, DateTime ngayDi)
        {
            List<KHACHSAN> listKS = new List<KHACHSAN>();

            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        command.Parameters.AddWithValue(parameters[i], values[i]);
                    }
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
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
                            KHACHSAN ks = new KHACHSAN(maks, tenKhachSan, tenTinh, tenThanhPho, danhGia, giaNhoNhat, diaChi, soKhachMin, khoangCachTP, khoangCacchSanBay, anh, ngayDen, ngayDi);
                            listKS.Add(ks);
                        }
                    }
                }
            }
            return listKS;
        }
        public void Truyen2 (string diaDiem, int min, int max,int soLuong1, List<KHACHSAN> listKS, DateTime ngayDen, DateTime ngayDi)
        {
            string query = "SELECT * FROM ThongTinCanBan, ViTri, (SELECT MIN(PHONG.SOKHACH) as MinKhach, ViTri.MAKS as VMaKS FROM PHONG,QLPHONG,ViTri WHERE TINH = @diadiem AND ViTri.MAKS = QLPHONG.MAKS AND QLPHONG.MAPHONG = PHONG.MAPHONG AND PHONG.SOKHACH >= @soLuong1 GROUP BY ViTri.MAKS) as QLKhach WHERE TINH = @diadiem AND QLKhach.VMaKS = ViTri.MAKS AND ThongTinCanBan.MAKS = ViTri.MAKS AND ThongTinCanBan.GIA >= @min AND ThongTinCanBan.GIA <= @max";
            string[] parameters = { "@diadiem", "@soLuong1", "@min", "@max" };
            object[] values = { diaDiem, soLuong1, min, max };
            List<KHACHSAN> results = LayDanhSachKhachSan(query, parameters, values, ngayDen, ngayDi);
            listKS.AddRange(results);
        }
        public void Truyen (string diaDiem, string sapXep, int soLuong1, List<KHACHSAN> listKS, DateTime ngayDen, DateTime ngayDi)
        {
            string query1 = string.Format("SELECT MIN(GIA) as MinGia, ViTri.MAKS as VMaKS  FROM PHONG,QLPHONG,ViTri WHERE ViTri.TINH = @diadiem AND ViTri.MAKS = QLPHONG.MAKS AND QLPHONG.MAPHONG = PHONG.MAPHONG GROUP BY ViTri.MAKS");
            
            SqlConnection conn1 = Connection_to_SQL.getConnection();
            conn1.Open();
            SqlCommand command1 = new SqlCommand(query1, conn1);
            command1.Parameters.AddWithValue("@diadiem", diaDiem);
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
            }
            string query = string.Format("SELECT * FROM ThongTinCanBan inner join ViTri ON ThongTinCanBan.MAKS = ViTri.MAKS,(SELECT MIN (PHONG.SOKHACH) as MinKhach, ViTri.MAKS as VMaKS FROM PHONG,QLPHONG,ViTri WHERE TINH = @diadiem AND ViTri.MAKS = QLPHONG.MAKS AND QLPHONG.MAPHONG = PHONG.MAPHONG AND PHONG.SOKHACH >= @soLuong1 GROUP BY ViTri.MAKS) as QLKhach WHERE TINH = @diadiem AND QLKhach.VMaKS = ViTri.MAKS ORDER BY {0} ASC ", sapXep);
            string[] parameters = { "@diadiem", "@soLuong1" };
            object[] values = { diaDiem, soLuong1 };
            List<KHACHSAN> results = LayDanhSachKhachSan(query, parameters, values, ngayDen, ngayDi);
            listKS.AddRange(results);
            conn1.Close();
        }
        public void layDuLieuTienNghi (string diaDiem, int soLuong1, int min, int max, List<KHACHSAN> listKS, DateTime ngayDen, DateTime ngayDi,List<int> maKS)
        {
            foreach (int i in maKS)
            {
                string query = "SELECT * FROM ThongTinCanBan, ViTri,(SELECT MIN (PHONG.SOKHACH) as MinKhach, ViTri.MAKS as VMaKS FROM PHONG,QLPHONG,ViTri WHERE TINH = @diadiem AND ViTri.MAKS = QLPHONG.MAKS AND QLPHONG.MAPHONG = PHONG.MAPHONG AND PHONG.SOKHACH >= @soLuong1 GROUP BY ViTri.MAKS) as QLKhach WHERE TINH = @diadiem AND QLKhach.VMaKS = ViTri.MAKS AND ThongTinCanBan.MAKS = ViTri.MAKS AND ViTri.MAKS = @maKS AND ThongTinCanBan.GIA >= @min AND ThongTinCanBan.GIA <= @max";
                string[] parameters = { "@diadiem", "@soLuong1", "@min", "@max", "@maKS" };
                object[] values = { diaDiem, soLuong1, min, max, i };
                List<KHACHSAN> results = LayDanhSachKhachSan(query, parameters, values, ngayDen, ngayDi);
                listKS.AddRange(results);
            }
        }
    }
}
