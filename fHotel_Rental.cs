﻿using DoAnDuLich;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace DuLich
{
    public partial class fHotel_Rental : Form
    {
        public int MaAnh;
        public int MaPhong = 1;
        public string tk;
        public string mk;
        public int MaKhachSan;
        public string AnhBia;
        public string AnhChinh;
        public string Anh1;
        public string Anh2;
        public string Anh3;
        public string Anh4;
        public string Anh5;
        public string Anh6;

        List<Phong> Phongs = new List<Phong>();
        public fHotel_Rental()
        {
            InitializeComponent();

        }
        public int kiemtratrang7;
        void DeleteColor()
        {
            label_ThongTin.ForeColor = Color.Black;
            label32.ForeColor = Color.Black;
            label30.ForeColor = Color.Black;
            label33.ForeColor = Color.Black;
            lbl_Ho.ForeColor = Color.Black;
        }
        public List<string> LayCacMucDaChon(CheckedListBox checkedListBox)
        {
            // List để lưu trữ các mục đã chọn
            List<string> cacMucDaChon = new List<string>();

            // Lặp qua tất cả các mục trong CheckedListBox
            foreach (var item in checkedListBox.CheckedItems)
            {
                // Chuyển đổi item sang dạng string
                string mucDaChon = item.ToString();

                // Thêm vào List nếu mục đã được chọn
                cacMucDaChon.Add(mucDaChon);
            }
            return cacMucDaChon;
        }

        private void btn_TiepTheo_Click(object sender, EventArgs e)
        {
        }

        private void pn_ThongTin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fHotel_Rental_Load(object sender, EventArgs e)
        {
            string query1 = string.Format("SELECT MAX(MAKS) as maxKS FROM KHACHSAN_THUOC_TAIKHOAN");
            SqlConnection conn1 = Connection_to_SQL.getConnection();
            conn1.Open();
            SqlCommand command1 = new SqlCommand(query1, conn1);
            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                int giaColumnIndex = reader1.GetOrdinal("maxKS");
                if (!reader1.IsDBNull(giaColumnIndex))
                {
                    MaKhachSan = reader1.GetInt32(giaColumnIndex) + 1;
                }
            }
            conn1.Close();
            string query = string.Format("SELECT MAX(MAPHONG) as maxPhong FROM PHONG");
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            UPhong uPhong = new UPhong();
            while (reader.Read())
            {
                int giaColumnIndex = reader.GetOrdinal("maxPhong");
                if (!reader.IsDBNull(giaColumnIndex))
                {
                    int maPhong2 = reader.GetInt32(giaColumnIndex) + 1;
                    uPhong.MaPhong = maPhong2;
                }
            }
            conn.Close();
            TabPage tabPage1 = tab_ChiTietPhongO.TabPages[0];
            uPhong.Size = tabPage1.Size;
            uPhong.MaKS = MaKhachSan;
            uPhong.taikhoan = tk;
            tabPage1.Controls.Add(uPhong);
            uPhong.BringToFront();
        }

        private void lbl_ThongTin_Click(object sender, EventArgs e)
        {
            DeleteColor();
            pn_Goc.VerticalScroll.Value = 0;
        }

        private void label32_Click(object sender, EventArgs e)
        {
            DeleteColor();
            pn_Goc.VerticalScroll.Value = 537;
        }

        private void label30_Click(object sender, EventArgs e)
        {
            DeleteColor();
            pn_Goc.VerticalScroll.Value = 924;
        }

        private void label33_Click(object sender, EventArgs e)
        {
            DeleteColor();
            pn_Goc.VerticalScroll.Value = 1501;
        }

        private void label34_Click(object sender, EventArgs e)
        {
            DeleteColor();
            pn_Goc.VerticalScroll.Value = 1787;
        }

        private void label35_Click(object sender, EventArgs e)
        {
            DeleteColor();
            pn_Goc.VerticalScroll.Value = 3000;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tab_ChiTietPhongO_MouseClick(object sender, MouseEventArgs e)
        {
            var lastIndex = this.tab_ChiTietPhongO.TabCount - 1;
            if (this.tab_ChiTietPhongO.GetTabRect(lastIndex).Contains(e.Location))
            {
                MaPhong++;
                this.tab_ChiTietPhongO.TabPages.Insert(lastIndex, "Phòng " + MaPhong);
                string query = string.Format("SELECT MAX(MAPHONG) as maxPhong FROM PHONG");
                SqlConnection conn = Connection_to_SQL.getConnection();
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                UPhong uPhong = new UPhong();
                while (reader.Read())
                {
                    int giaColumnIndex = reader.GetOrdinal("maxPhong");
                    if (!reader.IsDBNull(giaColumnIndex))
                    {
                        int maPhong2 = reader.GetInt32(giaColumnIndex) + 1;
                        MessageBox.Show(maPhong2.ToString());
                        uPhong.MaPhong = maPhong2;
                    }
                }
                conn.Close();
                this.tab_ChiTietPhongO.SelectedIndex = lastIndex;
                
                uPhong.phong = MaPhong;
                uPhong.taikhoan = tk;
                uPhong.MaKS = MaKhachSan;
                uPhong.SetMaKS(MaKhachSan);
                

                //Phongs.Add(new Phong(uPhong.));
                TabPage tabPage1 = tab_ChiTietPhongO.TabPages[MaPhong - 1];
                uPhong.Size = tabPage1.Size;
                tabPage1.Controls.Add(uPhong);
                uPhong.BringToFront();
            }
        }

        private void tab_ChiTietPhongO_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void tab_ChiTietPhongO_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == this.tab_ChiTietPhongO.TabCount - 1)
                e.Cancel = true;
        }
        byte[] ImageToByterArray(Image image)
        {
            MemoryStream m = new MemoryStream();
            image.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_TiepTheo_Click_1(object sender, EventArgs e)
        {

            string query1 = string.Format("SELECT MAX(MAKS) as maxKS FROM KHACHSAN_THUOC_TAIKHOAN");
            SqlConnection conn1 = Connection_to_SQL.getConnection();
            conn1.Open();
            SqlCommand command1 = new SqlCommand(query1, conn1);
            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                int giaColumnIndex = reader1.GetOrdinal("maxKS");
                if (!reader1.IsDBNull(giaColumnIndex))
                {
                    MaKhachSan = reader1.GetInt32(giaColumnIndex) + 1;
                }
            }

            //Khởi tạo đối tượng
            KhachSanThuocTaiKhoan khachSanThuocTaiKhoan = new KhachSanThuocTaiKhoan(tk, MaKhachSan);
            ThongTinCanBan thongTinCanBan = new ThongTinCanBan(MaKhachSan, tk, txt_DatTen.Text, txt_MoTa.Text, int.Parse(txt_KhoangCachSanBay.Text), int.Parse(txt_KhoangCachThanhPho.Text), int.Parse(cbb_DanhGiaSao.Text), AnhBia);
            ViTri viTri = new ViTri(MaKhachSan, tk, txt_DiaChi.Text, cbb_TenThanhPho.Text, cbb_Tinh.Text);
            // Chuyển các giá trị bool thành giá trị int
            int tienNghiChinh0 = clb_TienNghiChinh.GetItemChecked(0) ? 1 : 0;
            int tienNghiChinh1 = clb_TienNghiChinh.GetItemChecked(1) ? 1 : 0;
            int tienNghiChinh2 = clb_TienNghiChinh.GetItemChecked(2) ? 1 : 0;
            int tienNghiChinh3 = clb_TienNghiChinh.GetItemChecked(3) ? 1 : 0;
            int tienNghiChinh4 = clb_TienNghiChinh.GetItemChecked(4) ? 1 : 0;

            int dichVuKhachSan0 = clb_DichVuKhachSan.GetItemChecked(0) ? 1 : 0;
            int dichVuKhachSan1 = clb_DichVuKhachSan.GetItemChecked(1) ? 1 : 0;
            int dichVuKhachSan2 = clb_DichVuKhachSan.GetItemChecked(2) ? 1 : 0;
            int dichVuKhachSan3 = clb_DichVuKhachSan.GetItemChecked(3) ? 1 : 0;
            int dichVuKhachSan4 = clb_DichVuKhachSan.GetItemChecked(4) ? 1 : 0;

            int tienNghiCongCong0 = clb_TienNghiCongCong.GetItemChecked(0) ? 1 : 0;
            int tienNghiCongCong1 = clb_TienNghiCongCong.GetItemChecked(1) ? 1 : 0;
            int tienNghiCongCong2 = clb_TienNghiCongCong.GetItemChecked(2) ? 1 : 0;

            int amThuc0 = clb_AmThuc.GetItemChecked(0) ? 1 : 0;
            int amThuc1 = clb_AmThuc.GetItemChecked(1) ? 1 : 0;
            int amThuc2 = clb_AmThuc.GetItemChecked(2) ? 1 : 0;

            // Tạo đối tượng TienNghi và HoSo sử dụng các giá trị int đã chuyển đổi
            TienNghi tienNghi = new TienNghi(MaKhachSan, tk, tienNghiChinh0, tienNghiChinh1, tienNghiChinh2, tienNghiChinh3, tienNghiChinh4,
                            dichVuKhachSan0, dichVuKhachSan1, dichVuKhachSan2, dichVuKhachSan3, dichVuKhachSan4,
                            tienNghiCongCong0, tienNghiCongCong1, tienNghiCongCong2,
                            amThuc0, amThuc1, amThuc2);
            //Add data vao QL_TN
            QL_TN_DAO ql_TN_DAO = new QL_TN_DAO();
            List<QL_TN> QL_TNs = new List<QL_TN>();
            if (tienNghiChinh0 == 1)
            {
                QL_TNs.Add(new QL_TN(MaKhachSan, 1));
            }
            if (tienNghiChinh1 == 1)
            {
                QL_TNs.Add(new QL_TN(MaKhachSan, 2));
            }
            if (tienNghiChinh2 == 1)
            {
                QL_TNs.Add(new QL_TN(MaKhachSan, 3));
            }
            if (tienNghiChinh3 == 1)
            {
                QL_TNs.Add(new QL_TN(MaKhachSan, 4));
            }
            if (tienNghiChinh4 == 1)
            {
                QL_TNs.Add(new QL_TN(MaKhachSan, 5));
            }
            if (dichVuKhachSan0 == 1)
            {
                QL_TNs.Add(new QL_TN(MaKhachSan, 6));
            }
            if (dichVuKhachSan1 == 1)
            {
                QL_TNs.Add(new QL_TN(MaKhachSan, 7));
            }
            if (dichVuKhachSan2 == 1)
            {
                QL_TNs.Add(new QL_TN(MaKhachSan, 8));
            }
            if (dichVuKhachSan3 == 1)
            {
                QL_TNs.Add(new QL_TN(MaKhachSan, 9));
            }
            if (dichVuKhachSan4 == 1)
            {
                QL_TNs.Add(new QL_TN(MaKhachSan, 10));
            }
            if (tienNghiCongCong0 == 1)
            {
                QL_TNs.Add(new QL_TN(MaKhachSan, 11));
            }
            if (tienNghiCongCong1 == 1)
            {
                QL_TNs.Add(new QL_TN(MaKhachSan, 12));
            }
            if (tienNghiCongCong2 == 1)
            {
                QL_TNs.Add(new QL_TN(MaKhachSan, 13));
            }
            if (amThuc0 == 1)
            {
                QL_TNs.Add(new QL_TN(MaKhachSan, 14));
            }
            if (amThuc1 == 1)
            {
                QL_TNs.Add(new QL_TN(MaKhachSan, 15));
            }
            if (amThuc2 == 1)
            {
                QL_TNs.Add(new QL_TN(MaKhachSan, 16));
            }
            foreach (var i in QL_TNs)
            {
                ql_TN_DAO.Add(i, "QL_TN");
            }
            QL_HinhAnhDAO qL_HinhAnhDAO = new QL_HinhAnhDAO();
            qL_HinhAnhDAO.Add(new QL_HinhAnh(MaKhachSan, "anh chinh", AnhBia, MaAnh), "QL_ANH");
            qL_HinhAnhDAO.Add(new QL_HinhAnh(MaKhachSan, "Anh total", AnhChinh, MaAnh), "QL_ANH");
            qL_HinhAnhDAO.Add(new QL_HinhAnh(MaKhachSan, "Anh total", Anh1, MaAnh), "QL_ANH");
            qL_HinhAnhDAO.Add(new QL_HinhAnh(MaKhachSan, "Anh total", Anh2, MaAnh), "QL_ANH");
            qL_HinhAnhDAO.Add(new QL_HinhAnh(MaKhachSan, "Anh total", Anh3, MaAnh), "QL_ANH");
            qL_HinhAnhDAO.Add(new QL_HinhAnh(MaKhachSan, "Anh total", Anh4, MaAnh), "QL_ANH");
            qL_HinhAnhDAO.Add(new QL_HinhAnh(MaKhachSan, "Anh total", Anh5, MaAnh), "QL_ANH");
            qL_HinhAnhDAO.Add(new QL_HinhAnh(MaKhachSan, "Anh total", Anh6, MaAnh), "QL_ANH");
            //Tao Doi Tuong KHACHSAN tu THONGTINCANBAN VA VITRI (Chua co Danh gia , Gia)
            /*KHACHSAN_DAO ksDao = new KHACHSAN_DAO();
            KHACHSAN ks = new KHACHSAN(thongTinCanBan.TENKH, viTri.TINH, viTri.TENTHANHPHO, thongTinCanBan.SAO, thongTinCanBan.SAO, thongTinCanBan.SAO, viTri.DIACHI, thongTinCanBan.MAKS);
            ksDao.Add(ks, "KHACHSAN");*/

            // Chuyển các giá trị bool thành giá trị int
            int thanhToan0 = clb_ThanhToan.GetItemChecked(0) ? 1 : 0;
            int thanhToan1 = clb_ThanhToan.GetItemChecked(1) ? 1 : 0;

            // Tạo đối tượng HoSo sử dụng các giá trị int đã chuyển đổi
            HoSo hoSo = new HoSo(MaKhachSan, tk, txt_TenChuKhachSan.Text, txt_SoDienThoai.Text, txt_Email.Text, txt_DiaChi2.Text, cbb_ThanhPho.Text, cbb_Tinh2.Text, thanhToan0, thanhToan1);

            //Tạo đối tượng DAO
            KhachSanThuocTaiKhoanDAO khachSanThuocTaiKhoanDAO = new KhachSanThuocTaiKhoanDAO();
            ThongTinCanBanDAO thongTinCanBanDAO = new ThongTinCanBanDAO();
            ViTriDao viTriDao = new ViTriDao();
            TienNghiDAO tienNghiDAO = new TienNghiDAO();
            HoSoDAO hoSoDAO = new HoSoDAO();
            PhongDAO phongDAO = new PhongDAO();

            //Truyền đối tượng nào hàm DAO đẻ add vào SQL
            khachSanThuocTaiKhoanDAO.Add(khachSanThuocTaiKhoan, "KHACHSAN_THUOC_TAIKHOAN");
            thongTinCanBanDAO.Add(thongTinCanBan, "ThongTinCanBan");
            viTriDao.Add(viTri, "ViTri");
            tienNghiDAO.Add(tienNghi, "TIENNGHI");
            hoSoDAO.Add(hoSo, "HOSO");
            //while (true)
            //{
            //    //query = "Select * from PHONG where TaiKhoan = '" + tk + "' and MaKS = '" + MaKhachSan + "' and MAPHONG = '" + MaPhong + "' ";
            //    //var result = modify.Phong(query);
            //    //if (result.Count() > 0)
            //    //    MaPhong++;
            //    //else
            //        break;
            //}
            foreach (Phong phong in Phongs)
            {
                phongDAO.Add(phong, "PHONG");
            }

            MessageBox.Show("Đăng tải hoàn tất ");
        }



        private void label4_Click(object sender, EventArgs e)
        {
            DeleteColor();
            pn_Goc.VerticalScroll.Value = 2719;
        }

        private void ptb_AnhBia_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images (*.jpg, *.jpeg, *.png) | *.jpg;*.jpeg;*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = dialog.FileName;

                // Tạo thư mục "hinhanh" nếu nó không tồn tại (tùy chọn)
                string targetDirectory = Path.Combine(Application.StartupPath, "hinhanh");
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                try
                {
                    string targetPath = Path.Combine(targetDirectory, Path.GetFileName(imagePath));
                    File.Copy(imagePath, targetPath, true);  // Ghi đè lên các tệp hiện có

                    // Hiển thị ảnh trong PictureBox
                    ptb_AnhBia.Image = Image.FromFile(targetPath);
                    ptb_AnhBia.SizeMode = PictureBoxSizeMode.Zoom;

                    //tạo đối tượng
                    AnhBia = targetPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            pn_Goc.VerticalScroll.Value = 1501;
        }

        private void btn_ThemAnh_Click(object sender, EventArgs e)
        {
            ptb_AnhBia.Visible = true;
            ptb_AnhChinh.Visible = true;
            ptb_Anh1.Visible = true;
            ptb_Anh2.Visible = true;
            ptb_Anh3.Visible = true;
            ptb_Anh4.Visible = true;
            ptb_Anh5.Visible = true;
            ptb_Anh6.Visible = true;
            btn_ThemAnh.Visible = false;
            pn_Goc.VerticalScroll.Value = 1501;
        }

        private void ptb_AnhChinh_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images (*.jpg, *.jpeg, *.png) | *.jpg;*.jpeg;*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = dialog.FileName;

                // Tạo thư mục "hinhanh" nếu nó không tồn tại (tùy chọn)
                string targetDirectory = Path.Combine(Application.StartupPath, "hinhanh");
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                try
                {
                    string targetPath = Path.Combine(targetDirectory, Path.GetFileName(imagePath));
                    File.Copy(imagePath, targetPath, true);  // Ghi đè lên các tệp hiện có

                    // Hiển thị ảnh trong PictureBox
                    ptb_AnhChinh.Image = Image.FromFile(targetPath);
                    ptb_AnhChinh.SizeMode = PictureBoxSizeMode.Zoom;

                    //tạo đối tượng
                    AnhChinh = targetPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            pn_Goc.VerticalScroll.Value = 1501;
        }

        private void ptb_Anh1_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images (*.jpg, *.jpeg, *.png) | *.jpg;*.jpeg;*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = dialog.FileName;

                // Tạo thư mục "hinhanh" nếu nó không tồn tại (tùy chọn)
                string targetDirectory = Path.Combine(Application.StartupPath, "hinhanh");
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                try
                {
                    string targetPath = Path.Combine(targetDirectory, Path.GetFileName(imagePath));
                    File.Copy(imagePath, targetPath, true);  // Ghi đè lên các tệp hiện có

                    // Hiển thị ảnh trong PictureBox
                    ptb_Anh1.Image = Image.FromFile(targetPath);
                    ptb_Anh1.SizeMode = PictureBoxSizeMode.Zoom;

                    //tạo đối tượng
                    Anh1 = targetPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            pn_Goc.VerticalScroll.Value = 1501;
        }

        private void ptb_Anh2_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images (*.jpg, *.jpeg, *.png) | *.jpg;*.jpeg;*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = dialog.FileName;

                // Tạo thư mục "hinhanh" nếu nó không tồn tại (tùy chọn)
                string targetDirectory = Path.Combine(Application.StartupPath, "hinhanh");
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                try
                {
                    string targetPath = Path.Combine(targetDirectory, Path.GetFileName(imagePath));
                    File.Copy(imagePath, targetPath, true);  // Ghi đè lên các tệp hiện có

                    // Hiển thị ảnh trong PictureBox
                    ptb_Anh2.Image = Image.FromFile(targetPath);
                    ptb_Anh2.SizeMode = PictureBoxSizeMode.Zoom;

                    //tạo đối tượng
                    Anh2 = targetPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                pn_Goc.VerticalScroll.Value = 1501;
            }
        }

        private void ptb_Anh3_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images (*.jpg, *.jpeg, *.png) | *.jpg;*.jpeg;*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = dialog.FileName;

                // Tạo thư mục "hinhanh" nếu nó không tồn tại (tùy chọn)
                string targetDirectory = Path.Combine(Application.StartupPath, "hinhanh");
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                try
                {
                    string targetPath = Path.Combine(targetDirectory, Path.GetFileName(imagePath));
                    File.Copy(imagePath, targetPath, true);  // Ghi đè lên các tệp hiện có

                    // Hiển thị ảnh trong PictureBox
                    ptb_Anh3.Image = Image.FromFile(targetPath);
                    ptb_Anh3.SizeMode = PictureBoxSizeMode.Zoom;

                    //tạo đối tượng
                    Anh3 = targetPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            pn_Goc.VerticalScroll.Value = 1501;
        }

        private void ptb_Anh4_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images (*.jpg, *.jpeg, *.png) | *.jpg;*.jpeg;*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = dialog.FileName;

                // Tạo thư mục "hinhanh" nếu nó không tồn tại (tùy chọn)
                string targetDirectory = Path.Combine(Application.StartupPath, "hinhanh");
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                try
                {
                    string targetPath = Path.Combine(targetDirectory, Path.GetFileName(imagePath));
                    File.Copy(imagePath, targetPath, true);  // Ghi đè lên các tệp hiện có

                    // Hiển thị ảnh trong PictureBox
                    ptb_Anh4.Image = Image.FromFile(targetPath);
                    ptb_Anh4.SizeMode = PictureBoxSizeMode.Zoom;

                    //tạo đối tượng
                    Anh4 = targetPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            pn_Goc.VerticalScroll.Value = 1501;
        }

        private void ptb_Anh5_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images (*.jpg, *.jpeg, *.png) | *.jpg;*.jpeg;*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = dialog.FileName;

                // Tạo thư mục "hinhanh" nếu nó không tồn tại (tùy chọn)
                string targetDirectory = Path.Combine(Application.StartupPath, "hinhanh");
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                try
                {
                    string targetPath = Path.Combine(targetDirectory, Path.GetFileName(imagePath));
                    File.Copy(imagePath, targetPath, true);  // Ghi đè lên các tệp hiện có

                    // Hiển thị ảnh trong PictureBox
                    ptb_Anh5.Image = Image.FromFile(targetPath);
                    ptb_Anh5.SizeMode = PictureBoxSizeMode.Zoom;

                    //tạo đối tượng
                    Anh5 = targetPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            pn_Goc.VerticalScroll.Value = 1501;
        }

        private void ptb_Anh6_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images (*.jpg, *.jpeg, *.png) | *.jpg;*.jpeg;*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = dialog.FileName;

                // Tạo thư mục "hinhanh" nếu nó không tồn tại (tùy chọn)
                string targetDirectory = Path.Combine(Application.StartupPath, "hinhanh");
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                try
                {
                    string targetPath = Path.Combine(targetDirectory, Path.GetFileName(imagePath));
                    File.Copy(imagePath, targetPath, true);  // Ghi đè lên các tệp hiện có

                    // Hiển thị ảnh trong PictureBox
                    ptb_Anh6.Image = Image.FromFile(targetPath);
                    ptb_Anh6.SizeMode = PictureBoxSizeMode.Zoom;

                    //tạo đối tượng
                    Anh6 = targetPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            pn_Goc.VerticalScroll.Value = 1501;
        }
    }
}
