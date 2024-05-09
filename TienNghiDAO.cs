using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class TienNghiDAO
    {
        public string mayLanhSelected { get; set; }
        public string nhaHangSelected { get; set; }
        public string hoBoiSelected { get; set; }
        public string leTan24hSelected { get; set; }
        public string WifiSelected { get; set; }
        public string quayLeTanSelected { get; set; }
        public string dichVuThuDoiNgoaiTeSelected { get; set; }
        public string dichVuTiecCuoiSelected { get; set; }
        public string dichVuHoTroDatTourSelected { get; set; }
        public string nhanVienDaNgonNguSelected { get; set; }
        public string baiDauXeSelected { get; set; }
        public string tiemCaFeSelected { get; set; }
        public string thangMaySelected { get; set; }
        public string quayBarSelected { get; set; }
        public string quayBarBenHoBoiSelected { get; set; }
        public string buaSangSelected { get; set; }
        Connection_to_SQL connection = new Connection_to_SQL();
        public void Add(TienNghi acc, string TenQuanHe)
        {
            string sqlStr = string.Format("INSERT INTO {0} (MAKS, TK, MAYLANH, NHAHANG, HOBOI, LETAN24H, WIFI, QUAYLETAN, DICHVUTHUDOINGOAITE, DICHVUTIECCUOI, DICHVUHOTRODATTOUR, NHANVIENDANGONNGU, BAIDAUXE, TIEMCAFE, THANGMAY, QUAYBAR, BUASANG, QUAYBARBENHOBOI) VALUES ({1}, '{2}', {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18})", TenQuanHe, acc.MAKS, acc.TK, acc.MAYLANH, acc.NHAHANG, acc.HOBOI, acc.LETAN24H, acc.WIFI, acc.QUAYLETAN, acc.DICHVUTHUDOINGOAITE, acc.DICHVUTIECCUOI, acc.DICHVUHOTRODATTOUR, acc.NHANVIENDANGONNGU, acc.BAIDAUXE, acc.TIEMCAFE, acc.THANGMAY, acc.QUAYBAR, acc.BUASANG, acc.QUAYBARBENHOBOI);
            //connection.ThucThi(acc, sqlStr);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    cmd.Parameters.AddWithValue("@MAKS", acc.MAKS);
                    cmd.Parameters.AddWithValue("@TK", acc.TK);
                    cmd.Parameters.AddWithValue("@MAYLANH", acc.MAYLANH);
                    cmd.Parameters.AddWithValue("@NHAHANG", acc.NHAHANG);
                    cmd.Parameters.AddWithValue("@HOBOI", acc.HOBOI);
                    cmd.Parameters.AddWithValue("@LETAN24H", acc.LETAN24H);
                    cmd.Parameters.AddWithValue("@WIFI", acc.WIFI);
                    cmd.Parameters.AddWithValue("@QUAYLETAN", acc.QUAYLETAN);
                    cmd.Parameters.AddWithValue("@DICHVUTHUDOINGOAITE", acc.DICHVUTHUDOINGOAITE);
                    cmd.Parameters.AddWithValue("@DICHVUTIECCUOI", acc.DICHVUTIECCUOI);
                    cmd.Parameters.AddWithValue("@DICHVUHOTRODATTOUR", acc.DICHVUHOTRODATTOUR);
                    cmd.Parameters.AddWithValue("@NHANVIENDANGONNGU", acc.NHANVIENDANGONNGU);
                    cmd.Parameters.AddWithValue("@BAIDAUXE", acc.BAIDAUXE);
                    cmd.Parameters.AddWithValue("@TIEMCAFE", acc.TIEMCAFE);
                    cmd.Parameters.AddWithValue("@THANGMAY", acc.THANGMAY);
                    cmd.Parameters.AddWithValue("@QUAYBAR", acc.QUAYBAR);
                    cmd.Parameters.AddWithValue("@BUASANG", acc.BUASANG);
                    cmd.Parameters.AddWithValue("@QUAYBARBENHOBOI", acc.QUAYBARBENHOBOI);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public void Update(TienNghi acc, string TenQuanHe)
        {
            try
            {
                string SQL = string.Format("UPDATE {0} SET MAYLANH = '{1}', NHAHANG = '{2}', HOBOI = '{3}', LETAN24H = '{4}', WIFI = '{5}',QUAYLETAN = '{6}',DICHVUTHUDOINGOAITE = '{7}',DICHVUTIECCUOI = '{8}',DICHVUHOTRODATTOUR = '{9}', NHANVIENDANGONNGU = '{10}', BAIDAUXE = '{11}', TIEMCAFE = '{12}', THANGMAY = '{13}',QUAYBAR = '{14}',BUASANG = '{15}',QUAYBARBENHOBOI = '{16}' WHERE MAKS = '{17}' AND TK = '{18}'", TenQuanHe, acc.MAYLANH, acc.NHAHANG, acc.HOBOI, acc.LETAN24H, acc.WIFI, acc.QUAYLETAN, acc.DICHVUTHUDOINGOAITE, acc.DICHVUTIECCUOI, acc.DICHVUHOTRODATTOUR, acc.NHANVIENDANGONNGU, acc.BAIDAUXE, acc.TIEMCAFE, acc.THANGMAY, acc.QUAYBAR, acc.BUASANG, acc.QUAYBARBENHOBOI, acc.MAKS, acc.TK);
                //connection.ThucThi(acc, SQL);
                using (SqlConnection conn = Connection_to_SQL.getConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(SQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@MAKS", acc.MAKS);
                        cmd.Parameters.AddWithValue("@TK", acc.TK);
                        cmd.Parameters.AddWithValue("@MAYLANH", acc.MAYLANH);
                        cmd.Parameters.AddWithValue("@NHAHANG", acc.NHAHANG);
                        cmd.Parameters.AddWithValue("@HOBOI", acc.HOBOI);
                        cmd.Parameters.AddWithValue("@LETAN24H", acc.LETAN24H);
                        cmd.Parameters.AddWithValue("@WIFI", acc.WIFI);
                        cmd.Parameters.AddWithValue("@QUAYLETAN", acc.QUAYLETAN);
                        cmd.Parameters.AddWithValue("@DICHVUTHUDOINGOAITE", acc.DICHVUTHUDOINGOAITE);
                        cmd.Parameters.AddWithValue("@DICHVUTIECCUOI", acc.DICHVUTIECCUOI);
                        cmd.Parameters.AddWithValue("@DICHVUHOTRODATTOUR", acc.DICHVUHOTRODATTOUR);
                        cmd.Parameters.AddWithValue("@NHANVIENDANGONNGU", acc.NHANVIENDANGONNGU);
                        cmd.Parameters.AddWithValue("@BAIDAUXE", acc.BAIDAUXE);
                        cmd.Parameters.AddWithValue("@TIEMCAFE", acc.TIEMCAFE);
                        cmd.Parameters.AddWithValue("@THANGMAY", acc.THANGMAY);
                        cmd.Parameters.AddWithValue("@QUAYBAR", acc.QUAYBAR);
                        cmd.Parameters.AddWithValue("@BUASANG", acc.BUASANG);
                        cmd.Parameters.AddWithValue("@QUAYBARBENHOBOI", acc.QUAYBARBENHOBOI);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void getDuLieuTienNghi(string diaDiem, int soLuong1, int min, int max, List<KHACHSAN> listKS, DateTime ngayDen, DateTime ngayDi, List<int> maKS)
        {
            foreach (int i in maKS)
            {
                string query1 = string.Format("SELECT * FROM ThongTinCanBan, ViTri,(SELECT MIN (PHONG.SOKHACH) as MinKhach, ViTri.MAKS as VMaKS FROM PHONG,QLPHONG,ViTri WHERE TINH = @diadiem AND ViTri.MAKS = QLPHONG.MAKS AND QLPHONG.MAPHONG = PHONG.MAPHONG AND PHONG.SOKHACH >= @soLuong1 GROUP BY ViTri.MAKS) as QLKhach WHERE TINH = @diadiem AND QLKhach. VMaKS  = ViTri.MAKS AND ThongTinCanBan.MAKS = ViTri.MAKS AND ViTri.MAKS = {0} AND ThongTinCanBan.GIA >= {1} AND ThongTinCanBan.GIA <= {2}", i, min, max);
                SqlConnection conn1 = Connection_to_SQL.getConnection();
                conn1.Open();
                SqlCommand command1 = new SqlCommand(query1, conn1);
                command1.Parameters.AddWithValue("@diadiem", diaDiem);
                command1.Parameters.AddWithValue("@soLuong1", soLuong1);
                SqlDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read())
                {
                    string tenTinh = reader1.GetString(reader1.GetOrdinal("TINH"));
                    string tenThanhPho = reader1.GetString(reader1.GetOrdinal("TENTHANHPHO"));
                    string tenKhachSan = reader1.GetString(reader1.GetOrdinal("TENKH"));
                    string diaChi = reader1.GetString(reader1.GetOrdinal("DIACHI"));
                    int soKhachMin = reader1.GetInt32(reader1.GetOrdinal("MinKhach"));
                    double giaNhoNhat = reader1.GetDouble(reader1.GetOrdinal("GIA"));
                    int maks = reader1.GetInt32(reader1.GetOrdinal("VMaKS"));
                    int khoangCachTP = reader1.GetInt32(reader1.GetOrdinal("KCTHANHPHO"));
                    int khoangCacchSanBay = reader1.GetInt32(reader1.GetOrdinal("KCSANBAY"));
                    int danhGia = reader1.GetInt32(reader1.GetOrdinal("SAO"));
                    string anh = reader1.GetString(reader1.GetOrdinal("AnhBia"));
                    KHACHSAN ks = new KHACHSAN(maks, tenKhachSan, tenTinh, tenThanhPho, danhGia, giaNhoNhat, diaChi, soKhachMin, khoangCachTP, khoangCacchSanBay, anh, ngayDen, ngayDi);
                    listKS.Add(ks);
                }
            }
        }
        public void getSLTNTrung(int maksList)
        {
            string query1 = string.Format("SELECT * FROM TIENNGHI WHERE  MAKS = {0}", maksList);
            SqlConnection conn1 = Connection_to_SQL.getConnection();
            conn1.Open();
            SqlCommand command1 = new SqlCommand(query1, conn1);
            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                int maColumnIndex = reader1.GetOrdinal("MAYLANH");
                if (!reader1.IsDBNull(maColumnIndex))
                {
                    bool mayLanh = reader1.GetBoolean(maColumnIndex);
                    if (mayLanh)
                    {
                        mayLanhSelected = "Máy lạnh";
                    }
                }
                int maColumnIndex1 = reader1.GetOrdinal("NHAHANG");
                if (!reader1.IsDBNull(maColumnIndex1))
                {
                    bool nhaHang = reader1.GetBoolean(maColumnIndex1);
                    if (nhaHang)
                    {
                        nhaHangSelected = "Nhà hàng";
                    }
                }
                int maColumnIndex2 = reader1.GetOrdinal("HOBOI");
                if (!reader1.IsDBNull(maColumnIndex2))
                {
                    bool hoBoi = reader1.GetBoolean(maColumnIndex2);
                    if (hoBoi)
                    {
                        hoBoiSelected = "Hồ bơi";
                    }
                }
                int maColumnIndex3 = reader1.GetOrdinal("LETAN24H");
                if (!reader1.IsDBNull(maColumnIndex3))
                {
                    bool leTan = reader1.GetBoolean(maColumnIndex3);
                    if (leTan)
                    {
                        leTan24hSelected = "Lễ tân 24h";
                    }
                }
                int maColumnIndex4 = reader1.GetOrdinal("WIFI");
                if (!reader1.IsDBNull(maColumnIndex4))
                {
                    bool wifi = reader1.GetBoolean(maColumnIndex4);
                    if (wifi)
                    {
                        WifiSelected = "Wifi";
                    }
                }
                int maColumnIndex5 = reader1.GetOrdinal("QUAYLETAN");
                if (!reader1.IsDBNull(maColumnIndex5))
                {
                    bool quayLeTan = reader1.GetBoolean(maColumnIndex5);
                    if (quayLeTan)
                    {
                        quayLeTanSelected = "Quầy lễ tân";
                    }
                }
                int maColumnIndex6 = reader1.GetOrdinal("DICHVUTHUDOINGOAITE");
                if (!reader1.IsDBNull(maColumnIndex6))
                {
                    bool thuDoi = reader1.GetBoolean(maColumnIndex6);
                    if (thuDoi)
                    {
                        dichVuThuDoiNgoaiTeSelected = "Dịch vụ thu đổi ngoại tệ";
                    }
                }
                int maColumnIndex7 = reader1.GetOrdinal("DICHVUTIECCUOI");
                if (!reader1.IsDBNull(maColumnIndex7))
                {
                    bool tiecCuoi = reader1.GetBoolean(maColumnIndex7);
                    if (tiecCuoi)
                    {
                        dichVuTiecCuoiSelected = "Dịch vụ tiệc cưới";
                    }
                }
                int maColumnIndex8 = reader1.GetOrdinal("DICHVUHOTRODATTOUR");
                if (!reader1.IsDBNull(maColumnIndex8))
                {
                    bool datTour = reader1.GetBoolean(maColumnIndex8);
                    if (datTour)
                    {
                        dichVuHoTroDatTourSelected = "Dịch vụ hỗ trợ đặt tour";
                    }
                }
                int maColumnIndex9 = reader1.GetOrdinal("NHANVIENDANGONNGU");
                if (!reader1.IsDBNull(maColumnIndex9))
                {
                    bool nhanVien = reader1.GetBoolean(maColumnIndex9);
                    if (nhanVien)
                    {
                        nhanVienDaNgonNguSelected = "Nhân viên đa ngôn ngữ";
                    }
                }
                int maColumnIndex10 = reader1.GetOrdinal("BAIDAUXE");
                if (!reader1.IsDBNull(maColumnIndex10))
                {
                    bool baiDauXe = reader1.GetBoolean(maColumnIndex10);
                    if (baiDauXe)
                    {
                        baiDauXeSelected = "Bãi đậu xe";
                    }
                }
                int maColumnIndex11 = reader1.GetOrdinal("TIEMCAFE");
                if (!reader1.IsDBNull(maColumnIndex11))
                {
                    bool tiemCafe = reader1.GetBoolean(maColumnIndex11);
                    if (tiemCafe)
                    {
                        tiemCaFeSelected = "Tiệm cafe";
                    }
                }
                int maColumnIndex12 = reader1.GetOrdinal("THANGMAY");
                if (!reader1.IsDBNull(maColumnIndex12))
                {
                    bool thangMay = reader1.GetBoolean(maColumnIndex12);
                    if (thangMay)
                    {
                        thangMaySelected = "Thang máy";
                    }
                }
                int maColumnIndex13 = reader1.GetOrdinal("QUAYBAR");
                if (!reader1.IsDBNull(maColumnIndex13))
                {
                    bool quayBar = reader1.GetBoolean(maColumnIndex13);
                    if (quayBar)
                    {
                        quayBarSelected = "Quầy bar";
                    }
                }
                int maColumnIndex14 = reader1.GetOrdinal("BUASANG");
                if (!reader1.IsDBNull(maColumnIndex14))
                {
                    bool buaSang = reader1.GetBoolean(maColumnIndex14);
                    if (buaSang)
                    {
                        buaSangSelected = "Bữa sáng";
                    }
                }
                int maColumnIndex15 = reader1.GetOrdinal("QUAYBARBENHOBOI");
                if (!reader1.IsDBNull(maColumnIndex15))
                {
                    bool quayBar = reader1.GetBoolean(maColumnIndex15);
                    if (quayBar)
                    {
                        quayBarBenHoBoiSelected = "Quày bar bên hồ bơi";
                    }
                }
            }
            conn1.Close();
        }
    }
}
