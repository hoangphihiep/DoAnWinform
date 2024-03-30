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
using System.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace DuLich
{
    public partial class UAnh : UserControl
    {
        List<int> maAnh = new List<int>();
        public string tk;
        public string anh1;
        public string anh2;
        public string anh3;
        public string anh4;
        public string anh5;
        public string anh6;
        public string anh7;
        public string anhChinh;
        public UAnh()
        {
            InitializeComponent();
        }

        private void UAnh_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_MaKhachSan.Text == "")
                MessageBox.Show("Vui lòng nhập mã khách sạn");
            else
            {
                List<string> list = new List<string>();
                string connectionString = Connection_to_SQL.getConnnection();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "SELECT * FROM QL_ANH WHERE MAKS = @MAKS ";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@MAKS", txt_MaKhachSan.Text);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string address = reader["ADDRESS"].ToString();
                                    string picture  = reader["MAANH"].ToString();
                                    maAnh.Add(int.Parse(picture));
                                    list.Add(address);
                                }
                                anhChinh = list[0];
                                anh1 = list[1];
                                anh2 = list[2];
                                anh3 = list[3];
                                anh4 = list[4];
                                anh5 = list[5];
                                anh6 = list[6];
                                anh7 = list[7];
                            }
                        }
                        if (list.Count >= 8)
                        {
                            ptb_AnhChinh.Image = System.Drawing.Image.FromFile(anhChinh);
                            ptb_AnhBia.Image = System.Drawing.Image.FromFile(anh1);
                            ptb_Anh1.Image = System.Drawing.Image.FromFile(anh2);
                            ptb_Anh2.Image = System.Drawing.Image.FromFile(anh3);
                            ptb_Anh3.Image = System.Drawing.Image.FromFile(anh4);
                            ptb_Anh4.Image = System.Drawing.Image.FromFile(anh5);
                            ptb_Anh5.Image = System.Drawing.Image.FromFile(anh6);
                            ptb_Anh6.Image = System.Drawing.Image.FromFile(anh7);
                            ptb_AnhChinh.Refresh();
                            ptb_AnhBia.Refresh();
                            ptb_Anh1.Refresh();
                            ptb_Anh2.Refresh();
                            ptb_Anh3.Refresh();
                            ptb_Anh4.Refresh();
                            ptb_Anh5.Refresh();
                            ptb_Anh6.Refresh();
                        }
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            QL_HinhAnhDAO dao = new QL_HinhAnhDAO();
            QL_HinhAnh AnhBia = new(int.Parse(txt_MaKhachSan.Text), "anh tutol", anh1, maAnh[0]);
            QL_HinhAnh AnhChinh = new(int.Parse(txt_MaKhachSan.Text), "anh tutol", anhChinh, maAnh[1]);
            QL_HinhAnh Anh1 = new(int.Parse(txt_MaKhachSan.Text), "anh tutol", anh2, maAnh[2]);
            QL_HinhAnh Anh2 = new(int.Parse(txt_MaKhachSan.Text), "anh tutol", anh3, maAnh[3]);
            QL_HinhAnh Anh3 = new(int.Parse(txt_MaKhachSan.Text), "anh tutol", anh4, maAnh[4]);
            QL_HinhAnh Anh4 = new(int.Parse(txt_MaKhachSan.Text), "anh tutol", anh5, maAnh[5]);
            QL_HinhAnh Anh5 = new(int.Parse(txt_MaKhachSan.Text), "anh tutol", anh6, maAnh[6]);
            QL_HinhAnh Anh6 = new(int.Parse(txt_MaKhachSan.Text), "anh tutol", anh7, maAnh[7]);
            dao.Update(AnhBia, "QL_ANH");
            dao.Update(AnhChinh, "QL_ANH");
            dao.Update(Anh1, "QL_ANH");
            dao.Update(Anh2, "QL_ANH");
            dao.Update(Anh3, "QL_ANH");
            dao.Update(Anh4, "QL_ANH");
            dao.Update(Anh5, "QL_ANH");
            dao.Update(Anh6, "QL_ANH");
        }
            

        private void ptb_AnhBia_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images (*.jpg, *.jpeg, *.png) | *.jpg;*.jpeg;*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = dialog.FileName;

                // Tạo thư mục "hinhanh" nếu nó không tồn tại (tùy chọn)
                string targetDirectory = Path.Combine(System.Windows.Forms.Application.StartupPath, "hinhanh");
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                try
                {
                    string targetPath = Path.Combine(targetDirectory, Path.GetFileName(imagePath));
                    File.Copy(imagePath, targetPath, true);  // Ghi đè lên các tệp hiện có

                    // Hiển thị ảnh trong PictureBox
                    ptb_AnhBia.Image = System.Drawing.Image.FromFile(targetPath);
                    ptb_AnhBia.SizeMode = PictureBoxSizeMode.Zoom;

                    //tạo đối tượng
                    anh1 = targetPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ptb_AnhChinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images (*.jpg, *.jpeg, *.png) | *.jpg;*.jpeg;*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = dialog.FileName;

                // Tạo thư mục "hinhanh" nếu nó không tồn tại (tùy chọn)
                string targetDirectory = Path.Combine(System.Windows.Forms.Application.StartupPath, "hinhanh");
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                try
                {
                    string targetPath = Path.Combine(targetDirectory, Path.GetFileName(imagePath));
                    File.Copy(imagePath, targetPath, true);  // Ghi đè lên các tệp hiện có

                    // Hiển thị ảnh trong PictureBox
                    ptb_AnhChinh.Image = System.Drawing.Image.FromFile(targetPath);
                    ptb_AnhChinh.SizeMode = PictureBoxSizeMode.Zoom;

                    //tạo đối tượng
                    anhChinh = targetPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ptb_Anh1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images (*.jpg, *.jpeg, *.png) | *.jpg;*.jpeg;*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = dialog.FileName;

                // Tạo thư mục "hinhanh" nếu nó không tồn tại (tùy chọn)
                string targetDirectory = Path.Combine(System.Windows.Forms.Application.StartupPath, "hinhanh");
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                try
                {
                    string targetPath = Path.Combine(targetDirectory, Path.GetFileName(imagePath));
                    File.Copy(imagePath, targetPath, true);  // Ghi đè lên các tệp hiện có

                    // Hiển thị ảnh trong PictureBox
                    ptb_Anh1.Image = System.Drawing.Image.FromFile(targetPath);
                    ptb_Anh1.SizeMode = PictureBoxSizeMode.Zoom;

                    //tạo đối tượng
                    anh2 = targetPath;
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
                string targetDirectory = Path.Combine(System.Windows.Forms.Application.StartupPath, "hinhanh");
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                try
                {
                    string targetPath = Path.Combine(targetDirectory, Path.GetFileName(imagePath));
                    File.Copy(imagePath, targetPath, true);  // Ghi đè lên các tệp hiện có

                    // Hiển thị ảnh trong PictureBox
                    ptb_Anh2.Image = System.Drawing.Image.FromFile(targetPath);
                    ptb_Anh2.SizeMode = PictureBoxSizeMode.Zoom;

                    //tạo đối tượng
                    anh3 = targetPath;
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
                string targetDirectory = Path.Combine(System.Windows.Forms.Application.StartupPath, "hinhanh");
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                try
                {
                    string targetPath = Path.Combine(targetDirectory, Path.GetFileName(imagePath));
                    File.Copy(imagePath, targetPath, true);  // Ghi đè lên các tệp hiện có

                    // Hiển thị ảnh trong PictureBox
                    ptb_Anh5.Image = System.Drawing.Image.FromFile(targetPath);
                    ptb_Anh5.SizeMode = PictureBoxSizeMode.Zoom;

                    //tạo đối tượng
                    anh4 = targetPath;
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
                string targetDirectory = Path.Combine(System.Windows.Forms.Application.StartupPath, "hinhanh");
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                try
                {
                    string targetPath = Path.Combine(targetDirectory, Path.GetFileName(imagePath));
                    File.Copy(imagePath, targetPath, true);  // Ghi đè lên các tệp hiện có

                    // Hiển thị ảnh trong PictureBox
                    ptb_Anh2.Image = System.Drawing.Image.FromFile(targetPath);
                    ptb_Anh2.SizeMode = PictureBoxSizeMode.Zoom;

                    //tạo đối tượng
                    anh5 = targetPath;
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
                string targetDirectory = Path.Combine(System.Windows.Forms.Application.StartupPath, "hinhanh");
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                try
                {
                    string targetPath = Path.Combine(targetDirectory, Path.GetFileName(imagePath));
                    File.Copy(imagePath, targetPath, true);  // Ghi đè lên các tệp hiện có

                    // Hiển thị ảnh trong PictureBox
                    ptb_Anh3.Image = System.Drawing.Image.FromFile(targetPath);
                    ptb_Anh3.SizeMode = PictureBoxSizeMode.Zoom;

                    //tạo đối tượng
                    anh6 = targetPath;
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
                string targetDirectory = Path.Combine(System.Windows.Forms.Application.StartupPath, "hinhanh");
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                try
                {
                    string targetPath = Path.Combine(targetDirectory, Path.GetFileName(imagePath));
                    File.Copy(imagePath, targetPath, true);  // Ghi đè lên các tệp hiện có

                    // Hiển thị ảnh trong PictureBox
                    ptb_Anh1.Image = System.Drawing.Image.FromFile(targetPath);
                    ptb_Anh1.SizeMode = PictureBoxSizeMode.Zoom;

                    //tạo đối tượng
                    anh7 = targetPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
