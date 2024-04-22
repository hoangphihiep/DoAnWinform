namespace DuLich
{
    partial class FComment
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
            txbDanhGia = new TextBox();
            label1 = new Label();
            label2 = new Label();
            nUDDiemDG = new NumericUpDown();
            btn_NhanXet = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)nUDDiemDG).BeginInit();
            SuspendLayout();
            // 
            // txbDanhGia
            // 
            txbDanhGia.Location = new Point(12, 176);
            txbDanhGia.MinimumSize = new Size(583, 200);
            txbDanhGia.Name = "txbDanhGia";
            txbDanhGia.Size = new Size(608, 200);
            txbDanhGia.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkTurquoise;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(101, 30);
            label1.TabIndex = 5;
            label1.Text = "Đánh giá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(111, 17);
            label2.TabIndex = 6;
            label2.Text = "Điểm đánh giá : ";
            // 
            // nUDDiemDG
            // 
            nUDDiemDG.Location = new Point(135, 82);
            nUDDiemDG.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nUDDiemDG.Name = "nUDDiemDG";
            nUDDiemDG.Size = new Size(120, 23);
            nUDDiemDG.TabIndex = 7;
            // 
            // btn_NhanXet
            // 
            btn_NhanXet.Location = new Point(520, 404);
            btn_NhanXet.Name = "btn_NhanXet";
            btn_NhanXet.Size = new Size(100, 23);
            btn_NhanXet.TabIndex = 8;
            btn_NhanXet.Text = "Nhận xét";
            btn_NhanXet.UseVisualStyleBackColor = true;
            btn_NhanXet.Click += btn_NhanXet_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 137);
            label3.Name = "label3";
            label3.Size = new Size(78, 17);
            label3.TabIndex = 9;
            label3.Text = "Nội dung : ";
            // 
            // FComment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 448);
            Controls.Add(label3);
            Controls.Add(btn_NhanXet);
            Controls.Add(nUDDiemDG);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txbDanhGia);
            Name = "FComment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FComment";
            ((System.ComponentModel.ISupportInitialize)nUDDiemDG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbDanhGia;
        private Label label1;
        private Label label2;
        private NumericUpDown nUDDiemDG;
        private Button btn_NhanXet;
        private Label label3;
    }
}