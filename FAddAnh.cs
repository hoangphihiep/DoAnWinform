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
    public partial class FAddAnh : Form
    {

        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);

        public FAddAnh()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("C:\\Users\\Anya\\source\\repos\\DoAnWinform\\bin\\Debug\\net6.0-windows\\Image\\tải xuống (32).jpg");
        }

        public void Update(string sqlString)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                txbCommand.Text = sqlString;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show(sqlString);
                }
                else
                { MessageBox.Show("Update failse"); }
            }
            catch (Exception ex) { }
            finally { conn.Close(); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string cmd = string.Format("INSERT INTO QL_ANH (MAKS, MAANH, TENANH, ADDRESS) VALUES ('{0}', '{1}', '{2}', '{3}')", txbMaKS.Text, txbMaAnh.Text, txbTenAnh.Text, txbAddress.Text);
            txbCommand.Text=cmd;
        }

        private void FAddAnh_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void FAddAnh_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0)
                {
                    // Lấy đường dẫn tệp ảnh từ files[0]
                    string imagePath = files[0];

                    // Sao chép tệp ảnh vào thư mục lưu trữ của dự án
                    string targetDirectory = System.IO.Path.Combine(Application.StartupPath, "Image");
                    if (!System.IO.Directory.Exists(targetDirectory))
                    {
                        System.IO.Directory.CreateDirectory(targetDirectory);
                        MessageBox.Show("Khong ton tai folder");
                    }
                    string targetPath = Path.Combine(targetDirectory, Path.GetFileName(imagePath));
                    File.Copy(imagePath, targetPath, true);

                    txbAddress.Text = targetPath;

                    // Hiển thị ảnh trong PictureBox
                    pictureBox1.Image = Image.FromFile(targetPath);
                }
            }
        }
    }
}
