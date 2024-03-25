namespace DuLich
{
    partial class UCTNChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTNChinh));
            panel7 = new Panel();
            lblTNC = new Label();
            ptbTNC = new PictureBox();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbTNC).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.Controls.Add(lblTNC);
            panel7.Controls.Add(ptbTNC);
            panel7.Location = new Point(2, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(136, 48);
            panel7.TabIndex = 4;
            // 
            // lblTNC
            // 
            lblTNC.AutoSize = true;
            lblTNC.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTNC.Location = new Point(58, 16);
            lblTNC.Name = "lblTNC";
            lblTNC.Size = new Size(61, 17);
            lblTNC.TabIndex = 0;
            lblTNC.Text = "Máy lạnh";
            // 
            // ptbTNC
            // 
            ptbTNC.Image = (Image)resources.GetObject("ptbTNC.Image");
            ptbTNC.Location = new Point(3, 3);
            ptbTNC.Name = "ptbTNC";
            ptbTNC.Size = new Size(51, 42);
            ptbTNC.SizeMode = PictureBoxSizeMode.Zoom;
            ptbTNC.TabIndex = 0;
            ptbTNC.TabStop = false;
            // 
            // UCTNChinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel7);
            Name = "UCTNChinh";
            Size = new Size(141, 53);
            Load += UCTNChinh_Load;
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbTNC).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private Label lblTNC;
        private PictureBox ptbTNC;
    }
}
