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
            panel1 = new Panel();
            panel3 = new Panel();
            btn_DangNhap = new Button();
            lbl_ChuaCoTaiKhoan = new Label();
            btn_DangKy = new Button();
            panel2 = new Panel();
            txt_MatKhau = new TextBox();
            lbl_MatKhau = new Label();
            txt_TenDangNhap = new TextBox();
            lbl_TenDangNhap = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 242);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_DangNhap);
            panel3.Controls.Add(lbl_ChuaCoTaiKhoan);
            panel3.Controls.Add(btn_DangKy);
            panel3.Location = new Point(14, 134);
            panel3.Name = "panel3";
            panel3.Size = new Size(728, 84);
            panel3.TabIndex = 4;
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.Location = new Point(374, 3);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(94, 29);
            btn_DangNhap.TabIndex = 1;
            btn_DangNhap.Text = "Đăng nhập";
            btn_DangNhap.UseVisualStyleBackColor = true;
            btn_DangNhap.Click += button1_Click;
            // 
            // lbl_ChuaCoTaiKhoan
            // 
            lbl_ChuaCoTaiKhoan.AutoSize = true;
            lbl_ChuaCoTaiKhoan.Location = new Point(23, 48);
            lbl_ChuaCoTaiKhoan.Name = "lbl_ChuaCoTaiKhoan";
            lbl_ChuaCoTaiKhoan.Size = new Size(143, 20);
            lbl_ChuaCoTaiKhoan.TabIndex = 3;
            lbl_ChuaCoTaiKhoan.Text = "Chưa có tài khoản ? ";
            lbl_ChuaCoTaiKhoan.Click += label1_Click_1;
            // 
            // btn_DangKy
            // 
            btn_DangKy.Location = new Point(172, 44);
            btn_DangKy.Name = "btn_DangKy";
            btn_DangKy.Size = new Size(94, 29);
            btn_DangKy.TabIndex = 2;
            btn_DangKy.Text = "Đăng ký";
            btn_DangKy.UseVisualStyleBackColor = true;
            btn_DangKy.Click += btn_DangKy_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txt_MatKhau);
            panel2.Controls.Add(lbl_MatKhau);
            panel2.Controls.Add(txt_TenDangNhap);
            panel2.Controls.Add(lbl_TenDangNhap);
            panel2.Location = new Point(14, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(728, 93);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(154, 50);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(574, 27);
            txt_MatKhau.TabIndex = 3;
            txt_MatKhau.UseSystemPasswordChar = true;
            txt_MatKhau.TextChanged += textBox2_TextChanged;
            // 
            // lbl_MatKhau
            // 
            lbl_MatKhau.AutoSize = true;
            lbl_MatKhau.Location = new Point(23, 53);
            lbl_MatKhau.Name = "lbl_MatKhau";
            lbl_MatKhau.Size = new Size(81, 20);
            lbl_MatKhau.TabIndex = 2;
            lbl_MatKhau.Text = "Mật khẩu : ";
            // 
            // txt_TenDangNhap
            // 
            txt_TenDangNhap.Location = new Point(154, 3);
            txt_TenDangNhap.Name = "txt_TenDangNhap";
            txt_TenDangNhap.Size = new Size(731, 27);
            txt_TenDangNhap.TabIndex = 1;
            txt_TenDangNhap.TextChanged += txt_TenDangNhap_TextChanged;
            // 
            // lbl_TenDangNhap
            // 
            lbl_TenDangNhap.AutoSize = true;
            lbl_TenDangNhap.Location = new Point(23, 9);
            lbl_TenDangNhap.Name = "lbl_TenDangNhap";
            lbl_TenDangNhap.Size = new Size(118, 20);
            lbl_TenDangNhap.TabIndex = 0;
            lbl_TenDangNhap.Text = "Tên đăng nhập : ";
            lbl_TenDangNhap.Click += label1_Click;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 282);
            Controls.Add(panel1);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += fLogin_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txt_TenDangNhap;
        private Label lbl_TenDangNhap;
        private TextBox txt_MatKhau;
        private Label lbl_MatKhau;
        private Button btn_DangNhap;
        private Label lbl_ChuaCoTaiKhoan;
        private Button btn_DangKy;
        private Panel panel3;
    }
}