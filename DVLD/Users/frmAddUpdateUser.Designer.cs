namespace DVLD.Users
{
    partial class frmAddUpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateUser));
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo1 = new Syncfusion.Windows.Forms.BannerTextInfo();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo2 = new Syncfusion.Windows.Forms.BannerTextInfo();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo3 = new Syncfusion.Windows.Forms.BannerTextInfo();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblUserFormTitle = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.pnlfooter = new System.Windows.Forms.Panel();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.btnSave = new Syncfusion.WinForms.Controls.SfButton();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.tcPersonInfo = new System.Windows.Forms.TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.ctrlPersonInfoWithFilter1 = new DVLD.People.Controls.ctrlPersonInfoWithFilter();
            this.pnlTCContentFooter = new System.Windows.Forms.Panel();
            this.btnNext = new Syncfusion.WinForms.Controls.SfButton();
            this.tpLoginInfo = new System.Windows.Forms.TabPage();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.btnPervoius = new Syncfusion.WinForms.Controls.SfButton();
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.pnlConfirmPass = new System.Windows.Forms.Panel();
            this.txtConfirmPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.txtPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.pnlUserName = new System.Windows.Forms.Panel();
            this.txtUserName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblConfirmPassTitle = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUserNameTitle = new System.Windows.Forms.Label();
            this.lblPasswordTitle = new System.Windows.Forms.Label();
            this.lblUserIDTitle = new System.Windows.Forms.Label();
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.pnlfooter.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.tcPersonInfo.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.pnlTCContentFooter.SuspendLayout();
            this.tpLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblUserFormTitle);
            this.pnlHeader.Controls.Add(this.pbIcon);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1331, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblUserFormTitle
            // 
            this.lblUserFormTitle.AutoSize = true;
            this.lblUserFormTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFormTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblUserFormTitle.Location = new System.Drawing.Point(433, 9);
            this.lblUserFormTitle.Name = "lblUserFormTitle";
            this.lblUserFormTitle.Size = new System.Drawing.Size(236, 45);
            this.lblUserFormTitle.TabIndex = 3;
            this.lblUserFormTitle.Text = "Add New User";
            // 
            // pbIcon
            // 
            this.pbIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbIcon.Image")));
            this.pbIcon.Location = new System.Drawing.Point(0, 0);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(100, 70);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            // 
            // pnlfooter
            // 
            this.pnlfooter.Controls.Add(this.btnClose);
            this.pnlfooter.Controls.Add(this.btnSave);
            this.pnlfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlfooter.Location = new System.Drawing.Point(0, 700);
            this.pnlfooter.Name = "pnlfooter";
            this.pnlfooter.Size = new System.Drawing.Size(1331, 53);
            this.pnlfooter.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1053, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 42);
            this.btnClose.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.LightGray;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1194, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 42);
            this.btnSave.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tcPersonInfo);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 70);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1331, 630);
            this.pnlContent.TabIndex = 2;
            // 
            // tcPersonInfo
            // 
            this.tcPersonInfo.Controls.Add(this.tpPersonInfo);
            this.tcPersonInfo.Controls.Add(this.tpLoginInfo);
            this.tcPersonInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPersonInfo.Location = new System.Drawing.Point(0, 0);
            this.tcPersonInfo.Name = "tcPersonInfo";
            this.tcPersonInfo.SelectedIndex = 0;
            this.tcPersonInfo.Size = new System.Drawing.Size(1331, 630);
            this.tcPersonInfo.TabIndex = 0;
            this.tcPersonInfo.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcPersonInfo_Selecting);
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.Controls.Add(this.ctrlPersonInfoWithFilter1);
            this.tpPersonInfo.Controls.Add(this.pnlTCContentFooter);
            this.tpPersonInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 22);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(1323, 604);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Person Info";
            this.tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonInfoWithFilter1
            // 
            this.ctrlPersonInfoWithFilter1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlPersonInfoWithFilter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlPersonInfoWithFilter1.Location = new System.Drawing.Point(3, 3);
            this.ctrlPersonInfoWithFilter1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPersonInfoWithFilter1.Name = "ctrlPersonInfoWithFilter1";
            this.ctrlPersonInfoWithFilter1.Size = new System.Drawing.Size(1317, 549);
            this.ctrlPersonInfoWithFilter1.TabIndex = 1;
            this.ctrlPersonInfoWithFilter1.OnPersonSelected += new System.Action<int>(this.ctrlPersonInfoWithFilter1_OnPersonSelected);
            this.ctrlPersonInfoWithFilter1.Load += new System.EventHandler(this.ctrlPersonInfoWithFilter1_Load);
            // 
            // pnlTCContentFooter
            // 
            this.pnlTCContentFooter.Controls.Add(this.btnNext);
            this.pnlTCContentFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTCContentFooter.Location = new System.Drawing.Point(3, 552);
            this.pnlTCContentFooter.Name = "pnlTCContentFooter";
            this.pnlTCContentFooter.Size = new System.Drawing.Size(1317, 49);
            this.pnlTCContentFooter.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.LightGray;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(1120, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(193, 42);
            this.btnNext.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpLoginInfo
            // 
            this.tpLoginInfo.BackColor = System.Drawing.Color.White;
            this.tpLoginInfo.Controls.Add(this.cbShowPassword);
            this.tpLoginInfo.Controls.Add(this.btnPervoius);
            this.tpLoginInfo.Controls.Add(this.cbIsActive);
            this.tpLoginInfo.Controls.Add(this.pnlConfirmPass);
            this.tpLoginInfo.Controls.Add(this.txtConfirmPassword);
            this.tpLoginInfo.Controls.Add(this.pnlPassword);
            this.tpLoginInfo.Controls.Add(this.txtPassword);
            this.tpLoginInfo.Controls.Add(this.pnlUserName);
            this.tpLoginInfo.Controls.Add(this.txtUserName);
            this.tpLoginInfo.Controls.Add(this.lblConfirmPassTitle);
            this.tpLoginInfo.Controls.Add(this.lblUserID);
            this.tpLoginInfo.Controls.Add(this.lblUserNameTitle);
            this.tpLoginInfo.Controls.Add(this.lblPasswordTitle);
            this.tpLoginInfo.Controls.Add(this.lblUserIDTitle);
            this.tpLoginInfo.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpLoginInfo.Location = new System.Drawing.Point(4, 22);
            this.tpLoginInfo.Name = "tpLoginInfo";
            this.tpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpLoginInfo.Size = new System.Drawing.Size(1323, 604);
            this.tpLoginInfo.TabIndex = 1;
            this.tpLoginInfo.Text = "Login Info";
            this.tpLoginInfo.Click += new System.EventHandler(this.tpLoginInfo_Click);
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowPassword.Location = new System.Drawing.Point(594, 218);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(161, 29);
            this.cbShowPassword.TabIndex = 33;
            this.cbShowPassword.Text = "Show Password";
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // btnPervoius
            // 
            this.btnPervoius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPervoius.BackColor = System.Drawing.Color.LightGray;
            this.btnPervoius.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPervoius.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPervoius.Location = new System.Drawing.Point(1143, 556);
            this.btnPervoius.Name = "btnPervoius";
            this.btnPervoius.Size = new System.Drawing.Size(172, 42);
            this.btnPervoius.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnPervoius.TabIndex = 11;
            this.btnPervoius.Text = "Pervoius";
            this.btnPervoius.UseVisualStyleBackColor = false;
            this.btnPervoius.Click += new System.EventHandler(this.btnPervoius_Click);
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsActive.Location = new System.Drawing.Point(361, 283);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(100, 29);
            this.cbIsActive.TabIndex = 32;
            this.cbIsActive.Text = "Is Active";
            this.cbIsActive.UseVisualStyleBackColor = true;
            // 
            // pnlConfirmPass
            // 
            this.pnlConfirmPass.BackColor = System.Drawing.Color.Blue;
            this.pnlConfirmPass.Location = new System.Drawing.Point(361, 243);
            this.pnlConfirmPass.Name = "pnlConfirmPass";
            this.pnlConfirmPass.Size = new System.Drawing.Size(168, 1);
            this.pnlConfirmPass.TabIndex = 31;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.White;
            bannerTextInfo1.Color = System.Drawing.Color.DimGray;
            bannerTextInfo1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bannerTextInfo1.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode;
            bannerTextInfo1.Text = "Confirm Password ";
            bannerTextInfo1.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtConfirmPassword, bannerTextInfo1);
            this.txtConfirmPassword.BeforeTouchSize = new System.Drawing.Size(168, 18);
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(360, 218);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(168, 18);
            this.txtConfirmPassword.TabIndex = 30;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.Blue;
            this.pnlPassword.Location = new System.Drawing.Point(361, 200);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(168, 1);
            this.pnlPassword.TabIndex = 29;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            bannerTextInfo2.Color = System.Drawing.Color.DimGray;
            bannerTextInfo2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bannerTextInfo2.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode;
            bannerTextInfo2.Text = "Password ";
            bannerTextInfo2.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtPassword, bannerTextInfo2);
            this.txtPassword.BeforeTouchSize = new System.Drawing.Size(168, 18);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(360, 175);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(168, 18);
            this.txtPassword.TabIndex = 28;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // pnlUserName
            // 
            this.pnlUserName.BackColor = System.Drawing.Color.Blue;
            this.pnlUserName.Location = new System.Drawing.Point(361, 153);
            this.pnlUserName.Name = "pnlUserName";
            this.pnlUserName.Size = new System.Drawing.Size(168, 1);
            this.pnlUserName.TabIndex = 27;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            bannerTextInfo3.Color = System.Drawing.Color.DimGray;
            bannerTextInfo3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bannerTextInfo3.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode;
            bannerTextInfo3.Text = "UserName";
            bannerTextInfo3.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtUserName, bannerTextInfo3);
            this.txtUserName.BeforeTouchSize = new System.Drawing.Size(168, 18);
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.Location = new System.Drawing.Point(360, 128);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(168, 18);
            this.txtUserName.TabIndex = 26;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // lblConfirmPassTitle
            // 
            this.lblConfirmPassTitle.AutoSize = true;
            this.lblConfirmPassTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassTitle.Location = new System.Drawing.Point(77, 214);
            this.lblConfirmPassTitle.Name = "lblConfirmPassTitle";
            this.lblConfirmPassTitle.Size = new System.Drawing.Size(209, 30);
            this.lblConfirmPassTitle.TabIndex = 4;
            this.lblConfirmPassTitle.Text = "Confirm Password : ";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserID.Location = new System.Drawing.Point(390, 78);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(37, 30);
            this.lblUserID.TabIndex = 3;
            this.lblUserID.Text = "---";
            // 
            // lblUserNameTitle
            // 
            this.lblUserNameTitle.AutoSize = true;
            this.lblUserNameTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameTitle.Location = new System.Drawing.Point(77, 124);
            this.lblUserNameTitle.Name = "lblUserNameTitle";
            this.lblUserNameTitle.Size = new System.Drawing.Size(132, 30);
            this.lblUserNameTitle.TabIndex = 2;
            this.lblUserNameTitle.Text = "UserName : ";
            // 
            // lblPasswordTitle
            // 
            this.lblPasswordTitle.AutoSize = true;
            this.lblPasswordTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordTitle.Location = new System.Drawing.Point(77, 171);
            this.lblPasswordTitle.Name = "lblPasswordTitle";
            this.lblPasswordTitle.Size = new System.Drawing.Size(123, 30);
            this.lblPasswordTitle.TabIndex = 1;
            this.lblPasswordTitle.Text = "Password : ";
            // 
            // lblUserIDTitle
            // 
            this.lblUserIDTitle.AutoSize = true;
            this.lblUserIDTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDTitle.Location = new System.Drawing.Point(77, 78);
            this.lblUserIDTitle.Name = "lblUserIDTitle";
            this.lblUserIDTitle.Size = new System.Drawing.Size(102, 30);
            this.lblUserIDTitle.TabIndex = 0;
            this.lblUserIDTitle.Text = "User ID : ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 753);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlfooter);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmAddUpdateUser";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAddUser_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.pnlfooter.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.tcPersonInfo.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.pnlTCContentFooter.ResumeLayout(false);
            this.tpLoginInfo.ResumeLayout(false);
            this.tpLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlfooter;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.PictureBox pbIcon;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private Syncfusion.WinForms.Controls.SfButton btnSave;
        private System.Windows.Forms.TabControl tcPersonInfo;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private People.Controls.ctrlPersonInfoWithFilter ctrlPersonInfoWithFilter1;
        private System.Windows.Forms.Panel pnlTCContentFooter;
        private System.Windows.Forms.TabPage tpLoginInfo;
        private Syncfusion.WinForms.Controls.SfButton btnNext;
        private System.Windows.Forms.Label lblUserFormTitle;
        private System.Windows.Forms.Label lblConfirmPassTitle;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblUserNameTitle;
        private System.Windows.Forms.Label lblPasswordTitle;
        private System.Windows.Forms.Label lblUserIDTitle;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private System.Windows.Forms.Panel pnlConfirmPass;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtConfirmPassword;
        private System.Windows.Forms.Panel pnlPassword;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPassword;
        private System.Windows.Forms.Panel pnlUserName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtUserName;
        private System.Windows.Forms.CheckBox cbIsActive;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Syncfusion.WinForms.Controls.SfButton btnPervoius;
        private System.Windows.Forms.CheckBox cbShowPassword;
    }
}