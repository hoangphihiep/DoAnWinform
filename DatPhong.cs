﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class DatPhong
    {
        KhachHang kh;
        KHACHSAN ks;
        Room phong;
        DateTime ngayNhan;
        DateTime ngayTra;
        int soPhong;
        double tongThanhToan;
        string trangThai;
        string maHanhTrinh;
        int maDat;
        int makh;
        int maPhong;
        //bosung
        string tenKS;
        string tenPhong;
        string tenKH;
        string anhPhong;
        public DatPhong(int maDat, int makh,int maPhong,string tenKS, string tenPhong, string tenKH, DateTime ngayNhan, DateTime ngayTra, int soPhong, double tongThanhToan,string anhPhong) 
        {
            this.maDat = maDat;
            this.makh = makh;
            this.maPhong = maPhong;
            this.tenKS = tenKS;
            this.tenPhong = tenPhong;
            this.tenKH = tenKH;
            this.ngayNhan = ngayNhan;
            this.ngayTra = ngayTra;
            this.soPhong = soPhong;
            this.tongThanhToan = tongThanhToan;
            this.anhPhong = anhPhong;
        }
        public DatPhong(KhachHang kh, KHACHSAN ks, Room phong, DateTime ngayNhan, DateTime ngayTra, int soPhong, double tongThanhToan, string trangThai, string maHanhTrinh)
        {
            this.kh = kh;
            this.ks = ks;
            this.ngayNhan = ngayNhan;
            this.ngayTra = ngayTra;
            this.soPhong = soPhong;
            this.tongThanhToan = tongThanhToan;
            this.trangThai = trangThai;
            this.maHanhTrinh = maHanhTrinh;
        }

        public DatPhong(int maDat, KhachHang kh, KHACHSAN ks, Room phong, DateTime ngayNhan, DateTime ngayTra, int soPhong, double tongThanhToan, string trangThai, string maHanhTrinh)
        {
            this.maDat = maDat;
            this.kh = kh;
            this.ks = ks;
            this.ngayNhan = ngayNhan;
            this.ngayTra = ngayTra;
            this.soPhong = soPhong;
            this.tongThanhToan = tongThanhToan;
            this.trangThai = trangThai;
            this.maHanhTrinh = maHanhTrinh;
        }
        public int MAPHONG
        {
            get { return maPhong; }
            set { maPhong = value; }
        }
        public int MADAT
        {
            get { return maDat; }
            set { maDat = value; }
        }
        public int MAKH
        {
            get { return makh; }
            set { makh = value; }
        }

        public string ANHPHONG
        {
            get { return anhPhong; }
            set { anhPhong = value; }
        }
        public string TENKS
        {
            get { return tenKS; }
            set { tenKS = value; }
        }
        public string TENPHONG
        {
            get { return tenPhong; }
            set { tenPhong = value; }
        }
        public string TENKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }
        public Room Phong
        {
            get { return phong; }
            set { phong = value; }
        }

        public KhachHang KhachHang 
        { 
            get { return this.kh; } 
            set { this.kh = value; }
        }

        public KHACHSAN KS
        {
            get { return this.ks; }
            set { this.ks = value; }
        }

        public DateTime NgayNhan
        {
            get { return this.ngayNhan;}
            set { this.ngayNhan = value;}
        }

        public DateTime NgayTra
        {
            get { return this.ngayTra;}
            set { this.ngayTra = value;}
        }

        public int SoPhong
        {
            get { return this.soPhong; }
            set { this.soPhong = value; }
        }

        public double TongThanhToan
        {
            get { return this.tongThanhToan; }
            set { this.tongThanhToan = value; }
        }

        public string TrangThai
        {
            get { return this.trangThai;}
            set { this.trangThai = value;}
        }

        public string MaHanhTrinh
        {
            get { return this.maHanhTrinh; }
            set { this.maHanhTrinh = value; }
        }
    }
}
