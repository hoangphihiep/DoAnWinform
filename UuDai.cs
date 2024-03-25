using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class UuDai
    {
        public int MaKS { get; set; }
        public int MaUuDai { get; set; }
        public string TenUuDai { get; set; }
        public int GiaTriUuDai { get; set; }
        public string TK { get; set; }

        public UuDai(int maKS, int maUuDai, string tenUuDai, int giaTriUuDai, string tK)
        {
            MaKS = maKS;
            MaUuDai = maUuDai;
            TenUuDai = tenUuDai;
            GiaTriUuDai = giaTriUuDai;
            TK = tK;
        }
    }
}
