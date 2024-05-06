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
        Room phong;
        public UCPhongDaTraiNghiem(DatPhong dp)
        {
            InitializeComponent();
            this.dp = dp;
            this.phong = new Room_DAO().Get(dp.maphong);
            lbl_TenKhachSan.Text = dp.KS.TENKS;
            lbl_tenPhong.Text = phong.TENPHONG;
            lbl_diaChi.Text = dp.KS.THANHPHO + ", " + dp.KS.TINH + " Province ";
            lbl_soTien.Text = dp.TongThanhToan.ToString() + " VNĐ";
            lbl_soPhongDat.Text = dp.SoPhong.ToString() + " phòng, " + phong.SOKHACH.ToString() + " người";
            pB_anhPhong.Image = Image.FromFile(phong.HinhAnh);
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            this.Hide();
            FComment f = new FComment(dp);
            f.ShowDialog();
            this.Show();
        }
    }
}
