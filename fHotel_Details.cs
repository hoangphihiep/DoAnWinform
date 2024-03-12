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

        private void fHotel_Details_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
