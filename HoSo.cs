using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class HoSo
    {
        public int MAKS { get; set; }
        public string TK { get; set; }
        public string TENCHUKS { get; set; }
        public string SODIENTHOAI { get; set; }
        public string EMAIL { get; set; }
        public string DIACHI { get; set; }
        public string TENTHANHPHO { get; set; }
        public string TINH { get; set; }
        public int THEDIENTU { get; set; }
        public int NGANHANG { get; set; }

        public HoSo(int mAKS,string tk, string tENCHUKS, string sODIENTHOAI, string eMAIL, string dIACHI, string tENTHANHPHO, string tINH, int tHEDIENTU, int nGANHANG)
        {
            MAKS = mAKS;
            TK = tk;
            TENCHUKS = tENCHUKS;
            SODIENTHOAI = sODIENTHOAI;
            EMAIL = eMAIL;
            DIACHI = dIACHI;
            TENTHANHPHO = tENTHANHPHO;
            TINH = tINH;
            THEDIENTU = tHEDIENTU;
            NGANHANG = nGANHANG;
        }
    }
}
