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
    public partial class Phong : UserControl
    {
        public Phong()
        {
            InitializeComponent();
        }

        private void ptb_AnhBia_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptb_AnhBia.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
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

        }
    }
}
