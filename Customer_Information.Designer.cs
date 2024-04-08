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
            lbl_MaGiamGia = new Label();
            cbb_MaGiamGia = new ComboBox();
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
            label3 = new Label();
            lbl_LastCost = new Label();
            lbl_CostRoom = new Label();
            lbl_Cost = new Label();
            lbl_DichVuVaThue = new Label();
            lbl_Gia = new Label();
            lbl_BaoGom = new Label();
            lbl_GiaPhong = new Label();
            panel10 = new Panel();
            panel14 = new Panel();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            btn_ThayDoi = new Button();
            ptb_Anh = new Label();
            lbl_34 = new Label();
            lbl_ChucMung = new Label();
            lbl_NeuBan = new Label();
            txt_HoVaTen = new TextBox();
            dtp_NgayThangNamSinh = new DateTimePicker();
            lbl_SoLuong = new Label();
            txt_SoLuong = new TextBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel10.SuspendLayout();
            panel14.SuspendLayout();
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
            panel1.Controls.Add(lbl_SoLuong);
            panel1.Controls.Add(txt_SoLuong);
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
            // lbl_MaGiamGia
            // 
            lbl_MaGiamGia.AutoSize = true;
            lbl_MaGiamGia.Location = new Point(17, 794);
            lbl_MaGiamGia.Name = "lbl_MaGiamGia";
            lbl_MaGiamGia.Size = new Size(93, 20);
            lbl_MaGiamGia.TabIndex = 133;
            lbl_MaGiamGia.Text = "Mã giảm giá";
            lbl_MaGiamGia.Visible = false;
            // 
            // cbb_MaGiamGia
            // 
            cbb_MaGiamGia.FormattingEnabled = true;
            cbb_MaGiamGia.Location = new Point(181, 791);
            cbb_MaGiamGia.Name = "cbb_MaGiamGia";
            cbb_MaGiamGia.Size = new Size(151, 28);
            cbb_MaGiamGia.TabIndex = 132;
            cbb_MaGiamGia.Visible = false;
            cbb_MaGiamGia.SelectedValueChanged += cbb_MaGiamGia_SelectedValueChanged;
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
            panel3.Controls.Add(label3);
            panel3.Controls.Add(lbl_LastCost);
            panel3.Controls.Add(lbl_CostRoom);
            panel3.Controls.Add(lbl_Cost);
            panel3.Controls.Add(lbl_DichVuVaThue);
            panel3.Controls.Add(lbl_Gia);
            panel3.Controls.Add(lbl_BaoGom);
            panel3.Controls.Add(lbl_GiaPhong);
            panel3.Location = new Point(643, 582);
            panel3.Name = "panel3";
            panel3.Size = new Size(403, 243);
            panel3.TabIndex = 118;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 173);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 125;
            label3.Text = "Giá tổng : ";
            // 
            // lbl_LastCost
            // 
            lbl_LastCost.AutoSize = true;
            lbl_LastCost.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_LastCost.Location = new Point(238, 175);
            lbl_LastCost.Name = "lbl_LastCost";
            lbl_LastCost.Size = new Size(44, 23);
            lbl_LastCost.TabIndex = 124;
            lbl_LastCost.Text = "Cost";
            // 
            // lbl_CostRoom
            // 
            lbl_CostRoom.AutoSize = true;
            lbl_CostRoom.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_CostRoom.Location = new Point(238, 29);
            lbl_CostRoom.Name = "lbl_CostRoom";
            lbl_CostRoom.Size = new Size(44, 23);
            lbl_CostRoom.TabIndex = 122;
            lbl_CostRoom.Text = "Cost";
            // 
            // lbl_Cost
            // 
            lbl_Cost.AutoSize = true;
            lbl_Cost.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Cost.Location = new Point(238, 92);
            lbl_Cost.Name = "lbl_Cost";
            lbl_Cost.Size = new Size(44, 23);
            lbl_Cost.TabIndex = 123;
            lbl_Cost.Text = "Cost";
            // 
            // lbl_DichVuVaThue
            // 
            lbl_DichVuVaThue.AutoSize = true;
            lbl_DichVuVaThue.BackColor = SystemColors.ButtonHighlight;
            lbl_DichVuVaThue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_DichVuVaThue.Location = new Point(3, 135);
            lbl_DichVuVaThue.Name = "lbl_DichVuVaThue";
            lbl_DichVuVaThue.Size = new Size(241, 20);
            lbl_DichVuVaThue.TabIndex = 121;
            lbl_DichVuVaThue.Text = "Sau khi bổ sung phí dịch vụ và thuế";
            lbl_DichVuVaThue.Click += lbl_DichVuVaThue_Click;
            // 
            // lbl_Gia
            // 
            lbl_Gia.AutoSize = true;
            lbl_Gia.BackColor = SystemColors.ButtonHighlight;
            lbl_Gia.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Gia.Location = new Point(3, 92);
            lbl_Gia.Name = "lbl_Gia";
            lbl_Gia.Size = new Size(265, 23);
            lbl_Gia.TabIndex = 120;
            lbl_Gia.Text = "Giá                                              ";
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
            lbl_GiaPhong.Location = new Point(3, 29);
            lbl_GiaPhong.Name = "lbl_GiaPhong";
            lbl_GiaPhong.Size = new Size(363, 46);
            lbl_GiaPhong.TabIndex = 117;
            lbl_GiaPhong.Text = "Giá phòng (1 phòng x 1 đêm)        \r\nPhí đặt chỗ                                      MIỄN PHÍ";
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.ControlLightLight;
            panel10.Controls.Add(panel14);
            panel10.Controls.Add(btn_ThayDoi);
            panel10.Controls.Add(ptb_Anh);
            panel10.Location = new Point(643, 64);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(403, 372);
            panel10.TabIndex = 117;
            // 
            // panel14
            // 
            panel14.Controls.Add(label21);
            panel14.Controls.Add(label20);
            panel14.Controls.Add(label19);
            panel14.Controls.Add(label18);
            panel14.Controls.Add(label17);
            panel14.Controls.Add(label16);
            panel14.Controls.Add(label15);
            panel14.Location = new Point(16, 202);
            panel14.Margin = new Padding(3, 4, 3, 4);
            panel14.Name = "panel14";
            panel14.Size = new Size(330, 153);
            panel14.TabIndex = 7;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(159, 124);
            label21.Name = "label21";
            label21.Size = new Size(97, 20);
            label21.TabIndex = 6;
            label21.Text = "/phòng/đêm.";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.DarkTurquoise;
            label20.Location = new Point(3, 119);
            label20.Name = "label20";
            label20.Size = new Size(162, 25);
            label20.TabIndex = 5;
            label20.Text = "16.709.490  VND";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(146, 85);
            label19.Name = "label19";
            label19.Size = new Size(17, 20);
            label19.TabIndex = 4;
            label19.Text = "4";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(3, 85);
            label18.Name = "label18";
            label18.Size = new Size(148, 20);
            label18.TabIndex = 3;
            label18.Text = "Số phòng còn trống :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(80, 52);
            label17.Name = "label17";
            label17.Size = new Size(17, 20);
            label17.TabIndex = 2;
            label17.Text = "2";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.DimGray;
            label16.Location = new Point(3, 52);
            label16.Name = "label16";
            label16.Size = new Size(75, 20);
            label16.TabIndex = 1;
            label16.Text = "Số khách :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ControlText;
            label15.Location = new Point(3, 13);
            label15.Name = "label15";
            label15.Size = new Size(310, 25);
            label15.TabIndex = 0;
            label15.Text = "Beach Front 1 Bedroom Pool Villa";
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
            btn_ThayDoi.Click += btn_ThayDoi_Click;
            // 
            // ptb_Anh
            // 
            ptb_Anh.Image = (Image)resources.GetObject("ptb_Anh.Image");
            ptb_Anh.Location = new Point(16, 13);
            ptb_Anh.Name = "ptb_Anh";
            ptb_Anh.Size = new Size(207, 171);
            ptb_Anh.TabIndex = 0;
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
            lbl_34.Visible = false;
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
            // lbl_SoLuong
            // 
            lbl_SoLuong.AutoSize = true;
            lbl_SoLuong.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_SoLuong.Location = new Point(17, 712);
            lbl_SoLuong.Name = "lbl_SoLuong";
            lbl_SoLuong.Size = new Size(195, 23);
            lbl_SoLuong.TabIndex = 135;
            lbl_SoLuong.Text = "Số lượng phòng cần đặt";
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_SoLuong.Location = new Point(18, 748);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(447, 30);
            txt_SoLuong.TabIndex = 134;
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
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
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
        private Label ptb_Anh;
        private Panel panel3;
        private Label lbl_Gia;
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
        private Panel panel14;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label lbl_CostRoom;
        private Label lbl_Cost;
        private Label lbl_DichVuVaThue;
        private Label lbl_LastCost;
        private Label label3;
        private Label lbl_SoLuong;
        private TextBox txt_SoLuong;
    }
}