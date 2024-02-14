namespace DuLich
{
    partial class UTienNghi
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
            lbl_LoiVao = new Label();
            txt_LoiVao = new TextBox();
            lbl_ThongTinQT = new Label();
            lbl_AnToanSS = new Label();
            lbl_ThongTinTT = new Label();
            txt_ThongTinQT = new TextBox();
            txt_AnToanSS = new TextBox();
            txt_ThongTinTT = new TextBox();
            btn_ChinhSua = new Button();
            SuspendLayout();
            // 
            // lbl_LoiVao
            // 
            lbl_LoiVao.AutoSize = true;
            lbl_LoiVao.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_LoiVao.Location = new Point(50, 49);
            lbl_LoiVao.Name = "lbl_LoiVao";
            lbl_LoiVao.Size = new Size(71, 25);
            lbl_LoiVao.TabIndex = 1;
            lbl_LoiVao.Text = "Lối vào";
            // 
            // txt_LoiVao
            // 
            txt_LoiVao.Location = new Point(272, 47);
            txt_LoiVao.Name = "txt_LoiVao";
            txt_LoiVao.Size = new Size(313, 27);
            txt_LoiVao.TabIndex = 16;
            // 
            // lbl_ThongTinQT
            // 
            lbl_ThongTinQT.AutoSize = true;
            lbl_ThongTinQT.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ThongTinQT.Location = new Point(44, 139);
            lbl_ThongTinQT.Name = "lbl_ThongTinQT";
            lbl_ThongTinQT.Size = new Size(192, 25);
            lbl_ThongTinQT.TabIndex = 17;
            lbl_ThongTinQT.Text = "Thông tin quan trọng";
            // 
            // lbl_AnToanSS
            // 
            lbl_AnToanSS.AutoSize = true;
            lbl_AnToanSS.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_AnToanSS.Location = new Point(44, 228);
            lbl_AnToanSS.Name = "lbl_AnToanSS";
            lbl_AnToanSS.Size = new Size(190, 25);
            lbl_AnToanSS.TabIndex = 18;
            lbl_AnToanSS.Text = "Độ an toàn và sạch sẽ";
            // 
            // lbl_ThongTinTT
            // 
            lbl_ThongTinTT.AutoSize = true;
            lbl_ThongTinTT.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ThongTinTT.Location = new Point(44, 325);
            lbl_ThongTinTT.Name = "lbl_ThongTinTT";
            lbl_ThongTinTT.Size = new Size(188, 25);
            lbl_ThongTinTT.TabIndex = 19;
            lbl_ThongTinTT.Text = "Thông tin thanh toán";
            // 
            // txt_ThongTinQT
            // 
            txt_ThongTinQT.Location = new Point(272, 137);
            txt_ThongTinQT.Name = "txt_ThongTinQT";
            txt_ThongTinQT.Size = new Size(313, 27);
            txt_ThongTinQT.TabIndex = 20;
            // 
            // txt_AnToanSS
            // 
            txt_AnToanSS.Location = new Point(272, 226);
            txt_AnToanSS.Name = "txt_AnToanSS";
            txt_AnToanSS.Size = new Size(313, 27);
            txt_AnToanSS.TabIndex = 21;
            // 
            // txt_ThongTinTT
            // 
            txt_ThongTinTT.Location = new Point(272, 323);
            txt_ThongTinTT.Name = "txt_ThongTinTT";
            txt_ThongTinTT.Size = new Size(313, 27);
            txt_ThongTinTT.TabIndex = 22;
            // 
            // btn_ChinhSua
            // 
            btn_ChinhSua.Location = new Point(663, 424);
            btn_ChinhSua.Name = "btn_ChinhSua";
            btn_ChinhSua.Size = new Size(112, 49);
            btn_ChinhSua.TabIndex = 23;
            btn_ChinhSua.Text = "Chỉnh sửa";
            btn_ChinhSua.UseVisualStyleBackColor = true;
            // 
            // UTienNghi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_ChinhSua);
            Controls.Add(txt_ThongTinTT);
            Controls.Add(txt_AnToanSS);
            Controls.Add(txt_ThongTinQT);
            Controls.Add(lbl_ThongTinTT);
            Controls.Add(lbl_AnToanSS);
            Controls.Add(lbl_ThongTinQT);
            Controls.Add(txt_LoiVao);
            Controls.Add(lbl_LoiVao);
            Name = "UTienNghi";
            Size = new Size(800, 647);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_LoiVao;
        private TextBox txt_LoiVao;
        private Label lbl_ThongTinQT;
        private Label lbl_AnToanSS;
        private Label lbl_ThongTinTT;
        private TextBox txt_ThongTinQT;
        private TextBox txt_AnToanSS;
        private TextBox txt_ThongTinTT;
        private Button btn_ChinhSua;
    }
}
