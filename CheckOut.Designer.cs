namespace TripPlanner
{
    partial class CheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOut));
            this.labelHotal = new System.Windows.Forms.Label();
            this.labelAirpaln = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ConfrimBtn = new System.Windows.Forms.Button();
            this.labelHotelPrice = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelAirplanPrice = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHotal
            // 
            this.labelHotal.AutoSize = true;
            this.labelHotal.BackColor = System.Drawing.Color.Transparent;
            this.labelHotal.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold);
            this.labelHotal.Location = new System.Drawing.Point(341, 89);
            this.labelHotal.Name = "labelHotal";
            this.labelHotal.Size = new System.Drawing.Size(247, 59);
            this.labelHotal.TabIndex = 17;
            this.labelHotal.Text = "Hotal Price";
            // 
            // labelAirpaln
            // 
            this.labelAirpaln.AutoSize = true;
            this.labelAirpaln.BackColor = System.Drawing.Color.Transparent;
            this.labelAirpaln.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold);
            this.labelAirpaln.Location = new System.Drawing.Point(341, 231);
            this.labelAirpaln.Name = "labelAirpaln";
            this.labelAirpaln.Size = new System.Drawing.Size(283, 59);
            this.labelAirpaln.TabIndex = 18;
            this.labelAirpaln.Text = "Airplan Price";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold);
            this.labelTotal.Location = new System.Drawing.Point(341, 379);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(235, 59);
            this.labelTotal.TabIndex = 19;
            this.labelTotal.Text = "Total Price";
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(458, 570);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CancelBtn.Size = new System.Drawing.Size(206, 85);
            this.CancelBtn.TabIndex = 57;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ConfrimBtn
            // 
            this.ConfrimBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ConfrimBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConfrimBtn.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfrimBtn.Location = new System.Drawing.Point(774, 570);
            this.ConfrimBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ConfrimBtn.Name = "ConfrimBtn";
            this.ConfrimBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ConfrimBtn.Size = new System.Drawing.Size(206, 85);
            this.ConfrimBtn.TabIndex = 56;
            this.ConfrimBtn.Text = "Confirm";
            this.ConfrimBtn.UseVisualStyleBackColor = false;
            this.ConfrimBtn.Click += new System.EventHandler(this.ConfrimBtn_Click);
            // 
            // labelHotelPrice
            // 
            this.labelHotelPrice.AutoSize = true;
            this.labelHotelPrice.BackColor = System.Drawing.Color.White;
            this.labelHotelPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHotelPrice.Location = new System.Drawing.Point(956, 103);
            this.labelHotelPrice.Name = "labelHotelPrice";
            this.labelHotelPrice.Size = new System.Drawing.Size(112, 45);
            this.labelHotelPrice.TabIndex = 58;
            this.labelHotelPrice.Text = "Price 1";
            this.labelHotelPrice.Click += new System.EventHandler(this.labelHotelPrice_Click);
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.BackColor = System.Drawing.Color.White;
            this.labelTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelTotalPrice.Location = new System.Drawing.Point(956, 393);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(114, 45);
            this.labelTotalPrice.TabIndex = 59;
            this.labelTotalPrice.Text = "Price 3";
            this.labelTotalPrice.Click += new System.EventHandler(this.labelTotalPrice_Click);
            // 
            // labelAirplanPrice
            // 
            this.labelAirplanPrice.AutoSize = true;
            this.labelAirplanPrice.BackColor = System.Drawing.Color.White;
            this.labelAirplanPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelAirplanPrice.Location = new System.Drawing.Point(956, 245);
            this.labelAirplanPrice.Name = "labelAirplanPrice";
            this.labelAirplanPrice.Size = new System.Drawing.Size(115, 45);
            this.labelAirplanPrice.TabIndex = 60;
            this.labelAirplanPrice.Text = "Price 2";
            this.labelAirplanPrice.Click += new System.EventHandler(this.labelAirplanPrice_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(1336, 575);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 67;
            this.pictureBoxLogo.TabStop = false;
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1444, 685);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelAirplanPrice);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.labelHotelPrice);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ConfrimBtn);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelAirpaln);
            this.Controls.Add(this.labelHotal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelHotal;
        private System.Windows.Forms.Label labelAirpaln;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button ConfrimBtn;
        private System.Windows.Forms.Label labelHotelPrice;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelAirplanPrice;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}