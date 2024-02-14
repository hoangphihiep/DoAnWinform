namespace DuLich
{
    partial class UMatKhau
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
            lbl_GioiTinh = new Label();
            textBox6 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            btn_ChinhSua = new Button();
            SuspendLayout();
            // 
            // lbl_GioiTinh
            // 
            lbl_GioiTinh.AutoSize = true;
            lbl_GioiTinh.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_GioiTinh.Location = new Point(46, 50);
            lbl_GioiTinh.Name = "lbl_GioiTinh";
            lbl_GioiTinh.Size = new Size(134, 25);
            lbl_GioiTinh.TabIndex = 2;
            lbl_GioiTinh.Text = "Tên đăng nhập";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(248, 50);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(281, 27);
            textBox6.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 120);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 13;
            label1.Text = "Mật khẩu";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(248, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 27);
            textBox1.TabIndex = 14;
            // 
            // btn_ChinhSua
            // 
            btn_ChinhSua.Location = new Point(537, 187);
            btn_ChinhSua.Name = "btn_ChinhSua";
            btn_ChinhSua.Size = new Size(112, 49);
            btn_ChinhSua.TabIndex = 15;
            btn_ChinhSua.Text = "Chỉnh sửa";
            btn_ChinhSua.UseVisualStyleBackColor = true;
            // 
            // UMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_ChinhSua);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(lbl_GioiTinh);
            Name = "UMatKhau";
            Size = new Size(684, 502);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_GioiTinh;
        private TextBox textBox6;
        private Label label1;
        private TextBox textBox1;
        private Button btn_ChinhSua;
    }
}
