using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class QL_HinhAnh
    {
        public int MAKS { get; set; }
        public string TENANH { get; set;}
        public string ADDRESS { get; set; }
        public int MAANH { get; set; }

        public QL_HinhAnh(int mAKS, string tENANH, string aDDRESS, int mAANH)
        {
            MAKS = mAKS;
            TENANH = tENANH;
            ADDRESS = aDDRESS;
            MAANH = mAANH;
        }
    }
}
