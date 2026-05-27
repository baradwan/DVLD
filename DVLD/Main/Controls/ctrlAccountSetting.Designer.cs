namespace DVLD.Main.Controls
{
    partial class ctrlAccountSetting
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
            this.btnCurrentUserInfo = new Syncfusion.WinForms.Controls.SfButton();
            this.btnSignOut = new Syncfusion.WinForms.Controls.SfButton();
            this.btnChangePassword = new Syncfusion.WinForms.Controls.SfButton();
            this.SuspendLayout();
            // 
            // btnCurrentUserInfo
            // 
            this.btnCurrentUserInfo.BackColor = System.Drawing.Color.LightGray;
            this.btnCurrentUserInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.btnCurrentUserInfo.Location = new System.Drawing.Point(3, 3);
            this.btnCurrentUserInfo.Name = "btnCurrentUserInfo";
            this.btnCurrentUserInfo.Size = new System.Drawing.Size(216, 60);
            this.btnCurrentUserInfo.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnCurrentUserInfo.TabIndex = 8;
            this.btnCurrentUserInfo.Text = "Current User Info";
            this.btnCurrentUserInfo.UseVisualStyleBackColor = false;
            this.btnCurrentUserInfo.Click += new System.EventHandler(this.btnCurrentUserInfo_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Brown;
            this.btnSignOut.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.btnSignOut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSignOut.Location = new System.Drawing.Point(3, 69);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(424, 60);
            this.btnSignOut.Style.BackColor = System.Drawing.Color.Brown;
            this.btnSignOut.Style.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSignOut.TabIndex = 7;
            this.btnSignOut.Text = "Sign out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.LightGray;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.btnChangePassword.Location = new System.Drawing.Point(225, 3);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(202, 60);
            this.btnChangePassword.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnChangePassword.TabIndex = 6;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // ctrlAccountSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCurrentUserInfo);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnChangePassword);
            this.Name = "ctrlAccountSetting";
            this.Size = new System.Drawing.Size(437, 132);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.Controls.SfButton btnCurrentUserInfo;
        private Syncfusion.WinForms.Controls.SfButton btnSignOut;
        private Syncfusion.WinForms.Controls.SfButton btnChangePassword;
    }
}
