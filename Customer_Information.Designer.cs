namespace DuLich
{
    partial class Customer_Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Information));
            lbl_Email = new Label();
            txt_Email = new TextBox();
            label1 = new Label();
            lbl_DatCho = new Label();
            lbl_ThongTinThanhToan = new Label();
            lbl_ThongTinKhachHang = new Label();
            panel2 = new Panel();
            btn_NEXT = new Button();
            lbl_ChonLoaiHinh = new Label();
            lbl_ChoKhachHangXem = new Label();
            panel1 = new Panel();
            lbl_NhanUuDai = new Label();
            btn_DangNhap = new Button();
            lbl_SoDienThoai = new Label();
            txt_SoDienThoai = new TextBox();
            txt_NgayThangNamSinh = new Label();
            label6 = new Label();
            lbl_DiaChi = new Label();
            txt_DiaChi = new TextBox();
            lbl_GioiTinh = new Label();
            txt_GioiTinh = new TextBox();
            label5 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            lbl_TuanTheo = new Label();
            lbl_Gia = new Label();
            lbl_ThanHToan = new Label();
            lbl_BaoGom = new Label();
            lbl_GiaPhong = new Label();
            panel10 = new Panel();
            btn_ThayDoi = new Button();
            panel11 = new Panel();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            lbl_34 = new Label();
            lbl_ChucMung = new Label();
            lbl_NeuBan = new Label();
            txt_HoVaTen = new TextBox();
            dtp_NgayThangNamSinh = new DateTimePicker();
            cbb_MaGiamGia = new ComboBox();
            lbl_MaGiamGia = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Email.Location = new Point(17, 506);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(65, 23);
            lbl_Email.TabIndex = 81;
            lbl_Email.Text = "Email : ";
            lbl_Email.Click += lbl_Email_Click;
            // 
            // txt_Email
            // 
            txt_Email.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Email.Location = new Point(18, 542);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(447, 30);
            txt_Email.TabIndex = 80;
            txt_Email.TextChanged += txt_Email_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(26, 333);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 74;
            // 
            // lbl_DatCho
            // 
            lbl_DatCho.AutoSize = true;
            lbl_DatCho.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_DatCho.Location = new Point(23, 153);
            lbl_DatCho.Name = "lbl_DatCho";
            lbl_DatCho.Size = new Size(263, 35);
            lbl_DatCho.TabIndex = 7;
            lbl_DatCho.Text = "3.Đặt chỗ hoàn thành\r\n";
            // 
            // lbl_ThongTinThanhToan
            // 
            lbl_ThongTinThanhToan.AutoSize = true;
            lbl_ThongTinThanhToan.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ThongTinThanhToan.ForeColor = SystemColors.Desktop;
            lbl_ThongTinThanhToan.Location = new Point(23, 86);
            lbl_ThongTinThanhToan.Name = "lbl_ThongTinThanhToan";
            lbl_ThongTinThanhToan.Size = new Size(280, 35);
            lbl_ThongTinThanhToan.TabIndex = 6;
            lbl_ThongTinThanhToan.Text = "2.Thông tin thanh toán";
            lbl_ThongTinThanhToan.Click += lbl_Payment_information_Click;
            // 
            // lbl_ThongTinKhachHang
            // 
            lbl_ThongTinKhachHang.AutoSize = true;
            lbl_ThongTinKhachHang.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ThongTinKhachHang.ForeColor = SystemColors.Highlight;
            lbl_ThongTinKhachHang.Location = new Point(23, 20);
            lbl_ThongTinKhachHang.Name = "lbl_ThongTinKhachHang";
            lbl_ThongTinKhachHang.Size = new Size(283, 35);
            lbl_ThongTinKhachHang.TabIndex = 5;
            lbl_ThongTinKhachHang.Text = "1.Thông tin khách hàng";
            lbl_ThongTinKhachHang.Click += lbl_Customer_information_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbl_DatCho);
            panel2.Controls.Add(lbl_ThongTinThanhToan);
            panel2.Controls.Add(lbl_ThongTinKhachHang);
            panel2.Location = new Point(-11, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(316, 579);
            panel2.TabIndex = 12;
            // 
            // btn_NEXT
            // 
            btn_NEXT.BackColor = SystemColors.Highlight;
            btn_NEXT.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_NEXT.ForeColor = SystemColors.ButtonHighlight;
            btn_NEXT.Location = new Point(687, 876);
            btn_NEXT.Name = "btn_NEXT";
            btn_NEXT.Size = new Size(136, 56);
            btn_NEXT.TabIndex = 35;
            btn_NEXT.Text = "NEXT";
            btn_NEXT.UseVisualStyleBackColor = false;
            btn_NEXT.Click += btn_NEXT_Click;
            // 
            // lbl_ChonLoaiHinh
            // 
            lbl_ChonLoaiHinh.AutoSize = true;
            lbl_ChonLoaiHinh.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_ChonLoaiHinh.Location = new Point(35, 419);
            lbl_ChonLoaiHinh.Name = "lbl_ChonLoaiHinh";
            lbl_ChonLoaiHinh.Size = new Size(0, 31);
            lbl_ChonLoaiHinh.TabIndex = 5;
            // 
            // lbl_ChoKhachHangXem
            // 
            lbl_ChoKhachHangXem.AutoSize = true;
            lbl_ChoKhachHangXem.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_ChoKhachHangXem.Location = new Point(39, 168);
            lbl_ChoKhachHangXem.Name = "lbl_ChoKhachHangXem";
            lbl_ChoKhachHangXem.Size = new Size(0, 38);
            lbl_ChoKhachHangXem.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(lbl_MaGiamGia);
            panel1.Controls.Add(cbb_MaGiamGia);
            panel1.Controls.Add(lbl_NhanUuDai);
            panel1.Controls.Add(btn_DangNhap);
            panel1.Controls.Add(lbl_SoDienThoai);
            panel1.Controls.Add(txt_SoDienThoai);
            panel1.Controls.Add(txt_NgayThangNamSinh);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lbl_DiaChi);
            panel1.Controls.Add(txt_DiaChi);
            panel1.Controls.Add(lbl_GioiTinh);
            panel1.Controls.Add(txt_GioiTinh);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(lbl_34);
            panel1.Controls.Add(lbl_ChucMung);
            panel1.Controls.Add(lbl_NeuBan);
            panel1.Controls.Add(txt_HoVaTen);
            panel1.Controls.Add(dtp_NgayThangNamSinh);
            panel1.Controls.Add(lbl_Email);
            panel1.Controls.Add(txt_Email);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_NEXT);
            panel1.Controls.Add(lbl_ChonLoaiHinh);
            panel1.Controls.Add(lbl_ChoKhachHangXem);
            panel1.Location = new Point(311, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1079, 579);
            panel1.TabIndex = 13;
            panel1.TabStop = true;
            // 
            // lbl_NhanUuDai
            // 
            lbl_NhanUuDai.AutoSize = true;
            lbl_NhanUuDai.Location = new Point(16, 64);
            lbl_NhanUuDai.Name = "lbl_NhanUuDai";
            lbl_NhanUuDai.Size = new Size(298, 40);
            lbl_NhanUuDai.TabIndex = 131;
            lbl_NhanUuDai.Text = "Nhận ưu đãi độc quyền và tận hưởng nhiều \r\nlợi ích hơn khi bạn đăng nhập.";
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.Location = new Point(369, 56);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(158, 63);
            btn_DangNhap.TabIndex = 130;
            btn_DangNhap.Text = "Đăng nhập hoặc đăng kí";
            btn_DangNhap.UseVisualStyleBackColor = true;
            btn_DangNhap.Click += btn_DangNhap_Click;
            // 
            // lbl_SoDienThoai
            // 
            lbl_SoDienThoai.AutoSize = true;
            lbl_SoDienThoai.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_SoDienThoai.Location = new Point(17, 635);
            lbl_SoDienThoai.Name = "lbl_SoDienThoai";
            lbl_SoDienThoai.Size = new Size(111, 23);
            lbl_SoDienThoai.TabIndex = 129;
            lbl_SoDienThoai.Text = "Số điện thoại";
            // 
            // txt_SoDienThoai
            // 
            txt_SoDienThoai.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_SoDienThoai.Location = new Point(18, 671);
            txt_SoDienThoai.Name = "txt_SoDienThoai";
            txt_SoDienThoai.Size = new Size(447, 30);
            txt_SoDienThoai.TabIndex = 128;
            // 
            // txt_NgayThangNamSinh
            // 
            txt_NgayThangNamSinh.AutoSize = true;
            txt_NgayThangNamSinh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_NgayThangNamSinh.Location = new Point(16, 411);
            txt_NgayThangNamSinh.Name = "txt_NgayThangNamSinh";
            txt_NgayThangNamSinh.Size = new Size(175, 23);
            txt_NgayThangNamSinh.TabIndex = 127;
            txt_NgayThangNamSinh.Text = "Ngày tháng năm sinh";
            txt_NgayThangNamSinh.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(35, 417);
            label6.Name = "label6";
            label6.Size = new Size(0, 23);
            label6.TabIndex = 125;
            // 
            // lbl_DiaChi
            // 
            lbl_DiaChi.AutoSize = true;
            lbl_DiaChi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_DiaChi.Location = new Point(16, 316);
            lbl_DiaChi.Name = "lbl_DiaChi";
            lbl_DiaChi.Size = new Size(62, 23);
            lbl_DiaChi.TabIndex = 124;
            lbl_DiaChi.Text = "Địa chỉ";
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_DiaChi.Location = new Point(17, 352);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(448, 30);
            txt_DiaChi.TabIndex = 123;
            // 
            // lbl_GioiTinh
            // 
            lbl_GioiTinh.AutoSize = true;
            lbl_GioiTinh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_GioiTinh.Location = new Point(17, 230);
            lbl_GioiTinh.Name = "lbl_GioiTinh";
            lbl_GioiTinh.Size = new Size(75, 23);
            lbl_GioiTinh.TabIndex = 122;
            lbl_GioiTinh.Text = "Giới tính";
            // 
            // txt_GioiTinh
            // 
            txt_GioiTinh.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_GioiTinh.Location = new Point(18, 266);
            txt_GioiTinh.Name = "txt_GioiTinh";
            txt_GioiTinh.Size = new Size(447, 30);
            txt_GioiTinh.TabIndex = 121;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(34, 208);
            label5.Name = "label5";
            label5.Size = new Size(0, 31);
            label5.TabIndex = 120;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 168);
            label2.Name = "label2";
            label2.Size = new Size(98, 23);
            label2.TabIndex = 119;
            label2.Text = "Họ và tên : ";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(lbl_TuanTheo);
            panel3.Controls.Add(lbl_Gia);
            panel3.Controls.Add(lbl_ThanHToan);
            panel3.Controls.Add(lbl_BaoGom);
            panel3.Controls.Add(lbl_GiaPhong);
            panel3.Location = new Point(643, 582);
            panel3.Name = "panel3";
            panel3.Size = new Size(403, 243);
            panel3.TabIndex = 118;
            // 
            // lbl_TuanTheo
            // 
            lbl_TuanTheo.AutoSize = true;
            lbl_TuanTheo.BackColor = SystemColors.ButtonHighlight;
            lbl_TuanTheo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TuanTheo.Location = new Point(3, 179);
            lbl_TuanTheo.Name = "lbl_TuanTheo";
            lbl_TuanTheo.Size = new Size(367, 23);
            lbl_TuanTheo.TabIndex = 121;
            lbl_TuanTheo.Text = "Tuân theo điều khoản hoàn tiền     ₫ 3,894,199";
            // 
            // lbl_Gia
            // 
            lbl_Gia.AutoSize = true;
            lbl_Gia.BackColor = SystemColors.ButtonHighlight;
            lbl_Gia.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Gia.Location = new Point(3, 66);
            lbl_Gia.Name = "lbl_Gia";
            lbl_Gia.Size = new Size(348, 23);
            lbl_Gia.TabIndex = 120;
            lbl_Gia.Text = "Giá                                              ₫ 4,166,731";
            // 
            // lbl_ThanHToan
            // 
            lbl_ThanHToan.AutoSize = true;
            lbl_ThanHToan.BackColor = SystemColors.ButtonHighlight;
            lbl_ThanHToan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ThanHToan.Location = new Point(3, 121);
            lbl_ThanHToan.Name = "lbl_ThanHToan";
            lbl_ThanHToan.Size = new Size(321, 20);
            lbl_ThanHToan.TabIndex = 119;
            lbl_ThanHToan.Text = "Thanh toán ₫ 4.166.731 ngay và nhận ₫ 272.532";
            // 
            // lbl_BaoGom
            // 
            lbl_BaoGom.AutoSize = true;
            lbl_BaoGom.BackColor = SystemColors.ButtonHighlight;
            lbl_BaoGom.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_BaoGom.Location = new Point(3, 220);
            lbl_BaoGom.Name = "lbl_BaoGom";
            lbl_BaoGom.Size = new Size(279, 17);
            lbl_BaoGom.TabIndex = 118;
            lbl_BaoGom.Text = "Đã bao gồm trong giá: Thuế 8%, Phí dịch vụ 5%";
            // 
            // lbl_GiaPhong
            // 
            lbl_GiaPhong.AutoSize = true;
            lbl_GiaPhong.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_GiaPhong.Location = new Point(3, 3);
            lbl_GiaPhong.Name = "lbl_GiaPhong";
            lbl_GiaPhong.Size = new Size(366, 46);
            lbl_GiaPhong.TabIndex = 117;
            lbl_GiaPhong.Text = "Giá phòng (1 phòng x 1 đêm)         ₫ 3.674.366\r\nPhí đặt chỗ                                      MIỄN PHÍ";
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.ControlLightLight;
            panel10.Controls.Add(btn_ThayDoi);
            panel10.Controls.Add(panel11);
            panel10.Controls.Add(label27);
            panel10.Location = new Point(643, 64);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(403, 372);
            panel10.TabIndex = 117;
            // 
            // btn_ThayDoi
            // 
            btn_ThayDoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ThayDoi.Location = new Point(308, 13);
            btn_ThayDoi.Margin = new Padding(3, 4, 3, 4);
            btn_ThayDoi.Name = "btn_ThayDoi";
            btn_ThayDoi.Size = new Size(86, 31);
            btn_ThayDoi.TabIndex = 2;
            btn_ThayDoi.Text = "Thay đổi";
            btn_ThayDoi.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            panel11.Controls.Add(label19);
            panel11.Controls.Add(label20);
            panel11.Controls.Add(label21);
            panel11.Controls.Add(label22);
            panel11.Controls.Add(label23);
            panel11.Controls.Add(label24);
            panel11.Controls.Add(label25);
            panel11.Controls.Add(label26);
            panel11.Location = new Point(15, 193);
            panel11.Margin = new Padding(3, 4, 3, 4);
            panel11.Name = "panel11";
            panel11.Size = new Size(339, 163);
            panel11.TabIndex = 1;
            panel11.Paint += panel11_Paint;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = SystemColors.ControlDarkDark;
            label19.Location = new Point(144, 129);
            label19.Name = "label19";
            label19.Size = new Size(193, 20);
            label19.TabIndex = 7;
            label19.Text = "(2 khách, 1 phòng, 1 đêm)";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = SystemColors.MenuHighlight;
            label20.Location = new Point(15, 129);
            label20.Name = "label20";
            label20.Size = new Size(132, 23);
            label20.TabIndex = 6;
            label20.Text = "3,674,366 VNĐ";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(9, 88);
            label21.Name = "label21";
            label21.Size = new Size(217, 20);
            label21.TabIndex = 5;
            label21.Text = "Nha Trang, Khánh Hòa Province";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(15, 104);
            label22.Name = "label22";
            label22.Size = new Size(0, 20);
            label22.TabIndex = 4;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = SystemColors.HotTrack;
            label23.Location = new Point(75, 68);
            label23.Name = "label23";
            label23.Size = new Size(55, 20);
            label23.TabIndex = 3;
            label23.Text = "(9/10)";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(10, 68);
            label24.Name = "label24";
            label24.Size = new Size(69, 20);
            label24.TabIndex = 2;
            label24.Text = "Đánh giá";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(9, 48);
            label25.Name = "label25";
            label25.Size = new Size(179, 20);
            label25.TabIndex = 1;
            label25.Text = "Thứ 3, ngày 12 thg 3 2024";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label26.Location = new Point(9, 20);
            label26.Name = "label26";
            label26.Size = new Size(326, 28);
            label26.TabIndex = 0;
            label26.Text = "Melia Vinpearl Nha Trang Empire";
            // 
            // label27
            // 
            label27.Image = (Image)resources.GetObject("label27.Image");
            label27.Location = new Point(16, 13);
            label27.Name = "label27";
            label27.Size = new Size(207, 171);
            label27.TabIndex = 0;
            // 
            // lbl_34
            // 
            lbl_34.AutoSize = true;
            lbl_34.BackColor = Color.OrangeRed;
            lbl_34.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_34.ForeColor = SystemColors.HighlightText;
            lbl_34.Location = new Point(786, 556);
            lbl_34.Name = "lbl_34";
            lbl_34.Size = new Size(260, 23);
            lbl_34.TabIndex = 112;
            lbl_34.Text = "GIẢM GIÁ 34% NGAY HÔM NAY";
            lbl_34.Click += label3_Click;
            // 
            // lbl_ChucMung
            // 
            lbl_ChucMung.AutoSize = true;
            lbl_ChucMung.BackColor = SystemColors.ButtonHighlight;
            lbl_ChucMung.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ChucMung.ForeColor = Color.Green;
            lbl_ChucMung.Location = new Point(643, 467);
            lbl_ChucMung.Name = "lbl_ChucMung";
            lbl_ChucMung.Size = new Size(383, 62);
            lbl_ChucMung.TabIndex = 109;
            lbl_ChucMung.Text = "Chúc mừng! Bạn đã nhận được mức\r\ngiá thấp nhất";
            // 
            // lbl_NeuBan
            // 
            lbl_NeuBan.AutoSize = true;
            lbl_NeuBan.BackColor = SystemColors.ButtonHighlight;
            lbl_NeuBan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_NeuBan.ForeColor = SystemColors.Desktop;
            lbl_NeuBan.Location = new Point(18, 575);
            lbl_NeuBan.Name = "lbl_NeuBan";
            lbl_NeuBan.Size = new Size(580, 40);
            lbl_NeuBan.TabIndex = 99;
            lbl_NeuBan.Text = "Nếu bạn nhập địa chỉ email của mình và không hoàn tất việc đặt chỗ, chúng tôi có thể \r\ngửi cho bạn lời nhắc để giúp bạn tiếp tục đặt chỗ.";
            // 
            // txt_HoVaTen
            // 
            txt_HoVaTen.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_HoVaTen.Location = new Point(19, 194);
            txt_HoVaTen.Name = "txt_HoVaTen";
            txt_HoVaTen.Size = new Size(446, 30);
            txt_HoVaTen.TabIndex = 98;
            // 
            // dtp_NgayThangNamSinh
            // 
            dtp_NgayThangNamSinh.Location = new Point(16, 452);
            dtp_NgayThangNamSinh.Name = "dtp_NgayThangNamSinh";
            dtp_NgayThangNamSinh.Size = new Size(449, 27);
            dtp_NgayThangNamSinh.TabIndex = 26;
            // 
            // cbb_MaGiamGia
            // 
            cbb_MaGiamGia.FormattingEnabled = true;
            cbb_MaGiamGia.Location = new Point(182, 733);
            cbb_MaGiamGia.Name = "cbb_MaGiamGia";
            cbb_MaGiamGia.Size = new Size(151, 28);
            cbb_MaGiamGia.TabIndex = 132;
            cbb_MaGiamGia.Visible = false;
            // 
            // lbl_MaGiamGia
            // 
            lbl_MaGiamGia.AutoSize = true;
            lbl_MaGiamGia.Location = new Point(18, 736);
            lbl_MaGiamGia.Name = "lbl_MaGiamGia";
            lbl_MaGiamGia.Size = new Size(93, 20);
            lbl_MaGiamGia.TabIndex = 133;
            lbl_MaGiamGia.Text = "Mã giảm giá";
            lbl_MaGiamGia.Visible = false;
            // 
            // Customer_Information
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1389, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Customer_Information";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer_Information";
            Load += Customer_Information_Load;
            Shown += Customer_Information_Shown;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_Email;
        private TextBox txt_Email;
        private Label lbl_PhoneNumber;
        private Label label1;
        private TextBox txt_FullName;
        private Label lbl_DatCho;
        private Label lbl_ThongTinThanhToan;
        private Label lbl_ThongTinKhachHang;
        private Panel panel2;
        private Button btn_NEXT;
        private Label lbl_ChonLoaiHinh;
        private Label lbl_ChoKhachHangXem;
        private Panel panel1;
        private Label lbl_SignIn;
        private Button btn_Signin;
        private Label lbl_FullName;
        private TextBox txt_HoVaTen;
        private Label lbl_NeuBan;
        private Label lbl_ChucMung;
        private Label lbl_34;
        private Panel panel10;
        private Button btn_ThayDoi;
        private Panel panel11;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Panel panel3;
        private Label lbl_TuanTheo;
        private Label lbl_Gia;
        private Label lbl_ThanHToan;
        private Label lbl_BaoGom;
        private Label lbl_GiaPhong;
        private Label label2;
        private TextBox txt_GioiTinh;
        private Label label5;
        private DateTimePicker dtp_NgayThangNamSinh;
        private Label lbl_GioiTinh;
        private Label txt_NgayThangNamSinh;
        private Label label6;
        private Label lbl_DiaChi;
        private TextBox txt_DiaChi;
        private Label lbl_SoDienThoai;
        private TextBox txt_SoDienThoai;
        private Label lbl_NhanUuDai;
        private Button btn_DangNhap;
        private Label lbl_MaGiamGia;
        private ComboBox cbb_MaGiamGia;
    }
}