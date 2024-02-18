namespace DuLich
{
    partial class fPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPayment));
            label8 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(48, 16);
            label8.Name = "label8";
            label8.Size = new Size(207, 15);
            label8.TabIndex = 0;
            label8.Text = "Thanh toán trong thời gian : 10 phút";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DeepSkyBlue;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(0, 298);
            panel3.Name = "panel3";
            panel3.Size = new Size(493, 44);
            panel3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(0, 348);
            button1.Name = "button1";
            button1.Size = new Size(493, 41);
            button1.TabIndex = 5;
            button1.Text = "Thanh Toán";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 13);
            label6.Name = "label6";
            label6.Size = new Size(120, 17);
            label6.TabIndex = 0;
            label6.Text = "Tổng thanh toán :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Coral;
            label7.Location = new Point(335, 40);
            label7.Name = "label7";
            label7.Size = new Size(146, 25);
            label7.TabIndex = 1;
            label7.Text = "2.643.860 VNĐ";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(0, 176);
            panel2.Name = "panel2";
            panel2.Size = new Size(493, 74);
            panel2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 15);
            label4.Name = "label4";
            label4.Size = new Size(197, 17);
            label4.TabIndex = 0;
            label4.Text = "Chọn phương thức thanh toán";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Chuyển khoản ngân hàng", "Thanh toán khi nhận phòng" });
            comboBox1.Location = new Point(308, 9);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(173, 23);
            comboBox1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(493, 45);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DodgerBlue;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(174, 46);
            label3.Name = "label3";
            label3.Size = new Size(140, 15);
            label3.TabIndex = 2;
            label3.Text = "Thứ 3, ngày 12 thg 3 2024";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DodgerBlue;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(128, 26);
            label2.Name = "label2";
            label2.Size = new Size(239, 20);
            label2.TabIndex = 1;
            label2.Text = "Melia Vinpearl Nha Trang Empire";
            // 
            // label1
            // 
            label1.BackColor = Color.DodgerBlue;
            label1.Location = new Point(0, -1);
            label1.Name = "label1";
            label1.Size = new Size(493, 84);
            label1.TabIndex = 0;
            // 
            // fPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 401);
            Controls.Add(panel3);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fPayment";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Button button1;
        private Label label6;
        private Label label7;
        private Panel panel2;
        private Label label4;
        private ComboBox comboBox1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}