using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class KhachSanThuocTaiKhoan
    {
        public string TaiKhoan { get;set; }
        public int MaKS { get; set; }

        public KhachSanThuocTaiKhoan(string taiKhoan, int maKS)
        {
            TaiKhoan = taiKhoan;
            MaKS = maKS;
        }
    }
}
