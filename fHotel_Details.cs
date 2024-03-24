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
using System.Resources;

namespace DuLich
{
    public partial class fHotel_Details : Form
    {
        public fHotel_Details()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer_Information f = new Customer_Information();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer_Information f = new Customer_Information();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customer_Information f = new Customer_Information();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        public string tenKS;
        public string tenViTri;
        public byte[] hinhanh;
        private void fHotel_Details_Load(object sender, EventArgs e)
        {
            label2.Text = tenKS;
            label1.Text = tenViTri;
            if (hinhanh != null)
            {
                using (MemoryStream ms = new MemoryStream(hinhanh))
                {
                    ptbTotalImage1.Image = Image.FromStream(ms);
                }
            }
            string query = "SELECT * FROM KhachSan WHERE TENKS = @tenKS";
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@tenKS", tenKS);
            command.CommandTimeout = 120;
            SqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                label1.Text = reader.GetString(reader.GetOrdinal("DIACHI"));
                int giaColumnIndex = reader.GetOrdinal("GIA");
                if (!reader.IsDBNull(giaColumnIndex))
                {
                    double gia = reader.GetDouble(giaColumnIndex);
                    lbl_Tien.Text = gia.ToString() + " VNĐ";
                }
                int giaColumnIndex1 = reader.GetOrdinal("DANHGIA");
                if (!reader.IsDBNull(giaColumnIndex1))
                {
                    double danhgia = reader.GetDouble(giaColumnIndex1);
                    lbl_DanhGia.Text = danhgia.ToString();
                    label93.Text = danhgia.ToString();
                }
                i++;
            }
            conn.Close();
        }

        private void fHotel_Details_Shown(object sender, EventArgs e)
        {
            panelMain.VerticalScroll.Value = 0;
        }


        void DeleteColor()
        {
            lblTotal.ForeColor = Color.Black;
            lblRoom.ForeColor = Color.Black;
            lblConvenient.ForeColor = Color.Black;
            lblComment.ForeColor = Color.Black;
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            DeleteColor();
            panelMain.VerticalScroll.Value = 0;
            lblTotal.ForeColor = Color.DarkTurquoise;
        }

        private void lblRoom_Click(object sender, EventArgs e)
        {
            DeleteColor();
            panelMain.VerticalScroll.Value = 620;
            lblRoom.ForeColor = Color.DarkTurquoise;
        }

        private void lblConvenient_Click(object sender, EventArgs e)
        {
            DeleteColor();
            panelMain.VerticalScroll.Value = 1540;
            lblConvenient.ForeColor = Color.DarkTurquoise;
        }

        private void lblComment_Click(object sender, EventArgs e)
        {
            DeleteColor();
            panelMain.VerticalScroll.Value = 2350;
            lblComment.ForeColor = Color.DarkTurquoise;
        }

        private void lblConvenientDetail_Click(object sender, EventArgs e)
        {
            DeleteColor();
            panelMain.VerticalScroll.Value = 1170;
            lblConvenient.ForeColor = Color.DarkTurquoise;
        }

        private void lblCommentDetail_Click(object sender, EventArgs e)
        {
            DeleteColor();
            panelMain.VerticalScroll.Value = 1750;
            lblComment.ForeColor = Color.DarkTurquoise;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRoomChoose_Click(object sender, EventArgs e)
        {
            FAddAnh f= new FAddAnh();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
