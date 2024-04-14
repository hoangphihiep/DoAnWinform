using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class PhongDaDat
    {
        public int maDat { get; set; }
        public int maks {get; set;}
        public int maPhong { get; set; }
        public string tenPhong { get; set; }
        public string  tenKS { get; set; }
        public string tenTinh { get; set; }
        public string tenTP { get; set; }
        public string diaChi { get; set; }
        public int soLuongPhong { get; set; }
        public double tienThanhToan { get; set; }
        public string anhPhong { get; set; }
        public int soKhach { get; set; }
        public DateTime ngayDen { get; set; }
        public DateTime ngayDi { get; set; }
        public PhongDaDat (int madat, int maks, int maPhong, string tenPhong, string tenKS, string tenTinh, string tenTP, string diaChi, int soLuongPhong, double tienThanhToan, string anhPhong,int soKhach, DateTime ngayDen,  DateTime ngayDi)
        {
            this.maDat = madat;
            this.maks = maks;
            this.maPhong = maPhong;
            this.tenPhong = tenPhong;
            this.tenKS = tenKS;
            this.tenTinh = tenTinh;
            this.tenTP = tenTP;
            this.diaChi = diaChi;
            this.soLuongPhong = soLuongPhong;
            this.tienThanhToan = tienThanhToan;
            this.anhPhong = anhPhong;
            this.soKhach = soKhach;
            this.ngayDen = ngayDen;
            this.ngayDi = ngayDi;
        }
    }
}
