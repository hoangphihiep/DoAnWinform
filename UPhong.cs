using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using DuLich.Properties;
using System.Data.SqlClient;
using System.Collections;

namespace DuLich
{
    public partial class UPhong : UserControl
    {
        public int MaPhong;
        public int MAANH = 0;
        public string taikhoan;
        public int phong;
        public string anh1;
        public string anh2;
        public string anh3;
        public string anh4;
        public string anh5;
        public string anh6;
        public string AnhPhong;
        public int MaKS;
        public int index;
        List<int> Ma_Phong = new List<int>();
        public UPhong()
        {
            InitializeComponent();

        }

        private void ptb_AnhBia_Click(object sender, EventArgs e)
        {

        }
        public void SetMaKS(int maks)
        {
            MaKS = maks;
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
                    anh1 = targetPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                    anh2 = targetPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                    anh3 = targetPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                    anh4 = targetPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                    anh5 = targetPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                    anh6 = targetPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Phong_Load(object sender, EventArgs e)
        {

            this.Size = new Size(1115, 801);

            lbl_ThietLap.Size = new Size(218, 38);
            lbl_ThietLap.Location = new Point(9, 15);

            lbl_ChiTietPhong.Size = new Size(181, 31);
            lbl_ChiTietPhong.Location = new Point(14, 70);

            lbl_TenPhong.Size = new Size(105, 23);
            lbl_TenPhong.Location = new Point(17, 111);

            txt_TenPhong.Size = new Size(594, 30);
            txt_TenPhong.Location = new Point(16, 137);

            lbl_KichThuoc.Size = new Size(106, 23);
            lbl_KichThuoc.Location = new Point(15, 172);

            txt_KichThuoc.Size = new Size(558, 30);
            txt_KichThuoc.Location = new Point(15, 209);

            lbl_m2.Size = new Size(34, 23);
            lbl_m2.Location = new Point(574, 216);

            lbl_SucChua.Size = new Size(95, 23);
            lbl_SucChua.Location = new Point(15, 252);

            lbl_SoLuongNguoi.Size = new Size(559, 40);
            lbl_SoLuongNguoi.Location = new Point(14, 288);

            txt_SucChua.Size = new Size(594, 30);
            txt_SucChua.Location = new Point(14, 332);

            lbl_SoGiuong.Size = new Size(103, 23);
            lbl_SoGiuong.Location = new Point(15, 377);

            lbl_ChiDemSoLuong.Size = new Size(399, 20);
            lbl_ChiDemSoLuong.Location = new Point(17, 407);

            txt_SoGiuong.Size = new Size(593, 30);
            txt_SoGiuong.Location = new Point(18, 440);

            lbl_SoPhong.Size = new Size(98, 23);
            lbl_SoPhong.Location = new Point(17, 486);

            txt_SoPhong.Size = new Size(594, 30);
            txt_SoPhong.Location = new Point(16, 512);

            lbl_GiaMoiDem.Size = new Size(146, 31);
            lbl_GiaMoiDem.Location = new Point(17, 554);
            //lbl_VuiLong.Size = new Size(415, 20);
            //lbl_VuiLong.Location = new Point(16, 536);
            lbl_GiaGocChoPhongTieuChuan.Size = new Size(242, 23);
            lbl_GiaGocChoPhongTieuChuan.Location = new Point(17, 610);

            lbl_GiaToiThieuMoiDem.Size = new Size(177, 23);
            lbl_GiaToiThieuMoiDem.Location = new Point(16, 647);

            txt_GiaToiThieu.Size = new Size(539, 30);
            txt_GiaToiThieu.Location = new Point(17, 673);

            lbl_VND.Size = new Size(46, 23);
            lbl_VND.Location = new Point(562, 676);

            lbl_ThemKhach.Size = new Size(131, 23);
            lbl_ThemKhach.Location = new Point(16, 716);

            //lbl_SauKhiNhieuHon.Size = new Size(374, 40);
            //lbl_SauKhiNhieuHon.Location = new Point(17, 716);
            txt_tienThemKhach.Size = new Size(540, 30);
            txt_tienThemKhach.Location = new Point(16, 758);

            lbl_Nguoi.Size = new Size(46, 23);
            lbl_Nguoi.Location = new Point(562, 761);
            lbl_ThemHinhAnh.Size = new Size(283, 31);
            lbl_ThemHinhAnh.Location = new Point(721, 70);
            //ptb_Anh1.Size = new Size(135, 119);
            //ptb_Anh1.Location = new Point(637, 297);
            //ptb_Anh2.Size = new Size(135, 119);
            //ptb_Anh2.Location = new Point(794, 297);
            //ptb_Anh3.Size = new Size(135, 119);
            //ptb_Anh3.Location = new Point(954, 297);
            //ptb_Anh4.Size = new Size(135, 119);
            //ptb_Anh4.Location = new Point(637, 437);
            //ptb_Anh5.Size = new Size(135, 119);
            //ptb_Anh5.Location = new Point(794, 437);
            //ptb_Anh6.Size = new Size(135, 119);
            //ptb_Anh6.Location = new Point(954, 437);
            //ptb_AnhPhong.Size = new Size(320, 158);
            //ptb_AnhPhong.Location = new Point(707, 117);
            btn_ThemPhong.Size = new Size(94, 29);
            btn_ThemPhong.Location = new Point(825, 569);
            //btn_ThemPhong.Font = new System.Drawing.FontFamily("Segoe UI", 9pt, FontStyle.Regular);
            ptb_AnhPhong.Size = new Size(391, 331);
            ptb_AnhPhong.Location = new Point(676, 172);
        }

        private void btn_UploadAnh_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            List<QL_HinhAnh> list = new List<QL_HinhAnh>();
            QL_HinhAnhDAO hinhAnhDAO = new QL_HinhAnhDAO();
            list.Add(new QL_HinhAnh(MaKS, "Anh total", AnhPhong, MAANH));
            //list.Add(new QL_HinhAnh(MaKS, "Anh total 2", anh1, MAANH));
            //list.Add(new QL_HinhAnh(MaKS, "Anh total 3", anh2, MAANH));
            //list.Add(new QL_HinhAnh(MaKS, "Anh total 4", anh3, MAANH));
            //list.Add(new QL_HinhAnh(MaKS, "Anh total 5", anh4, MAANH));
            //list.Add(new QL_HinhAnh(MaKS, "Anh total 6", anh5, MAANH));
            //list.Add(new QL_HinhAnh(MaKS, "Anh total 7", anh6, MAANH));
            foreach (var i in list)
            {
                hinhAnhDAO.Add(i, "QL_ANH");
            }
            //HinhAnh hinh = new HinhAnh(taikhoan, phong, anh1, anh2, anh3, anh4, anh5, anh6, MaKS);
            //HinhAnhDAO hinhAnhDAO = new HinhAnhDAO();
            //bool duplicateFound = false;
            //while (!duplicateFound)
            //{
            //    string query = "SELECT * FROM HinhAnh WHERE TenDangNhap = '" + taikhoan.ToString() + "' AND MaKS = '" + MaKS + "' AND PHONG = '" + MaPhong + "'";
            //    List<HinhAnh> list_accounts = modify.HinhAnh(query);
            //    if (list_accounts.Count == 1)
            //    {
            //        MaPhong++;
            //    }
            //    else
            //    {
            //        duplicateFound = true;
            //    }
            //}
            //hinh.Phong = MaPhong;
            //hinhAnhDAO.Add(hinh, "HinhAnh");
            MessageBox.Show("Upload ảnh thành công");
        }

