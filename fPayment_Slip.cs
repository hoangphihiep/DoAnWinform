using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;
namespace DuLich
{
    public partial class fPayment_Slip : Form
    {
        DatPhong datphong;
        public string tk;
        public string mk;
        public Image tenAnh;
        public string tenKhachSan;
        public string soKhach;
        public string soPhongConTrong;
        public string Gia;
        public string sdt;
        public string TenKhachHang;
        public DateTime NgayNhan;
        public DateTime NgayTra;
        KhachHang kh;
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
            lblHotelName.Text = datphong.KS.TENKS;
            lblHotelAddress.Text = datphong.KS.DIACHI;
            lblCheckIn.Text = datphong.NgayNhan.Date.ToString();
            lblCheckOut.Text = datphong.NgayTra.Date.ToString();
            lblRoomName.Text = datphong.Phong.TENPHONG.ToString();
            lblRoomCount.Text = datphong.SoPhong.ToString();
            lblCustomerCount.Text = datphong.Phong.SOKHACH.ToString();
            lblCustomerName.Text = datphong.KhachHang.Ten;
            lbl_soDT.Text = datphong.KhachHang.Sdt;
            lblPrice.Text = datphong.TongThanhToan.ToString();
            lblState.Text = datphong.TongThanhToan.ToString();
            lblMaHanhTrinh.Text = datphong.MaHanhTrinh.ToString();
            lbl_SDT2.Text = datphong.KhachHang.Sdt.ToString();
            MessageBox.Show(datphong.KhachHang.TENTAIKHOAN);
        }

        public void SetSDT(string Sdt)
        {
            sdt = Sdt;
            // Gọi lại phương thức load dữ liệu
            //fPayment_Slip_Load(this, EventArgs.Empty);
        }
        public void SetTenKhachHang(string tenKhachHang)
        {
            //TenKhachHang = tenKhachHang;
            // Gọi lại phương thức load dữ liệu
            //fPayment_Slip_Load(this, EventArgs.Empty);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Payment_Information f = new Payment_Information(datphong);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btn_BookNow_Click(object sender, EventArgs e)
        {

            datphong.TongThanhToan = float.Parse(lblPrice.Text);
            DatPhongDAO datPhongDAO = new DatPhongDAO();
            KhachHangDAO khachHangDAO = new KhachHangDAO();
            datPhongDAO.AddDatPhong(datphong);

            khachHangDAO.AddKhachHang(datphong.KhachHang);
            this.Close();
        }

        public DatPhong DP
        {
            get { return datphong; }
            set { datphong = value; }
        }

    }
}
