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
    public partial class UCHuyphongCKS : UserControl
    {
        KhachHang kh;
        KHACHSAN ks;
        Room phong;
        DatPhong dp;
        QL_HinhAnh QL_HinhAnh;
        public UCHuyphongCKS(KhachHang kh, KHACHSAN ks, Room phong)
        {
            InitializeComponent();
            this.kh = kh;
            this.ks = ks;
            this.phong = phong;
        }

        private void UCHuyphongCKS_Load(object sender, EventArgs e)
        {
            lblName.Text = ks.TENKS;
            lblCheckIn.Text = dp.NgayNhan.Date.ToString();
            lblCheckOut.Text = dp.NgayTra.Date.ToString();
            lblAddress.Text = ks.DIACHI;
            lblCusName.Text = kh.Ten;
            lblSoPhong.Text = dp.SoPhong.ToString();
            List<QL_HinhAnh> list = (new QL_HinhAnhDAO().Get(ks.MAKS));
            foreach (QL_HinhAnh anh in list)
            {
                if (anh.TENANH == "anh chinh")
                {
                    ptbImage.Image = Image.FromFile(anh.ADDRESS);
                }
            }
        }
    }
}
