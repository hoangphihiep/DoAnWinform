namespace DuLich
{
    partial class UHoSo
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
            lbl_MaKS = new Label();
            txt_MaKhachSan = new TextBox();
            lbl_SDT = new Label();
            lbl_Email = new Label();
            lbl_PhuongThucTT = new Label();
            txt_SoDienThoai = new TextBox();
            txt_Email = new TextBox();
            btn_ChinhSua = new Button();
            txt_DiaChi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkedListBox3 = new CheckedListBox();
            txt_HoVaTenChuKhachSan = new TextBox();
            lbl_HoVaTenChuKhachSan = new Label();
            cbb_Tinh = new ComboBox();
            cbb_ThanhPho = new ComboBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_MaKS
            // 
            lbl_MaKS.AutoSize = true;
            lbl_MaKS.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_MaKS.Location = new Point(33, 39);
            lbl_MaKS.Name = "lbl_MaKS";
            lbl_MaKS.Size = new Size(122, 25);
            lbl_MaKS.TabIndex = 1;
            lbl_MaKS.Text = "Mã khách sạn";
            // 
            // txt_MaKhachSan
            // 
            txt_MaKhachSan.Location = new Point(298, 37);
            txt_MaKhachSan.Name = "txt_MaKhachSan";
            txt_MaKhachSan.Size = new Size(313, 27);
            txt_MaKhachSan.TabIndex = 16;
            // 
            // lbl_SDT
            // 
            lbl_SDT.AutoSize = true;
            lbl_SDT.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_SDT.Location = new Point(30, 146);
            lbl_SDT.Name = "lbl_SDT";
            lbl_SDT.Size = new Size(122, 25);
            lbl_SDT.TabIndex = 18;
            lbl_SDT.Text = "Số điện thoại";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Email.Location = new Point(30, 209);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(56, 25);
            lbl_Email.TabIndex = 19;
            lbl_Email.Text = "Email";
            lbl_Email.Click += lbl_Email_Click;
            // 
            // lbl_PhuongThucTT
            // 
            lbl_PhuongThucTT.AutoSize = true;
            lbl_PhuongThucTT.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_PhuongThucTT.Location = new Point(30, 444);
            lbl_PhuongThucTT.Name = "lbl_PhuongThucTT";
            lbl_PhuongThucTT.Size = new Size(213, 25);
            lbl_PhuongThucTT.TabIndex = 20;
            lbl_PhuongThucTT.Text = "Phương thức thanh toán";
            // 
            // txt_SoDienThoai
            // 
            txt_SoDienThoai.Location = new Point(298, 144);
            txt_SoDienThoai.Name = "txt_SoDienThoai";
            txt_SoDienThoai.Size = new Size(313, 27);
            txt_SoDienThoai.TabIndex = 22;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(298, 207);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(313, 27);
            txt_Email.TabIndex = 23;
            // 
            // btn_ChinhSua
            // 
            btn_ChinhSua.Location = new Point(675, 471);
            btn_ChinhSua.Name = "btn_ChinhSua";
            btn_ChinhSua.Size = new Size(112, 49);
            btn_ChinhSua.TabIndex = 25;
            btn_ChinhSua.Text = "Chỉnh sửa";
            btn_ChinhSua.UseVisualStyleBackColor = true;
            btn_ChinhSua.Click += btn_ChinhSua_Click;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Location = new Point(298, 380);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(313, 27);
            txt_DiaChi.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 382);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 29;
            label1.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 321);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 28;
            label2.Text = "Thành phố";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 264);
            label3.Name = "label3";
            label3.Size = new Size(48, 25);
            label3.TabIndex = 26;
            label3.Text = "Tỉnh";
            // 
            // checkedListBox3
            // 
            checkedListBox3.FormattingEnabled = true;
            checkedListBox3.Items.AddRange(new object[] { "Thẻ điện tử", "Tiền gửi trực tiếp vào ngân hàng" });
            checkedListBox3.Location = new Point(298, 444);
            checkedListBox3.Name = "checkedListBox3";
            checkedListBox3.Size = new Size(313, 48);
            checkedListBox3.TabIndex = 117;
            // 
            // txt_HoVaTenChuKhachSan
            // 
            txt_HoVaTenChuKhachSan.Location = new Point(298, 90);
            txt_HoVaTenChuKhachSan.Name = "txt_HoVaTenChuKhachSan";
            txt_HoVaTenChuKhachSan.Size = new Size(313, 27);
            txt_HoVaTenChuKhachSan.TabIndex = 119;
            // 
            // lbl_HoVaTenChuKhachSan
            // 
            lbl_HoVaTenChuKhachSan.AutoSize = true;
            lbl_HoVaTenChuKhachSan.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_HoVaTenChuKhachSan.Location = new Point(33, 92);
            lbl_HoVaTenChuKhachSan.Name = "lbl_HoVaTenChuKhachSan";
            lbl_HoVaTenChuKhachSan.Size = new Size(210, 25);
            lbl_HoVaTenChuKhachSan.TabIndex = 118;
            lbl_HoVaTenChuKhachSan.Text = "Họ và tên chủ khách sạn\r\n";
            // 
            // cbb_Tinh
            // 
            cbb_Tinh.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cbb_Tinh.FormattingEnabled = true;
            cbb_Tinh.Items.AddRange(new object[] { "An Giang", "Bà Rịa - Vũng Tàu", "Bạc Liêu", "Bắc Giang", "Bắc Kạn", "Bắc Ninh", "Bến Tre", "Bình Định", "Bình Dương", "Bình Phước", "Bình Thuận", "Cà Mau", "Cao Bằng", "Đắk Lắk", "Đắk Nông", "Điện Biên", "Đồng Nai", "Đồng Tháp", "Gia Lai", "Hà Giang", "Hà Nam", "Hà Tĩnh", "Hải Dương", "Hải Phòng", "Hậu Giang", "Hòa Bình", "Hồ Chí Minh (TP.HCM)", "Hưng Yên", "Khánh Hòa", "Kiên Giang", "Kon Tum", "Lai Châu", "Lâm Đồng", "Lạng Sơn", "Lào Cai", "Long An", "Nam Định", "Nghệ An", "Ninh Bình", "Ninh Thuận", "Phú Thọ", "Phú Yên", "Quảng Bình", "Quảng Nam", "Quảng Ngãi", "Quảng Ninh", "Quảng Trị", "Sóc Trăng", "Sơn La", "Tây Ninh", "Thái Bình", "Thái Nguyên", "Thanh Hóa", "Thừa Thiên-Huế", "Tiền Giang", "Trà Vinh", "Tuyên Quang", "Vĩnh Long", "Vĩnh Phúc", "Yên Bái" });
            cbb_Tinh.Location = new Point(298, 258);
            cbb_Tinh.Name = "cbb_Tinh";
            cbb_Tinh.Size = new Size(313, 31);
            cbb_Tinh.TabIndex = 121;
            // 
            // cbb_ThanhPho
            // 
            cbb_ThanhPho.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cbb_ThanhPho.FormattingEnabled = true;
            cbb_ThanhPho.Items.AddRange(new object[] { "An Giang", "Bà Rịa - Vũng Tàu", "Bạc Liêu", "Bắc Giang", "Bắc Kạn", "Bắc Ninh", "Bến Tre", "Bình Định", "Bình Dương", "Bình Phước", "Bình Thuận", "Cà Mau", "Cao Bằng", "Đắk Lắk", "Đắk Nông", "Điện Biên", "Đồng Nai", "Đồng Tháp", "Gia Lai", "Hà Giang", "Hà Nam", "Hà Tĩnh", "Hải Dương", "Hải Phòng", "Hậu Giang", "Hòa Bình", "Hồ Chí Minh (TP.HCM)", "Hưng Yên", "Khánh Hòa", "Kiên Giang", "Kon Tum", "Lai Châu", "Lâm Đồng", "Lạng Sơn", "Lào Cai", "Long An", "Nam Định", "Nghệ An", "Ninh Bình", "Ninh Thuận", "Phú Thọ", "Phú Yên", "Quảng Bình", "Quảng Nam", "Quảng Ngãi", "Quảng Ninh", "Quảng Trị", "Sóc Trăng", "Sơn La", "Tây Ninh", "Thái Bình", "Thái Nguyên", "Thanh Hóa", "Thừa Thiên-Huế", "Tiền Giang", "Trà Vinh", "Tuyên Quang", "Vĩnh Long", "Vĩnh Phúc", "Yên Bái" });
            cbb_ThanhPho.Location = new Point(298, 320);
            cbb_ThanhPho.Name = "cbb_ThanhPho";
            cbb_ThanhPho.Size = new Size(313, 31);
            cbb_ThanhPho.TabIndex = 120;
            // 
            // button1
            // 
            button1.Location = new Point(656, 37);
            button1.Name = "button1";
            button1.Size = new Size(112, 27);
            button1.TabIndex = 122;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(656, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(564, 301);
            dataGridView1.TabIndex = 123;
            // 
            // UHoSo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(cbb_Tinh);
            Controls.Add(cbb_ThanhPho);
            Controls.Add(txt_HoVaTenChuKhachSan);
            Controls.Add(lbl_HoVaTenChuKhachSan);
            Controls.Add(checkedListBox3);
            Controls.Add(txt_DiaChi);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(btn_ChinhSua);
            Controls.Add(txt_Email);
            Controls.Add(txt_SoDienThoai);
            Controls.Add(lbl_PhuongThucTT);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_SDT);
            Controls.Add(txt_MaKhachSan);
            Controls.Add(lbl_MaKS);
            Name = "UHoSo";
            Size = new Size(1221, 606);
            Load += UHoSo_Load;
            VisibleChanged += UHoSo_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_MaKS;
        private TextBox txt_MaKhachSan;
        private Label lbl_SDT;
        private Label lbl_Email;
        private Label lbl_PhuongThucTT;
        private TextBox txt_SoDienThoai;
        private TextBox txt_Email;
        private Button btn_ChinhSua;
        private TextBox txt_DiaChi;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckedListBox checkedListBox3;
        private TextBox txt_HoVaTenChuKhachSan;
        private Label lbl_HoVaTenChuKhachSan;
        private ComboBox cbb_Tinh;
        private ComboBox cbb_ThanhPho;
        private Button button1;
        private DataGridView dataGridView1;
    }
}
