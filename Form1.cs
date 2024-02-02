namespace DoAnDuLich
{
    public partial class FTrangChuTK : Form
    {
        public FTrangChuTK()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            if (pictureBox1.Visible == false)
            {
                btn_next.Parent = pictureBox1;
                btn_next.BackColor = Color.Transparent;
                btn_back.Parent = pictureBox1;
                btn_back.BackColor = Color.Transparent;
                button2.Parent = pictureBox1;
                button2.BackColor = Color.Transparent;
                button3.Parent = pictureBox1;
                button3.BackColor = Color.Transparent;
                button4.Parent = pictureBox1;
                button4.BackColor = Color.Transparent;
                button5.Parent = pictureBox1;
                button5.BackColor = Color.Transparent;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
            }
            panel1.Parent = pictureBox1;
            panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
            panel2.Parent = pictureBox1;
            panel2.BackColor = Color.FromArgb(80, 0, 0, 0);
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                panel1.Parent = pictureBox2;
                panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
                panel2.Parent = pictureBox2;
                panel2.BackColor = Color.FromArgb(80, 0, 0, 0);
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                label4.Parent = pictureBox2;
                label4.BackColor = Color.Transparent;
                btn_next.Parent = pictureBox2;
                btn_next.BackColor = Color.Transparent;
                btn_back.Parent = pictureBox2;
                btn_back.BackColor = Color.Transparent;
                button2.Parent = pictureBox2;
                button2.BackColor = Color.Transparent;
                button3.Parent = pictureBox2;
                button3.BackColor = Color.Transparent;
                button4.Parent = pictureBox2;
                button4.BackColor = Color.Transparent;
                button5.Parent = pictureBox2;
                button5.BackColor = Color.Transparent;
            }
            else if (pictureBox2.Visible == true)
            {
                panel1.Parent = pictureBox3;
                panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
                panel2.Parent = pictureBox3;
                panel2.BackColor = Color.FromArgb(80, 0, 0, 0);

                pictureBox1.Visible = false;
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                label4.Parent = pictureBox3;
                label4.BackColor = Color.Transparent;
                btn_next.Parent = pictureBox3;
                btn_next.BackColor = Color.Transparent;
                btn_back.Parent = pictureBox3;
                btn_back.BackColor = Color.Transparent;
                button2.Parent = pictureBox3;
                button2.BackColor = Color.Transparent;
                button3.Parent = pictureBox3;
                button3.BackColor = Color.Transparent;
                button4.Parent = pictureBox3;
                button4.BackColor = Color.Transparent;
                button5.Parent = pictureBox3;
                button5.BackColor = Color.Transparent;
            }
            else if (pictureBox3.Visible == true)
            {
                panel1.Parent = pictureBox4;
                panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
                panel2.Parent = pictureBox4;
                panel2.BackColor = Color.FromArgb(80, 0, 0, 0);

                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                label4.Parent = pictureBox4;
                label4.BackColor = Color.Transparent;
                btn_next.Parent = pictureBox4;
                btn_next.BackColor = Color.Transparent;
                btn_back.Parent = pictureBox4;
                btn_back.BackColor = Color.Transparent;
                button2.Parent = pictureBox4;
                button2.BackColor = Color.Transparent;
                button3.Parent = pictureBox4;
                button3.BackColor = Color.Transparent;
                button4.Parent = pictureBox4;
                button4.BackColor = Color.Transparent;
                button5.Parent = pictureBox4;
                button5.BackColor = Color.Transparent;
            }
            else if (pictureBox4.Visible == true)
            {
                panel1.Parent = pictureBox5;
                panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
                panel2.Parent = pictureBox5;
                panel2.BackColor = Color.FromArgb(80, 0, 0, 0);

                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                label4.Parent = pictureBox5;
                label4.BackColor = Color.Transparent;
                btn_next.Parent = pictureBox5;
                btn_next.BackColor = Color.Transparent;
                btn_back.Parent = pictureBox5;
                btn_back.BackColor = Color.Transparent;
                button2.Parent = pictureBox5;
                button2.BackColor = Color.Transparent;
                button3.Parent = pictureBox5;
                button3.BackColor = Color.Transparent;
                button4.Parent = pictureBox5;
                button4.BackColor = Color.Transparent;
                button5.Parent = pictureBox5;
                button5.BackColor = Color.Transparent;
            }
            else
            {
                panel1.Parent = pictureBox1;
                panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
                panel2.Parent = pictureBox1;
                panel2.BackColor = Color.FromArgb(80, 0, 0, 0);

                pictureBox1.Visible = true;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                label4.Parent = pictureBox1;
                label4.BackColor = Color.Transparent;
                btn_next.Parent = pictureBox1;
                btn_next.BackColor = Color.Transparent;
                btn_back.Parent = pictureBox1;
                btn_back.BackColor = Color.Transparent;
                button2.Parent = pictureBox1;
                button2.BackColor = Color.Transparent;
                button3.Parent = pictureBox1;
                button3.BackColor = Color.Transparent;
                button4.Parent = pictureBox1;
                button4.BackColor = Color.Transparent;
                button5.Parent = pictureBox1;
                button5.BackColor = Color.Transparent;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Visible == true)
            {
                panel1.Parent = pictureBox2;
                panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
                panel2.Parent = pictureBox2;
                panel2.BackColor = Color.FromArgb(80, 0, 0, 0);

                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                label4.Parent = pictureBox2;
                label4.BackColor = Color.Transparent;
                btn_back.Parent = pictureBox2;
                btn_back.BackColor = Color.Transparent;
                btn_next.Parent = pictureBox2;
                btn_next.BackColor = Color.Transparent;
                button2.Parent = pictureBox2;
                button2.BackColor = Color.Transparent;
                button3.Parent = pictureBox2;
                button3.BackColor = Color.Transparent;
                button4.Parent = pictureBox2;
                button4.BackColor = Color.Transparent;
                button5.Parent = pictureBox2;
                button5.BackColor = Color.Transparent;
            }
            else if (pictureBox2.Visible == true)
            {
                panel1.Parent = pictureBox3;
                panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
                panel2.Parent = pictureBox3;
                panel2.BackColor = Color.FromArgb(80, 0, 0, 0);

                pictureBox1.Visible = false;
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                label4.Parent = pictureBox3;
                label4.BackColor = Color.Transparent;
                btn_back.Parent = pictureBox3;
                btn_back.BackColor = Color.Transparent;
                btn_next.Parent = pictureBox3;
                btn_next.BackColor = Color.Transparent;
                button2.Parent = pictureBox3;
                button2.BackColor = Color.Transparent;
                button3.Parent = pictureBox3;
                button3.BackColor = Color.Transparent;
                button4.Parent = pictureBox3;
                button4.BackColor = Color.Transparent;
                button5.Parent = pictureBox3;
                button5.BackColor = Color.Transparent;
            }
            else if (pictureBox3.Visible == true)
            {
                panel1.Parent = pictureBox4;
                panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
                panel2.Parent = pictureBox4;
                panel2.BackColor = Color.FromArgb(80, 0, 0, 0);

                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                label4.Parent = pictureBox4;
                label4.BackColor = Color.Transparent;
                btn_back.Parent = pictureBox4;
                btn_back.BackColor = Color.Transparent;
                btn_next.Parent = pictureBox4;
                btn_next.BackColor = Color.Transparent;
                button2.Parent = pictureBox4;
                button2.BackColor = Color.Transparent;
                button3.Parent = pictureBox4;
                button3.BackColor = Color.Transparent;
                button4.Parent = pictureBox4;
                button4.BackColor = Color.Transparent;
                button5.Parent = pictureBox4;
                button5.BackColor = Color.Transparent;
            }
            else if (pictureBox4.Visible == true)
            {
                panel1.Parent = pictureBox5;
                panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
                panel2.Parent = pictureBox5;
                panel2.BackColor = Color.FromArgb(80, 0, 0, 0);

                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                label4.Parent = pictureBox5;
                label4.BackColor = Color.Transparent;
                btn_back.Parent = pictureBox5;
                btn_back.BackColor = Color.Transparent;
                btn_next.Parent = pictureBox5;
                btn_next.BackColor = Color.Transparent;
                button2.Parent = pictureBox5;
                button2.BackColor = Color.Transparent;
                button3.Parent = pictureBox5;
                button3.BackColor = Color.Transparent;
                button4.Parent = pictureBox5;
                button4.BackColor = Color.Transparent;
                button5.Parent = pictureBox5;
                button5.BackColor = Color.Transparent;
            }
            else
            {
                panel1.Parent = pictureBox1;
                panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
                panel2.Parent = pictureBox1;
                panel2.BackColor = Color.FromArgb(80, 0, 0, 0);

                pictureBox1.Visible = true;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                label4.Parent = pictureBox1;
                label4.BackColor = Color.Transparent;
                btn_back.Parent = pictureBox1;
                btn_back.BackColor = Color.Transparent;
                btn_next.Parent = pictureBox1;
                btn_next.BackColor = Color.Transparent;
                button2.Parent = pictureBox1;
                button2.BackColor = Color.Transparent;
                button3.Parent = pictureBox1;
                button3.BackColor = Color.Transparent;
                button4.Parent = pictureBox1;
                button4.BackColor = Color.Transparent;
                button5.Parent = pictureBox1;
                button5.BackColor = Color.Transparent;
            }
        }

        private void btn_next_Paint(object sender, PaintEventArgs e)
        {
            btn_next.BackColor = Color.Transparent;
        }
    }
}