﻿namespace DuLich
{
    partial class fBanking_Payment
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            label4 = new Label();
            panel2 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            label8 = new Label();
            label7 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DodgerBlue;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(174, 45);
            label3.Name = "label3";
            label3.Size = new Size(140, 15);
            label3.TabIndex = 5;
            label3.Text = "Thứ 3, ngày 12 thg 3 2024";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DodgerBlue;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(128, 25);
            label2.Name = "label2";
            label2.Size = new Size(239, 20);
            label2.TabIndex = 4;
            label2.Text = "Melia Vinpearl Nha Trang Empire";
            // 
            // label1
            // 
            label1.BackColor = Color.DodgerBlue;
            label1.Location = new Point(0, -2);
            label1.Name = "label1";
            label1.Size = new Size(493, 84);
            label1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 48);
            panel1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "BIDV", "AgriBank", "ViettinBank", "Vietcombank" });
            comboBox1.Location = new Point(333, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 14);
            label4.Name = "label4";
            label4.Size = new Size(148, 17);
            label4.TabIndex = 0;
            label4.Text = "Ngân hàng thanh toán";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(12, 176);
            panel2.Name = "panel2";
            panel2.Size = new Size(470, 84);
            panel2.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(118, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(336, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(336, 23);
            textBox1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 49);
            label6.Name = "label6";
            label6.Size = new Size(74, 17);
            label6.TabIndex = 1;
            label6.Text = "Mật khẩu :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 19);
            label5.Name = "label5";
            label5.Size = new Size(100, 17);
            label5.TabIndex = 0;
            label5.Text = "Tên tài khoản :";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(12, 280);
            panel3.Name = "panel3";
            panel3.Size = new Size(470, 47);
            panel3.TabIndex = 8;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkTurquoise;
            label8.Location = new Point(308, 12);
            label8.Name = "label8";
            label8.Size = new Size(146, 23);
            label8.TabIndex = 1;
            label8.Text = "Nguyễn Văn A";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 15);
            label7.Name = "label7";
            label7.Size = new Size(172, 17);
            label7.TabIndex = 0;
            label7.Text = "Tên tài khoản thanh toán :";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(337, 369);
            button1.Name = "button1";
            button1.Size = new Size(145, 32);
            button1.TabIndex = 9;
            button1.Text = "Thanh toán";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fBanking_Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 421);
            Controls.Add(button1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fBanking_Payment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fBanking_Payment";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private ComboBox comboBox1;
        private Label label4;
        private Panel panel2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Panel panel3;
        private Label label8;
        private Label label7;
        private Button button1;
    }
}