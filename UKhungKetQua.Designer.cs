namespace DuLich
{
    partial class UKhungKetQua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UKhungKetQua));
            lbl_TenKhachSan = new Label();
            pictureBox1 = new PictureBox();
            lbl_ViTri = new Label();
            lbl_Tien = new Label();
            lbl_KhoangCachTP = new Label();
            lbl_SoLuong = new Label();
            lbl_KhoangCachSanBay = new Label();
            lbl_danhGia = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_TenKhachSan
            // 
            lbl_TenKhachSan.AutoSize = true;
            lbl_TenKhachSan.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TenKhachSan.Location = new Point(217, 10);
            lbl_TenKhachSan.Name = "lbl_TenKhachSan";
            lbl_TenKhachSan.Size = new Size(437, 38);
            lbl_TenKhachSan.TabIndex = 2;
            lbl_TenKhachSan.Text = "Melia Vinpearl Nha Trang Empir";
            lbl_TenKhachSan.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(15, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lbl_ViTri
            // 
            lbl_ViTri.AutoSize = true;
            lbl_ViTri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ViTri.Location = new Point(217, 101);
            lbl_ViTri.Name = "lbl_ViTri";
            lbl_ViTri.Size = new Size(56, 20);
            lbl_ViTri.TabIndex = 4;
            lbl_ViTri.Text = "Địa chỉ";
            // 
            // lbl_Tien
            // 
            lbl_Tien.AutoSize = true;
            lbl_Tien.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Tien.Location = new Point(706, 67);
            lbl_Tien.Name = "lbl_Tien";
            lbl_Tien.Size = new Size(59, 20);
            lbl_Tien.TabIndex = 5;
            lbl_Tien.Text = "Số Tiền";
            // 
            // lbl_KhoangCachTP
            // 
            lbl_KhoangCachTP.AutoSize = true;
            lbl_KhoangCachTP.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_KhoangCachTP.Location = new Point(217, 67);
            lbl_KhoangCachTP.Name = "lbl_KhoangCachTP";
            lbl_KhoangCachTP.Size = new Size(118, 20);
            lbl_KhoangCachTP.TabIndex = 6;
            lbl_KhoangCachTP.Text = "Khoảng cách TP";
            lbl_KhoangCachTP.Visible = false;
            // 
            // lbl_SoLuong
            // 
            lbl_SoLuong.AutoSize = true;
            lbl_SoLuong.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_SoLuong.Location = new Point(706, 101);
            lbl_SoLuong.Name = "lbl_SoLuong";
            lbl_SoLuong.Size = new Size(73, 20);
            lbl_SoLuong.TabIndex = 7;
            lbl_SoLuong.Text = "Số Lượng";
            lbl_SoLuong.Visible = false;
            // 
            // lbl_KhoangCachSanBay
            // 
            lbl_KhoangCachSanBay.AutoSize = true;
            lbl_KhoangCachSanBay.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_KhoangCachSanBay.Location = new Point(217, 67);
            lbl_KhoangCachSanBay.Name = "lbl_KhoangCachSanBay";
            lbl_KhoangCachSanBay.Size = new Size(153, 20);
            lbl_KhoangCachSanBay.TabIndex = 8;
            lbl_KhoangCachSanBay.Text = "Khoảng cách sân bay";
            lbl_KhoangCachSanBay.Visible = false;
            // 
            // lbl_danhGia
            // 
            lbl_danhGia.AutoSize = true;
            lbl_danhGia.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_danhGia.Location = new Point(217, 67);
            lbl_danhGia.Name = "lbl_danhGia";
            lbl_danhGia.Size = new Size(69, 20);
            lbl_danhGia.TabIndex = 9;
            lbl_danhGia.Text = "đánh giá";
            lbl_danhGia.Visible = false;
            // 
            // UKhungKetQua
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(lbl_danhGia);
            Controls.Add(lbl_SoLuong);
            Controls.Add(lbl_KhoangCachTP);
            Controls.Add(lbl_Tien);
            Controls.Add(lbl_ViTri);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_TenKhachSan);
            Controls.Add(lbl_KhoangCachSanBay);
            Name = "UKhungKetQua";
            Size = new Size(917, 137);
            Load += UKhungKetQua_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_TenKhachSan;
        private PictureBox pictureBox1;
        private Label lbl_ViTri;
        private Label lbl_Tien;
        private Label lbl_KhoangCachTP;
        private Label lbl_SoLuong;
        private Label lbl_KhoangCachSanBay;
        private Label lbl_danhGia;
    }
}
