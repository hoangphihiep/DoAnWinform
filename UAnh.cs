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
using System.Net;
using System.Net.WebSockets;

namespace DuLich
{
    public partial class UAnh : UserControl
    {
        int[] maAnh = new int[8];
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
        public void SetTenTK(string tenTK)
        {
            tk = tenTK;
            // Gọi lại phương thức load dữ liệu
            UAnh_Load(this, EventArgs.Empty);
        }

        private void UAnh_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Connection_to_SQL.getConnnection()))
            {
                connection.Open();
                string sql = "SELECT QA.* " + "FROM QL_ANH QA " + "JOIN KHACHSAN_THUOC_TAIKHOAN KT ON QA.MAKS = KT.MaKS " + "WHERE KT.TaiKhoan = '" + tk + "'";
                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader reader = command.ExecuteReader();

                // Clear existing columns in the DataGridView
                dataGridView1.Columns.Clear();

                // Add columns to the DataGridView
                dataGridView1.Columns.Add("MAKS", "MAKS");
                dataGridView1.Columns.Add("TENANH", "TENANH");
                dataGridView1.Columns.Add("ADDRESS", "ADDRESS");
                dataGridView1.Columns.Add("MAANH", "MAANH");

                while (reader.Read())
                {
                    int maks = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    string tenanh = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                    string address = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                    int maAnh = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);

                    // Add rows to the DataGridView
                    dataGridView1.Rows.Add(maks, tenanh, address, maAnh);
                }
                reader.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            if (txt_MaKhachSan.Text == "")
                MessageBox.Show("Hãy nhập mã khách sạn");
            else
            {
                string query = "SELECT QA.* " +
                             "FROM QL_ANH QA " +
                             "JOIN KHACHSAN_THUOC_TAIKHOAN KT ON QA.MAKS = KT.MaKS " +
                             "WHERE KT.TaiKhoan = '" + tk + "' AND QA.MAKS = " + int.Parse(txt_MaKhachSan.Text);
                QL_HinhAnhDAO Dao = new QL_HinhAnhDAO();
                List<QL_HinhAnh> list_Anh = modify.QL_HinhAnh(query);
                if (list_Anh.Count() >= 8)
                {
                    ptb_AnhChinh.Visible = true;
                    ptb_AnhBia.Visible = true;
                    ptb_Anh1.Visible = true;
                    ptb_Anh2.Visible = true;
                    ptb_Anh3.Visible = true;
                    ptb_Anh4.Visible = true;
                    ptb_Anh5.Visible = true;
                    ptb_Anh6.Visible = true;
                    ptb_AnhChinh.Image = System.Drawing.Image.FromFile(list_Anh[0].ADDRESS);
                    ptb_AnhBia.Image = System.Drawing.Image.FromFile(list_Anh[1].ADDRESS);
                    ptb_Anh1.Image = System.Drawing.Image.FromFile(list_Anh[2].ADDRESS);
                    ptb_Anh2.Image = System.Drawing.Image.FromFile(list_Anh[3].ADDRESS);
                    ptb_Anh3.Image = System.Drawing.Image.FromFile(list_Anh[4].ADDRESS);
                    ptb_Anh4.Image = System.Drawing.Image.FromFile(list_Anh[5].ADDRESS);
                    ptb_Anh5.Image = System.Drawing.Image.FromFile(list_Anh[6].ADDRESS);
                    ptb_Anh6.Image = System.Drawing.Image.FromFile(list_Anh[7].ADDRESS);

                    anhChinh = list_Anh[0].ADDRESS;
                    anh1 = list_Anh[1].ADDRESS;
                    anh2 = list_Anh[2].ADDRESS;
                    anh3 = list_Anh[3].ADDRESS;
                    anh4 = list_Anh[4].ADDRESS;
                    anh5 = list_Anh[5].ADDRESS;
                    anh6 = list_Anh[6].ADDRESS;
                    anh7 = list_Anh[7].ADDRESS;

                    for (int i = 0; i < 8; i++)
                    {
                        maAnh[i] = list_Anh[i].MAANH;
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
            MessageBox.Show("Update thành công");
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
