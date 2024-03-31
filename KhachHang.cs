using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class KhachHang
    {
        string ten;
        string sdt;
        public KhachHang(string ten, string sdt)
        {
            this.ten = ten;
            this.sdt = sdt;
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
