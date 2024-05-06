namespace DuLich
{
    partial class fHotel_booked
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHotel_booked));
            panel1 = new Panel();
            pDaTraiNghiem = new Panel();
            label6 = new Label();
            label7 = new Label();
            pDangTraiNghiem = new Panel();
            label2 = new Label();
            label5 = new Label();
            pSapDen = new Panel();
            label4 = new Label();
            label3 = new Label();
            flb_PhongDaDat = new FlowLayoutPanel();
            label1 = new Label();
            panel1.SuspendLayout();
            pDaTraiNghiem.SuspendLayout();
            pDangTraiNghiem.SuspendLayout();
            pSapDen.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(pDaTraiNghiem);
            panel1.Controls.Add(pDangTraiNghiem);
            panel1.Controls.Add(pSapDen);
            panel1.Controls.Add(flb_PhongDaDat);
            panel1.Location = new Point(14, 135);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 697);
            panel1.TabIndex = 0;
            // 
            // pDaTraiNghiem
            // 
            pDaTraiNghiem.BackColor = SystemColors.ControlLight;
            pDaTraiNghiem.Controls.Add(label6);
            pDaTraiNghiem.Controls.Add(label7);
            pDaTraiNghiem.Location = new Point(597, 85);
            pDaTraiNghiem.Margin = new Padding(3, 4, 3, 4);
            pDaTraiNghiem.Name = "pDaTraiNghiem";
            pDaTraiNghiem.Size = new Size(246, 197);
            pDaTraiNghiem.TabIndex = 8;
            pDaTraiNghiem.Click += pDaTraiNghiem_Click;
            pDaTraiNghiem.Paint += pDaTraiNghiem_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(66, 159);
            label6.Name = "label6";
            label6.Size = new Size(143, 25);
            label6.TabIndex = 1;
            label6.Text = "Đã trải nghiệm";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(246, 147);
            label7.TabIndex = 0;
            label7.Click += label7_Click;
            // 
            // pDangTraiNghiem
            // 
            pDangTraiNghiem.BackColor = SystemColors.ControlLight;
            pDangTraiNghiem.Controls.Add(label2);
            pDangTraiNghiem.Controls.Add(label5);
            pDangTraiNghiem.Location = new Point(307, 85);
            pDangTraiNghiem.Margin = new Padding(3, 4, 3, 4);
            pDangTraiNghiem.Name = "pDangTraiNghiem";
            pDangTraiNghiem.Size = new Size(246, 197);
            pDangTraiNghiem.TabIndex = 7;
            pDangTraiNghiem.Click += pDangTraiNghiem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(51, 159);
            label2.Name = "label2";
            label2.Size = new Size(167, 25);
            label2.TabIndex = 1;
            label2.Text = "Đang trải nghiệm";
            // 
            // label5
            // 
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(246, 147);
            label5.TabIndex = 0;
            // 
            // pSapDen
            // 
            pSapDen.BackColor = SystemColors.ControlLight;
            pSapDen.Controls.Add(label4);
            pSapDen.Controls.Add(label3);
            pSapDen.Location = new Point(15, 85);
            pSapDen.Margin = new Padding(3, 4, 3, 4);
            pSapDen.Name = "pSapDen";
            pSapDen.Size = new Size(246, 197);
            pSapDen.TabIndex = 6;
            pSapDen.Click += pSapDen_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(90, 159);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 1;
            label4.Text = "Sắp tới";
            // 
            // label3
            // 
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(246, 147);
            label3.TabIndex = 0;
            // 
            // flb_PhongDaDat
            // 
            flb_PhongDaDat.AutoSize = true;
            flb_PhongDaDat.FlowDirection = FlowDirection.TopDown;
            flb_PhongDaDat.Location = new Point(15, 357);
            flb_PhongDaDat.Name = "flb_PhongDaDat";
            flb_PhongDaDat.Size = new Size(839, 337);
            flb_PhongDaDat.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkTurquoise;
            label1.Location = new Point(14, 45);
            label1.Name = "label1";
            label1.Size = new Size(234, 37);
            label1.TabIndex = 4;
            label1.Text = "Khách sạn đã đặt";
            // 
            // fHotel_booked
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(927, 551);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fHotel_booked";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel_booked";
            Load += fHotel_booked_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pDaTraiNghiem.ResumeLayout(false);
            pDaTraiNghiem.PerformLayout();
            pDangTraiNghiem.ResumeLayout(false);
            pDangTraiNghiem.PerformLayout();
            pSapDen.ResumeLayout(false);
            pSapDen.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flb_PhongDaDat;
        private Label label1;
        private Panel pDaTraiNghiem;
        private Label label6;
        private Label label7;
        private Panel pDangTraiNghiem;
        private Label label2;
        private Label label5;
        private Panel pSapDen;
        private Label label4;
        private Label label3;
    }
}