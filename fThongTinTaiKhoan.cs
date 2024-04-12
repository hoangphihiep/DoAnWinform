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

namespace DuLich
{
    public partial class fThongTinTaiKhoan : Form
    {
        public string tentk;
        public string mk;
        // Khai báo danh sách để lưu các Mã phòng
        public List<int> maPhongList = new List<int>();
        public int index = 0;
        public fThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private void fThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            uPhong2.Size = new Size(1224, 801);
            uThongtin2.tentk = tentk;
            uThongtin2.mk = mk;
            uThongTinKhachSan1.SetTenTK(tentk);
            uThongtin1.tentk = tentk;
            uViTri1.SetTenTK(tentk);
            uHoSo1.SetTenTK(tentk);
            uMatKhau1.tentk = tentk;
            uUuDai1.tentk = tentk;
            uAnh1.tk = tentk;
            uAnh2.SetTenTK(tentk);
            uTienNghi1.SetTenTK(tentk);
            Modify modify = new Modify();
            string query = "Select * from KHACHSAN_THUOC_TAIKHOAN where TaiKhoan = '" + tentk + "' ";
            var result = modify.KhachSanThuocTaiKhoan(query);
            if (result.Count() > 0)
            {
                btn_ThongTinKhachSan.Visible = true;
                btn_ThongTinKhachSan.Visible = true;
                uUuDai1.SetTenTK(tentk); // Gán giá trị tentk vào UserControl UUuDai
            }
            // Tạo kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(Connection_to_SQL.getConnnection()))
            {
                // Mở kết nối
                connection.Open();

                // Chuỗi truy vấn SQL để lấy Mã phòng từ Tài khoản (TK)
                string query1 = "SELECT DISTINCT QLPHONG.MAPHONG " +
                               "FROM QLPHONG " +
                               "JOIN ThongTinCanBan ON QLPHONG.MAKS = ThongTinCanBan.MAKS " +
                               "WHERE ThongTinCanBan.TK = @TaiKhoan";

                // Tạo và thiết lập đối tượng SqlCommand
                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    // Thêm tham số cho truy vấn để tránh tình trạng SQL injection
                    command.Parameters.AddWithValue("@TaiKhoan", tentk);

                    // Thực thi truy vấn và đọc dữ liệu
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Đọc từng hàng dữ liệu và thêm Mã phòng vào danh sách
                        while (reader.Read())
                        {
                            int maPhong = reader.GetInt32(0);
                            maPhongList.Add(maPhong);
                        }
                    }
                }
            }
            uPhong2.Ktr(index, maPhongList);
            uPhong2.HienThi(index, maPhongList);
        }
        public void ShowQLHuy()
        {
            panel6.Visible = true;
            btn_QuanLyHuy.Visible = true;
        }
        public void HideQLHuy()
        {
            panel6.Visible = false;
        }
        public void ShowThongTinCanBan()
        {
            btn_ThongTingKS.Visible = true;
        }
        public void ShowViTri()
        {
            btn_ViTri.Visible = true;
        }
        public void ShowChiTietPhong()
        {
            btn_ChiTietPhong.Visible = true;
        }
        public void ShowAnh()
        {
            btn_Anh.Visible = true;
        }
        public void ShowHoSo()
        {
            btn_HoSo.Visible = true;
        }
        public void HideThongTinCanBan()
        {
            btn_ThongTingKS.Visible = false;
        }
        public void HideViTri()
        {
            btn_ViTri.Visible = false;
        }
        public void HideChiTietPhong()
        {
            btn_ChiTietPhong.Visible = false;
        }
        public void HideAnh()
        {
            btn_Anh.Visible = false;
        }
        public void HideHoSo()
        {
            btn_HoSo.Visible = false;
        }
        public void ShowThongTinKS()
        {
            btn_ThongTinKhachSan.Visible = true;
        }
        public void ShowUDai()
        {
            btn_UDai.Visible = true;
        }
        public void HideUDai()
        {
            btn_UDai.Visible = false;
        }
        public void HideTienNghi()
        {
            btn_TienNghi.Visible = false;
        }
        public void ShowTienNghi()
        {
            btn_TienNghi.Visible = true;
        }
        private void btn_ThongTin_Click(object sender, EventArgs e)
        {
            uThongtin2.BringToFront();
            panel6.Visible = false;
            panel6.SendToBack();
        }

        private void btn_MatKhau_Click(object sender, EventArgs e)
        {
            uMatKhau1.BringToFront();
            panel6.Visible = false;
            panel6.SendToBack();
        }

        private void btn_ThongTingKS_Click(object sender, EventArgs e)
        {
            uThongTinKhachSan1.BringToFront();
            panel6.Visible = false;
            panel6.SendToBack();
        }

        private void btn_ViTri_Click(object sender, EventArgs e)
        {
            uViTri1.BringToFront();
            panel6.Visible = false;
            panel6.SendToBack();
        }

        private void btn_ChiTietPhong_Click(object sender, EventArgs e)
        {
            uPhong2.BringToFront();
            panel6.Visible = false;
            panel6.SendToBack();
        }

        private void btn_Anh_Click(object sender, EventArgs e)
        {
            uAnh2.BringToFront();
            panel6.Visible = false;
            panel6.SendToBack();
        }

        private void btn_HoSo_Click(object sender, EventArgs e)
        {
            uHoSo1.BringToFront();
            panel6.Visible = false;
            panel6.SendToBack();
        }
        int dem = 0;
        private void btn_ThongTinKhachSan_Click(object sender, EventArgs e)
        {
            if (dem % 2 == 0)
            {
                ShowThongTinCanBan();
                ShowViTri();
                ShowChiTietPhong();
                ShowAnh();
                ShowHoSo();
                ShowUDai();
                ShowTienNghi();
                ShowQLHuy();
                dem++;
            }
            else
            {
                HideThongTinCanBan();
                HideViTri();
                HideChiTietPhong();
                HideAnh();
                HideHoSo();
                HideUDai();
                HideTienNghi();
                HideQLHuy();
                dem++;
            }
        }

        private void uThongtin2_Load(object sender, EventArgs e)
        {

        }

        private void btn_TienNghi_Click(object sender, EventArgs e)
        {
            uTienNghi1.BringToFront();
            panel6.Visible = false;
            panel6.SendToBack();
        }

        private void btn_UDai_Click(object sender, EventArgs e)
        {
            uUuDai1.BringToFront();
            panel6.Visible = false;
            panel6.SendToBack();
        }

        private void btn_QuanLyHuy_Click(object sender, EventArgs e)
        {
            panel6.BringToFront();
            panel6.Visible = true;
        }

        private void uChiTietPhongo1_Load(object sender, EventArgs e)
        {

        }
    }
}
