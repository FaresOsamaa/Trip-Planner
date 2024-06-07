namespace TripPlanner
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxPasswordUp = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxUsernameUp = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPasswordUp = new System.Windows.Forms.Label();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.AccessibleName = "";
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhoneNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(603, 420);
            this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPhoneNumber.MaxLength = 11;
            this.textBoxPhoneNumber.Multiline = true;
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(710, 78);
            this.textBoxPhoneNumber.TabIndex = 15;
            this.textBoxPhoneNumber.TextChanged += new System.EventHandler(this.textBoxPhoneNumber_TextChanged);
            // 
            // textBoxPasswordUp
            // 
            this.textBoxPasswordUp.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPasswordUp.Location = new System.Drawing.Point(603, 150);
            this.textBoxPasswordUp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPasswordUp.MaxLength = 10;
            this.textBoxPasswordUp.Multiline = true;
            this.textBoxPasswordUp.Name = "textBoxPasswordUp";
            this.textBoxPasswordUp.Size = new System.Drawing.Size(710, 78);
            this.textBoxPasswordUp.TabIndex = 14;
            this.textBoxPasswordUp.TextChanged += new System.EventHandler(this.textBoxPasswordUp_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxEmail.Location = new System.Drawing.Point(603, 328);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(710, 78);
            this.textBoxEmail.TabIndex = 13;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxUsernameUp
            // 
            this.textBoxUsernameUp.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsernameUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxUsernameUp.Location = new System.Drawing.Point(603, 61);
            this.textBoxUsernameUp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsernameUp.Multiline = true;
            this.textBoxUsernameUp.Name = "textBoxUsernameUp";
            this.textBoxUsernameUp.Size = new System.Drawing.Size(710, 78);
            this.textBoxUsernameUp.TabIndex = 17;
            this.textBoxUsernameUp.TextChanged += new System.EventHandler(this.textBoxUsernameUp_TextChanged);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirm.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(776, 547);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonConfirm.Size = new System.Drawing.Size(206, 85);
            this.buttonConfirm.TabIndex = 18;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 16.125F);
            this.labelUsername.Location = new System.Drawing.Point(143, 64);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(215, 59);
            this.labelUsername.TabIndex = 19;
            this.labelUsername.Text = "Username";
            this.labelUsername.Click += new System.EventHandler(this.labelUsername_Click);
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 16.125F);
            this.labelPhoneNumber.Location = new System.Drawing.Point(143, 423);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(311, 59);
            this.labelPhoneNumber.TabIndex = 20;
            this.labelPhoneNumber.Text = "Phone Number";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 16.125F);
            this.labelEmail.Location = new System.Drawing.Point(143, 328);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(126, 59);
            this.labelEmail.TabIndex = 21;
            this.labelEmail.Text = "Email";
            // 
            // labelPasswordUp
            // 
            this.labelPasswordUp.AutoSize = true;
            this.labelPasswordUp.BackColor = System.Drawing.Color.Transparent;
            this.labelPasswordUp.Font = new System.Drawing.Font("Segoe UI", 16.125F);
            this.labelPasswordUp.Location = new System.Drawing.Point(143, 153);
            this.labelPasswordUp.Name = "labelPasswordUp";
            this.labelPasswordUp.Size = new System.Drawing.Size(202, 59);
            this.labelPasswordUp.TabIndex = 22;
            this.labelPasswordUp.Text = "Password";
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 16.125F);
            this.labelConfirmPassword.Location = new System.Drawing.Point(143, 242);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(365, 59);
            this.labelConfirmPassword.TabIndex = 24;
            this.labelConfirmPassword.Text = "Confirm Password";
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(603, 239);
            this.textBoxConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConfirmPassword.MaxLength = 10;
            this.textBoxConfirmPassword.Multiline = true;
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(710, 78);
            this.textBoxConfirmPassword.TabIndex = 23;
            this.textBoxConfirmPassword.TextChanged += new System.EventHandler(this.textBoxConfirmPassword_TextChanged);
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxShowPassword.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(1116, 556);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(197, 29);
            this.checkBoxShowPassword.TabIndex = 25;
            this.checkBoxShowPassword.Text = "Show Password";
            this.checkBoxShowPassword.UseVisualStyleBackColor = false;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
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
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(551, 547);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonBack.Size = new System.Drawing.Size(206, 85);
            this.buttonBack.TabIndex = 68;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1444, 685);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Controls.Add(this.labelPasswordUp);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxUsernameUp);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxPasswordUp);
            this.Controls.Add(this.textBoxEmail);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxPasswordUp;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxUsernameUp;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPasswordUp;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonBack;
    }
}