using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class QLPHONG
    {
        public int MAKS {  get; set; }
        public int SOPHONG { get; set; }
        public int SOPHONG_DD { get; set; }
        public int MAPHONG { get; set; }

        public QLPHONG(int mAKS, int sOPHONG, int sOPHONG_DD, int mAPHONG)
        {
            MAKS = mAKS;
            SOPHONG = sOPHONG;
            SOPHONG_DD = sOPHONG_DD;
            MAPHONG = mAPHONG;
        }
    }
}
