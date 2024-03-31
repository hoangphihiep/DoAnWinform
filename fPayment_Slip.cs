using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
<<<<<<< HEAD
        DatPhong datphong;
=======
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
>>>>>>> b2ef75ac2af6db1e301d1fd6d64be76a097b8cb9
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
<<<<<<< HEAD
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
=======
            label11.Text = tenKhachSan;
            //Diachi ????
            label14.Text = sdt;
            label4.Text = TenKhachHang;
            label6.Text = sdt;
            label25.Text = soKhach;
            label27.Text = Gia;
            pictureBox1.Image = tenAnh;

            int ngayNhan = NgayNhan.Day;
            int thangNhan = NgayNhan.Month;
            int namNhan = NgayNhan.Year;

            // Tạo một đối tượng DateTime chỉ chứa ngày tháng năm
            DateTime ngayThangNamNhan = new DateTime(namNhan, thangNhan, ngayNhan);
            label18.Text = ngayThangNamNhan.ToString();


            int ngayTra = NgayTra.Day;
            int thangTra = NgayTra.Month;
            int namTra = NgayTra.Year;

            // Tạo một đối tượng DateTime chỉ chứa ngày tháng năm
            DateTime ngayThangNamTra = new DateTime(namTra, thangTra, ngayTra);
            label19.Text = ngayThangNamTra.ToString();
        }
        public void SetSDT(string Sdt)
        {
            sdt = Sdt;
            // Gọi lại phương thức load dữ liệu
            fPayment_Slip_Load(this, EventArgs.Empty);
        }
        public void SetTenKhachHang(string tenKhachHang)
        {
            TenKhachHang = tenKhachHang;
            // Gọi lại phương thức load dữ liệu
            fPayment_Slip_Load(this, EventArgs.Empty);
>>>>>>> b2ef75ac2af6db1e301d1fd6d64be76a097b8cb9
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