        private void btn_ThemPhong_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MaPhong.ToString());
            Room_DAO room_DAO = new Room_DAO();
            Room room = new Room(int.Parse(txt_SucChua.Text), int.Parse(txt_SoGiuong.Text), int.Parse(txt_GiaToiThieu.Text), txt_TenPhong.Text, MaPhong, AnhPhong);
            room_DAO.Add(room, "PHONG");
            //List<QL_HinhAnh> list = new List<QL_HinhAnh>();
            //QL_HinhAnhDAO hinhAnhDAO = new QL_HinhAnhDAO();
            //list.Add(new QL_HinhAnh(MaKS, "Anh total", AnhPhong, MAANH));
            //list.Add(new QL_HinhAnh(MaKS, "Anh total 2", anh1, MAANH));
            //list.Add(new QL_HinhAnh(MaKS, "Anh total 3", anh2, MAANH));
            //list.Add(new QL_HinhAnh(MaKS, "Anh total 4", anh3, MAANH));
            //list.Add(new QL_HinhAnh(MaKS, "Anh total 5", anh4, MAANH));
            //list.Add(new QL_HinhAnh(MaKS, "Anh total 6", anh5, MAANH));
            //list.Add(new QL_HinhAnh(MaKS, "Anh total 7", anh6, MAANH));
            //foreach (var i in list)
            //{
            //    hinhAnhDAO.Add(i, "QL_ANH");
            //}
            //Modify modify = new Modify();
            //bool duplicateFound = false;
            //while (!duplicateFound)
            //{
            //    string query = "SELECT * FROM PHONG WHERE TaiKhoan = '" + taikhoan.ToString() + "' AND MaKS = '" + MaKS + "' AND MAPHONG = '" + MaPhong + "'";
            //    List<Phong> list_accounts = modify.Phong(query);
            //    if (list_accounts.Count == 1)
            //    {
            //        MaPhong++;
            //    }
            //    else
            //    {
            //        duplicateFound = true;
            //    }
            //}
            //phong.MaPhong = MaPhong;
            //Dao.Add(phong, "PHONG");
            int maPhong;
            string connectionString = Connection_to_SQL.getConnnection();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query1 = "SELECT MAX(MAPHONG) FROM PHONG";

                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    // Thực thi truy vấn và nhận giá trị MaPhong
                    maPhong = int.Parse(command.ExecuteScalar().ToString());
                    Console.WriteLine("MaPhong: " + maPhong);
                }
            }
            QLPHONG phong1 = new QLPHONG(MaKS, int.Parse(txt_SoPhong.Text), 0, maPhong);
            QLPHONG_DAO qLPHONG_DAO = new QLPHONG_DAO();
            qLPHONG_DAO.Add(phong1, "QLPHONG");
            MessageBox.Show("Add Phòng thành công");
        }

        private void ptb_AnhPhong_Click(object sender, EventArgs e)
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
                    ptb_AnhPhong.Image = Image.FromFile(targetPath);
                    ptb_AnhPhong.SizeMode = PictureBoxSizeMode.Zoom;

                    //tạo đối tượng
                    AnhPhong = targetPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lbl_ChiTietPhong_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ChiDemSoLuong_Click(object sender, EventArgs e)
        {

        }

        private void lbl_SoPhong_Click(object sender, EventArgs e)
        {

        }

        private void lbl_m2_Click(object sender, EventArgs e)
        {

        }
        public void HienThi(int index, List<int> maPhong)
        {
            Ma_Phong = maPhong;
            int maPhongHienTai = maPhong[index];
            string query1 = "SELECT * FROM PHONG WHERE MAPHONG = @MaPhong1";
            string query2 = "SELECT * FROM QLPHONG WHERE MAPHONG = @MaPhong2";
            using (SqlConnection connection = new SqlConnection(Connection_to_SQL.getConnnection()))
            {
                connection.Open();

                // Thực hiện truy vấn từ bảng PHONG
                using (SqlCommand command1 = new SqlCommand(query1, connection))
                {
                    command1.Parameters.AddWithValue("@MaPhong1", maPhongHienTai); // Thêm tham số cho mã phòng
                    using (SqlDataReader reader1 = command1.ExecuteReader())
                    {
                        while (reader1.Read())
                        {

                            txt_SucChua.Text = reader1["SOKHACH"].ToString();
                            txt_SoGiuong.Text = reader1["SOGIUONG"].ToString();
                            txt_GiaToiThieu.Text = reader1["GIA"].ToString();
                            txt_TenPhong.Text = reader1["TENPHONG"].ToString();
                            ptb_AnhPhong.Image = Image.FromFile(reader1["ANH"].ToString());
                        }
                    }
                }

                // Thực hiện truy vấn từ bảng QLPHONG
                using (SqlCommand command2 = new SqlCommand(query2, connection))
                {
                    command2.Parameters.AddWithValue("@MaPhong2", maPhongHienTai); // Thêm tham số cho mã phòng
                    using (SqlDataReader reader2 = command2.ExecuteReader())
                    {
                        while (reader2.Read())
                        {
                            txt_SoPhong.Text = reader2["SOPHONG"].ToString();
                            txt_tienThemKhach.Text = reader2["SOPHONG_DD"].ToString();
                        }
                    }
                }
            }
        }
        public void Ktr(int index, List<int> maPHong)
        {
            MaPhong = maPHong[index];
            btn_ChinhSua.Visible = true;
            btn_ThemPhong.Visible = false;
            btn_Next.Visible = true;
            btn_Back.Visible = true;
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MaPhong.ToString());
            Room_DAO room_DAO = new Room_DAO();
            Room room = new Room(int.Parse(txt_SucChua.Text), int.Parse(txt_SoGiuong.Text), int.Parse(txt_GiaToiThieu.Text), txt_TenPhong.Text, MaPhong, AnhPhong);
            room_DAO.Update(room, "PHONG");
            int maPhong;
            string connectionString = Connection_to_SQL.getConnnection();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query1 = "SELECT MAX(MAPHONG) FROM PHONG";

                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    // Thực thi truy vấn và nhận giá trị MaPhong
                    maPhong = int.Parse(command.ExecuteScalar().ToString());
                    Console.WriteLine("MaPhong: " + maPhong);
                }
            }
            QLPHONG phong1 = new QLPHONG(MaKS, int.Parse(txt_SoPhong.Text), 0, maPhong);
            QLPHONG_DAO qLPHONG_DAO = new QLPHONG_DAO();
            qLPHONG_DAO.Update(phong1, "QLPHONG");
            MessageBox.Show("Update phòng thành công");
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (index < Ma_Phong.Count - 1)
                HienThi(++index, Ma_Phong);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (index > 0)
                HienThi(--index, Ma_Phong);
        }
    }
}
