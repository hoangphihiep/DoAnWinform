namespace DuLich
{
    partial class FAddAnh
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
            pictureBox1 = new PictureBox();
            txbMaKS = new TextBox();
            txbTenAnh = new TextBox();
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txbMaAnh = new TextBox();
            label4 = new Label();
            txbAddress = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(510, 332);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txbMaKS
            // 
            txbMaKS.Location = new Point(562, 45);
            txbMaKS.Name = "txbMaKS";
            txbMaKS.Size = new Size(193, 23);
            txbMaKS.TabIndex = 1;
            // 
            // txbTenAnh
            // 
            txbTenAnh.Location = new Point(562, 232);
            txbTenAnh.Name = "txbTenAnh";
            txbTenAnh.Size = new Size(193, 23);
            txbTenAnh.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(680, 375);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(562, 9);
            label1.Name = "label1";
            label1.Size = new Size(118, 21);
            label1.TabIndex = 4;
            label1.Text = "Ma khach san:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(559, 197);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 5;
            label2.Text = "Ten anh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(562, 105);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 7;
            label3.Text = "Ma anh:";
            // 
            // txbMaAnh
            // 
            txbMaAnh.Location = new Point(562, 138);
            txbMaAnh.Name = "txbMaAnh";
            txbMaAnh.Size = new Size(193, 23);
            txbMaAnh.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(556, 286);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 9;
            label4.Text = "Address:";
            // 
            // txbAddress
            // 
            txbAddress.Location = new Point(559, 321);
            txbAddress.Name = "txbAddress";
            txbAddress.Size = new Size(193, 23);
            txbAddress.TabIndex = 8;
            // 
            // FAddAnh
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txbAddress);
            Controls.Add(label3);
            Controls.Add(txbMaAnh);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(txbTenAnh);
            Controls.Add(txbMaKS);
            Controls.Add(pictureBox1);
            Name = "FAddAnh";
            Text = "FAddAnh";
            DragDrop += FAddAnh_DragDrop;
            DragEnter += FAddAnh_DragEnter;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txbMaKS;
        private TextBox txbTenAnh;
        private Button btnAdd;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txbMaAnh;
        private Label label4;
        private TextBox txbAddress;
    }
}