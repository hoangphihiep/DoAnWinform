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

        private void btn_ThongTin_Click(object sender, EventArgs e)
        {
            uMatKhau1.SendToBack();
        }

        private void btn_MatKhau_Click(object sender, EventArgs e)
        {  
            uThongtin2.SendToBack();
        }
    }
}
