using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class TruyenDuLieuTienNghi
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
        public void thucHienTruyen (int maksList)
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
