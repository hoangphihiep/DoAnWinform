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
namespace DuLich
{
    public partial class UPhong : UserControl
    {
        public UPhong()
        {
            InitializeComponent();
        }

        private void ptb_AnhBia_Click(object sender, EventArgs e)
        {

            // OpenFileDialog to select an image
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images (*.jpg, *.jpeg, *.png) | *.jpg;*.jpeg;*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Get image path and name
                string imagePath = dialog.FileName;
                string imageName = Path.GetFileNameWithoutExtension(imagePath);

                // **Add the image as an embedded resource:**
                //Properties.Resources.AddResource(imageName, imagePath);

                //// Access the image from resources using its name
                //ptb_AnhBia.Image = Properties.Resources.imageName;
                ptb_AnhBia.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void ptb_Anh1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptb_Anh1.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void ptb_Anh2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptb_Anh2.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void ptb_Anh3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptb_Anh3.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void ptb_Anh4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptb_Anh4.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void ptb_Anh5_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptb_Anh5.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void ptb_Anh6_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptb_Anh5.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void Phong_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1115, 801);
            lbl_ThietLap.Size = new Size(218, 38);
            lbl_ThietLap.Location = new Point(9, 15);
            label4.Size = new Size(460, 20);
            label4.Location = new Point(15, 53);
            lbl_ChiTietPhong.Size = new Size(181, 31);
            lbl_ChiTietPhong.Location = new Point(9, 84);
            lbl_QuyDoiTac.Size = new Size(545, 20);
            lbl_QuyDoiTac.Location = new Point(9, 126);
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
            lbl_ChiDemSoLuong.Location = new Point(14, 416);
            txt_SoGiuong.Size = new Size(593, 30);
            txt_SoGiuong.Location = new Point(15, 449);
            lbl_GiaMoiDem.Size = new Size(146, 31);
            lbl_GiaMoiDem.Location = new Point(16, 494);
            lbl_VuiLong.Size = new Size(415, 20);
            lbl_VuiLong.Location = new Point(16, 536);
            lbl_GiaGocChoPhongTieuChuan.Size = new Size(242, 23);
            lbl_GiaGocChoPhongTieuChuan.Location = new Point(17, 571);
            lbl_GiaToiThieuMoiDem.Size = new Size(177, 23);
            lbl_GiaToiThieuMoiDem.Location = new Point(16, 613);
            txt_GiaToiThieu.Size = new Size(539, 30);
            txt_GiaToiThieu.Location = new Point(17, 639);
            lbl_VND.Size = new Size(46, 23);
            lbl_VND.Location = new Point(562, 642);
            lbl_ThemKhach.Size = new Size(131, 23);
            lbl_ThemKhach.Location = new Point(16, 678);
            lbl_SauKhiNhieuHon.Size = new Size(374, 40);
            lbl_SauKhiNhieuHon.Location = new Point(17, 716);
            txt_tienThemKhach.Size = new Size(540, 30);
            txt_tienThemKhach.Location = new Point(16, 758);
            lbl_Nguoi.Size = new Size(46, 23);
            lbl_Nguoi.Location = new Point(562, 761);
            lbl_ThemHinhAnh.Size = new Size(283, 31);
            lbl_ThemHinhAnh.Location = new Point(673, 84);
            ptb_AnhBia.Size = new Size(452, 228);
            ptb_AnhBia.Location = new Point(652, 134);
            ptb_Anh1.Size = new Size(135, 119);
            ptb_Anh1.Location = new Point(652, 377);
            ptb_Anh2.Size = new Size(135, 119);
            ptb_Anh2.Location = new Point(809, 377);
            ptb_Anh3.Size = new Size(135, 119);
            ptb_Anh3.Location = new Point(969, 377);
            ptb_Anh4.Size = new Size(135, 119);
            ptb_Anh4.Location = new Point(652, 517);
            ptb_Anh5.Size = new Size(135, 119);
            ptb_Anh5.Location = new Point(809, 517);
            ptb_Anh6.Size = new Size(135, 119);
            ptb_Anh6.Location = new Point(969, 517);

        }
    }
}
