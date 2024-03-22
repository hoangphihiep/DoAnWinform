namespace DuLich
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            btn_DangKy = new Button();
            pictureBox1 = new PictureBox();
            txt_TenDangNhap = new TextBox();
            pictureBox2 = new PictureBox();
            txt_MatKhau = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            btn_DangNhap = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btn_DangKy
            // 
            btn_DangKy.FlatStyle = FlatStyle.Popup;
            btn_DangKy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DangKy.Location = new Point(46, 400);
            btn_DangKy.Name = "btn_DangKy";
            btn_DangKy.Size = new Size(319, 54);
            btn_DangKy.TabIndex = 4;
            btn_DangKy.Text = "Đăng ký";
            btn_DangKy.UseVisualStyleBackColor = true;
            btn_DangKy.Click += btn_DangKy_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(134, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // txt_TenDangNhap
            // 
            txt_TenDangNhap.BorderStyle = BorderStyle.None;
            txt_TenDangNhap.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_TenDangNhap.Location = new Point(111, 224);
            txt_TenDangNhap.Name = "txt_TenDangNhap";
            txt_TenDangNhap.Size = new Size(254, 21);
            txt_TenDangNhap.TabIndex = 1;
            txt_TenDangNhap.Text = "Tên tài khoản";
            txt_TenDangNhap.MouseClick += txt_TenDangNhap_MouseClick;
            txt_TenDangNhap.TextChanged += txt_TenDangNhap_TextChanged;
            txt_TenDangNhap.MouseEnter += txt_TenDangNhap_MouseEnter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(105, 116);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(177, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.BorderStyle = BorderStyle.None;
            txt_MatKhau.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_MatKhau.Location = new Point(111, 284);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(254, 21);
            txt_MatKhau.TabIndex = 2;
            txt_MatKhau.Text = "Mật khẩu";
            txt_MatKhau.UseSystemPasswordChar = true;
            txt_MatKhau.MouseClick += txt_MatKhau_MouseClick;
            txt_MatKhau.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(46, 214);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(46, 274);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 37);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(111, 243);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 1);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(111, 303);
            panel2.Name = "panel2";
            panel2.Size = new Size(254, 1);
            panel2.TabIndex = 10;
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.BackColor = Color.Azure;
            btn_DangNhap.FlatStyle = FlatStyle.Popup;
            btn_DangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DangNhap.Location = new Point(46, 332);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(319, 52);
            btn_DangNhap.TabIndex = 3;
            btn_DangNhap.Text = "Đăng nhập";
            btn_DangNhap.UseVisualStyleBackColor = false;
            btn_DangNhap.Click += btn_DangNhap_Click;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(407, 499);
            Controls.Add(btn_DangNhap);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Controls.Add(btn_DangKy);
            Controls.Add(txt_MatKhau);
            Controls.Add(pictureBox3);
            Controls.Add(txt_TenDangNhap);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += fLogin_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_DangKy;
        private PictureBox pictureBox1;
        private TextBox txt_TenDangNhap;
        private PictureBox pictureBox2;
        private TextBox txt_MatKhau;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel panel1;
        private Panel panel2;
        private Button btn_DangNhap;
    }
}