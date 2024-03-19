namespace DuLich
{
    partial class UThongtin
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
            lbl_HoTen = new Label();
            lbl_GioiTinh = new Label();
            lbl_DiaChi = new Label();
            lbl_Date = new Label();
            lbl_Email = new Label();
            lbl_Phone = new Label();
            txt_HoTen = new TextBox();
            txt_GioiTinh = new TextBox();
            txt_DiaChi = new TextBox();
            txt_Email = new TextBox();
            txt_SoDienThoai = new TextBox();
            dtp_ngaythangnamsinh = new DateTimePicker();
            btn_ChinhSua = new Button();
            SuspendLayout();
            // 
            // lbl_HoTen
            // 
            lbl_HoTen.AutoSize = true;
            lbl_HoTen.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_HoTen.Location = new Point(45, 19);
            lbl_HoTen.Name = "lbl_HoTen";
            lbl_HoTen.Size = new Size(93, 25);
            lbl_HoTen.TabIndex = 0;
            lbl_HoTen.Text = "Họ và Tên";
            // 
            // lbl_GioiTinh
            // 
            lbl_GioiTinh.AutoSize = true;
            lbl_GioiTinh.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_GioiTinh.Location = new Point(45, 97);
            lbl_GioiTinh.Name = "lbl_GioiTinh";
            lbl_GioiTinh.Size = new Size(84, 25);
            lbl_GioiTinh.TabIndex = 1;
            lbl_GioiTinh.Text = "Giới tính";
            // 
            // lbl_DiaChi
            // 
            lbl_DiaChi.AutoSize = true;
            lbl_DiaChi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_DiaChi.Location = new Point(45, 176);
            lbl_DiaChi.Name = "lbl_DiaChi";
            lbl_DiaChi.Size = new Size(67, 25);
            lbl_DiaChi.TabIndex = 2;
            lbl_DiaChi.Text = "Địa chỉ";
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Date.Location = new Point(45, 258);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(188, 25);
            lbl_Date.TabIndex = 3;
            lbl_Date.Text = "Ngày tháng năm sinh";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Email.Location = new Point(45, 338);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(56, 25);
            lbl_Email.TabIndex = 4;
            lbl_Email.Text = "Email";
            // 
            // lbl_Phone
            // 
            lbl_Phone.AutoSize = true;
            lbl_Phone.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Phone.Location = new Point(45, 432);
            lbl_Phone.Name = "lbl_Phone";
            lbl_Phone.Size = new Size(122, 25);
            lbl_Phone.TabIndex = 5;
            lbl_Phone.Text = "Số điện thoại";
            // 
            // txt_HoTen
            // 
            txt_HoTen.Location = new Point(286, 20);
            txt_HoTen.Name = "txt_HoTen";
            txt_HoTen.Size = new Size(281, 27);
            txt_HoTen.TabIndex = 6;
            // 
            // txt_GioiTinh
            // 
            txt_GioiTinh.Location = new Point(286, 95);
            txt_GioiTinh.Name = "txt_GioiTinh";
            txt_GioiTinh.Size = new Size(281, 27);
            txt_GioiTinh.TabIndex = 7;
            txt_GioiTinh.TextChanged += txt_GioiTinh_TextChanged;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Location = new Point(286, 174);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(281, 27);
            txt_DiaChi.TabIndex = 8;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(286, 339);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(281, 27);
            txt_Email.TabIndex = 10;
            // 
            // txt_SoDienThoai
            // 
            txt_SoDienThoai.Location = new Point(286, 430);
            txt_SoDienThoai.Name = "txt_SoDienThoai";
            txt_SoDienThoai.Size = new Size(281, 27);
            txt_SoDienThoai.TabIndex = 11;
            // 
            // dtp_ngaythangnamsinh
            // 
            dtp_ngaythangnamsinh.Location = new Point(286, 256);
            dtp_ngaythangnamsinh.Name = "dtp_ngaythangnamsinh";
            dtp_ngaythangnamsinh.Size = new Size(281, 27);
            dtp_ngaythangnamsinh.TabIndex = 12;
            // 
            // btn_ChinhSua
            // 
            btn_ChinhSua.Location = new Point(696, 544);
            btn_ChinhSua.Name = "btn_ChinhSua";
            btn_ChinhSua.Size = new Size(112, 49);
            btn_ChinhSua.TabIndex = 13;
            btn_ChinhSua.Text = "Chỉnh sửa";
            btn_ChinhSua.UseVisualStyleBackColor = true;
            btn_ChinhSua.Click += btn_ChinhSua_Click;
            // 
            // UThongtin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_ChinhSua);
            Controls.Add(dtp_ngaythangnamsinh);
            Controls.Add(txt_SoDienThoai);
            Controls.Add(txt_Email);
            Controls.Add(txt_DiaChi);
            Controls.Add(txt_GioiTinh);
            Controls.Add(txt_HoTen);
            Controls.Add(lbl_Phone);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_Date);
            Controls.Add(lbl_DiaChi);
            Controls.Add(lbl_GioiTinh);
            Controls.Add(lbl_HoTen);
            Name = "UThongtin";
            Size = new Size(824, 606);
            Load += UThongtin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_HoTen;
        private Label lbl_GioiTinh;
        private Label lbl_DiaChi;
        private Label lbl_Date;
        private Label lbl_Email;
        private Label lbl_Phone;
        private TextBox txt_HoTen;
        private TextBox txt_GioiTinh;
        private TextBox txt_DiaChi;
        private TextBox txt_Email;
        private TextBox txt_SoDienThoai;
        private DateTimePicker dtp_ngaythangnamsinh;
        private Button btn_ChinhSua;
    }
}
