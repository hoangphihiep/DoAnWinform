namespace DuLich
{
    partial class UUuDai
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
            button1 = new Button();
            txt_MaKhachSan = new TextBox();
            lbl_MaKS = new Label();
            txt_TenUuDai = new TextBox();
            lbl_TenUuDai = new Label();
            txt_GiaTriUuDai = new TextBox();
            lbl_GiaTriUuDai = new Label();
            dataGridView1 = new DataGridView();
            btn_Xoa = new Button();
            btn_Sua = new Button();
            txt_MaUuDai = new TextBox();
            lbl_MaUuDai = new Label();
            btn_Them = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(629, 114);
            button1.Name = "button1";
            button1.Size = new Size(112, 27);
            button1.TabIndex = 125;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_MaKhachSan
            // 
            txt_MaKhachSan.Location = new Point(282, 57);
            txt_MaKhachSan.Name = "txt_MaKhachSan";
            txt_MaKhachSan.Size = new Size(313, 27);
            txt_MaKhachSan.TabIndex = 124;
            // 
            // lbl_MaKS
            // 
            lbl_MaKS.AutoSize = true;
            lbl_MaKS.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_MaKS.Location = new Point(17, 57);
            lbl_MaKS.Name = "lbl_MaKS";
            lbl_MaKS.Size = new Size(122, 25);
            lbl_MaKS.TabIndex = 123;
            lbl_MaKS.Text = "Mã khách sạn";
            // 
            // txt_TenUuDai
            // 
            txt_TenUuDai.Location = new Point(282, 176);
            txt_TenUuDai.Name = "txt_TenUuDai";
            txt_TenUuDai.Size = new Size(313, 27);
            txt_TenUuDai.TabIndex = 127;
            // 
            // lbl_TenUuDai
            // 
            lbl_TenUuDai.AutoSize = true;
            lbl_TenUuDai.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TenUuDai.Location = new Point(15, 178);
            lbl_TenUuDai.Name = "lbl_TenUuDai";
            lbl_TenUuDai.Size = new Size(98, 25);
            lbl_TenUuDai.TabIndex = 126;
            lbl_TenUuDai.Text = "Tên ưu đãi";
            // 
            // txt_GiaTriUuDai
            // 
            txt_GiaTriUuDai.Location = new Point(282, 233);
            txt_GiaTriUuDai.Name = "txt_GiaTriUuDai";
            txt_GiaTriUuDai.Size = new Size(266, 27);
            txt_GiaTriUuDai.TabIndex = 129;
            // 
            // lbl_GiaTriUuDai
            // 
            lbl_GiaTriUuDai.AutoSize = true;
            lbl_GiaTriUuDai.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_GiaTriUuDai.Location = new Point(15, 235);
            lbl_GiaTriUuDai.Name = "lbl_GiaTriUuDai";
            lbl_GiaTriUuDai.Size = new Size(120, 25);
            lbl_GiaTriUuDai.TabIndex = 128;
            lbl_GiaTriUuDai.Text = "Giá trị ưu đãi";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 399);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(795, 189);
            dataGridView1.TabIndex = 130;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(361, 320);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(94, 29);
            btn_Xoa.TabIndex = 132;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(629, 320);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(94, 29);
            btn_Sua.TabIndex = 133;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // txt_MaUuDai
            // 
            txt_MaUuDai.Location = new Point(282, 114);
            txt_MaUuDai.Name = "txt_MaUuDai";
            txt_MaUuDai.Size = new Size(313, 27);
            txt_MaUuDai.TabIndex = 135;
            // 
            // lbl_MaUuDai
            // 
            lbl_MaUuDai.AutoSize = true;
            lbl_MaUuDai.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_MaUuDai.Location = new Point(17, 113);
            lbl_MaUuDai.Name = "lbl_MaUuDai";
            lbl_MaUuDai.Size = new Size(95, 25);
            lbl_MaUuDai.TabIndex = 134;
            lbl_MaUuDai.Text = "Mã ưu đãi";
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(87, 320);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(94, 29);
            btn_Them.TabIndex = 136;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(554, 235);
            label1.Name = "label1";
            label1.Size = new Size(27, 25);
            label1.TabIndex = 137;
            label1.Text = "%";
            // 
            // U_UuDai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(btn_Them);
            Controls.Add(txt_MaUuDai);
            Controls.Add(lbl_MaUuDai);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Xoa);
            Controls.Add(dataGridView1);
            Controls.Add(txt_GiaTriUuDai);
            Controls.Add(lbl_GiaTriUuDai);
            Controls.Add(txt_TenUuDai);
            Controls.Add(lbl_TenUuDai);
            Controls.Add(button1);
            Controls.Add(txt_MaKhachSan);
            Controls.Add(lbl_MaKS);
            Name = "U_UuDai";
            Size = new Size(824, 606);
            Load += U_UuDai_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txt_MaKhachSan;
        private Label lbl_MaKS;
        private TextBox txt_TenUuDai;
        private Label lbl_TenUuDai;
        private TextBox txt_GiaTriUuDai;
        private Label lbl_GiaTriUuDai;
        private DataGridView dataGridView1;
        private Button btn_Xoa;
        private Button btn_Sua;
        private TextBox txt_MaUuDai;
        private Label lbl_MaUuDai;
        private Button btn_Them;
        private Label label1;
    }
}
