namespace DuLich
{
    partial class UMatKhau
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
            lbl_TenDangNhap = new Label();
            txt_TenDangNhap = new TextBox();
            lbl_MatKhauHienTai = new Label();
            txt_MatKhau = new TextBox();
            btn_ChinhSua = new Button();
            txt_NhapLaiMatKhau = new TextBox();
            lbl_NhapLaiMatKhauMoi = new Label();
            txt_NhapMatKhauMoi = new TextBox();
            lbl_NhapMatKhauMoi = new Label();
            SuspendLayout();
            // 
            // lbl_TenDangNhap
            // 
            lbl_TenDangNhap.AutoSize = true;
            lbl_TenDangNhap.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TenDangNhap.Location = new Point(46, 50);
            lbl_TenDangNhap.Name = "lbl_TenDangNhap";
            lbl_TenDangNhap.Size = new Size(134, 25);
            lbl_TenDangNhap.TabIndex = 2;
            lbl_TenDangNhap.Text = "Tên đăng nhập";
            // 
            // txt_TenDangNhap
            // 
            txt_TenDangNhap.Location = new Point(248, 50);
            txt_TenDangNhap.Name = "txt_TenDangNhap";
            txt_TenDangNhap.Size = new Size(281, 27);
            txt_TenDangNhap.TabIndex = 12;
            // 
            // lbl_MatKhauHienTai
            // 
            lbl_MatKhauHienTai.AutoSize = true;
            lbl_MatKhauHienTai.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_MatKhauHienTai.Location = new Point(46, 120);
            lbl_MatKhauHienTai.Name = "lbl_MatKhauHienTai";
            lbl_MatKhauHienTai.Size = new Size(156, 25);
            lbl_MatKhauHienTai.TabIndex = 13;
            lbl_MatKhauHienTai.Text = "Mật khẩu hiện tại";
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_MatKhau.Location = new Point(248, 118);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.PasswordChar = '*';
            txt_MatKhau.Size = new Size(281, 27);
            txt_MatKhau.TabIndex = 14;
            txt_MatKhau.TextChanged += textBox1_TextChanged;
            // 
            // btn_ChinhSua
            // 
            btn_ChinhSua.Location = new Point(534, 323);
            btn_ChinhSua.Name = "btn_ChinhSua";
            btn_ChinhSua.Size = new Size(112, 49);
            btn_ChinhSua.TabIndex = 15;
            btn_ChinhSua.Text = "Chỉnh sửa";
            btn_ChinhSua.UseVisualStyleBackColor = true;
            btn_ChinhSua.Click += btn_ChinhSua_Click;
            // 
            // txt_NhapLaiMatKhau
            // 
            txt_NhapLaiMatKhau.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_NhapLaiMatKhau.Location = new Point(248, 251);
            txt_NhapLaiMatKhau.Name = "txt_NhapLaiMatKhau";
            txt_NhapLaiMatKhau.PasswordChar = '*';
            txt_NhapLaiMatKhau.Size = new Size(281, 27);
            txt_NhapLaiMatKhau.TabIndex = 17;
            // 
            // lbl_NhapLaiMatKhauMoi
            // 
            lbl_NhapLaiMatKhauMoi.AutoSize = true;
            lbl_NhapLaiMatKhauMoi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NhapLaiMatKhauMoi.Location = new Point(46, 253);
            lbl_NhapLaiMatKhauMoi.Name = "lbl_NhapLaiMatKhauMoi";
            lbl_NhapLaiMatKhauMoi.Size = new Size(198, 25);
            lbl_NhapLaiMatKhauMoi.TabIndex = 16;
            lbl_NhapLaiMatKhauMoi.Text = "Nhập lại mật khẩu mới";
            // 
            // txt_NhapMatKhauMoi
            // 
            txt_NhapMatKhauMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_NhapMatKhauMoi.Location = new Point(248, 189);
            txt_NhapMatKhauMoi.Name = "txt_NhapMatKhauMoi";
            txt_NhapMatKhauMoi.PasswordChar = '*';
            txt_NhapMatKhauMoi.Size = new Size(281, 27);
            txt_NhapMatKhauMoi.TabIndex = 19;
            // 
            // lbl_NhapMatKhauMoi
            // 
            lbl_NhapMatKhauMoi.AutoSize = true;
            lbl_NhapMatKhauMoi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NhapMatKhauMoi.Location = new Point(46, 191);
            lbl_NhapMatKhauMoi.Name = "lbl_NhapMatKhauMoi";
            lbl_NhapMatKhauMoi.Size = new Size(174, 25);
            lbl_NhapMatKhauMoi.TabIndex = 18;
            lbl_NhapMatKhauMoi.Text = "Nhập mật khẩu mới";
            // 
            // UMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txt_NhapMatKhauMoi);
            Controls.Add(lbl_NhapMatKhauMoi);
            Controls.Add(txt_NhapLaiMatKhau);
            Controls.Add(lbl_NhapLaiMatKhauMoi);
            Controls.Add(btn_ChinhSua);
            Controls.Add(txt_MatKhau);
            Controls.Add(lbl_MatKhauHienTai);
            Controls.Add(txt_TenDangNhap);
            Controls.Add(lbl_TenDangNhap);
            Name = "UMatKhau";
            Size = new Size(1221, 606);
            Load += UMatKhau_Load;
            VisibleChanged += UMatKhau_VisibleChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_TenDangNhap;
        private TextBox txt_TenDangNhap;
        private Label lbl_MatKhauHienTai;
        private TextBox txt_MatKhau;
        private Button btn_ChinhSua;
        private TextBox txt_NhapLaiMatKhau;
        private Label lbl_NhapLaiMatKhauMoi;
        private TextBox txt_NhapMatKhauMoi;
        private Label lbl_NhapMatKhauMoi;
    }
}
