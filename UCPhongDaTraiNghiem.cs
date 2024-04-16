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
    public partial class UCPhongDaTraiNghiem : UserControl
    {
        DatPhong dp;
        public UCPhongDaTraiNghiem(DatPhong dp)
        {
            InitializeComponent();
            this.dp = dp;
            this.dp = dp;
            lbl_TenKhachSan.Text = dp.KS.TENKS;
            lbl_tenPhong.Text = dp.Phong.TENPHONG;
            lbl_diaChi.Text = dp.KS.THANHPHO + ", " + dp.KS.TINH + " Province ";
            lbl_soTien.Text = dp.TongThanhToan.ToString() + " VNĐ";
            lbl_soPhongDat.Text = dp.SoPhong.ToString() + " phòng, " + dp.Phong.SOKHACH.ToString() + " người";
            pB_anhPhong.Image = Image.FromFile(new SupFHotelBooked().AnhPhong(dp.Phong.MAPHONG));
        }

    }
}
