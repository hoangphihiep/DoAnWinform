﻿namespace DuLich
{
    partial class UViTri
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
            lbl_DiaChi = new Label();
            txt_DiaChi = new TextBox();
            lbl_Tinh = new Label();
            lbl_ThanhPho = new Label();
            txt_Tinh = new TextBox();
            txt_ThanhPho = new TextBox();
            btn_ChinhSua = new Button();
            txt_MaKhachSan = new TextBox();
            lbl_MaKS = new Label();
            SuspendLayout();
            // 
            // lbl_DiaChi
            // 
            lbl_DiaChi.AutoSize = true;
            lbl_DiaChi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_DiaChi.Location = new Point(39, 101);
            lbl_DiaChi.Name = "lbl_DiaChi";
            lbl_DiaChi.Size = new Size(67, 25);
            lbl_DiaChi.TabIndex = 1;
            lbl_DiaChi.Text = "Địa chỉ";
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Location = new Point(284, 99);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(313, 27);
            txt_DiaChi.TabIndex = 16;
            // 
            // lbl_Tinh
            // 
            lbl_Tinh.AutoSize = true;
            lbl_Tinh.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Tinh.Location = new Point(39, 186);
            lbl_Tinh.Name = "lbl_Tinh";
            lbl_Tinh.Size = new Size(48, 25);
            lbl_Tinh.TabIndex = 19;
            lbl_Tinh.Text = "Tỉnh";
            // 
            // lbl_ThanhPho
            // 
            lbl_ThanhPho.AutoSize = true;
            lbl_ThanhPho.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ThanhPho.Location = new Point(39, 268);
            lbl_ThanhPho.Name = "lbl_ThanhPho";
            lbl_ThanhPho.Size = new Size(99, 25);
            lbl_ThanhPho.TabIndex = 20;
            lbl_ThanhPho.Text = "Thành phố";
            // 
            // txt_Tinh
            // 
            txt_Tinh.Location = new Point(284, 184);
            txt_Tinh.Name = "txt_Tinh";
            txt_Tinh.Size = new Size(313, 27);
            txt_Tinh.TabIndex = 24;
            // 
            // txt_ThanhPho
            // 
            txt_ThanhPho.Location = new Point(284, 266);
            txt_ThanhPho.Name = "txt_ThanhPho";
            txt_ThanhPho.Size = new Size(313, 27);
            txt_ThanhPho.TabIndex = 25;
            // 
            // btn_ChinhSua
            // 
            btn_ChinhSua.Location = new Point(670, 492);
            btn_ChinhSua.Name = "btn_ChinhSua";
            btn_ChinhSua.Size = new Size(112, 49);
            btn_ChinhSua.TabIndex = 27;
            btn_ChinhSua.Text = "Chỉnh sửa";
            btn_ChinhSua.UseVisualStyleBackColor = true;
            btn_ChinhSua.Click += btn_ChinhSua_Click;
            // 
            // txt_MaKhachSan
            // 
            txt_MaKhachSan.Location = new Point(284, 24);
            txt_MaKhachSan.Name = "txt_MaKhachSan";
            txt_MaKhachSan.Size = new Size(313, 27);
            txt_MaKhachSan.TabIndex = 29;
            // 
            // lbl_MaKS
            // 
            lbl_MaKS.AutoSize = true;
            lbl_MaKS.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_MaKS.Location = new Point(39, 26);
            lbl_MaKS.Name = "lbl_MaKS";
            lbl_MaKS.Size = new Size(122, 25);
            lbl_MaKS.TabIndex = 28;
            lbl_MaKS.Text = "Mã khách sạn";
            lbl_MaKS.Click += lbl_MaKS_Click;
            // 
            // UViTri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txt_MaKhachSan);
            Controls.Add(lbl_MaKS);
            Controls.Add(btn_ChinhSua);
            Controls.Add(txt_ThanhPho);
            Controls.Add(txt_Tinh);
            Controls.Add(lbl_ThanhPho);
            Controls.Add(lbl_Tinh);
            Controls.Add(txt_DiaChi);
            Controls.Add(lbl_DiaChi);
            Name = "UViTri";
            Size = new Size(807, 563);
            Load += UViTri_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_DiaChi;
        private TextBox txt_DiaChi;
        private Label lbl_Tinh;
        private Label lbl_ThanhPho;
        private TextBox txt_Tinh;
        private TextBox txt_ThanhPho;
        private Button btn_ChinhSua;
        private TextBox txt_MaKhachSan;
        private Label lbl_MaKS;
    }
}
