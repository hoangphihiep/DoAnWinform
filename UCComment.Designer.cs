namespace DuLich
{
    partial class UCComment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCComment));
            panel57 = new Panel();
            label125 = new Label();
            lblDiem = new Label();
            lblContent = new Label();
            lblName = new Label();
            panel57.SuspendLayout();
            SuspendLayout();
            // 
            // panel57
            // 
            panel57.BackColor = SystemColors.Control;
            panel57.Controls.Add(label125);
            panel57.Controls.Add(lblDiem);
            panel57.Controls.Add(lblContent);
            panel57.Controls.Add(lblName);
            panel57.Location = new Point(3, 3);
            panel57.Name = "panel57";
            panel57.Size = new Size(472, 110);
            panel57.TabIndex = 8;
            // 
            // label125
            // 
            label125.AutoSize = true;
            label125.Location = new Point(418, 15);
            label125.Name = "label125";
            label125.Size = new Size(24, 15);
            label125.TabIndex = 3;
            label125.Text = "/10";
            // 
            // lblDiem
            // 
            lblDiem.AutoSize = true;
            lblDiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDiem.ForeColor = Color.DarkTurquoise;
            lblDiem.Location = new Point(409, 15);
            lblDiem.Name = "lblDiem";
            lblDiem.Size = new Size(14, 15);
            lblDiem.TabIndex = 2;
            lblDiem.Text = "9";
            // 
            // lblContent
            // 
            lblContent.Location = new Point(10, 40);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(457, 65);
            lblContent.TabIndex = 1;
            lblContent.Text = resources.GetString("lblContent.Text");
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.DarkTurquoise;
            lblName.Location = new Point(9, 15);
            lblName.Name = "lblName";
            lblName.Size = new Size(96, 17);
            lblName.TabIndex = 0;
            lblName.Text = "Nguyễn Văn A";
            // 
            // UCComment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel57);
            Name = "UCComment";
            Size = new Size(489, 117);
            Load += UCComment_Load;
            panel57.ResumeLayout(false);
            panel57.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel57;
        private Label label125;
        private Label lblDiem;
        private Label lblContent;
        private Label lblName;
    }
}
