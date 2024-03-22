using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class TienNghi
    {
        public int MAKS { get; set; }
        public string TK { get; set; }
        public int MAYLANH { get; set; }
        public int NHAHANG { get; set; }
        public int HOBOI { get; set; }
        public int LETAN24H { get; set; }
        public int WIFI { get; set; }
        public int QUAYLETAN { get; set; }
        public int DICHVUTHUDOINGOAITE { get; set; }
        public int DICHVUTIECCUOI { get; set; }
        public int DICHVUHOTRODATTOUR { get; set; }
        public int NHANVIENDANGONNGU { get; set; }
        public int BAIDAUXE { get; set; }
        public int TIEMCAFE { get; set; }
        public int THANGMAY { get; set; }
        public int QUAYBAR { get; set; }
        public int BUASANG { get; set; }
        public int QUAYBARBENHOBOI { get; set; }

        public TienNghi(int mAKS,string tk, int mAYLANH, int nHAHANG, int hOBOI, int lETAN24H, int wIFI, int qUAYLETAN, int dICHVUTHUDOINGOAITE, int dICHVUTIECCUOI, int dICHVUHOTRODATTOUR, int nHANVIENDANGONNGU, int bAIDAUXE, int tIEMCAFE, int tHANGMAY, int qUAYBAR, int bUASANG, int qUAYBARBENHOBOI)
        {
            MAKS = mAKS;
            TK = tk;
            MAYLANH = mAYLANH;
            NHAHANG = nHAHANG;
            HOBOI = hOBOI;
            LETAN24H = lETAN24H;
            WIFI = wIFI;
            QUAYLETAN = qUAYLETAN;
            DICHVUTHUDOINGOAITE = dICHVUTHUDOINGOAITE;
            DICHVUTIECCUOI = dICHVUTIECCUOI;
            DICHVUHOTRODATTOUR = dICHVUHOTRODATTOUR;
            NHANVIENDANGONNGU = nHANVIENDANGONNGU;
            BAIDAUXE = bAIDAUXE;
            TIEMCAFE = tIEMCAFE;
            THANGMAY = tHANGMAY;
            QUAYBAR = qUAYBAR;
            BUASANG = bUASANG;
            QUAYBARBENHOBOI = qUAYBARBENHOBOI;
        }
    }
}
