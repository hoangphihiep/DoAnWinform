using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class DanhGia
    {
        string tenKH;
        int diem;
        string noidung;
        int maks;
        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }
        public int Diem
        {
            get { return diem; }
            set { diem = value; }
        }
        public int Maks
        {
            get { return maks; }
            set { maks = value; }
        }
        public string NoiDung
        {
            get { return noidung; }
            set { noidung = value; }
        }
        public DanhGia(string tenKH, int diem, string noidung, int maks)
        {
            this.tenKH = tenKH;
            this.diem = diem;
            this.noidung = noidung;
            this.maks = maks;
        }
    }
}
