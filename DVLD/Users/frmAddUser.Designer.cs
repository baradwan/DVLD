namespace DVLD.Users
{
    partial class frmAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUser));
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo4 = new Syncfusion.Windows.Forms.BannerTextInfo();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo5 = new Syncfusion.Windows.Forms.BannerTextInfo();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo6 = new Syncfusion.Windows.Forms.BannerTextInfo();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitleUser = new System.Windows.Forms.Label();
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
            this.pnlHeader.Controls.Add(this.lblTitleUser);
            this.pnlHeader.Controls.Add(this.pbIcon);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(2662, 135);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // lblTitleUser
            // 
            this.lblTitleUser.AutoSize = true;
            this.lblTitleUser.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleUser.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitleUser.Location = new System.Drawing.Point(866, 17);
            this.lblTitleUser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitleUser.Name = "lblTitleUser";
            this.lblTitleUser.Size = new System.Drawing.Size(469, 86);
            this.lblTitleUser.TabIndex = 3;
            this.lblTitleUser.Text = "Add New User";
            // 
            // pbIcon
            // 
            this.pbIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbIcon.Image")));
            this.pbIcon.Location = new System.Drawing.Point(0, 0);
            this.pbIcon.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(200, 135);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            // 
            // pnlfooter
            // 
            this.pnlfooter.Controls.Add(this.btnClose);
            this.pnlfooter.Controls.Add(this.btnSave);
            this.pnlfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlfooter.Location = new System.Drawing.Point(0, 1346);
            this.pnlfooter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlfooter.Name = "pnlfooter";
            this.pnlfooter.Size = new System.Drawing.Size(2662, 102);
            this.pnlfooter.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(2106, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(252, 81);
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
            this.btnSave.Location = new System.Drawing.Point(2388, 12);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(252, 81);
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
            this.pnlContent.Location = new System.Drawing.Point(0, 135);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(2662, 1211);
            this.pnlContent.TabIndex = 2;
            // 
            // tcPersonInfo
            // 
            this.tcPersonInfo.Controls.Add(this.tpPersonInfo);
            this.tcPersonInfo.Controls.Add(this.tpLoginInfo);
            this.tcPersonInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPersonInfo.Location = new System.Drawing.Point(0, 0);
            this.tcPersonInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tcPersonInfo.Name = "tcPersonInfo";
            this.tcPersonInfo.SelectedIndex = 0;
            this.tcPersonInfo.Size = new System.Drawing.Size(2662, 1211);
            this.tcPersonInfo.TabIndex = 0;
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.Controls.Add(this.ctrlPersonInfoWithFilter1);
            this.tpPersonInfo.Controls.Add(this.pnlTCContentFooter);
            this.tpPersonInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPersonInfo.Location = new System.Drawing.Point(8, 39);
            this.tpPersonInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tpPersonInfo.Size = new System.Drawing.Size(2646, 1164);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Person Info";
            this.tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonInfoWithFilter1
            // 
            this.ctrlPersonInfoWithFilter1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlPersonInfoWithFilter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlPersonInfoWithFilter1.Location = new System.Drawing.Point(6, 6);
            this.ctrlPersonInfoWithFilter1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.ctrlPersonInfoWithFilter1.Name = "ctrlPersonInfoWithFilter1";
            this.ctrlPersonInfoWithFilter1.Size = new System.Drawing.Size(2634, 1058);
            this.ctrlPersonInfoWithFilter1.TabIndex = 1;
            this.ctrlPersonInfoWithFilter1.Load += new System.EventHandler(this.ctrlPersonInfoWithFilter1_Load);
            // 
            // pnlTCContentFooter
            // 
            this.pnlTCContentFooter.Controls.Add(this.btnNext);
            this.pnlTCContentFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTCContentFooter.Location = new System.Drawing.Point(6, 1064);
            this.pnlTCContentFooter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlTCContentFooter.Name = "pnlTCContentFooter";
            this.pnlTCContentFooter.Size = new System.Drawing.Size(2634, 94);
            this.pnlTCContentFooter.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.LightGray;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(2240, 8);
            this.btnNext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(386, 81);
            this.btnNext.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // tpLoginInfo
            // 
            this.tpLoginInfo.BackColor = System.Drawing.Color.White;
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
            this.tpLoginInfo.Location = new System.Drawing.Point(8, 39);
            this.tpLoginInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tpLoginInfo.Name = "tpLoginInfo";
            this.tpLoginInfo.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tpLoginInfo.Size = new System.Drawing.Size(2646, 1164);
            this.tpLoginInfo.TabIndex = 1;
            this.tpLoginInfo.Text = "Login Info";
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsActive.Location = new System.Drawing.Point(722, 544);
            this.cbIsActive.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(193, 55);
            this.cbIsActive.TabIndex = 32;
            this.cbIsActive.Text = "Is Active";
            this.cbIsActive.UseVisualStyleBackColor = true;
            // 
            // pnlConfirmPass
            // 
            this.pnlConfirmPass.BackColor = System.Drawing.Color.Blue;
            this.pnlConfirmPass.Location = new System.Drawing.Point(722, 467);
            this.pnlConfirmPass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlConfirmPass.Name = "pnlConfirmPass";
            this.pnlConfirmPass.Size = new System.Drawing.Size(336, 2);
            this.pnlConfirmPass.TabIndex = 31;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.White;
            bannerTextInfo4.Color = System.Drawing.Color.DimGray;
            bannerTextInfo4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bannerTextInfo4.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode;
            bannerTextInfo4.Text = "Confirm Password ";
            bannerTextInfo4.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtConfirmPassword, bannerTextInfo4);
            this.txtConfirmPassword.BeforeTouchSize = new System.Drawing.Size(200, 35);
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(720, 419);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(336, 35);
            this.txtConfirmPassword.TabIndex = 30;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.Blue;
            this.pnlPassword.Location = new System.Drawing.Point(722, 385);
            this.pnlPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(336, 2);
            this.pnlPassword.TabIndex = 29;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            bannerTextInfo5.Color = System.Drawing.Color.DimGray;
            bannerTextInfo5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bannerTextInfo5.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode;
            bannerTextInfo5.Text = "Password ";
            bannerTextInfo5.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtPassword, bannerTextInfo5);
            this.txtPassword.BeforeTouchSize = new System.Drawing.Size(200, 35);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(720, 337);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(336, 35);
            this.txtPassword.TabIndex = 28;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // pnlUserName
            // 
            this.pnlUserName.BackColor = System.Drawing.Color.Blue;
            this.pnlUserName.Location = new System.Drawing.Point(722, 294);
            this.pnlUserName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlUserName.Name = "pnlUserName";
            this.pnlUserName.Size = new System.Drawing.Size(336, 2);
            this.pnlUserName.TabIndex = 27;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            bannerTextInfo6.Color = System.Drawing.Color.DimGray;
            bannerTextInfo6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bannerTextInfo6.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode;
            bannerTextInfo6.Text = "DVLD@DVLD.com";
            bannerTextInfo6.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtUserName, bannerTextInfo6);
            this.txtUserName.BeforeTouchSize = new System.Drawing.Size(200, 35);
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.Location = new System.Drawing.Point(720, 246);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(336, 35);
            this.txtUserName.TabIndex = 26;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // lblConfirmPassTitle
            // 
            this.lblConfirmPassTitle.AutoSize = true;
            this.lblConfirmPassTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassTitle.Location = new System.Drawing.Point(154, 412);
            this.lblConfirmPassTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblConfirmPassTitle.Name = "lblConfirmPassTitle";
            this.lblConfirmPassTitle.Size = new System.Drawing.Size(418, 57);
            this.lblConfirmPassTitle.TabIndex = 4;
            this.lblConfirmPassTitle.Text = "Confirm Password : ";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserID.Location = new System.Drawing.Point(780, 150);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(76, 57);
            this.lblUserID.TabIndex = 3;
            this.lblUserID.Text = "---";
            // 
            // lblUserNameTitle
            // 
            this.lblUserNameTitle.AutoSize = true;
            this.lblUserNameTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameTitle.Location = new System.Drawing.Point(154, 238);
            this.lblUserNameTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUserNameTitle.Name = "lblUserNameTitle";
            this.lblUserNameTitle.Size = new System.Drawing.Size(265, 57);
            this.lblUserNameTitle.TabIndex = 2;
            this.lblUserNameTitle.Text = "UserName : ";
            // 
            // lblPasswordTitle
            // 
            this.lblPasswordTitle.AutoSize = true;
            this.lblPasswordTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordTitle.Location = new System.Drawing.Point(154, 329);
            this.lblPasswordTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPasswordTitle.Name = "lblPasswordTitle";
            this.lblPasswordTitle.Size = new System.Drawing.Size(246, 57);
            this.lblPasswordTitle.TabIndex = 1;
            this.lblPasswordTitle.Text = "Password : ";
            // 
            // lblUserIDTitle
            // 
            this.lblUserIDTitle.AutoSize = true;
            this.lblUserIDTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDTitle.Location = new System.Drawing.Point(154, 150);
            this.lblUserIDTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUserIDTitle.Name = "lblUserIDTitle";
            this.lblUserIDTitle.Size = new System.Drawing.Size(204, 57);
            this.lblUserIDTitle.TabIndex = 0;
            this.lblUserIDTitle.Text = "User ID : ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2662, 1448);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlfooter);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmAddUser";
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
        private System.Windows.Forms.Label lblTitleUser;
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
    }
}