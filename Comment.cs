using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class Comment
    {
        string tenkh;
        int diem;
        string noidung;
        public Comment(string tenkh, int diem, string noidung)
        {
            this.tenkh = tenkh;
            this.diem = diem;
            this.noidung = noidung;
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
        public string NoiDung
        {
            get { return noidung; }
            set { noidung = value; }
        }
    }
}
