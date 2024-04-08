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
    public partial class Payment_Information : Form
    {
        public string tk;
        public string mk;
        public Image tenAnh;
        public string tenKhachSan;
        public string soKhach;
        public string soPhongConTrong;
        public string Gia;
        public string sdt;
        public string lastcost;
        public string TenKhachHang;
        public int giamgia;
        public DateTime NgayNhan;
        public DateTime NgayTra;
        public DatPhong datphong;

        public Payment_Information(DatPhong datPhong)
        {
            this.datphong = datphong;
            InitializeComponent();
        }

        public Payment_Information()
        {
            InitializeComponent();
        }

        private void lbl_All_Click(object sender, EventArgs e)
        {

        }

        private void txt_Ten_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Customer_Information f = new Customer_Information(datphong.KS, datphong.Phong, NgayNhan, NgayTra);
            f.tenAnh = ptb_Anh.Image;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btn_BookNow_Click(object sender, EventArgs e)
        {
            datphong.TongThanhToan = float.Parse(lbl_LastCost.Text);
            fPayment_Slip f = new fPayment_Slip();
            f.DP = datphong;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void Payment_Information_Load(object sender, EventArgs e)
        {
            if(giamgia != 0)
            {
                lbl_giamGia.Visible = true;
                lbl_giamGia.Text = "Đã áp dụng mã giảm giá " +giamgia +" %";
            }
            ptb_Anh.Image = tenAnh;
            label15.Text = datphong.KS.TENKS;
            label17.Text = datphong.Phong.SOKHACH.ToString();
            label19.Text = (datphong.Phong.SOPHONG - datphong.Phong.SOPHONGDD).ToString();
            label20.Text = datphong.Phong.GIA.ToString();
            lbl_CostRoom.Text = datphong.Phong.GIA.ToString();
            lbl_Cost.Text = datphong.Phong.GIA.ToString();
            lbl_LastCost.Text = lastcost;
        }

        private void Payment_Information_Shown(object sender, EventArgs e)
        {
            panel1.VerticalScroll.Value = 0;
        }

        public DatPhong DP
        {
            get { return datphong; }
            set { datphong = value; }
        }
        public void SetLastCost(string a)
        {
            lastcost = a;
            // Gọi lại phương thức load dữ liệu
            Payment_Information_Load(this, EventArgs.Empty);
        }
    }
}
