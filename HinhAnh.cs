using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class HinhAnh
    {
        public string TaiKhoan { get; set; }
        public int Phong {  get; set; }
        public string AnhBia { get; set; }
        public string Anh1 { get; set; }
        public string Anh2 { get; set; }
        public string Anh3 { get; set; }
        public string Anh4 { get; set; }
        public string Anh5 { get; set; }
        public string Anh6 { get; set; }

        public HinhAnh(string taiKhoan, int phong, string anhBia, string anh1, string anh2, string anh3, string anh4, string anh5, string anh6)
        {
            TaiKhoan = taiKhoan;
            Phong = phong;
            AnhBia = anhBia;
            Anh1 = anh1;
            Anh2 = anh2;
            Anh3 = anh3;
            Anh4 = anh4;
            Anh5 = anh5;
            Anh6 = anh6;
        }
    }
}
