using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuLich
{
    public partial class FComment : Form
    {
        DatPhong dp;
        public FComment(DatPhong dp)
        {
            InitializeComponent();
            this.dp = dp;
        }

        private void btn_NhanXet_Click(object sender, EventArgs e)
        {
            int diem = Int32.Parse(nUDDiemDG.Text);
            KhachHang kh = new KhachHangDAO().Get(dp.MAKH);
            string tenkh = kh.Ten;
            string noidung = txbDanhGia.Text;
            int maks = dp.KS.MAKS;
            DanhGia dg = new DanhGia(tenkh, diem, noidung, maks);
            DanhGiaDAO dgDAO = new DanhGiaDAO();
            dgDAO.Add(dg);
            this.Close();
        }
    }
}
