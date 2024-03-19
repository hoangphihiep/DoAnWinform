using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class ThongTinCanBan
    {
        public int MAKS { get; set; }
        public string TK {  get; set; }
        public string TENKH { get; set; }
        public string MOTA { get; set; }
        public int? KCTHANHPHO { get; set; }
        public int? KCSANBAY { get; set; }
        public int SAO { get; set; }

        public ThongTinCanBan(int mAKS,string tk, string tENKH, string mOTA, int? kCTHANHPHO, int? kCSANBAY, int sAO)
        {
            MAKS = mAKS;
            TK = tk;
            TENKH = tENKH;
            MOTA = mOTA;
            KCTHANHPHO = kCTHANHPHO;
            KCSANBAY = kCSANBAY;
            SAO = sAO;
        }
    }
}
