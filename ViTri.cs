using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class ViTri
    {
        public int MAKS { get; set; }
        public string TK { get; set; }
        public string DIACHI { get; set; }
        public string TENTHANHPHO { get; set; }
        public string TINH { get; set; }

        public ViTri(int mAKS,string tk, string dIACHI, string tENTHANHPHO, string tINH)
        {
            MAKS = mAKS;
            TK = tk;
            DIACHI = dIACHI;
            TENTHANHPHO = tENTHANHPHO;
            TINH = tINH;
        }
    }
}
