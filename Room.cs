using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class Room
    {
        public int SOKHACH {  get; set; }
        public int SOGIUONG { get; set; }
        public double GIA { get; set; }
        public string TENPHONG { get; set; }
        public int MAPHONG { get; set; }
        public string HinhAnh { get; set; }

<<<<<<< HEAD
        public int SOPHONGDD { get; set; }
        public int SOPHONG { get; set; }

        public Room(int sOKHACH, int sOGIUONG, double gIA, string tENPHONG, int mAPHONG)
=======
        public Room(int sOKHACH, int sOGIUONG, double gIA, string tENPHONG, int mAPHONG, string hinhAnh)
>>>>>>> 0315dd3d28401e5b819b232b419bdd5f62a7e14f
        {
            SOKHACH = sOKHACH;
            SOGIUONG = sOGIUONG;
            GIA = gIA;
            TENPHONG = tENPHONG;
            MAPHONG = mAPHONG;
            HinhAnh = hinhAnh;
        }

        public Room(int sOKHACH, int sOGIUONG, double gIA, string tENPHONG, int mAPHONG, int sophong, int sophongdd)
        {
            SOKHACH = sOKHACH;
            SOGIUONG = sOGIUONG;
            GIA = gIA;
            TENPHONG = tENPHONG;
            MAPHONG = mAPHONG;
            SOPHONG= sophong;
            SOPHONGDD = sophongdd;
        }
    }
}

