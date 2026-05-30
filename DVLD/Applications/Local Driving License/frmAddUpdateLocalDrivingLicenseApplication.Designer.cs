namespace DVLD.Applications.Local_Driving_License
{
    partial class frmAddUpdateLocalDrivingLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateLocalDrivingLicenseApplication));
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            this.btnNext = new Syncfusion.WinForms.Controls.SfButton();
            this.ctrlPersonInfoWithFilter1 = new DVLD.People.Controls.ctrlPersonInfoWithFilter();
            this.pnlTCContentFooter = new System.Windows.Forms.Panel();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.tcApplicationInfo = new System.Windows.Forms.TabControl();
            this.tpApplicationInfo = new System.Windows.Forms.TabPage();
            this.cbLicenseClass = new System.Windows.Forms.ComboBox();
            this.lblAppDateValue = new System.Windows.Forms.Label();
            this.lblAppFeesValue = new System.Windows.Forms.Label();
            this.lblCreadtedByUserValue = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.btnPervoius = new Syncfusion.WinForms.Controls.SfButton();
            this.lblCrearedByUser = new System.Windows.Forms.Label();
            this.lblDLAppIDValue = new System.Windows.Forms.Label();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.lblLicenseClass = new System.Windows.Forms.Label();
            this.lblDrivingLocalAppID = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.pnlfooter = new System.Windows.Forms.Panel();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.btnSave = new Syncfusion.WinForms.Controls.SfButton();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlTCContentFooter.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.tcApplicationInfo.SuspendLayout();
            this.tpApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.pnlfooter.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.LightGray;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(1029, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(193, 42);
            this.btnNext.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // ctrlPersonInfoWithFilter1
            // 
            this.ctrlPersonInfoWithFilter1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlPersonInfoWithFilter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlPersonInfoWithFilter1.Location = new System.Drawing.Point(3, 3);
            this.ctrlPersonInfoWithFilter1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPersonInfoWithFilter1.Name = "ctrlPersonInfoWithFilter1";
            this.ctrlPersonInfoWithFilter1.Size = new System.Drawing.Size(1226, 479);
            this.ctrlPersonInfoWithFilter1.TabIndex = 1;
            // 
            // pnlTCContentFooter
            // 
            this.pnlTCContentFooter.Controls.Add(this.btnNext);
            this.pnlTCContentFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTCContentFooter.Location = new System.Drawing.Point(3, 482);
            this.pnlTCContentFooter.Name = "pnlTCContentFooter";
            this.pnlTCContentFooter.Size = new System.Drawing.Size(1226, 42);
            this.pnlTCContentFooter.TabIndex = 0;
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.Controls.Add(this.ctrlPersonInfoWithFilter1);
            this.tpPersonInfo.Controls.Add(this.pnlTCContentFooter);
            this.tpPersonInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 22);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(1232, 527);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Person Info";
            this.tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // tcApplicationInfo
            // 
            this.tcApplicationInfo.Controls.Add(this.tpPersonInfo);
            this.tcApplicationInfo.Controls.Add(this.tpApplicationInfo);
            this.tcApplicationInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcApplicationInfo.Location = new System.Drawing.Point(0, 0);
            this.tcApplicationInfo.Name = "tcApplicationInfo";
            this.tcApplicationInfo.SelectedIndex = 0;
            this.tcApplicationInfo.Size = new System.Drawing.Size(1240, 553);
            this.tcApplicationInfo.TabIndex = 0;
            // 
            // tpApplicationInfo
            // 
            this.tpApplicationInfo.BackColor = System.Drawing.Color.White;
            this.tpApplicationInfo.Controls.Add(this.cbLicenseClass);
            this.tpApplicationInfo.Controls.Add(this.lblAppDateValue);
            this.tpApplicationInfo.Controls.Add(this.lblAppFeesValue);
            this.tpApplicationInfo.Controls.Add(this.lblCreadtedByUserValue);
            this.tpApplicationInfo.Controls.Add(this.lblAppFees);
            this.tpApplicationInfo.Controls.Add(this.btnPervoius);
            this.tpApplicationInfo.Controls.Add(this.lblCrearedByUser);
            this.tpApplicationInfo.Controls.Add(this.lblDLAppIDValue);
            this.tpApplicationInfo.Controls.Add(this.lblAppDate);
            this.tpApplicationInfo.Controls.Add(this.lblLicenseClass);
            this.tpApplicationInfo.Controls.Add(this.lblDrivingLocalAppID);
            this.tpApplicationInfo.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpApplicationInfo.Location = new System.Drawing.Point(4, 22);
            this.tpApplicationInfo.Name = "tpApplicationInfo";
            this.tpApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpApplicationInfo.Size = new System.Drawing.Size(1232, 527);
            this.tpApplicationInfo.TabIndex = 1;
            this.tpApplicationInfo.Text = "Login Info";
            // 
            // cbLicenseClass
            // 
            this.cbLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClass.FormattingEnabled = true;
            this.cbLicenseClass.Location = new System.Drawing.Point(346, 180);
            this.cbLicenseClass.Name = "cbLicenseClass";
            this.cbLicenseClass.Size = new System.Drawing.Size(270, 21);
            this.cbLicenseClass.TabIndex = 135;
            // 
            // lblAppDateValue
            // 
            this.lblAppDateValue.AutoSize = true;
            this.lblAppDateValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDateValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAppDateValue.Location = new System.Drawing.Point(390, 124);
            this.lblAppDateValue.Name = "lblAppDateValue";
            this.lblAppDateValue.Size = new System.Drawing.Size(37, 30);
            this.lblAppDateValue.TabIndex = 33;
            this.lblAppDateValue.Text = "---";
            this.lblAppDateValue.Click += new System.EventHandler(this.lblAppDateValue_Click);
            // 
            // lblAppFeesValue
            // 
            this.lblAppFeesValue.AutoSize = true;
            this.lblAppFeesValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFeesValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAppFeesValue.Location = new System.Drawing.Point(390, 216);
            this.lblAppFeesValue.Name = "lblAppFeesValue";
            this.lblAppFeesValue.Size = new System.Drawing.Size(37, 30);
            this.lblAppFeesValue.TabIndex = 32;
            this.lblAppFeesValue.Text = "---";
            // 
            // lblCreadtedByUserValue
            // 
            this.lblCreadtedByUserValue.AutoSize = true;
            this.lblCreadtedByUserValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreadtedByUserValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCreadtedByUserValue.Location = new System.Drawing.Point(390, 280);
            this.lblCreadtedByUserValue.Name = "lblCreadtedByUserValue";
            this.lblCreadtedByUserValue.Size = new System.Drawing.Size(37, 30);
            this.lblCreadtedByUserValue.TabIndex = 31;
            this.lblCreadtedByUserValue.Text = "---";
            this.lblCreadtedByUserValue.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFees.Location = new System.Drawing.Point(77, 216);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(181, 30);
            this.lblAppFees.TabIndex = 29;
            this.lblAppFees.Text = "Application Fees:";
            // 
            // btnPervoius
            // 
            this.btnPervoius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPervoius.BackColor = System.Drawing.Color.LightGray;
            this.btnPervoius.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPervoius.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPervoius.Location = new System.Drawing.Point(1052, 556);
            this.btnPervoius.Name = "btnPervoius";
            this.btnPervoius.Size = new System.Drawing.Size(172, 42);
            this.btnPervoius.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnPervoius.TabIndex = 11;
            this.btnPervoius.Text = "Pervoius";
            this.btnPervoius.UseVisualStyleBackColor = false;
            // 
            // lblCrearedByUser
            // 
            this.lblCrearedByUser.AutoSize = true;
            this.lblCrearedByUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearedByUser.Location = new System.Drawing.Point(77, 280);
            this.lblCrearedByUser.Name = "lblCrearedByUser";
            this.lblCrearedByUser.Size = new System.Drawing.Size(118, 30);
            this.lblCrearedByUser.TabIndex = 4;
            this.lblCrearedByUser.Text = "Created By";
            // 
            // lblDLAppIDValue
            // 
            this.lblDLAppIDValue.AutoSize = true;
            this.lblDLAppIDValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDLAppIDValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDLAppIDValue.Location = new System.Drawing.Point(390, 78);
            this.lblDLAppIDValue.Name = "lblDLAppIDValue";
            this.lblDLAppIDValue.Size = new System.Drawing.Size(37, 30);
            this.lblDLAppIDValue.TabIndex = 3;
            this.lblDLAppIDValue.Text = "---";
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDate.Location = new System.Drawing.Point(77, 124);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(190, 30);
            this.lblAppDate.TabIndex = 2;
            this.lblAppDate.Text = "Application Date: ";
            // 
            // lblLicenseClass
            // 
            this.lblLicenseClass.AutoSize = true;
            this.lblLicenseClass.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseClass.Location = new System.Drawing.Point(77, 171);
            this.lblLicenseClass.Name = "lblLicenseClass";
            this.lblLicenseClass.Size = new System.Drawing.Size(144, 30);
            this.lblLicenseClass.TabIndex = 1;
            this.lblLicenseClass.Text = "License Class:";
            // 
            // lblDrivingLocalAppID
            // 
            this.lblDrivingLocalAppID.AutoSize = true;
            this.lblDrivingLocalAppID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrivingLocalAppID.Location = new System.Drawing.Point(77, 78);
            this.lblDrivingLocalAppID.Name = "lblDrivingLocalAppID";
            this.lblDrivingLocalAppID.Size = new System.Drawing.Size(198, 30);
            this.lblDrivingLocalAppID.TabIndex = 0;
            this.lblDrivingLocalAppID.Text = "D.L.Application ID:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tcApplicationInfo);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 70);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1240, 553);
            this.pnlContent.TabIndex = 5;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblFormTitle.Location = new System.Drawing.Point(433, 9);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(326, 45);
            this.lblFormTitle.TabIndex = 3;
            this.lblFormTitle.Text = "Local Drving Licence";
            // 
            // pbIcon
            // 
            this.pbIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbIcon.Image")));
            this.pbIcon.Location = new System.Drawing.Point(0, 0);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(119, 70);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            // 
            // pnlfooter
            // 
            this.pnlfooter.Controls.Add(this.btnClose);
            this.pnlfooter.Controls.Add(this.btnSave);
            this.pnlfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlfooter.Location = new System.Drawing.Point(0, 623);
            this.pnlfooter.Name = "pnlfooter";
            this.pnlfooter.Size = new System.Drawing.Size(1240, 53);
            this.pnlfooter.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(962, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 42);
            this.btnClose.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.LightGray;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1103, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 42);
            this.btnSave.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblFormTitle);
            this.pnlHeader.Controls.Add(this.pbIcon);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1240, 70);
            this.pnlHeader.TabIndex = 3;
            // 
            // frmAddUpdateLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 676);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlfooter);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmAddUpdateLocalDrivingLicenseApplication";
            this.Text = "frmLocalNewDrivingLicenseApplication";
            this.pnlTCContentFooter.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.tcApplicationInfo.ResumeLayout(false);
            this.tpApplicationInfo.ResumeLayout(false);
            this.tpApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.pnlfooter.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private Syncfusion.WinForms.Controls.SfButton btnNext;
        private People.Controls.ctrlPersonInfoWithFilter ctrlPersonInfoWithFilter1;
        private System.Windows.Forms.Panel pnlTCContentFooter;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.TabControl tcApplicationInfo;
        private System.Windows.Forms.TabPage tpApplicationInfo;
        private Syncfusion.WinForms.Controls.SfButton btnPervoius;
        private System.Windows.Forms.Label lblCrearedByUser;
        private System.Windows.Forms.Label lblDLAppIDValue;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.Label lblLicenseClass;
        private System.Windows.Forms.Label lblDrivingLocalAppID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlfooter;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private Syncfusion.WinForms.Controls.SfButton btnSave;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lblAppDateValue;
        private System.Windows.Forms.Label lblAppFeesValue;
        private System.Windows.Forms.Label lblCreadtedByUserValue;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.ComboBox cbLicenseClass;
    }
}