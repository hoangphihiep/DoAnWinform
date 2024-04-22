using System;
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
        public int maphong;
        public int makh;
        public int maks;
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
            this.phong = phong;
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
            this.phong = phong;
        }

        public DatPhong(int maDat, int makh, KHACHSAN ks, int maphong, DateTime ngayNhan, DateTime ngayTra, int soPhong, double tongThanhToan, string trangThai, string maHanhTrinh)
        {
            this.maDat = maDat;
            this.makh = makh;
            this.ks = ks;
            this.ngayNhan = ngayNhan;
            this.ngayTra = ngayTra;
            this.soPhong = soPhong;
            this.tongThanhToan = tongThanhToan;
            this.trangThai = trangThai;
            this.maHanhTrinh = maHanhTrinh;
            this.maphong = maphong;
        }

        public int MADAT
        {
            get { return maDat; }
            set { maDat = value; }  
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
