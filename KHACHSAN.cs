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
        public double DANHGIA { get; set; }
        public double GIA { get; set; }
        public string DIACHI { get; set; }
        public int MAKS { get; set; }

        public KHACHSAN(string tENKS, string tINH, string tHANHPHO, int sAO, double dANHGIA, double gIA, string dIACHI, int mAKS)
        {
            TENKS = tENKS;
            TINH = tINH;
            THANHPHO = tHANHPHO;
            SAO = sAO;
            DANHGIA = dANHGIA;
            GIA = gIA;
            DIACHI = dIACHI;
            MAKS = mAKS;
        }
    }
}
