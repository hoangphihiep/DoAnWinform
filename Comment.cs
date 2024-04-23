using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class Comment
    {
        int maks;
        string tenkh;
        int diem;
        string noidung;
        public Comment(string tenkh, int diem, string noidung)
        {
            this.tenkh = tenkh;
            this.diem = diem;
            this.noidung = noidung;
        }

        public Comment(int maks, string tenkh, int diem, string noidung)
        {
            this.tenkh = tenkh;
            this.diem = diem;
            this.noidung = noidung;
            this.maks = maks;
        }

        public string Tenkh
        {
            get { return tenkh; }
            set { tenkh = value; }
        }
        public int Diem
        {
            get { return diem; }
            set { diem = value; }
        }

        public int MaKS
        {
            get { return maks; }
            set { maks = value; }
        }

        public string NoiDung
        {
            get { return noidung; }
            set { noidung = value; }
        }
    }
}
