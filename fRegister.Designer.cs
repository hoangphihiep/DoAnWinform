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
            lbl_TaoMotNguoiSuDungMoi = new Label();
            lbl_ThemNguoiDungMoi = new Label();
            cbb_GioiTinh = new TextBox();
            lbl_NgayThangNamSinh = new Label();
            dtp_NgayThangNamSinh = new DateTimePicker();
            lbl_GioiTinh = new Label();
            txt_DiaChi = new TextBox();
            lbl_DiaChi = new Label();
            txt_SoDienThoai = new TextBox();
            lbl_SoDienThoai = new Label();
            txt_Email = new TextBox();
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
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.dulichPhuQuoc_1649392573_9234_1649405369;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(808, 720);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(cb_ToiDongY);
            panel3.Controls.Add(btn_DangKy);
            panel3.Controls.Add(lbl_ChuaCoTaiKhoan);
            panel3.Location = new Point(3, 627);
            panel3.Name = "panel3";
            panel3.Size = new Size(646, 84);
            panel3.TabIndex = 4;
            panel3.Paint += panel3_Paint;
            // 
            // cb_ToiDongY
            // 
            cb_ToiDongY.AutoSize = true;
            cb_ToiDongY.BackColor = SystemColors.ControlLightLight;
            cb_ToiDongY.Location = new Point(23, 16);
            cb_ToiDongY.Name = "cb_ToiDongY";
            cb_ToiDongY.Size = new Size(426, 24);
            cb_ToiDongY.TabIndex = 10;
            cb_ToiDongY.Text = "Tôi đồng ý với những điều khoản và điều kiện của ứng dụng";
            cb_ToiDongY.UseVisualStyleBackColor = false;
            cb_ToiDongY.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btn_DangKy
            // 
            btn_DangKy.BackColor = SystemColors.ControlLightLight;
            btn_DangKy.Location = new Point(515, 16);
            btn_DangKy.Name = "btn_DangKy";
            btn_DangKy.Size = new Size(94, 29);
            btn_DangKy.TabIndex = 11;
            btn_DangKy.Text = "Đăng ký";
            btn_DangKy.UseVisualStyleBackColor = false;
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
            panel2.AccessibleRole = AccessibleRole.IpAddress;
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lbl_TaoMotNguoiSuDungMoi);
            panel2.Controls.Add(lbl_ThemNguoiDungMoi);
            panel2.Controls.Add(cbb_GioiTinh);
            panel2.Controls.Add(lbl_NgayThangNamSinh);
            panel2.Controls.Add(dtp_NgayThangNamSinh);
            panel2.Controls.Add(lbl_GioiTinh);
            panel2.Controls.Add(txt_DiaChi);
            panel2.Controls.Add(lbl_DiaChi);
            panel2.Controls.Add(txt_SoDienThoai);
            panel2.Controls.Add(lbl_SoDienThoai);
            panel2.Controls.Add(txt_Email);
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
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(646, 618);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint_1;
            // 
            // lbl_TaoMotNguoiSuDungMoi
            // 
            lbl_TaoMotNguoiSuDungMoi.AutoSize = true;
            lbl_TaoMotNguoiSuDungMoi.BackColor = SystemColors.ControlLightLight;
            lbl_TaoMotNguoiSuDungMoi.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TaoMotNguoiSuDungMoi.Location = new Point(23, 55);
            lbl_TaoMotNguoiSuDungMoi.Name = "lbl_TaoMotNguoiSuDungMoi";
            lbl_TaoMotNguoiSuDungMoi.Size = new Size(301, 17);
            lbl_TaoMotNguoiSuDungMoi.TabIndex = 21;
            lbl_TaoMotNguoiSuDungMoi.Text = "Tạo một người sử dụng mới vào ứng dụng này";
            // 
            // lbl_ThemNguoiDungMoi
            // 
            lbl_ThemNguoiDungMoi.AutoSize = true;
            lbl_ThemNguoiDungMoi.BackColor = SystemColors.ControlLightLight;
            lbl_ThemNguoiDungMoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ThemNguoiDungMoi.Location = new Point(23, 17);
            lbl_ThemNguoiDungMoi.Name = "lbl_ThemNguoiDungMoi";
            lbl_ThemNguoiDungMoi.Size = new Size(224, 28);
            lbl_ThemNguoiDungMoi.TabIndex = 20;
            lbl_ThemNguoiDungMoi.Text = "Thêm người dùng mới";
            // 
            // cbb_GioiTinh
            // 
            cbb_GioiTinh.Location = new Point(182, 207);
            cbb_GioiTinh.Name = "cbb_GioiTinh";
            cbb_GioiTinh.Size = new Size(281, 27);
            cbb_GioiTinh.TabIndex = 3;
            // 
            // lbl_NgayThangNamSinh
            // 
            lbl_NgayThangNamSinh.AutoSize = true;
            lbl_NgayThangNamSinh.BackColor = SystemColors.ControlLightLight;
            lbl_NgayThangNamSinh.Location = new Point(18, 321);
            lbl_NgayThangNamSinh.Name = "lbl_NgayThangNamSinh";
            lbl_NgayThangNamSinh.Size = new Size(156, 20);
            lbl_NgayThangNamSinh.TabIndex = 17;
            lbl_NgayThangNamSinh.Text = "Ngày tháng năm sinh :";
            // 
            // dtp_NgayThangNamSinh
            // 
            dtp_NgayThangNamSinh.Location = new Point(182, 314);
            dtp_NgayThangNamSinh.Name = "dtp_NgayThangNamSinh";
            dtp_NgayThangNamSinh.Size = new Size(281, 27);
            dtp_NgayThangNamSinh.TabIndex = 5;
            dtp_NgayThangNamSinh.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lbl_GioiTinh
            // 
            lbl_GioiTinh.AutoSize = true;
            lbl_GioiTinh.BackColor = SystemColors.ControlLightLight;
            lbl_GioiTinh.Location = new Point(18, 214);
            lbl_GioiTinh.Name = "lbl_GioiTinh";
            lbl_GioiTinh.Size = new Size(72, 20);
            lbl_GioiTinh.TabIndex = 15;
            lbl_GioiTinh.Text = "Giới tính :";
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Location = new Point(182, 266);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(281, 27);
            txt_DiaChi.TabIndex = 4;
            txt_DiaChi.TextChanged += textBox3_TextChanged;
            // 
            // lbl_DiaChi
            // 
            lbl_DiaChi.AutoSize = true;
            lbl_DiaChi.BackColor = SystemColors.ControlLightLight;
            lbl_DiaChi.Location = new Point(18, 273);
            lbl_DiaChi.Name = "lbl_DiaChi";
            lbl_DiaChi.Size = new Size(62, 20);
            lbl_DiaChi.TabIndex = 13;
            lbl_DiaChi.Text = "Địa chỉ :";
            lbl_DiaChi.Click += label2_Click_1;
            // 
            // txt_SoDienThoai
            // 
            txt_SoDienThoai.Location = new Point(182, 418);
            txt_SoDienThoai.Name = "txt_SoDienThoai";
            txt_SoDienThoai.Size = new Size(281, 27);
            txt_SoDienThoai.TabIndex = 7;
            // 
            // lbl_SoDienThoai
            // 
            lbl_SoDienThoai.AutoSize = true;
            lbl_SoDienThoai.BackColor = SystemColors.ControlLightLight;
            lbl_SoDienThoai.Location = new Point(18, 421);
            lbl_SoDienThoai.Name = "lbl_SoDienThoai";
            lbl_SoDienThoai.Size = new Size(104, 20);
            lbl_SoDienThoai.TabIndex = 11;
            lbl_SoDienThoai.Text = "Số điện thoại :";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(182, 362);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(281, 27);
            txt_Email.TabIndex = 6;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.BackColor = SystemColors.ControlLightLight;
            lbl_Email.Location = new Point(18, 369);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(53, 20);
            lbl_Email.TabIndex = 9;
            lbl_Email.Text = "Email :";
            lbl_Email.Click += lbl_Email_Click;
            // 
            // txt_NhapLaiMatKhau
            // 
            txt_NhapLaiMatKhau.Location = new Point(182, 516);
            txt_NhapLaiMatKhau.Name = "txt_NhapLaiMatKhau";
            txt_NhapLaiMatKhau.Size = new Size(281, 27);
            txt_NhapLaiMatKhau.TabIndex = 9;
            txt_NhapLaiMatKhau.UseSystemPasswordChar = true;
            txt_NhapLaiMatKhau.TextChanged += txt_MatKhau_TextChanged;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(182, 468);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(281, 27);
            txt_MatKhau.TabIndex = 8;
            txt_MatKhau.UseSystemPasswordChar = true;
            // 
            // lbl_NhapLaiMatKhau
            // 
            lbl_NhapLaiMatKhau.AutoSize = true;
            lbl_NhapLaiMatKhau.BackColor = SystemColors.ControlLightLight;
            lbl_NhapLaiMatKhau.Location = new Point(18, 520);
            lbl_NhapLaiMatKhau.Name = "lbl_NhapLaiMatKhau";
            lbl_NhapLaiMatKhau.Size = new Size(137, 20);
            lbl_NhapLaiMatKhau.TabIndex = 4;
            lbl_NhapLaiMatKhau.Text = "Nhập lại mật khẩu :";
            lbl_NhapLaiMatKhau.Click += lbl_NhapLaiMatKhau_Click;
            // 
            // lbl_MatKhau
            // 
            lbl_MatKhau.AutoSize = true;
            lbl_MatKhau.BackColor = SystemColors.ControlLightLight;
            lbl_MatKhau.Location = new Point(18, 472);
            lbl_MatKhau.Name = "lbl_MatKhau";
            lbl_MatKhau.Size = new Size(81, 20);
            lbl_MatKhau.TabIndex = 7;
            lbl_MatKhau.Text = "Mật khẩu : ";
            // 
            // txt_HoVaTen
            // 
            txt_HoVaTen.Location = new Point(182, 148);
            txt_HoVaTen.Name = "txt_HoVaTen";
            txt_HoVaTen.Size = new Size(281, 27);
            txt_HoVaTen.TabIndex = 2;
            // 
            // lbl_HoVaTen
            // 
            lbl_HoVaTen.AutoSize = true;
            lbl_HoVaTen.BackColor = SystemColors.ControlLightLight;
            lbl_HoVaTen.Location = new Point(18, 155);
            lbl_HoVaTen.Name = "lbl_HoVaTen";
            lbl_HoVaTen.Size = new Size(82, 20);
            lbl_HoVaTen.TabIndex = 5;
            lbl_HoVaTen.Text = "Họ và Tên :";
            lbl_HoVaTen.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 129);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 4;
            // 
            // txt_TenDangNhap
            // 
            txt_TenDangNhap.Location = new Point(182, 96);
            txt_TenDangNhap.Name = "txt_TenDangNhap";
            txt_TenDangNhap.Size = new Size(281, 27);
            txt_TenDangNhap.TabIndex = 1;
            txt_TenDangNhap.TextChanged += txt_TenDangNhap_TextChanged;
            // 
            // lbl_TenDangNhap
            // 
            lbl_TenDangNhap.AutoSize = true;
            lbl_TenDangNhap.BackColor = SystemColors.ControlLightLight;
            lbl_TenDangNhap.Location = new Point(18, 102);
            lbl_TenDangNhap.Name = "lbl_TenDangNhap";
            lbl_TenDangNhap.Size = new Size(118, 20);
            lbl_TenDangNhap.TabIndex = 0;
            lbl_TenDangNhap.Text = "Tên đăng nhập : ";
            lbl_TenDangNhap.Click += lbl_TenDangNhap_Click;
            // 
            // fRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 735);
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
        private TextBox txt_NhapLaiMatKhau;
        private TextBox txt_MatKhau;
        private Label lbl_NhapLaiMatKhau;
        private Label lbl_MatKhau;
        private TextBox txt_HoVaTen;
        private Label lbl_HoVaTen;
        private TextBox txt_Email;
        private Label lbl_Email;
        private TextBox txt_SoDienThoai;
        private Label lbl_SoDienThoai;
        private TextBox txt_DiaChi;
        private Label lbl_DiaChi;
        private Label lbl_GioiTinh;
        private Label lbl_NgayThangNamSinh;
        private DateTimePicker dtp_NgayThangNamSinh;
        private CheckBox cb_ToiDongY;
        private TextBox cbb_GioiTinh;
        private Label lbl_TaoMotNguoiSuDungMoi;
        private Label lbl_ThemNguoiDungMoi;
    }
}