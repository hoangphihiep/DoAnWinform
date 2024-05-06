using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class HuyPhong
    {
        int madat;
        string trangthai;
        public HuyPhong(int madat, string trangthai)
        {
            this.madat = madat;
            this.trangthai = trangthai;
        }

        public int MaDat
        {
            get { return madat; }
            set { madat = value; }
        }

        public string TrangThai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }

    }
}
