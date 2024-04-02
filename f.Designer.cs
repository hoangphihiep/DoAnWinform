namespace DuLich
{
    partial class f
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
            u_HienThiPhong1 = new U_HienThiPhong();
            SuspendLayout();
            // 
            // u_HienThiPhong1
            // 
            u_HienThiPhong1.Location = new Point(33, 70);
            u_HienThiPhong1.Name = "u_HienThiPhong1";
            u_HienThiPhong1.Size = new Size(730, 320);
            u_HienThiPhong1.TabIndex = 0;
            // 
            // f
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 674);
            Controls.Add(u_HienThiPhong1);
            Name = "f";
            Text = "f";
            Load += f_Load;
            ResumeLayout(false);
        }

        #endregion

        private U_HienThiPhong u_HienThiPhong1;
    }
}