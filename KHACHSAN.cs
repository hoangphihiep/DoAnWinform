using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class KHACHSAN
    {
        public string TENKS { get; set; }
        public string TINH { get; set;}
        public string THANHPHO { get; set; }
        public int SAO { get; set; }
        public double GIA { get; set; }
        public string DIACHI { get; set; }
        public int MAKS { get; set; }
        public int soLuongKhach { get; set; }
        public int khoangCachTP { get; set; }
        public int khoangCachSanBay { get; set; }
        public string diaChiAnh { get; set; }

        public DateTime ngayDen { get; set; }
        public DateTime ngayDi { get; set; }
        public KHACHSAN(string tenKS, string tinh, string thanhPho, int sao, double gia, string diaChi, int soLuong, int TP, int SanBay, string Anh, int maKS, DateTime ngayDen, DateTime ngayDi)
        {
            TENKS = tenKS;
            TINH = tinh;
            THANHPHO = thanhPho;
            SAO = sao;
            GIA = gia;
            DIACHI = diaChi;
            soLuongKhach = soLuong;
            khoangCachTP = TP;
            khoangCachSanBay = SanBay;
            diaChiAnh = Anh;
            MAKS = maKS;
            this.ngayDen = ngayDen;
            this.ngayDi = ngayDi;
        }
    }
}
