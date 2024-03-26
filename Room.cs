﻿using System;
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

        public Room(int sOKHACH, int sOGIUONG, double gIA, string tENPHONG, int mAPHONG, string hinhAnh)
        {
            SOKHACH = sOKHACH;
            SOGIUONG = sOGIUONG;
            GIA = gIA;
            TENPHONG = tENPHONG;
            MAPHONG = mAPHONG;
            HinhAnh = hinhAnh;
        }
    }
}
