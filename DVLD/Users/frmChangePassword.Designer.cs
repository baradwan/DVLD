namespace DVLD.Users
{
    partial class frmChangePassword
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
            this.pnlInformation = new System.Windows.Forms.Panel();
            this.ctrlUserInfoCard1 = new DVLD.Users.Control.ctrlUserInfoCard();
            this.pnlContentChangePassword = new System.Windows.Forms.Panel();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.pnlConfirmPass = new System.Windows.Forms.Panel();
            this.txtConfirmPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.txtNewPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.pnlUserName = new System.Windows.Forms.Panel();
            this.txtCurrentPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblConfirmPassTitle = new System.Windows.Forms.Label();
            this.lblCurrentPasswordTitle = new System.Windows.Forms.Label();
            this.lblPasswordTitle = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.btnSave = new Syncfusion.WinForms.Controls.SfButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlInformation.SuspendLayout();
            this.pnlContentChangePassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentPassword)).BeginInit();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInformation
            // 
            this.pnlInformation.Controls.Add(this.ctrlUserInfoCard1);
            this.pnlInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInformation.Location = new System.Drawing.Point(0, 0);
            this.pnlInformation.Name = "pnlInformation";
            this.pnlInformation.Size = new System.Drawing.Size(712, 520);
            this.pnlInformation.TabIndex = 0;
            // 
            // ctrlUserInfoCard1
            // 
            this.ctrlUserInfoCard1.BackColor = System.Drawing.Color.White;
            this.ctrlUserInfoCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlUserInfoCard1.Location = new System.Drawing.Point(0, 0);
            this.ctrlUserInfoCard1.Name = "ctrlUserInfoCard1";
            this.ctrlUserInfoCard1.Size = new System.Drawing.Size(712, 520);
            this.ctrlUserInfoCard1.TabIndex = 0;
            this.ctrlUserInfoCard1.Load += new System.EventHandler(this.ctrlUserInfoCard1_Load);
            // 
            // pnlContentChangePassword
            // 
            this.pnlContentChangePassword.BackColor = System.Drawing.Color.White;
            this.pnlContentChangePassword.Controls.Add(this.cbShowPassword);
            this.pnlContentChangePassword.Controls.Add(this.pnlConfirmPass);
            this.pnlContentChangePassword.Controls.Add(this.txtConfirmPassword);
            this.pnlContentChangePassword.Controls.Add(this.pnlPassword);
            this.pnlContentChangePassword.Controls.Add(this.txtNewPassword);
            this.pnlContentChangePassword.Controls.Add(this.pnlUserName);
            this.pnlContentChangePassword.Controls.Add(this.txtCurrentPassword);
            this.pnlContentChangePassword.Controls.Add(this.lblConfirmPassTitle);
            this.pnlContentChangePassword.Controls.Add(this.lblCurrentPasswordTitle);
            this.pnlContentChangePassword.Controls.Add(this.lblPasswordTitle);
            this.pnlContentChangePassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentChangePassword.Location = new System.Drawing.Point(0, 520);
            this.pnlContentChangePassword.Name = "pnlContentChangePassword";
            this.pnlContentChangePassword.Size = new System.Drawing.Size(712, 251);
            this.pnlContentChangePassword.TabIndex = 1;
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowPassword.Location = new System.Drawing.Point(539, 155);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(161, 29);
            this.cbShowPassword.TabIndex = 34;
            this.cbShowPassword.Text = "Show Password";
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // pnlConfirmPass
            // 
            this.pnlConfirmPass.BackColor = System.Drawing.Color.Blue;
            this.pnlConfirmPass.Location = new System.Drawing.Point(296, 157);
            this.pnlConfirmPass.Name = "pnlConfirmPass";
            this.pnlConfirmPass.Size = new System.Drawing.Size(168, 1);
            this.pnlConfirmPass.TabIndex = 40;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.White;
            this.txtConfirmPassword.BeforeTouchSize = new System.Drawing.Size(168, 18);
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(295, 132);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(168, 18);
            this.txtConfirmPassword.TabIndex = 39;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.Blue;
            this.pnlPassword.Location = new System.Drawing.Point(296, 114);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(168, 1);
            this.pnlPassword.TabIndex = 38;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.White;
            this.txtNewPassword.BeforeTouchSize = new System.Drawing.Size(168, 18);
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewPassword.Location = new System.Drawing.Point(295, 89);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(168, 18);
            this.txtNewPassword.TabIndex = 37;
            this.txtNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPassword_Validating);
            // 
            // pnlUserName
            // 
            this.pnlUserName.BackColor = System.Drawing.Color.Blue;
            this.pnlUserName.Location = new System.Drawing.Point(296, 67);
            this.pnlUserName.Name = "pnlUserName";
            this.pnlUserName.Size = new System.Drawing.Size(168, 1);
            this.pnlUserName.TabIndex = 36;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BackColor = System.Drawing.Color.White;
            this.txtCurrentPassword.BeforeTouchSize = new System.Drawing.Size(168, 18);
            this.txtCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCurrentPassword.Location = new System.Drawing.Point(295, 42);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(168, 18);
            this.txtCurrentPassword.TabIndex = 35;
            this.txtCurrentPassword.TextChanged += new System.EventHandler(this.txtCurrentPassword_TextChanged);
            this.txtCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtCurrentPassword_Validating);
            // 
            // lblConfirmPassTitle
            // 
            this.lblConfirmPassTitle.AutoSize = true;
            this.lblConfirmPassTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassTitle.Location = new System.Drawing.Point(12, 128);
            this.lblConfirmPassTitle.Name = "lblConfirmPassTitle";
            this.lblConfirmPassTitle.Size = new System.Drawing.Size(209, 30);
            this.lblConfirmPassTitle.TabIndex = 34;
            this.lblConfirmPassTitle.Text = "Confirm Password : ";
            // 
            // lblCurrentPasswordTitle
            // 
            this.lblCurrentPasswordTitle.AutoSize = true;
            this.lblCurrentPasswordTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPasswordTitle.Location = new System.Drawing.Point(12, 38);
            this.lblCurrentPasswordTitle.Name = "lblCurrentPasswordTitle";
            this.lblCurrentPasswordTitle.Size = new System.Drawing.Size(197, 30);
            this.lblCurrentPasswordTitle.TabIndex = 33;
            this.lblCurrentPasswordTitle.Text = "CurrentPassword : ";
            // 
            // lblPasswordTitle
            // 
            this.lblPasswordTitle.AutoSize = true;
            this.lblPasswordTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordTitle.Location = new System.Drawing.Point(12, 85);
            this.lblPasswordTitle.Name = "lblPasswordTitle";
            this.lblPasswordTitle.Size = new System.Drawing.Size(180, 30);
            this.lblPasswordTitle.TabIndex = 32;
            this.lblPasswordTitle.Text = " New Password : ";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 710);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(712, 61);
            this.pnlFooter.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(442, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 42);
            this.btnClose.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.TabIndex = 11;
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
            this.btnSave.Location = new System.Drawing.Point(574, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 42);
            this.btnSave.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 771);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlContentChangePassword);
            this.Controls.Add(this.pnlInformation);
            this.Name = "frmChangePassword";
            this.Text = "frmChangePassword";
            this.pnlInformation.ResumeLayout(false);
            this.pnlContentChangePassword.ResumeLayout(false);
            this.pnlContentChangePassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentPassword)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInformation;
        private Control.ctrlUserInfoCard ctrlUserInfoCard1;
        private System.Windows.Forms.Panel pnlContentChangePassword;
        private System.Windows.Forms.Panel pnlFooter;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private Syncfusion.WinForms.Controls.SfButton btnSave;
        private System.Windows.Forms.Panel pnlConfirmPass;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtConfirmPassword;
        private System.Windows.Forms.Panel pnlPassword;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtNewPassword;
        private System.Windows.Forms.Panel pnlUserName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCurrentPassword;
        private System.Windows.Forms.Label lblConfirmPassTitle;
        private System.Windows.Forms.Label lblCurrentPasswordTitle;
        private System.Windows.Forms.Label lblPasswordTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox cbShowPassword;
    }
}