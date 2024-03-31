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
    public partial class fPayment_Slip : Form
    {
        DatPhong datphong;
        public fPayment_Slip()
        {
            InitializeComponent();
        }
        public fPayment_Slip(DatPhong datphong)
        {
            this.datphong = datphong;
            InitializeComponent();
        }

        private void fPayment_Slip_Load(object sender, EventArgs e)
        {
            lblHotelName.Text= datphong.KS.TENKS;
            lblHotelAddress.Text = datphong.KS.DIACHI;
            lblCheckIn.Text = datphong.NgayNhan.ToString();
            lblCheckOut.Text = datphong.NgayTra.ToString();
            lblRoomName.Text = datphong.Phong.ToString();
            lblRoomCount.Text = datphong.SoPhong.ToString();
            lblCustomerCount.Text = datphong.Phong.SoKhach.ToString();
            lblCustomerName.Text = datphong.KhachHang.Ten;
            lblPrice.Text = datphong.TongThanhToan.ToString();
            lblState.Text = datphong.TongThanhToan.ToString();
            lblMaHanhTrinh.Text = datphong.MaHanhTrinh.ToString();
        }

        void ChenDuLieuVaoBang()
        {
            string sqlString = string.Format("INSERT INTO ");
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Payment_Information f = new Payment_Information();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btn_BookNow_Click(object sender, EventArgs e)
        {

        }
    }
}
