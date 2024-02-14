namespace DuLich
{
    partial class UChiTietPhongO
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
            lbl_TenPhong = new Label();
            txt_TenPhong = new TextBox();
            lbl_KichThuoc = new Label();
            lbl_PhongTam = new Label();
            lbl_SucChua = new Label();
            label1 = new Label();
            btn_ChinhSua = new Button();
            txtKichThuoc = new TextBox();
            txt_SucChua = new TextBox();
            txt_PhongTam = new TextBox();
            txt_Gia = new TextBox();
            SuspendLayout();
            // 
            // lbl_TenPhong
            // 
            lbl_TenPhong.AutoSize = true;
            lbl_TenPhong.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TenPhong.Location = new Point(43, 52);
            lbl_TenPhong.Name = "lbl_TenPhong";
            lbl_TenPhong.Size = new Size(100, 25);
            lbl_TenPhong.TabIndex = 1;
            lbl_TenPhong.Text = "Tên phòng";
            // 
            // txt_TenPhong
            // 
            txt_TenPhong.Location = new Point(273, 50);
            txt_TenPhong.Name = "txt_TenPhong";
            txt_TenPhong.Size = new Size(313, 27);
            txt_TenPhong.TabIndex = 16;
            // 
            // lbl_KichThuoc
            // 
            lbl_KichThuoc.AutoSize = true;
            lbl_KichThuoc.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_KichThuoc.Location = new Point(43, 135);
            lbl_KichThuoc.Name = "lbl_KichThuoc";
            lbl_KichThuoc.Size = new Size(98, 25);
            lbl_KichThuoc.TabIndex = 17;
            lbl_KichThuoc.Text = "Kích thước";
            // 
            // lbl_PhongTam
            // 
            lbl_PhongTam.AutoSize = true;
            lbl_PhongTam.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_PhongTam.Location = new Point(40, 303);
            lbl_PhongTam.Name = "lbl_PhongTam";
            lbl_PhongTam.Size = new Size(103, 25);
            lbl_PhongTam.TabIndex = 18;
            lbl_PhongTam.Text = "Phòng tắm";
            // 
            // lbl_SucChua
            // 
            lbl_SucChua.AutoSize = true;
            lbl_SucChua.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_SucChua.Location = new Point(43, 220);
            lbl_SucChua.Name = "lbl_SucChua";
            lbl_SucChua.Size = new Size(84, 25);
            lbl_SucChua.TabIndex = 19;
            lbl_SucChua.Text = "Sức chứa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(43, 384);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 20;
            label1.Text = "Giá mỗi đêm";
            // 
            // btn_ChinhSua
            // 
            btn_ChinhSua.Location = new Point(645, 532);
            btn_ChinhSua.Name = "btn_ChinhSua";
            btn_ChinhSua.Size = new Size(112, 49);
            btn_ChinhSua.TabIndex = 21;
            btn_ChinhSua.Text = "Chỉnh sửa";
            btn_ChinhSua.UseVisualStyleBackColor = true;
            // 
            // txtKichThuoc
            // 
            txtKichThuoc.Location = new Point(273, 133);
            txtKichThuoc.Name = "txtKichThuoc";
            txtKichThuoc.Size = new Size(313, 27);
            txtKichThuoc.TabIndex = 22;
            // 
            // txt_SucChua
            // 
            txt_SucChua.Location = new Point(273, 218);
            txt_SucChua.Name = "txt_SucChua";
            txt_SucChua.Size = new Size(313, 27);
            txt_SucChua.TabIndex = 23;
            // 
            // txt_PhongTam
            // 
            txt_PhongTam.Location = new Point(273, 301);
            txt_PhongTam.Name = "txt_PhongTam";
            txt_PhongTam.Size = new Size(313, 27);
            txt_PhongTam.TabIndex = 24;
            // 
            // txt_Gia
            // 
            txt_Gia.Location = new Point(273, 382);
            txt_Gia.Name = "txt_Gia";
            txt_Gia.Size = new Size(313, 27);
            txt_Gia.TabIndex = 25;
            // 
            // UChiTietPhongO
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txt_Gia);
            Controls.Add(txt_PhongTam);
            Controls.Add(txt_SucChua);
            Controls.Add(txtKichThuoc);
            Controls.Add(btn_ChinhSua);
            Controls.Add(label1);
            Controls.Add(lbl_SucChua);
            Controls.Add(lbl_PhongTam);
            Controls.Add(lbl_KichThuoc);
            Controls.Add(txt_TenPhong);
            Controls.Add(lbl_TenPhong);
            Name = "UChiTietPhongO";
            Size = new Size(779, 605);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_TenPhong;
        private TextBox txt_TenPhong;
        private Label lbl_KichThuoc;
        private Label lbl_PhongTam;
        private Label lbl_SucChua;
        private Label label1;
        private Button btn_ChinhSua;
        private TextBox txtKichThuoc;
        private TextBox txt_SucChua;
        private TextBox txt_PhongTam;
        private TextBox txt_Gia;
    }
}
