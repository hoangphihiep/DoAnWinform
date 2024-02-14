namespace DuLich
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
            panel2 = new Panel();
            btn_MatKhau = new Button();
            btn_ThanhToan = new Button();
            btn_ThongTin = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            uMatKhau1 = new UMatKhau();
            uThongtin2 = new UThongtin();
            uThongtin1 = new UThongtin();
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
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_MatKhau);
            panel1.Controls.Add(btn_ThanhToan);
            panel1.Controls.Add(btn_ThongTin);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 654);
            panel1.TabIndex = 0;
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
            // btn_ThanhToan
            // 
            btn_ThanhToan.Location = new Point(0, 197);
            btn_ThanhToan.Name = "btn_ThanhToan";
            btn_ThanhToan.Size = new Size(190, 40);
            btn_ThanhToan.TabIndex = 2;
            btn_ThanhToan.Text = "Phương thức thanh toán";
            btn_ThanhToan.TextAlign = ContentAlignment.MiddleLeft;
            btn_ThanhToan.UseVisualStyleBackColor = true;
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
            panel5.Controls.Add(uMatKhau1);
            panel5.Controls.Add(uThongtin2);
            panel5.Controls.Add(uThongtin1);
            panel5.Location = new Point(0, 43);
            panel5.Name = "panel5";
            panel5.Size = new Size(903, 611);
            panel5.TabIndex = 1;
            // 
            // uMatKhau1
            // 
            uMatKhau1.Location = new Point(0, 0);
            uMatKhau1.Name = "uMatKhau1";
            uMatKhau1.Size = new Size(903, 611);
            uMatKhau1.TabIndex = 2;
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
        private Button btn_ThanhToan;
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
    }
}