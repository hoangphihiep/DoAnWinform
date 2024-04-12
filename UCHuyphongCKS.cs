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
        DatPhong dp;
        QL_HinhAnh QL_HinhAnh;
        public UCHuyphongCKS(DatPhong dp)
        {
            InitializeComponent();
            this.dp = dp;
        }

        private void UCHuyphongCKS_Load(object sender, EventArgs e)
        {
            lblName.Text = dp.KS.TENKS;
            lblRoomName.Text = dp.Phong.TENPHONG;
            lblCheckIn.Text = dp.NgayNhan.Date.ToString();
            lblCheckOut.Text = dp.NgayTra.Date.ToString();
            lblAddress.Text = dp.KS.DIACHI;
            lblCusName.Text = dp.KhachHang.Ten;
            lblSoPhong.Text = dp.SoPhong.ToString();
            lblPrice.Text = dp.TongThanhToan.ToString();
            List<QL_HinhAnh> list = (new QL_HinhAnhDAO().Get(dp.KS.MAKS));
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
