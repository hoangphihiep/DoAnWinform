namespace DuLich
{
    partial class UThongtin
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
            lbl_HoTen = new Label();
            lbl_GioiTinh = new Label();
            lbl_DiaChi = new Label();
            lbl_Date = new Label();
            lbl_Email = new Label();
            lbl_Phone = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btn_ChinhSua = new Button();
            SuspendLayout();
            // 
            // lbl_HoTen
            // 
            lbl_HoTen.AutoSize = true;
            lbl_HoTen.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_HoTen.Location = new Point(45, 19);
            lbl_HoTen.Name = "lbl_HoTen";
            lbl_HoTen.Size = new Size(93, 25);
            lbl_HoTen.TabIndex = 0;
            lbl_HoTen.Text = "Họ và Tên";
            // 
            // lbl_GioiTinh
            // 
            lbl_GioiTinh.AutoSize = true;
            lbl_GioiTinh.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_GioiTinh.Location = new Point(45, 114);
            lbl_GioiTinh.Name = "lbl_GioiTinh";
            lbl_GioiTinh.Size = new Size(84, 25);
            lbl_GioiTinh.TabIndex = 1;
            lbl_GioiTinh.Text = "Giới tính";
            // 
            // lbl_DiaChi
            // 
            lbl_DiaChi.AutoSize = true;
            lbl_DiaChi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_DiaChi.Location = new Point(45, 215);
            lbl_DiaChi.Name = "lbl_DiaChi";
            lbl_DiaChi.Size = new Size(67, 25);
            lbl_DiaChi.TabIndex = 2;
            lbl_DiaChi.Text = "Địa chỉ";
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Date.Location = new Point(45, 315);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(188, 25);
            lbl_Date.TabIndex = 3;
            lbl_Date.Text = "Ngày tháng năm sinh";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Email.Location = new Point(45, 418);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(56, 25);
            lbl_Email.TabIndex = 4;
            lbl_Email.Text = "Email";
            // 
            // lbl_Phone
            // 
            lbl_Phone.AutoSize = true;
            lbl_Phone.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Phone.Location = new Point(45, 509);
            lbl_Phone.Name = "lbl_Phone";
            lbl_Phone.Size = new Size(122, 25);
            lbl_Phone.TabIndex = 5;
            lbl_Phone.Text = "Số điện thoại";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(286, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(286, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(281, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(286, 213);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(281, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(286, 416);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(281, 27);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(286, 507);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(281, 27);
            textBox6.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(286, 313);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(281, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // btn_ChinhSua
            // 
            btn_ChinhSua.Location = new Point(696, 544);
            btn_ChinhSua.Name = "btn_ChinhSua";
            btn_ChinhSua.Size = new Size(112, 49);
            btn_ChinhSua.TabIndex = 13;
            btn_ChinhSua.Text = "Chỉnh sửa";
            btn_ChinhSua.UseVisualStyleBackColor = true;
            // 
            // UThongtin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_ChinhSua);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbl_Phone);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_Date);
            Controls.Add(lbl_DiaChi);
            Controls.Add(lbl_GioiTinh);
            Controls.Add(lbl_HoTen);
            Name = "UThongtin";
            Size = new Size(824, 606);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_HoTen;
        private Label lbl_GioiTinh;
        private Label lbl_DiaChi;
        private Label lbl_Date;
        private Label lbl_Email;
        private Label lbl_Phone;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox6;
        private DateTimePicker dateTimePicker1;
        private Button btn_ChinhSua;
    }
}
