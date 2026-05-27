namespace DVLD.Login
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo1 = new Syncfusion.Windows.Forms.BannerTextInfo();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo2 = new Syncfusion.Windows.Forms.BannerTextInfo();
            this.pnlLoginInput = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsername = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.cbRememberMe = new System.Windows.Forms.CheckBox();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.pnlUserName = new System.Windows.Forms.Panel();
            this.pnlView = new System.Windows.Forms.Panel();
            this.lblTitleLoginScreen = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            this.pnlLoginInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            this.pnlView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLoginInput
            // 
            this.pnlLoginInput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlLoginInput.Controls.Add(this.btnLogin);
            this.pnlLoginInput.Controls.Add(this.txtUsername);
            this.pnlLoginInput.Controls.Add(this.txtPassword);
            this.pnlLoginInput.Controls.Add(this.cbRememberMe);
            this.pnlLoginInput.Controls.Add(this.pnlPassword);
            this.pnlLoginInput.Controls.Add(this.pnlUserName);
            this.pnlLoginInput.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLoginInput.Location = new System.Drawing.Point(479, 0);
            this.pnlLoginInput.Name = "pnlLoginInput";
            this.pnlLoginInput.Size = new System.Drawing.Size(393, 521);
            this.pnlLoginInput.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(144, 415);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(113, 50);
            this.btnLogin.TabIndex = 41;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.InactiveCaption;
            bannerTextInfo1.Color = System.Drawing.SystemColors.WindowFrame;
            bannerTextInfo1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bannerTextInfo1.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode;
            bannerTextInfo1.Text = "Username";
            bannerTextInfo1.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtUsername, bannerTextInfo1);
            this.txtUsername.BeforeTouchSize = new System.Drawing.Size(235, 34);
            this.txtUsername.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.CornerRadius = 5;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtUsername.FarImage = ((System.Drawing.Image)(resources.GetObject("txtUsername.FarImage")));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 18.75F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.Location = new System.Drawing.Point(88, 203);
            this.txtUsername.MinimumSize = new System.Drawing.Size(14, 10);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(235, 34);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.WordWrap = false;
            this.txtUsername.TextChanged += new System.EventHandler(this.textBoxExt1_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            bannerTextInfo2.Color = System.Drawing.SystemColors.WindowFrame;
            bannerTextInfo2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bannerTextInfo2.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode;
            bannerTextInfo2.Text = "Password";
            bannerTextInfo2.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtPassword, bannerTextInfo2);
            this.txtPassword.BeforeTouchSize = new System.Drawing.Size(235, 34);
            this.txtPassword.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.CornerRadius = 5;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtPassword.FarImage = ((System.Drawing.Image)(resources.GetObject("txtPassword.FarImage")));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 18.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(87, 286);
            this.txtPassword.MinimumSize = new System.Drawing.Size(14, 10);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(235, 34);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WordWrap = false;
            // 
            // cbRememberMe
            // 
            this.cbRememberMe.AutoSize = true;
            this.cbRememberMe.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRememberMe.Location = new System.Drawing.Point(122, 365);
            this.cbRememberMe.Name = "cbRememberMe";
            this.cbRememberMe.Size = new System.Drawing.Size(153, 29);
            this.cbRememberMe.TabIndex = 2;
            this.cbRememberMe.Text = "Remember Me";
            this.cbRememberMe.UseVisualStyleBackColor = true;
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.Blue;
            this.pnlPassword.Location = new System.Drawing.Point(88, 320);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(234, 2);
            this.pnlPassword.TabIndex = 40;
            // 
            // pnlUserName
            // 
            this.pnlUserName.BackColor = System.Drawing.Color.Blue;
            this.pnlUserName.Location = new System.Drawing.Point(87, 238);
            this.pnlUserName.Name = "pnlUserName";
            this.pnlUserName.Size = new System.Drawing.Size(234, 2);
            this.pnlUserName.TabIndex = 38;
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlView.Controls.Add(this.lblTitleLoginScreen);
            this.pnlView.Controls.Add(this.pictureBox1);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(0, 0);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(479, 521);
            this.pnlView.TabIndex = 1;
            // 
            // lblTitleLoginScreen
            // 
            this.lblTitleLoginScreen.AutoSize = true;
            this.lblTitleLoginScreen.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblTitleLoginScreen.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblTitleLoginScreen.Location = new System.Drawing.Point(103, 42);
            this.lblTitleLoginScreen.Name = "lblTitleLoginScreen";
            this.lblTitleLoginScreen.Size = new System.Drawing.Size(269, 50);
            this.lblTitleLoginScreen.TabIndex = 1;
            this.lblTitleLoginScreen.Text = "Logic Account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 521);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.pnlLoginInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlLoginInput.ResumeLayout(false);
            this.pnlLoginInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            this.pnlView.ResumeLayout(false);
            this.pnlView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoginInput;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Label lblTitleLoginScreen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbRememberMe;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Panel pnlUserName;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtUsername;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}