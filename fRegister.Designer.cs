namespace DuLich
{
    partial class fRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            cb_ToiDongY = new CheckBox();
            btn_DangKy = new Button();
            lbl_ChuaCoTaiKhoan = new Label();
            panel2 = new Panel();
            textBox3 = new TextBox();
            lbl_NgayThangNamSinh = new Label();
            dateTimePicker1 = new DateTimePicker();
            lbl_GioiTinh = new Label();
            txt_DiaChi = new TextBox();
            lbl_DiaChi = new Label();
            textBox2 = new TextBox();
            lbl_SoDienThoai = new Label();
            textBox1 = new TextBox();
            lbl_Email = new Label();
            txt_NhapLaiMatKhau = new TextBox();
            txt_MatKhau = new TextBox();
            lbl_NhapLaiMatKhau = new Label();
            lbl_MatKhau = new Label();
            txt_HoVaTen = new TextBox();
            lbl_HoVaTen = new Label();
            label1 = new Label();
            txt_TenDangNhap = new TextBox();
            lbl_TenDangNhap = new Label();
            panel4 = new Panel();
            lbl_TaoMotNguoiSuDungMoi = new Label();
            lbl_ThemNguoiDungMoi = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 644);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(cb_ToiDongY);
            panel3.Controls.Add(btn_DangKy);
            panel3.Controls.Add(lbl_ChuaCoTaiKhoan);
            panel3.Location = new Point(37, 524);
            panel3.Name = "panel3";
            panel3.Size = new Size(748, 84);
            panel3.TabIndex = 4;
            panel3.Paint += panel3_Paint;
            // 
            // cb_ToiDongY
            // 
            cb_ToiDongY.AutoSize = true;
            cb_ToiDongY.Location = new Point(23, 16);
            cb_ToiDongY.Name = "cb_ToiDongY";
            cb_ToiDongY.Size = new Size(426, 24);
            cb_ToiDongY.TabIndex = 10;
            cb_ToiDongY.Text = "Tôi đồng ý với những điều khoản và điều kiện của ứng dụng";
            cb_ToiDongY.UseVisualStyleBackColor = true;
            cb_ToiDongY.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btn_DangKy
            // 
            btn_DangKy.Location = new Point(608, 13);
            btn_DangKy.Name = "btn_DangKy";
            btn_DangKy.Size = new Size(94, 29);
            btn_DangKy.TabIndex = 11;
            btn_DangKy.Text = "Đăng ký";
            btn_DangKy.UseVisualStyleBackColor = true;
            btn_DangKy.Click += btn_DangNhap_Click;
            // 
            // lbl_ChuaCoTaiKhoan
            // 
            lbl_ChuaCoTaiKhoan.AutoSize = true;
            lbl_ChuaCoTaiKhoan.Location = new Point(23, 46);
            lbl_ChuaCoTaiKhoan.Name = "lbl_ChuaCoTaiKhoan";
            lbl_ChuaCoTaiKhoan.Size = new Size(0, 20);
            lbl_ChuaCoTaiKhoan.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(lbl_NgayThangNamSinh);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(lbl_GioiTinh);
            panel2.Controls.Add(txt_DiaChi);
            panel2.Controls.Add(lbl_DiaChi);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(lbl_SoDienThoai);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(lbl_Email);
            panel2.Controls.Add(txt_NhapLaiMatKhau);
            panel2.Controls.Add(txt_MatKhau);
            panel2.Controls.Add(lbl_NhapLaiMatKhau);
            panel2.Controls.Add(lbl_MatKhau);
            panel2.Controls.Add(txt_HoVaTen);
            panel2.Controls.Add(lbl_HoVaTen);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txt_TenDangNhap);
            panel2.Controls.Add(lbl_TenDangNhap);
            panel2.Location = new Point(37, 17);
            panel2.Name = "panel2";
            panel2.Size = new Size(748, 501);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint_1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(187, 114);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(551, 27);
            textBox3.TabIndex = 3;
            // 
            // lbl_NgayThangNamSinh
            // 
            lbl_NgayThangNamSinh.AutoSize = true;
            lbl_NgayThangNamSinh.Location = new Point(23, 228);
            lbl_NgayThangNamSinh.Name = "lbl_NgayThangNamSinh";
            lbl_NgayThangNamSinh.Size = new Size(156, 20);
            lbl_NgayThangNamSinh.TabIndex = 17;
            lbl_NgayThangNamSinh.Text = "Ngày tháng năm sinh :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(187, 221);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(551, 27);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lbl_GioiTinh
            // 
            lbl_GioiTinh.AutoSize = true;
            lbl_GioiTinh.Location = new Point(23, 121);
            lbl_GioiTinh.Name = "lbl_GioiTinh";
            lbl_GioiTinh.Size = new Size(72, 20);
            lbl_GioiTinh.TabIndex = 15;
            lbl_GioiTinh.Text = "Giới tính :";
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Location = new Point(187, 173);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(551, 27);
            txt_DiaChi.TabIndex = 4;
            txt_DiaChi.TextChanged += textBox3_TextChanged;
            // 
            // lbl_DiaChi
            // 
            lbl_DiaChi.AutoSize = true;
            lbl_DiaChi.Location = new Point(23, 180);
            lbl_DiaChi.Name = "lbl_DiaChi";
            lbl_DiaChi.Size = new Size(62, 20);
            lbl_DiaChi.TabIndex = 13;
            lbl_DiaChi.Text = "Địa chỉ :";
            lbl_DiaChi.Click += label2_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(187, 321);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(551, 27);
            textBox2.TabIndex = 7;
            // 
            // lbl_SoDienThoai
            // 
            lbl_SoDienThoai.AutoSize = true;
            lbl_SoDienThoai.Location = new Point(23, 328);
            lbl_SoDienThoai.Name = "lbl_SoDienThoai";
            lbl_SoDienThoai.Size = new Size(104, 20);
            lbl_SoDienThoai.TabIndex = 11;
            lbl_SoDienThoai.Text = "Số điện thoại :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(187, 269);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(551, 27);
            textBox1.TabIndex = 6;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(23, 276);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(53, 20);
            lbl_Email.TabIndex = 9;
            lbl_Email.Text = "Email :";
            lbl_Email.Click += lbl_Email_Click;
            // 
            // txt_NhapLaiMatKhau
            // 
            txt_NhapLaiMatKhau.Location = new Point(187, 423);
            txt_NhapLaiMatKhau.Name = "txt_NhapLaiMatKhau";
            txt_NhapLaiMatKhau.Size = new Size(551, 27);
            txt_NhapLaiMatKhau.TabIndex = 9;
            txt_NhapLaiMatKhau.UseSystemPasswordChar = true;
            txt_NhapLaiMatKhau.TextChanged += txt_MatKhau_TextChanged;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(187, 375);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(551, 27);
            txt_MatKhau.TabIndex = 8;
            txt_MatKhau.UseSystemPasswordChar = true;
            // 
            // lbl_NhapLaiMatKhau
            // 
            lbl_NhapLaiMatKhau.AutoSize = true;
            lbl_NhapLaiMatKhau.Location = new Point(23, 427);
            lbl_NhapLaiMatKhau.Name = "lbl_NhapLaiMatKhau";
            lbl_NhapLaiMatKhau.Size = new Size(137, 20);
            lbl_NhapLaiMatKhau.TabIndex = 4;
            lbl_NhapLaiMatKhau.Text = "Nhập lại mật khẩu :";
            lbl_NhapLaiMatKhau.Click += lbl_NhapLaiMatKhau_Click;
            // 
            // lbl_MatKhau
            // 
            lbl_MatKhau.AutoSize = true;
            lbl_MatKhau.Location = new Point(23, 379);
            lbl_MatKhau.Name = "lbl_MatKhau";
            lbl_MatKhau.Size = new Size(81, 20);
            lbl_MatKhau.TabIndex = 7;
            lbl_MatKhau.Text = "Mật khẩu : ";
            // 
            // txt_HoVaTen
            // 
            txt_HoVaTen.Location = new Point(187, 55);
            txt_HoVaTen.Name = "txt_HoVaTen";
            txt_HoVaTen.Size = new Size(551, 27);
            txt_HoVaTen.TabIndex = 2;
            // 
            // lbl_HoVaTen
            // 
            lbl_HoVaTen.AutoSize = true;
            lbl_HoVaTen.Location = new Point(23, 62);
            lbl_HoVaTen.Name = "lbl_HoVaTen";
            lbl_HoVaTen.Size = new Size(82, 20);
            lbl_HoVaTen.TabIndex = 5;
            lbl_HoVaTen.Text = "Họ và Tên :";
            lbl_HoVaTen.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(305, 36);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 4;
            // 
            // txt_TenDangNhap
            // 
            txt_TenDangNhap.Location = new Point(187, 2);
            txt_TenDangNhap.Name = "txt_TenDangNhap";
            txt_TenDangNhap.Size = new Size(551, 27);
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
            lbl_TenDangNhap.Click += lbl_TenDangNhap_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(lbl_TaoMotNguoiSuDungMoi);
            panel4.Controls.Add(lbl_ThemNguoiDungMoi);
            panel4.Location = new Point(12, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(808, 95);
            panel4.TabIndex = 2;
            panel4.Paint += panel4_Paint;
            // 
            // lbl_TaoMotNguoiSuDungMoi
            // 
            lbl_TaoMotNguoiSuDungMoi.AutoSize = true;
            lbl_TaoMotNguoiSuDungMoi.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TaoMotNguoiSuDungMoi.Location = new Point(37, 54);
            lbl_TaoMotNguoiSuDungMoi.Name = "lbl_TaoMotNguoiSuDungMoi";
            lbl_TaoMotNguoiSuDungMoi.Size = new Size(301, 17);
            lbl_TaoMotNguoiSuDungMoi.TabIndex = 6;
            lbl_TaoMotNguoiSuDungMoi.Text = "Tạo một người sử dụng mới vào ứng dụng này";
            // 
            // lbl_ThemNguoiDungMoi
            // 
            lbl_ThemNguoiDungMoi.AutoSize = true;
            lbl_ThemNguoiDungMoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ThemNguoiDungMoi.Location = new Point(37, 16);
            lbl_ThemNguoiDungMoi.Name = "lbl_ThemNguoiDungMoi";
            lbl_ThemNguoiDungMoi.Size = new Size(224, 28);
            lbl_ThemNguoiDungMoi.TabIndex = 5;
            lbl_ThemNguoiDungMoi.Text = "Thêm người dùng mới";
            lbl_ThemNguoiDungMoi.Click += label2_Click;
            // 
            // fRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 918);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "fRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký";
            FormClosing += fRegister_FormClosing;
            Load += fRegister_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Button btn_DangKy;
        private Label lbl_ChuaCoTaiKhoan;
        private Panel panel2;
        private Label label1;
        private TextBox txt_TenDangNhap;
        private Label lbl_TenDangNhap;
        private Panel panel4;
        private Label lbl_ThemNguoiDungMoi;
        private Label lbl_TaoMotNguoiSuDungMoi;
        private TextBox txt_NhapLaiMatKhau;
        private TextBox txt_MatKhau;
        private Label lbl_NhapLaiMatKhau;
        private Label lbl_MatKhau;
        private TextBox txt_HoVaTen;
        private Label lbl_HoVaTen;
        private TextBox textBox1;
        private Label lbl_Email;
        private TextBox textBox2;
        private Label lbl_SoDienThoai;
        private TextBox txt_DiaChi;
        private Label lbl_DiaChi;
        private Label lbl_GioiTinh;
        private Label lbl_NgayThangNamSinh;
        private DateTimePicker dateTimePicker1;
        private CheckBox cb_ToiDongY;
        private TextBox textBox3;
    }
}