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

        public fHotel_Details(int maks)
        {
            this.maks = maks;
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
        public int maks;
        private void fHotel_Details_Load(object sender, EventArgs e)
        {
            ChenThongTinCanBan();
            ChenAnhToTal();
            ChenTNChinh();
            ChenTienNghi();
            ChenPhong();
            ChenDanhGia();
        }

        void ChenDanhGia()
        {
            string query = "SELECT * FROM DANHGIA WHERE DANHGIA.MAKS = @maks";
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@maks", maks);
            command.CommandTimeout = 120;
            SqlDataReader reader = command.ExecuteReader();
            List<DanhGia> list = new List<DanhGia>();
            int rt = 0, t = 0, tb = 0, k = 0;
            int tong = 0;
            int n = 0;
            while (reader.Read())
            {
                string tenKH = reader.GetString(reader.GetOrdinal("TENKH"));
                int diem = reader.GetInt32(reader.GetOrdinal("DIEM"));
                string noidung = reader.GetString(reader.GetOrdinal("NOIDUNG"));
                int maks = reader.GetInt32(reader.GetOrdinal("MAKS"));
                if(diem<5)
                {
                    k++;
                }
                if (diem < 7 && diem >= 5)
                {
                    tb++;
                }
                if (diem == 8 || diem == 7)
                {
                    t++;
                }
                if (diem == 10)
                {
                    rt++;
                }
                tong += diem;
                n++;
                DanhGia dg= new DanhGia(tenKH, diem, noidung, maks);
                list.Add(dg);
            }
            double dtb = (float)tong / n;
            dtb = Math.Round(dtb, 1);
            lblDG1.Text = dtb.ToString();
            lblDG2.Text = dtb.ToString();
            lblRT1.Text = rt.ToString();
            lblRT2.Text = rt.ToString();
            lblT1.Text = t.ToString();
            lblT2.Text = t.ToString();
            lblTB1.Text = tb.ToString();
            lblTB2.Text = tb.ToString();
            lblK1.Text = k.ToString();
            lblK2.Text = k.ToString();
            conn.Close();
        }

        void ChenPhong()
        {
            string query = "SELECT * FROM PHONG INNER JOIN QLPHONG ON QLPHONG.MAPHONG=PHONG.MAPHONG WHERE QLPHONG.MAKS = @maks";
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@maks", maks);
            command.CommandTimeout = 120;
            SqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                int maphong = reader.GetInt32(reader.GetOrdinal("MAPHONG"));
                string tenphong = reader.GetString(reader.GetOrdinal("TENPHONG"));
                int sophong = reader.GetInt32(reader.GetOrdinal("SOPHONG"));
                int sophongdd = reader.GetInt32(reader.GetOrdinal("SOPHONG_DD"));
                int sokhach = reader.GetInt32(reader.GetOrdinal("SOKHACH"));
                int sogiuong = reader.GetInt32(reader.GetOrdinal("SOGIUONG"));
                double gia = reader.GetInt32(reader.GetOrdinal("GIA"));
                string anh = reader.GetString(reader.GetOrdinal("ANH"));
                Room room = new Room(sokhach, sogiuong,gia, tenphong, maphong, sophong, sophongdd, anh);
                flbRoom.Controls.Add(new UCPhong(room));
                i++;
            }
            conn.Close();
        }

        void ChenTienNghi()
        {
            string query = "SELECT * FROM QL_TN INNER JOIN TN ON QL_TN.MATN=TN.MATN WHERE QL_TN.MAKS = @maks";
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@maks", maks);
            command.CommandTimeout = 120;
            SqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                int ltn = reader.GetInt32(reader.GetOrdinal("MALTN"));
                if (ltn == 1)
                {
                    flpTNChinh.Controls.Add(new UCTN(reader.GetString(reader.GetOrdinal("TENTN"))));
                }
                if (ltn == 2)
                {
                    flpDVKS.Controls.Add(new UCTN(reader.GetString(reader.GetOrdinal("TENTN"))));
                }
                if (ltn == 3)
                {
                    flpTNCC.Controls.Add(new UCTN(reader.GetString(reader.GetOrdinal("TENTN"))));
                }
                if (ltn == 4)
                {
                    flpFood.Controls.Add(new UCTN(reader.GetString(reader.GetOrdinal("TENTN"))));
                }

                i++;
            }
            conn.Close();
        }

        void ChenTNChinh()
        {
            string query = "SELECT * FROM QL_TN INNER JOIN TN ON QL_TN.MATN=TN.MATN WHERE QL_TN.MAKS = @maks AND MALTN=1";
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@maks", maks);
            command.CommandTimeout = 120;
            SqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                flpTNC.Controls.Add(new UCTNChinh(reader.GetInt32(reader.GetOrdinal("MATN"))));
                i++;
            }
            conn.Close();
        }

        void ChenAnhToTal()
        {
            string query = "SELECT * FROM QL_ANH WHERE QL_ANH.MAKS = @maks";
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@maks", maks);
            command.CommandTimeout = 120;
            SqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {

                if (i == 1)
                {
                    ptbTotalImage1.Image = Image.FromFile(reader.GetString(reader.GetOrdinal("ADDRESS")));
                }
                if (i == 2)
                {
                    ptbTotalImage2.Image = Image.FromFile(reader.GetString(reader.GetOrdinal("ADDRESS")));
                }
                if (i == 3)
                {
                    ptbTotalImage3.Image = Image.FromFile(reader.GetString(reader.GetOrdinal("ADDRESS")));
                }
                if (i == 4)
                {
                    ptbTotalImage4.Image = Image.FromFile(reader.GetString(reader.GetOrdinal("ADDRESS")));
                }
                if (i == 5)
                {
                    ptbTotalImage5.Image = Image.FromFile(reader.GetString(reader.GetOrdinal("ADDRESS")));
                }
                if (i == 6)
                {
                    ptbTotalImage6.Image = Image.FromFile(reader.GetString(reader.GetOrdinal("ADDRESS")));
                }
                if (i == 7)
                {
                    ptbTotalImage7.Image = Image.FromFile(reader.GetString(reader.GetOrdinal("ADDRESS")));
                }
                i++;
            }
            conn.Close();
        }

        void ChenThongTinCanBan()
        {
            string query = "SELECT * FROM ThongTinCanBan inner join ViTri ON ThongTinCanBan.MAKS = ViTri.MAKS WHERE ViTri.MAKS = @maks";
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@maks", maks);
            command.CommandTimeout = 120;
            SqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                lblName.Text = reader.GetString(reader.GetOrdinal("TENKH"));
                lblAddress.Text = reader.GetString(reader.GetOrdinal("DIACHI"));
                int giaColumnIndex = reader.GetOrdinal("GIA");
                if (!reader.IsDBNull(giaColumnIndex))
                {
                    int gia = reader.GetInt32(giaColumnIndex);
                    lblPrice.Text = gia.ToString() + " VNĐ";
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
            FAddAnh f = new FAddAnh();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
