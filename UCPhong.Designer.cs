namespace DuLich
{
    partial class UCPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPhong));
            panel13 = new Panel();
            button2 = new Button();
            panel14 = new Panel();
            lblSoGiuong = new Label();
            label1 = new Label();
            label21 = new Label();
            lblPrice = new Label();
            lblSoPhongTrong = new Label();
            label18 = new Label();
            lblSoKhach = new Label();
            label16 = new Label();
            lblName2 = new Label();
            ptbAnh = new PictureBox();
            lblName1 = new Label();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).BeginInit();
            SuspendLayout();
            // 
            // panel13
            // 
            panel13.BackColor = Color.LightCyan;
            panel13.Controls.Add(button2);
            panel13.Controls.Add(panel14);
            panel13.Controls.Add(ptbAnh);
            panel13.Controls.Add(lblName1);
            panel13.Location = new Point(2, -3);
            panel13.Margin = new Padding(3, 4, 3, 4);
            panel13.Name = "panel13";
            panel13.Size = new Size(582, 253);
            panel13.TabIndex = 5;
            panel13.Paint += panel13_Paint;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkTurquoise;
            button2.Location = new Point(474, 13);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(94, 31);
            button2.TabIndex = 3;
            button2.Text = "Đặt phòng";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel14
            // 
            panel14.Controls.Add(lblSoGiuong);
            panel14.Controls.Add(label1);
            panel14.Controls.Add(label21);
            panel14.Controls.Add(lblPrice);
            panel14.Controls.Add(lblSoPhongTrong);
            panel14.Controls.Add(label18);
            panel14.Controls.Add(lblSoKhach);
            panel14.Controls.Add(label16);
            panel14.Controls.Add(lblName2);
            panel14.Location = new Point(238, 52);
            panel14.Margin = new Padding(3, 4, 3, 4);
            panel14.Name = "panel14";
            panel14.Size = new Size(330, 179);
            panel14.TabIndex = 2;
            // 
            // lblSoGiuong
            // 
            lblSoGiuong.AutoSize = true;
            lblSoGiuong.Location = new Point(80, 85);
            lblSoGiuong.Name = "lblSoGiuong";
            lblSoGiuong.Size = new Size(17, 20);
            lblSoGiuong.TabIndex = 8;
            lblSoGiuong.Text = "2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(3, 85);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 7;
            label1.Text = "Số giường :";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(169, 152);
            label21.Name = "label21";
            label21.Size = new Size(97, 20);
            label21.TabIndex = 6;
            label21.Text = "/phòng/đêm.";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.DarkTurquoise;
            lblPrice.Location = new Point(3, 145);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(100, 25);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "16709490";
            // 
            // lblSoPhongTrong
            // 
            lblSoPhongTrong.AutoSize = true;
            lblSoPhongTrong.Location = new Point(146, 124);
            lblSoPhongTrong.Name = "lblSoPhongTrong";
            lblSoPhongTrong.Size = new Size(17, 20);
            lblSoPhongTrong.TabIndex = 4;
            lblSoPhongTrong.Text = "4";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(3, 124);
            label18.Name = "label18";
            label18.Size = new Size(148, 20);
            label18.TabIndex = 3;
            label18.Text = "Số phòng còn trống :";
            // 
            // lblSoKhach
            // 
            lblSoKhach.AutoSize = true;
            lblSoKhach.Location = new Point(80, 52);
            lblSoKhach.Name = "lblSoKhach";
            lblSoKhach.Size = new Size(17, 20);
            lblSoKhach.TabIndex = 2;
            lblSoKhach.Text = "2";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.DimGray;
            label16.Location = new Point(3, 52);
            label16.Name = "label16";
            label16.Size = new Size(75, 20);
            label16.TabIndex = 1;
            label16.Text = "Số khách :";
            // 
            // lblName2
            // 
            lblName2.AutoSize = true;
            lblName2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblName2.ForeColor = SystemColors.ControlText;
            lblName2.Location = new Point(3, 13);
            lblName2.Name = "lblName2";
            lblName2.Size = new Size(310, 25);
            lblName2.TabIndex = 0;
            lblName2.Text = "Beach Front 1 Bedroom Pool Villa";
            // 
            // ptbAnh
            // 
            ptbAnh.Image = (Image)resources.GetObject("ptbAnh.Image");
            ptbAnh.Location = new Point(18, 49);
            ptbAnh.Margin = new Padding(3, 4, 3, 4);
            ptbAnh.Name = "ptbAnh";
            ptbAnh.Size = new Size(213, 185);
            ptbAnh.SizeMode = PictureBoxSizeMode.Zoom;
            ptbAnh.TabIndex = 1;
            ptbAnh.TabStop = false;
            // 
            // lblName1
            // 
            lblName1.AutoSize = true;
            lblName1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblName1.ForeColor = Color.DarkTurquoise;
            lblName1.Location = new Point(6, 8);
            lblName1.Name = "lblName1";
            lblName1.Size = new Size(397, 32);
            lblName1.TabIndex = 0;
            lblName1.Text = "1 Bedroom Pool Villa Beach Front";
            // 
            // UCPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel13);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCPhong";
            Size = new Size(601, 251);
            Load += UCPhong_Load;
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel13;
        private Button button2;
        private Panel panel14;
        private Label lblSoGiuong;
        private Label label1;
        private Label label21;
        private Label lblPrice;
        private Label lblSoPhongTrong;
        private Label label18;
        private Label lblSoKhach;
        private Label label16;
        private Label lblName2;
        private PictureBox ptbAnh;
        private Label lblName1;
    }
}
