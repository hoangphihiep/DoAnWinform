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
            uUuDai1 = new UUuDai();
            SuspendLayout();
            // 
            // uUuDai1
            // 
            uUuDai1.Location = new Point(12, 12);
            uUuDai1.Name = "uUuDai1";
            uUuDai1.Size = new Size(1030, 645);
            uUuDai1.TabIndex = 0;
            // 
            // f
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 674);
            Controls.Add(uUuDai1);
            Name = "f";
            Text = "f";
            Load += f_Load;
            ResumeLayout(false);
        }

        #endregion

        private UUuDai uUuDai1;
    }
}