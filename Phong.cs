using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class Phong
    {
        public string TenPhong { get; set; }
        public int MaPhong { get; set; }
        public int SoKhach { get; set; }
        public int SoGiuong { get; set; }
        public int Gia {  get; set; }
        public int KichThuoc { get; set; }
        public string TaiKhoan { get; set; }
        public int GiaThemKhach { get; set; }
        public int MaKS {  get; set; }

        public Phong(int maPhong, int soKhach, int soGiuong, int gia, int kichThuoc, string taiKhoan, int giaThemKhach, int maKS)
        {
            MaPhong = maPhong;
            SoKhach = soKhach;
            SoGiuong = soGiuong;
            Gia = gia;
            KichThuoc = kichThuoc;
            TaiKhoan = taiKhoan;
            GiaThemKhach = giaThemKhach;
            MaKS = maKS;
        }

        public Phong(int maPhong, string tenphong, int soKhach, int soGiuong, int gia, int maKS)
        {
            MaPhong = maPhong;
            SoKhach = soKhach;
            SoGiuong = soGiuong;
            Gia = gia;
            MaKS = maKS;
            TenPhong = tenphong;
        }
    }
}
