namespace DuLich
{
    partial class UTienNghi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_ChinhSua = new Button();
            clb_DichVuKhachSan = new CheckedListBox();
            lbl_KhachCoTheChon = new Label();
            lbl_DichVuKhachSan = new Label();
            clb_AmThuc = new CheckedListBox();
            lbl_ChoKhachThayRang = new Label();
            lbl_AmThuc = new Label();
            clb_TienNghiCongCong = new CheckedListBox();
            lbl_CacDichVuNay = new Label();
            lbl_TIenNghiCongCong = new Label();
            clb_TienNghiChinh = new CheckedListBox();
            lbl_DayLaNhungCach = new Label();
            lbl_TienNghiChinh = new Label();
            txt_MaKhachSan = new TextBox();
            lbl_MaKS = new Label();
            SuspendLayout();
            // 
            // btn_ChinhSua
            // 
            btn_ChinhSua.Location = new Point(643, 556);
            btn_ChinhSua.Name = "btn_ChinhSua";
            btn_ChinhSua.Size = new Size(112, 49);
            btn_ChinhSua.TabIndex = 23;
            btn_ChinhSua.Text = "Chỉnh sửa";
            btn_ChinhSua.UseVisualStyleBackColor = true;
            btn_ChinhSua.Click += btn_ChinhSua_Click;
            // 
            // clb_DichVuKhachSan
            // 
            clb_DichVuKhachSan.FormattingEnabled = true;
            clb_DichVuKhachSan.Items.AddRange(new object[] { "Quầy lễ tân", "Dịch vụ thu đổi ngoại tệ", "Dịch vụ tiệc cưới", "Dịch vụ hỗ trợ đặt tour", "Nhân viên đa ngôn ngữ" });
            clb_DichVuKhachSan.Location = new Point(410, 192);
            clb_DichVuKhachSan.Name = "clb_DichVuKhachSan";
            clb_DichVuKhachSan.Size = new Size(284, 114);
            clb_DichVuKhachSan.TabIndex = 87;
            // 
            // lbl_KhachCoTheChon
            // 
            lbl_KhachCoTheChon.AutoSize = true;
            lbl_KhachCoTheChon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_KhachCoTheChon.Location = new Point(410, 152);
            lbl_KhachCoTheChon.Name = "lbl_KhachCoTheChon";
            lbl_KhachCoTheChon.Size = new Size(384, 40);
            lbl_KhachCoTheChon.TabIndex = 86;
            lbl_KhachCoTheChon.Text = "Đảm bảo cho du khách biết những dịch vụ của khách sạn\r\n\r\n";
            // 
            // lbl_DichVuKhachSan
            // 
            lbl_DichVuKhachSan.AutoSize = true;
            lbl_DichVuKhachSan.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_DichVuKhachSan.Location = new Point(410, 110);
            lbl_DichVuKhachSan.Name = "lbl_DichVuKhachSan";
            lbl_DichVuKhachSan.Size = new Size(200, 31);
            lbl_DichVuKhachSan.TabIndex = 85;
            lbl_DichVuKhachSan.Text = "Dịch vụ khách sạn";
            // 
            // clb_AmThuc
            // 
            clb_AmThuc.FormattingEnabled = true;
            clb_AmThuc.Items.AddRange(new object[] { "Quầy bar", "Bữa sáng", "Quầy bar bên hồ bơi" });
            clb_AmThuc.Location = new Point(410, 418);
            clb_AmThuc.Name = "clb_AmThuc";
            clb_AmThuc.Size = new Size(284, 114);
            clb_AmThuc.TabIndex = 84;
            // 
            // lbl_ChoKhachThayRang
            // 
            lbl_ChoKhachThayRang.AutoSize = true;
            lbl_ChoKhachThayRang.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ChoKhachThayRang.Location = new Point(410, 367);
            lbl_ChoKhachThayRang.Name = "lbl_ChoKhachThayRang";
            lbl_ChoKhachThayRang.Size = new Size(275, 40);
            lbl_ChoKhachThayRang.TabIndex = 83;
            lbl_ChoKhachThayRang.Text = "Cho khách thấy rằng quý đối tác\r\n coi trọng sự an toàn và sức khỏe của họ";
            // 
            // lbl_AmThuc
            // 
            lbl_AmThuc.AutoSize = true;
            lbl_AmThuc.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_AmThuc.Location = new Point(410, 327);
            lbl_AmThuc.Name = "lbl_AmThuc";
            lbl_AmThuc.Size = new Size(101, 31);
            lbl_AmThuc.TabIndex = 82;
            lbl_AmThuc.Text = "Ẩm thực";
            // 
            // clb_TienNghiCongCong
            // 
            clb_TienNghiCongCong.FormattingEnabled = true;
            clb_TienNghiCongCong.Items.AddRange(new object[] { "Bãi đậu xe", "Tiệm cafe", "Thang máy" });
            clb_TienNghiCongCong.Location = new Point(12, 418);
            clb_TienNghiCongCong.Name = "clb_TienNghiCongCong";
            clb_TienNghiCongCong.Size = new Size(284, 114);
            clb_TienNghiCongCong.TabIndex = 81;
            // 
            // lbl_CacDichVuNay
            // 
            lbl_CacDichVuNay.AutoSize = true;
            lbl_CacDichVuNay.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_CacDichVuNay.Location = new Point(12, 367);
            lbl_CacDichVuNay.Name = "lbl_CacDichVuNay";
            lbl_CacDichVuNay.Size = new Size(263, 40);
            lbl_CacDichVuNay.TabIndex = 80;
            lbl_CacDichVuNay.Text = "Các dịch vụ này có hầu hết tại \r\ncác chỗ nghỉ thành công của chúng tôi\r\n";
            // 
            // lbl_TIenNghiCongCong
            // 
            lbl_TIenNghiCongCong.AutoSize = true;
            lbl_TIenNghiCongCong.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TIenNghiCongCong.Location = new Point(12, 327);
            lbl_TIenNghiCongCong.Name = "lbl_TIenNghiCongCong";
            lbl_TIenNghiCongCong.Size = new Size(226, 31);
            lbl_TIenNghiCongCong.TabIndex = 79;
            lbl_TIenNghiCongCong.Text = "Tiện nghi công cộng";
            // 
            // clb_TienNghiChinh
            // 
            clb_TienNghiChinh.FormattingEnabled = true;
            clb_TienNghiChinh.Items.AddRange(new object[] { "Máy lạnh", "Nhà hàng", "Hồ bơi", "Lễ tân 24h", "Wifi" });
            clb_TienNghiChinh.Location = new Point(12, 192);
            clb_TienNghiChinh.Name = "clb_TienNghiChinh";
            clb_TienNghiChinh.Size = new Size(284, 114);
            clb_TienNghiChinh.TabIndex = 78;
            // 
            // lbl_DayLaNhungCach
            // 
            lbl_DayLaNhungCach.AutoSize = true;
            lbl_DayLaNhungCach.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_DayLaNhungCach.Location = new Point(12, 152);
            lbl_DayLaNhungCach.Name = "lbl_DayLaNhungCach";
            lbl_DayLaNhungCach.Size = new Size(286, 60);
            lbl_DayLaNhungCach.TabIndex = 77;
            lbl_DayLaNhungCach.Text = "Đây là những tiện nghi chính của chỗ nghỉ\r\n\r\n\r\n";
            // 
            // lbl_TienNghiChinh
            // 
            lbl_TienNghiChinh.AutoSize = true;
            lbl_TienNghiChinh.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TienNghiChinh.Location = new Point(12, 110);
            lbl_TienNghiChinh.Name = "lbl_TienNghiChinh";
            lbl_TienNghiChinh.Size = new Size(178, 31);
            lbl_TienNghiChinh.TabIndex = 76;
            lbl_TienNghiChinh.Text = "Tiện nghi chính ";
            // 
            // txt_MaKhachSan
            // 
            txt_MaKhachSan.Location = new Point(410, 58);
            txt_MaKhachSan.Name = "txt_MaKhachSan";
            txt_MaKhachSan.Size = new Size(313, 27);
            txt_MaKhachSan.TabIndex = 89;
            // 
            // lbl_MaKS
            // 
            lbl_MaKS.AutoSize = true;
            lbl_MaKS.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_MaKS.Location = new Point(21, 60);
            lbl_MaKS.Name = "lbl_MaKS";
            lbl_MaKS.Size = new Size(122, 25);
            lbl_MaKS.TabIndex = 88;
            lbl_MaKS.Text = "Mã khách sạn";
            // 
            // UTienNghi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txt_MaKhachSan);
            Controls.Add(lbl_MaKS);
            Controls.Add(clb_DichVuKhachSan);
            Controls.Add(lbl_KhachCoTheChon);
            Controls.Add(lbl_DichVuKhachSan);
            Controls.Add(clb_AmThuc);
            Controls.Add(lbl_ChoKhachThayRang);
            Controls.Add(lbl_AmThuc);
            Controls.Add(clb_TienNghiCongCong);
            Controls.Add(lbl_CacDichVuNay);
            Controls.Add(lbl_TIenNghiCongCong);
            Controls.Add(clb_TienNghiChinh);
            Controls.Add(lbl_DayLaNhungCach);
            Controls.Add(lbl_TienNghiChinh);
            Controls.Add(btn_ChinhSua);
            Name = "UTienNghi";
            Size = new Size(800, 647);
            Load += UTienNghi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_ChinhSua;
        private CheckedListBox clb_DichVuKhachSan;
        private Label lbl_KhachCoTheChon;
        private Label lbl_DichVuKhachSan;
        private CheckedListBox clb_AmThuc;
        private Label lbl_ChoKhachThayRang;
        private Label lbl_AmThuc;
        private CheckedListBox clb_TienNghiCongCong;
        private Label lbl_CacDichVuNay;
        private Label lbl_TIenNghiCongCong;
        private CheckedListBox clb_TienNghiChinh;
        private Label lbl_DayLaNhungCach;
        private Label lbl_TienNghiChinh;
        private TextBox txt_MaKhachSan;
        private Label lbl_MaKS;
    }
}
