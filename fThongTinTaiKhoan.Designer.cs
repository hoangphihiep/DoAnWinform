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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            uThongtin2 = new UThongtin();
            uMatKhau1 = new UMatKhau();
            uThongtin1 = new UThongtin();
            panel4 = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
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
            // button3
            // 
            button3.Location = new Point(0, 160);
            button3.Name = "button3";
            button3.Size = new Size(190, 40);
            button3.TabIndex = 3;
            button3.Text = "Mật khẩu";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(0, 197);
            button2.Name = "button2";
            button2.Size = new Size(190, 40);
            button2.TabIndex = 2;
            button2.Text = "Phương thức thanh toán";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(0, 123);
            button1.Name = "button1";
            button1.Size = new Size(190, 40);
            button1.TabIndex = 1;
            button1.Text = "Thông tin người dùng";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            panel5.Controls.Add(uMatKhau1);
            panel5.Controls.Add(uThongtin1);
            panel5.Location = new Point(0, 43);
            panel5.Name = "panel5";
            panel5.Size = new Size(903, 611);
            panel5.TabIndex = 1;
            // 
            // uThongtin2
            // 
            uThongtin2.Location = new Point(31, 117);
            uThongtin2.Name = "uThongtin2";
            uThongtin2.Size = new Size(900, 608);
            uThongtin2.TabIndex = 2;
            // 
            // uMatKhau1
            // 
            uMatKhau1.Location = new Point(3, 0);
            uMatKhau1.Name = "uMatKhau1";
            uMatKhau1.Size = new Size(903, 608);
            uMatKhau1.TabIndex = 1;
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
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(897, 40);
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
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UThongtin uThongtin1;
        private UMatKhau uMatKhau1;
        private UThongtin uThongtin2;
    }
}