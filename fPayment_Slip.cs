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
            ChenDuLieuVaoBang();
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
            
            try
            {
                string sqlString = string.Format("INSERT INTO DATPHONG (MAKS, CHECKIN, CHECKOUT, SOLUONG, MAPHONG, TENDANGNHAP, MAKH, THANHTOAN) VALUES ({0}, '{1}', '{2}', {3}, {4}, '{5}', {6}, {7})", datphong.KS.MAKS, datphong.NgayNhan, datphong.NgayTra, datphong.SoPhong, datphong.Phong.MaPhong, datphong.KhachHang.MaKH, datphong.TongThanhToan);
                SqlConnection conn = Connection_to_SQL.getConnection();
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
