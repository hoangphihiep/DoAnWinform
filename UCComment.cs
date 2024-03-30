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
    public partial class UCComment : UserControl
    {
        DanhGia danhgia;
        public UCComment(DanhGia danhgia)
        {
            InitializeComponent();
            this.danhgia = danhgia;
        }

        private void UCComment_Load(object sender, EventArgs e)
        {
            lblName.Text = danhgia.TenKH;
            lblDiem.Text = danhgia.Diem.ToString();
            lblContent.Text = danhgia.NoiDung;
        }
    }
}
