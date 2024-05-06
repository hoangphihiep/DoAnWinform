using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class TienNghiChinh
    {
        string tenTN;
        string hinhanh;
        public TienNghiChinh(string tenTN, string hinhanh)
        {
            this.tenTN = tenTN;
            this.hinhanh = hinhanh;
        }
        public string TenTN
        {
            get { return tenTN; }
            set { tenTN = value; }
        }
        public string HinhAnh
        {
            get { return hinhanh; }
            set { hinhanh = value; }
        }
    }
}
