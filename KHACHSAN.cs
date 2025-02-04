﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class KHACHSAN
    {
        int maks;
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

        public KHACHSAN(int maks, string tenKS, string tinh, string thanhPho, int sao, double gia, string diaChi, int soLuong, int TP, int SanBay, string Anh, DateTime ngayDen, DateTime ngayDi)
        {
            MAKS = maks;
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
            this.ngayDen = ngayDen;
            this.ngayDi = ngayDi;
        }

        public KHACHSAN(int maks, string tenKS, string tinh, string thanhPho, int sao, double gia, string diaChi)
        {
            MAKS = maks;
            TENKS = tenKS;
            TINH = tinh;
            THANHPHO = thanhPho;
            SAO = sao;
            GIA = gia;
            DIACHI = diaChi;
            this.ngayDen = ngayDen;
            this.ngayDi = ngayDi;
        }

        public int Maks
        {
            get { return MAKS; }
            set { MAKS = value; }
        }
    }
}
