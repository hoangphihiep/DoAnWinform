using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DuLich
{
    public partial class UPhongDaDat : UserControl
    {
        DatPhong dp;
        public UPhongDaDat(DatPhong dp)
        {
            InitializeComponent();
            this.dp = dp;
            lbl_TenKhachSan.Text = dp.KS.TENKS;
            lbl_tenPhong.Text = dp.Phong.TENPHONG;
            lbl_diaChi.Text = dp.KS.THANHPHO + ", " + dp.KS.TINH + " Province ";
            lbl_soTien.Text = dp.TongThanhToan.ToString() + " VNĐ";
            lbl_soPhongDat.Text = dp.SoPhong.ToString() + " phòng, " + dp.Phong.SOKHACH.ToString() + " người";
            pB_anhPhong.Image = Image.FromFile(new SupFHotelBooked().AnhPhong(dp.Phong.MAPHONG));
            lbl_thoiGianDen.Text = dp.NgayNhan.ToString();
            if (dp.NgayNhan < DateTime.Now)
                lbl_thoiGianConLai.Text = "Đang trải nghiệm";
            else
            {
                int thoiGian = Int32.Parse((dp.NgayNhan - DateTime.Now).Days.ToString());
                lbl_thoiGianConLai.Text = "Thời gian còn lại: " + thoiGian.ToString() + " ngày";
            }
        }
        private void UPhongDaDat_Load(object sender, EventArgs e)
        {
            this.Size = new Size(793, 199);
            pB_anhPhong.Size = new Size(207, 171);
            pB_anhPhong.Location = new Point(3, 14);
            lbl_TenKhachSan.Size = new Size(326, 28);
            lbl_TenKhachSan.Location = new Point(233, 22);
            lbl_tenPhong.Size = new Size(326, 28);
            lbl_tenPhong.Location = new Point(233, 50);
            lbl_thoiGianDen.Size = new Size(179, 20);
            lbl_thoiGianDen.Location = new Point(238, 87);
            label24.Size = new Size(69, 20);
            label24.Location = new Point(235, 107);
            lbl_danhGia.Size = new Size(55, 20);
            lbl_danhGia.Location = new Point(310, 107);
            lbl_diaChi.Size = new Size(217, 20);
            lbl_diaChi.Location = new Point(233, 127);
            lbl_soTien.Size = new Size(132, 23);
            lbl_soTien.Location = new Point(233, 154);
            lbl_soPhongDat.Size = new Size(193, 20);
            lbl_soPhongDat.Location = new Point(366, 154);
            lbl_thoiGianConLai.Size = new Size(182, 20);
            lbl_thoiGianConLai.Location = new Point(605, 22);
            btn_huyDat.Size = new Size(134, 34);
            btn_huyDat.Location = new Point(648, 154);
        }
        private void lbl_TenKhachSan_Click(object sender, EventArgs e)
        {

        }
        private void btn_huyDat_Click(object sender, EventArgs e)
        {
            btn_huyDat.Text = "Đang chờ xử lý";
            SqlConnection conn = Connection_to_SQL.getConnection();
            try
            {
                conn.Open();
                string sqlString = "INSERT INTO HUYPHONG (MADAT,TRANGTHAI) VALUES (@madat,@trangthai)";
                using (SqlCommand cmd = new SqlCommand(sqlString, conn))
                {
                    cmd.Parameters.AddWithValue("@madat", dp.MADAT);
                    cmd.Parameters.AddWithValue("@trangthai", "Chưa đặt");
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
