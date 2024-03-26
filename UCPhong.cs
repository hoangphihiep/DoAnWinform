using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuLich
{
    public partial class UCPhong : UserControl
    {
        Room room;
        public UCPhong(Room room)
        {
            this.room = room;
            InitializeComponent();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UCPhong_Load(object sender, EventArgs e)
        {
            lblName1.Text = room.TENPHONG.ToString();
            lblName2.Text = room.TENPHONG.ToString();
            lblSoKhach.Text = room.SOKHACH.ToString();
            lblSoGiuong.Text = room.SOGIUONG.ToString();
            int phongtrong = room.SOPHONG - room.SOPHONGDD;
            lblSoPhongTrong.Text = phongtrong.ToString();
            lblPrice.Text = room.GIA.ToString();
            ptbAnh.Image = Image.FromFile(room.HinhAnh);
        }
    }
}
