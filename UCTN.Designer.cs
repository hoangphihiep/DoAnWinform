namespace DuLich
{
    partial class UCTN
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
            panel29 = new Panel();
            lblTN = new Label();
            label64 = new Label();
            panel29.SuspendLayout();
            SuspendLayout();
            // 
            // panel29
            // 
            panel29.Controls.Add(lblTN);
            panel29.Controls.Add(label64);
            panel29.Location = new Point(3, 3);
            panel29.Name = "panel29";
            panel29.Size = new Size(196, 32);
            panel29.TabIndex = 8;
            // 
            // lblTN
            // 
            lblTN.AutoSize = true;
            lblTN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTN.ForeColor = SystemColors.ControlDarkDark;
            lblTN.Location = new Point(23, 9);
            lblTN.Name = "lblTN";
            lblTN.Size = new Size(56, 15);
            lblTN.TabIndex = 1;
            lblTN.Text = "Máy lạnh";
            // 
            // label64
            // 
            label64.AutoSize = true;
            label64.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label64.ForeColor = SystemColors.ControlDarkDark;
            label64.Location = new Point(7, 5);
            label64.Name = "label64";
            label64.Size = new Size(15, 20);
            label64.TabIndex = 0;
            label64.Text = "-";
            // 
            // UCTN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel29);
            Name = "UCTN";
            Size = new Size(200, 37);
            Load += UCTN_Load;
            panel29.ResumeLayout(false);
            panel29.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel29;
        private Label lblTN;
        private Label label64;
    }
}
