namespace CABACUNGAN_OrderMealManagementSystem
{
    partial class frm_LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LogInForm));
            this.panelLogInForm = new System.Windows.Forms.Panel();
            this.lbl_AboutUs = new System.Windows.Forms.Label();
            this.gbtn_Login = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.lnklbl_AboutUs = new System.Windows.Forms.LinkLabel();
            this.lbl_AllError = new System.Windows.Forms.Label();
            this.lbl_ErrorPassword = new System.Windows.Forms.Label();
            this.lbl_ErrorUsername = new System.Windows.Forms.Label();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.picboxResLogo = new System.Windows.Forms.PictureBox();
            this.panelClose = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.chk_ShowHide = new System.Windows.Forms.CheckBox();
            this.panelLogInForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxResLogo)).BeginInit();
            this.panelClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogInForm
            // 
            this.panelLogInForm.BackColor = System.Drawing.Color.White;
            this.panelLogInForm.Controls.Add(this.chk_ShowHide);
            this.panelLogInForm.Controls.Add(this.lbl_AboutUs);
            this.panelLogInForm.Controls.Add(this.gbtn_Login);
            this.panelLogInForm.Controls.Add(this.lbl_Welcome);
            this.panelLogInForm.Controls.Add(this.lnklbl_AboutUs);
            this.panelLogInForm.Controls.Add(this.lbl_AllError);
            this.panelLogInForm.Controls.Add(this.lbl_ErrorPassword);
            this.panelLogInForm.Controls.Add(this.lbl_ErrorUsername);
            this.panelLogInForm.Controls.Add(this.picboxLogo);
            this.panelLogInForm.Controls.Add(this.panelPassword);
            this.panelLogInForm.Controls.Add(this.txt_Password);
            this.panelLogInForm.Controls.Add(this.lbl_Password);
            this.panelLogInForm.Controls.Add(this.panelUsername);
            this.panelLogInForm.Controls.Add(this.txt_Username);
            this.panelLogInForm.Controls.Add(this.lbl_Username);
            this.panelLogInForm.Location = new System.Drawing.Point(439, -1);
            this.panelLogInForm.Name = "panelLogInForm";
            this.panelLogInForm.Size = new System.Drawing.Size(353, 501);
            this.panelLogInForm.TabIndex = 0;
            // 
            // lbl_AboutUs
            // 
            this.lbl_AboutUs.AutoSize = true;
            this.lbl_AboutUs.Location = new System.Drawing.Point(124, 452);
            this.lbl_AboutUs.Name = "lbl_AboutUs";
            this.lbl_AboutUs.Size = new System.Drawing.Size(60, 13);
            this.lbl_AboutUs.TabIndex = 16;
            this.lbl_AboutUs.Text = "Learn more";
            // 
            // gbtn_Login
            // 
            this.gbtn_Login.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_Login.BorderRadius = 15;
            this.gbtn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbtn_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_Login.FillColor = System.Drawing.Color.Black;
            this.gbtn_Login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtn_Login.ForeColor = System.Drawing.Color.White;
            this.gbtn_Login.Location = new System.Drawing.Point(98, 385);
            this.gbtn_Login.Name = "gbtn_Login";
            this.gbtn_Login.Size = new System.Drawing.Size(165, 32);
            this.gbtn_Login.TabIndex = 15;
            this.gbtn_Login.Text = "Login";
            this.gbtn_Login.Click += new System.EventHandler(this.gbtn_Login_Click);
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.Location = new System.Drawing.Point(110, 174);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(133, 31);
            this.lbl_Welcome.TabIndex = 13;
            this.lbl_Welcome.Text = "Welcome";
            // 
            // lnklbl_AboutUs
            // 
            this.lnklbl_AboutUs.AutoSize = true;
            this.lnklbl_AboutUs.Location = new System.Drawing.Point(181, 452);
            this.lnklbl_AboutUs.Name = "lnklbl_AboutUs";
            this.lnklbl_AboutUs.Size = new System.Drawing.Size(51, 13);
            this.lnklbl_AboutUs.TabIndex = 12;
            this.lnklbl_AboutUs.TabStop = true;
            this.lnklbl_AboutUs.Text = "About Us";
            this.lnklbl_AboutUs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_AboutUs_LinkClicked);
            // 
            // lbl_AllError
            // 
            this.lbl_AllError.AutoSize = true;
            this.lbl_AllError.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AllError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AllError.ForeColor = System.Drawing.Color.Red;
            this.lbl_AllError.Location = new System.Drawing.Point(90, 419);
            this.lbl_AllError.Name = "lbl_AllError";
            this.lbl_AllError.Size = new System.Drawing.Size(0, 13);
            this.lbl_AllError.TabIndex = 11;
            // 
            // lbl_ErrorPassword
            // 
            this.lbl_ErrorPassword.AutoSize = true;
            this.lbl_ErrorPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ErrorPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorPassword.Location = new System.Drawing.Point(79, 345);
            this.lbl_ErrorPassword.Name = "lbl_ErrorPassword";
            this.lbl_ErrorPassword.Size = new System.Drawing.Size(0, 13);
            this.lbl_ErrorPassword.TabIndex = 10;
            // 
            // lbl_ErrorUsername
            // 
            this.lbl_ErrorUsername.AutoSize = true;
            this.lbl_ErrorUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ErrorUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorUsername.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorUsername.Location = new System.Drawing.Point(79, 274);
            this.lbl_ErrorUsername.Name = "lbl_ErrorUsername";
            this.lbl_ErrorUsername.Size = new System.Drawing.Size(0, 13);
            this.lbl_ErrorUsername.TabIndex = 9;
            // 
            // picboxLogo
            // 
            this.picboxLogo.BackColor = System.Drawing.Color.Transparent;
            this.picboxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxLogo.BackgroundImage")));
            this.picboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxLogo.Location = new System.Drawing.Point(80, 34);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(197, 195);
            this.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxLogo.TabIndex = 8;
            this.picboxLogo.TabStop = false;
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.Black;
            this.panelPassword.Location = new System.Drawing.Point(82, 344);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(195, 1);
            this.panelPassword.TabIndex = 7;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.White;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Location = new System.Drawing.Point(82, 329);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(170, 13);
            this.txt_Password.TabIndex = 5;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(77, 310);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(67, 16);
            this.lbl_Password.TabIndex = 6;
            this.lbl_Password.Text = "Password";
            // 
            // panelUsername
            // 
            this.panelUsername.BackColor = System.Drawing.Color.Black;
            this.panelUsername.Location = new System.Drawing.Point(82, 273);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(195, 1);
            this.panelUsername.TabIndex = 4;
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.White;
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Username.Location = new System.Drawing.Point(82, 258);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(195, 13);
            this.txt_Username.TabIndex = 1;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(77, 236);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(70, 16);
            this.lbl_Username.TabIndex = 2;
            this.lbl_Username.Text = "Username";
            // 
            // picboxResLogo
            // 
            this.picboxResLogo.BackColor = System.Drawing.Color.Transparent;
            this.picboxResLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxResLogo.Image = ((System.Drawing.Image)(resources.GetObject("picboxResLogo.Image")));
            this.picboxResLogo.Location = new System.Drawing.Point(81, 109);
            this.picboxResLogo.Name = "picboxResLogo";
            this.picboxResLogo.Size = new System.Drawing.Size(280, 266);
            this.picboxResLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxResLogo.TabIndex = 13;
            this.picboxResLogo.TabStop = false;
            // 
            // panelClose
            // 
            this.panelClose.Controls.Add(this.btn_Close);
            this.panelClose.Location = new System.Drawing.Point(808, 1);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(30, 30);
            this.panelClose.TabIndex = 14;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Location = new System.Drawing.Point(-25, -24);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(82, 78);
            this.btn_Close.TabIndex = 13;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            this.btn_Close.MouseEnter += new System.EventHandler(this.btn_MouseLeave_Click);
            this.btn_Close.MouseLeave += new System.EventHandler(this.btn_MouseEnter_Click);
            // 
            // chk_ShowHide
            // 
            this.chk_ShowHide.AutoSize = true;
            this.chk_ShowHide.Location = new System.Drawing.Point(262, 329);
            this.chk_ShowHide.Name = "chk_ShowHide";
            this.chk_ShowHide.Size = new System.Drawing.Size(15, 14);
            this.chk_ShowHide.TabIndex = 17;
            this.chk_ShowHide.UseVisualStyleBackColor = true;
            this.chk_ShowHide.CheckedChanged += new System.EventHandler(this.chk_ShowHide_CheckedChanged);
            // 
            // frm_LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 499);
            this.Controls.Add(this.panelClose);
            this.Controls.Add(this.picboxResLogo);
            this.Controls.Add(this.panelLogInForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frm_LogInForm_Load);
            this.panelLogInForm.ResumeLayout(false);
            this.panelLogInForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxResLogo)).EndInit();
            this.panelClose.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogInForm;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.PictureBox picboxLogo;
        private System.Windows.Forms.Label lbl_ErrorPassword;
        private System.Windows.Forms.Label lbl_ErrorUsername;
        private System.Windows.Forms.Label lbl_AllError;
        private System.Windows.Forms.LinkLabel lnklbl_AboutUs;
        private System.Windows.Forms.PictureBox picboxResLogo;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Welcome;
        private Guna.UI2.WinForms.Guna2Button gbtn_Login;
        private System.Windows.Forms.Label lbl_AboutUs;
        private System.Windows.Forms.CheckBox chk_ShowHide;
    }
}

