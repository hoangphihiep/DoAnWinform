﻿namespace DuLich
{
    partial class fThongTinTaiKhoan
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
            btn_HoSo = new Button();
            btn_Anh = new Button();
            btn_ChiTietPhong = new Button();
            btn_ViTri = new Button();
            btn_ThongTingKS = new Button();
            panel2 = new Panel();
            btn_MatKhau = new Button();
            btn_ThongTinKhachSan = new Button();
            btn_ThongTin = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            uThongtin2 = new UThongtin();
            uThongtin1 = new UThongtin();
            uMatKhau1 = new UMatKhau();
            uThongTinKhachSan1 = new UThongTinKhachSan();
            uViTri1 = new UViTri();
            uHoSo1 = new UHoSo();
            uAnh1 = new UAnh();
            uChiTietPhongo1 = new UChiTietPhongO();
            panel4 = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(btn_HoSo);
            panel1.Controls.Add(btn_Anh);
            panel1.Controls.Add(btn_ChiTietPhong);
            panel1.Controls.Add(btn_ViTri);
            panel1.Controls.Add(btn_ThongTingKS);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_MatKhau);
            panel1.Controls.Add(btn_ThongTinKhachSan);
            panel1.Controls.Add(btn_ThongTin);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 654);
            panel1.TabIndex = 0;
            // 
            // btn_HoSo
            // 
            btn_HoSo.Location = new Point(44, 370);
            btn_HoSo.Name = "btn_HoSo";
            btn_HoSo.Size = new Size(146, 38);
            btn_HoSo.TabIndex = 8;
            btn_HoSo.Text = "Hồ Sơ";
            btn_HoSo.TextAlign = ContentAlignment.MiddleLeft;
            btn_HoSo.UseVisualStyleBackColor = true;
            btn_HoSo.Visible = false;
            btn_HoSo.Click += btn_HoSo_Click;
            // 
            // btn_Anh
            // 
            btn_Anh.Location = new Point(44, 338);
            btn_Anh.Name = "btn_Anh";
            btn_Anh.Size = new Size(146, 38);
            btn_Anh.TabIndex = 7;
            btn_Anh.Text = "Ảnh";
            btn_Anh.TextAlign = ContentAlignment.MiddleLeft;
            btn_Anh.UseVisualStyleBackColor = true;
            btn_Anh.Visible = false;
            btn_Anh.Click += btn_Anh_Click;
            // 
            // btn_ChiTietPhong
            // 
            btn_ChiTietPhong.Location = new Point(44, 304);
            btn_ChiTietPhong.Name = "btn_ChiTietPhong";
            btn_ChiTietPhong.Size = new Size(146, 38);
            btn_ChiTietPhong.TabIndex = 6;
            btn_ChiTietPhong.Text = "Chi tiết phòng";
            btn_ChiTietPhong.TextAlign = ContentAlignment.MiddleLeft;
            btn_ChiTietPhong.UseVisualStyleBackColor = true;
            btn_ChiTietPhong.Visible = false;
            btn_ChiTietPhong.Click += btn_ChiTietPhong_Click;
            // 
            // btn_ViTri
            // 
            btn_ViTri.Location = new Point(44, 269);
            btn_ViTri.Name = "btn_ViTri";
            btn_ViTri.Size = new Size(146, 38);
            btn_ViTri.TabIndex = 5;
            btn_ViTri.Text = "Vị trí";
            btn_ViTri.TextAlign = ContentAlignment.MiddleLeft;
            btn_ViTri.UseVisualStyleBackColor = true;
            btn_ViTri.Visible = false;
            btn_ViTri.Click += btn_ViTri_Click;
            // 
            // btn_ThongTingKS
            // 
            btn_ThongTingKS.Location = new Point(44, 235);
            btn_ThongTingKS.Name = "btn_ThongTingKS";
            btn_ThongTingKS.Size = new Size(146, 38);
            btn_ThongTingKS.TabIndex = 4;
            btn_ThongTingKS.Text = "Thông tin căn bản";
            btn_ThongTingKS.TextAlign = ContentAlignment.MiddleLeft;
            btn_ThongTingKS.UseVisualStyleBackColor = true;
            btn_ThongTingKS.Visible = false;
            btn_ThongTingKS.Click += btn_ThongTingKS_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(190, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 125);
            panel2.TabIndex = 1;
            // 
            // btn_MatKhau
            // 
            btn_MatKhau.Location = new Point(0, 160);
            btn_MatKhau.Name = "btn_MatKhau";
            btn_MatKhau.Size = new Size(190, 40);
            btn_MatKhau.TabIndex = 3;
            btn_MatKhau.Text = "Mật khẩu";
            btn_MatKhau.TextAlign = ContentAlignment.MiddleLeft;
            btn_MatKhau.UseVisualStyleBackColor = true;
            btn_MatKhau.Click += btn_MatKhau_Click;
            // 
            // btn_ThongTinKhachSan
            // 
            btn_ThongTinKhachSan.Location = new Point(0, 197);
            btn_ThongTinKhachSan.Name = "btn_ThongTinKhachSan";
            btn_ThongTinKhachSan.Size = new Size(190, 40);
            btn_ThongTinKhachSan.TabIndex = 2;
            btn_ThongTinKhachSan.Text = "Thông tin khách sạn";
            btn_ThongTinKhachSan.TextAlign = ContentAlignment.MiddleLeft;
            btn_ThongTinKhachSan.UseVisualStyleBackColor = true;
            btn_ThongTinKhachSan.Click += btn_ThongTinKhachSan_Click;
            // 
            // btn_ThongTin
            // 
            btn_ThongTin.Location = new Point(0, 123);
            btn_ThongTin.Name = "btn_ThongTin";
            btn_ThongTin.Size = new Size(190, 40);
            btn_ThongTin.TabIndex = 1;
            btn_ThongTin.Text = "Thông tin người dùng";
            btn_ThongTin.TextAlign = ContentAlignment.MiddleLeft;
            btn_ThongTin.UseVisualStyleBackColor = true;
            btn_ThongTin.Click += btn_ThongTin_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(190, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(903, 654);
            panel3.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(uThongtin2);
            panel5.Controls.Add(uThongtin1);
            panel5.Controls.Add(uMatKhau1);
            panel5.Controls.Add(uThongTinKhachSan1);
            panel5.Controls.Add(uViTri1);
            panel5.Controls.Add(uHoSo1);
            panel5.Controls.Add(uAnh1);
            panel5.Controls.Add(uChiTietPhongo1);
            panel5.Location = new Point(0, 43);
            panel5.Name = "panel5";
            panel5.Size = new Size(903, 611);
            panel5.TabIndex = 1;
            // 
            // uThongtin2
            // 
            uThongtin2.Location = new Point(0, 3);
            uThongtin2.Name = "uThongtin2";
            uThongtin2.Size = new Size(903, 611);
            uThongtin2.TabIndex = 1;
            // 
            // uThongtin1
            // 
            uThongtin1.Location = new Point(1194, 154);
            uThongtin1.Name = "uThongtin1";
            uThongtin1.Size = new Size(900, 611);
            uThongtin1.TabIndex = 0;
            // 
            // uMatKhau1
            // 
            uMatKhau1.Location = new Point(0, 0);
            uMatKhau1.Name = "uMatKhau1";
            uMatKhau1.Size = new Size(903, 611);
            uMatKhau1.TabIndex = 2;
            // 
            // uThongTinKhachSan1
            // 
            uThongTinKhachSan1.Location = new Point(0, 0);
            uThongTinKhachSan1.Name = "uThongTinKhachSan1";
            uThongTinKhachSan1.Size = new Size(903, 611);
            uThongTinKhachSan1.TabIndex = 3;
            // 
            // uViTri1
            // 
            uViTri1.Location = new Point(0, 0);
            uViTri1.Name = "uViTri1";
            uViTri1.Size = new Size(903, 611);
            uViTri1.TabIndex = 4;
            // 
            // uHoSo1
            // 
            uHoSo1.Location = new Point(0, 0);
            uHoSo1.Name = "uHoSo1";
            uHoSo1.Size = new Size(903, 614);
            uHoSo1.TabIndex = 7;
            // 
            // uAnh1
            // 
            uAnh1.Location = new Point(0, 0);
            uAnh1.Name = "uAnh1";
            uAnh1.Size = new Size(903, 611);
            uAnh1.TabIndex = 6;
            // 
            // uChiTietPhongo1
            // 
            uChiTietPhongo1.Location = new Point(0, 0);
            uChiTietPhongo1.Name = "uChiTietPhongo1";
            uChiTietPhongo1.Size = new Size(900, 611);
            uChiTietPhongo1.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonFace;
            panel4.Location = new Point(0, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(903, 40);
            panel4.TabIndex = 0;
            // 
            // fThongTinTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 654);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "fThongTinTaiKhoan";
            Text = "fThongTinTaiKhoan";
            Load += fThongTinTaiKhoan_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_MatKhau;
        private Button btn_ThongTinKhachSan;
        private Button btn_ThongTin;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UThongtin uThongtin1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private UThongtin uThongtin2;
        private UMatKhau uMatKhau1;
        private Button btn_HoSo;
        private Button btn_Anh;
        private Button btn_ChiTietPhong;
        private Button btn_ViTri;
        private Button btn_ThongTingKS;
        private UThongTinKhachSan uThongTinKhachSan1;
        private UViTri uViTri1;
        private UChiTietPhongO uChiTietPhongo1;
        private UAnh uAnh1;
        private UHoSo uHoSo1;
    }
}