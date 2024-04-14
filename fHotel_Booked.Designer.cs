namespace DuLich
{
    partial class fHotel_booked
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
            label1 = new Label();
            flb_PhongDaDat = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkTurquoise;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(234, 37);
            label1.TabIndex = 2;
            label1.Text = "Khách sạn đã đặt";
            // 
            // flb_PhongDaDat
            // 
            flb_PhongDaDat.AutoScroll = true;
            flb_PhongDaDat.Location = new Point(5, 59);
            flb_PhongDaDat.Name = "flb_PhongDaDat";
            flb_PhongDaDat.Size = new Size(896, 525);
            flb_PhongDaDat.TabIndex = 3;
            // 
            // fHotel_booked
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(flb_PhongDaDat);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fHotel_booked";
            Text = "Hotel_booked";
            Load += fHotel_booked_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private FlowLayoutPanel flb_PhongDaDat;
    }
}