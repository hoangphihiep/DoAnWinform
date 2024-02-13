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
    public partial class fThongTinTaiKhoan : Form
    {
        public fThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private void fThongTinTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            uThongtin2.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uMatKhau1.BringToFront();
        }
    }
}
