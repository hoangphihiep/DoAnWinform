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
    public partial class UCHuyphongCKS : UserControl
    {
        DatPhong dp;
        QL_HinhAnh QL_HinhAnh;
        int soLuongPhongTong;
        public UCHuyphongCKS(DatPhong dp)
        {
            InitializeComponent();
            this.dp = dp;
        }

        private void UCHuyphongCKS_Load(object sender, EventArgs e)
        {
            lblName.Text = dp.KS.TENKS;
            lblRoomName.Text = dp.Phong.TENPHONG.ToString();
            lblCheckIn.Text = dp.NgayNhan.Date.ToString();
            lblCheckOut.Text = dp.NgayTra.Date.ToString();
            lblCusName.Text = dp.KhachHang.Ten;
            lblSoPhong.Text = dp.SoPhong.ToString();
            lblPrice.Text = dp.TongThanhToan.ToString();
            lblAddress.Text = dp.KS.THANHPHO + ", " + dp.KS.TINH;
            ptbImage.Image = Image.FromFile(dp.Phong.HinhAnh.ToString());
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string sqlStr = "DELETE DATPHONG WHERE MADAT = @MADAT";
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    cmd.Parameters.AddWithValue("@MADAT", dp.MADAT);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            string sqlStr1 = "DELETE HUYPHONG WHERE MADAT = @MADAT";
            using (SqlConnection conn1 = Connection_to_SQL.getConnection())
            {
                conn1.Open();
                using (SqlCommand cmd1 = new SqlCommand(sqlStr1, conn1))
                {
                    cmd1.Parameters.AddWithValue("@MADAT", dp.MADAT);
                    cmd1.ExecuteNonQuery();
                }
                conn1.Close();
            }
            string sqlStr2 = "DELETE KHACHHANG WHERE MAKH = @MAKH";
            using (SqlConnection conn2 = Connection_to_SQL.getConnection())
            {
                conn2.Open();
                using (SqlCommand cmd2 = new SqlCommand(sqlStr2, conn2))
                {
                    cmd2.Parameters.AddWithValue("@MAKH", dp.KhachHang.MaKH);
                    cmd2.ExecuteNonQuery();
                }
              
                conn2.Close();
            }
            string sqlStr3 = "SELECT SOPHONG FROM QLPHONG WHERE MAPHONG = @MAPHONG";
            SqlConnection conn3 = Connection_to_SQL.getConnection();
            conn3.Open();
            SqlCommand command3 = new SqlCommand(sqlStr3, conn3);
            command3.Parameters.AddWithValue("@MAPHONG", dp.Phong.MAPHONG);
            SqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                int giaColumnIndex = reader3.GetOrdinal("SOPHONG");
                if (!reader3.IsDBNull(giaColumnIndex))
                {
                    soLuongPhongTong = reader3.GetInt32(giaColumnIndex);
                }
            }
            conn3.Close();
            string sqlStr4 = "UPDATE QLPHONG SET SOPHONG = @SOPHONG WHERE MAPHONG = @MAPHONG";
            using (SqlConnection conn4 = Connection_to_SQL.getConnection())
            {
                conn4.Open();
                using (SqlCommand cmd4 = new SqlCommand(sqlStr4, conn4))
                {
                    cmd4.Parameters.AddWithValue("@MAPHONG", dp.Phong.MAPHONG);
                    cmd4.Parameters.AddWithValue("@SOPHONG", soLuongPhongTong + dp.SoPhong);
                    cmd4.ExecuteNonQuery();
                }
                conn4.Close();
            }
        }
    }
}
