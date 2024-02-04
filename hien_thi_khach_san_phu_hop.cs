using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuLich
{
    public partial class hien_thi_khach_san_phu_hop : Form
    {
        public hien_thi_khach_san_phu_hop()
        {
            InitializeComponent();
            trackBar1.Value = 50; // Giá trị mặc định
            trackBar1.Scroll += trackBar1_Scroll;
            trackBar2.Value = 4000000; // Giá trị mặc định
            trackBar2.Scroll += trackBar2_Scroll;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int value = trackBar1.Value;
            // Xử lý giá trị mới tại đây
            label2.Text = $"{value}";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            int value = trackBar2.Value;

            // Tính giá trị đảo ngược của value
            value = trackBar2.Maximum - value;

            // Hiển thị giá trị đảo ngược lên label
            label4.Text = value.ToString();


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fHotel_Posting f = new fHotel_Posting();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
