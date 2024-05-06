using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class KhachHang
    {
        string tenTaiKhoan;
        public int makh { get; set; }
        string ten;
        string sdt;
        string gt;
        DateTime bdate;
        string gmail;
        string diachi;
        public KhachHang (string tenTaiKhoan)
        {
            this.tenTaiKhoan = tenTaiKhoan;
        }
        public KhachHang(int makh, string ten, string sdt, string gt, DateTime bdate, string gmail, string diachi)
        {
            this.makh = makh;
            this.ten = ten;
            this.sdt = sdt;
            this.bdate = bdate;
            this.gmail = gmail;
            this.diachi = diachi;
            this.gt = gt;
        }

        public KhachHang(string ten, string sdt, string gt, DateTime bdate, string gmail, string diachi, string tenTaiKhoan)
        {
            this.ten = ten;
            this.sdt = sdt;
            this.bdate = bdate;
            this.gmail = gmail;
            this.diachi = diachi;
            this.gt = gt;
            this.tenTaiKhoan = tenTaiKhoan;
        }

        public string TENTAIKHOAN
        {
            get { return tenTaiKhoan; }
            set { this.tenTaiKhoan = value; }
        }
        public int MaKH
        {
            get { return makh; }
            set { this.makh = value; } 
        }

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public string Sdt
        { 
            get { return sdt; } 
            set { sdt = value; } 
        }

        public string Gmail
        {
            get { return gmail; }
            set { gmail = value; }
        }

        public DateTime Bdate
        {
            get { return bdate; } 
            set {  bdate = value; } 
        }

        public string Gt
        {
            get { return gt; }
            set { gt = value; }
        }

        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }

    }
}
