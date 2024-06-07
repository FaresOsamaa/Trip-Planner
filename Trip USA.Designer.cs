namespace TripPlanner
{
    partial class Plan_A
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plan_A));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerDepature = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerArrival = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBoxAirlines = new System.Windows.Forms.ListBox();
            this.listBoxHotel = new System.Windows.Forms.ListBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.125F);
            this.label5.Location = new System.Drawing.Point(476, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 59);
            this.label5.TabIndex = 53;
            this.label5.Text = "Pick your hotel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.125F);
            this.label4.Location = new System.Drawing.Point(476, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 59);
            this.label4.TabIndex = 51;
            this.label4.Text = "Airlines";
            // 
            // dateTimePickerDepature
            // 
            this.dateTimePickerDepature.Location = new System.Drawing.Point(908, 96);
            this.dateTimePickerDepature.Name = "dateTimePickerDepature";
            this.dateTimePickerDepature.Size = new System.Drawing.Size(450, 31);
            this.dateTimePickerDepature.TabIndex = 49;
            this.dateTimePickerDepature.ValueChanged += new System.EventHandler(this.dateTimePickerDepature_ValueChanged);
            // 
            // dateTimePickerArrival
            // 
            this.dateTimePickerArrival.Location = new System.Drawing.Point(908, 198);
            this.dateTimePickerArrival.Name = "dateTimePickerArrival";
            this.dateTimePickerArrival.Size = new System.Drawing.Size(450, 31);
            this.dateTimePickerArrival.TabIndex = 48;
            this.dateTimePickerArrival.ValueChanged += new System.EventHandler(this.dateTimePickerArrival_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.125F);
            this.label3.Location = new System.Drawing.Point(476, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 59);
            this.label3.TabIndex = 47;
            this.label3.Text = "Depature Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.125F);
            this.label2.Location = new System.Drawing.Point(476, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 59);
            this.label2.TabIndex = 46;
            this.label2.Text = "Arrival Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 67);
            this.label1.TabIndex = 45;
            this.label1.Text = "USA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(64, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 222);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // listBoxAirlines
            // 
            this.listBoxAirlines.FormattingEnabled = true;
            this.listBoxAirlines.ItemHeight = 25;
            this.listBoxAirlines.Items.AddRange(new object[] {
            "EgyptAir",
            "Air Arabia Egypt",
            "Corendon Airlines Europe",
            "Air Cairo",
            "EasyJet"});
            this.listBoxAirlines.Location = new System.Drawing.Point(908, 270);
            this.listBoxAirlines.Name = "listBoxAirlines";
            this.listBoxAirlines.Size = new System.Drawing.Size(450, 79);
            this.listBoxAirlines.TabIndex = 57;
            this.listBoxAirlines.SelectedIndexChanged += new System.EventHandler(this.listBoxAirlines_SelectedIndexChanged);
            // 
            // listBoxHotel
            // 
            this.listBoxHotel.FormattingEnabled = true;
            this.listBoxHotel.ItemHeight = 25;
            this.listBoxHotel.Items.AddRange(new object[] {
            "AVALLO POINT LODGE, SAN FRANCISCO",
            "MANDARIN ORIENTAL NEW YORK",
            "FOUR SEASONS RESORT HUALALAI, BIG ISLAND"});
            this.listBoxHotel.Location = new System.Drawing.Point(908, 385);
            this.listBoxHotel.Name = "listBoxHotel";
            this.listBoxHotel.Size = new System.Drawing.Size(450, 79);
            this.listBoxHotel.TabIndex = 58;
            this.listBoxHotel.SelectedIndexChanged += new System.EventHandler(this.listBoxHotel_SelectedIndexChanged);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNext.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(776, 547);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonNext.Size = new System.Drawing.Size(172, 85);
            this.buttonNext.TabIndex = 59;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(551, 547);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonBack.Size = new System.Drawing.Size(172, 85);
            this.buttonBack.TabIndex = 60;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
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
            // Plan_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1444, 685);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.listBoxHotel);
            this.Controls.Add(this.listBoxAirlines);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerDepature);
            this.Controls.Add(this.dateTimePickerArrival);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Plan_A";
            this.RightToLeftLayout = true;
            this.Text = "USA Trip";
            this.Load += new System.EventHandler(this.Plan_A_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepature;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrival;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBoxAirlines;
        private System.Windows.Forms.ListBox listBoxHotel;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}