using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class KhachHang
    {
        int makh;
        string ten;
        string sdt;
        public KhachHang(int makh, string ten, string sdt)
        {
            this.makh = makh;
            this.ten = ten;
            this.sdt = sdt;
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

    }
}
