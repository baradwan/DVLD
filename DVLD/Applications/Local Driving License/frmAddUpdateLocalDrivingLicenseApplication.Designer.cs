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
            this.pnlTCContentFooter = new System.Windows.Forms.Panel();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNext = new Syncfusion.WinForms.Controls.SfButton();
            this.tcApplicationInfo = new System.Windows.Forms.TabControl();
            this.tpApplicationInfo = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrevious = new Syncfusion.WinForms.Controls.SfButton();
            this.cmbLicenseClass = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblAppDateValue = new System.Windows.Forms.Label();
            this.lblAppFeesValue = new System.Windows.Forms.Label();
            this.lblCreadtedByUserValue = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
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
            this.ctrlPersonInfoWithFilter1 = new DVLD.People.Controls.ctrlPersonInfoWithFilter();
            this.tpPersonInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tcApplicationInfo.SuspendLayout();
            this.tpApplicationInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLicenseClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.pnlfooter.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTCContentFooter
            // 
            this.pnlTCContentFooter.Location = new System.Drawing.Point(0, 0);
            this.pnlTCContentFooter.Name = "pnlTCContentFooter";
            this.pnlTCContentFooter.Size = new System.Drawing.Size(200, 100);
            this.pnlTCContentFooter.TabIndex = 0;
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.Controls.Add(this.ctrlPersonInfoWithFilter1);
            this.tpPersonInfo.Controls.Add(this.panel2);
            this.tpPersonInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 22);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(1232, 557);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Person Info";
            this.tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 497);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1226, 57);
            this.panel2.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.LightGray;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(1028, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(193, 42);
            this.btnNext.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // tcApplicationInfo
            // 
            this.tcApplicationInfo.Controls.Add(this.tpPersonInfo);
            this.tcApplicationInfo.Controls.Add(this.tpApplicationInfo);
            this.tcApplicationInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcApplicationInfo.Location = new System.Drawing.Point(0, 0);
            this.tcApplicationInfo.Name = "tcApplicationInfo";
            this.tcApplicationInfo.SelectedIndex = 0;
            this.tcApplicationInfo.Size = new System.Drawing.Size(1240, 583);
            this.tcApplicationInfo.TabIndex = 0;
            this.tcApplicationInfo.SelectedIndexChanged += new System.EventHandler(this.tcApplicationInfo_SelectedIndexChanged);
            this.tcApplicationInfo.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcApplicationInfo_Selecting);
            this.tcApplicationInfo.TabIndexChanged += new System.EventHandler(this.tcApplicationInfo_TabIndexChanged);
            // 
            // tpApplicationInfo
            // 
            this.tpApplicationInfo.BackColor = System.Drawing.Color.White;
            this.tpApplicationInfo.Controls.Add(this.panel1);
            this.tpApplicationInfo.Controls.Add(this.cmbLicenseClass);
            this.tpApplicationInfo.Controls.Add(this.lblAppDateValue);
            this.tpApplicationInfo.Controls.Add(this.lblAppFeesValue);
            this.tpApplicationInfo.Controls.Add(this.lblCreadtedByUserValue);
            this.tpApplicationInfo.Controls.Add(this.lblAppFees);
            this.tpApplicationInfo.Controls.Add(this.lblCrearedByUser);
            this.tpApplicationInfo.Controls.Add(this.lblDLAppIDValue);
            this.tpApplicationInfo.Controls.Add(this.lblAppDate);
            this.tpApplicationInfo.Controls.Add(this.lblLicenseClass);
            this.tpApplicationInfo.Controls.Add(this.lblDrivingLocalAppID);
            this.tpApplicationInfo.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpApplicationInfo.Location = new System.Drawing.Point(4, 22);
            this.tpApplicationInfo.Name = "tpApplicationInfo";
            this.tpApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpApplicationInfo.Size = new System.Drawing.Size(1232, 557);
            this.tpApplicationInfo.TabIndex = 1;
            this.tpApplicationInfo.Text = "Application Info";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 497);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 57);
            this.panel1.TabIndex = 137;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.BackColor = System.Drawing.Color.LightGray;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(1033, 8);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(193, 46);
            this.btnPrevious.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // cmbLicenseClass
            // 
            this.cmbLicenseClass.AllowDropDownResize = false;
            this.cmbLicenseClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLicenseClass.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbLicenseClass.DisplayMember = "";
            this.cmbLicenseClass.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbLicenseClass.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.cmbLicenseClass.ForeColor = System.Drawing.Color.Black;
            this.cmbLicenseClass.Location = new System.Drawing.Point(338, 175);
            this.cmbLicenseClass.Name = "cmbLicenseClass";
            this.cmbLicenseClass.Size = new System.Drawing.Size(274, 26);
            this.cmbLicenseClass.Style.DropDownButtonStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmbLicenseClass.Style.DropDownButtonStyle.FocusedBackColor = System.Drawing.Color.Transparent;
            this.cmbLicenseClass.Style.DropDownButtonStyle.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmbLicenseClass.Style.DropDownButtonStyle.ImageForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmbLicenseClass.Style.DropDownButtonStyle.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmbLicenseClass.Style.DropDownStyle.BorderColor = System.Drawing.Color.LightGray;
            this.cmbLicenseClass.Style.EditorStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbLicenseClass.Style.EditorStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.cmbLicenseClass.Style.EditorStyle.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.cmbLicenseClass.Style.EditorStyle.ForeColor = System.Drawing.Color.Black;
            this.cmbLicenseClass.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.cmbLicenseClass.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbLicenseClass.Style.TokenStyle.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.cmbLicenseClass.TabIndex = 136;
            this.cmbLicenseClass.TabStop = false;
            this.cmbLicenseClass.SelectedIndexChanged += new System.EventHandler(this.cmbLicenseClass_SelectedIndexChanged);
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
            this.pnlContent.Size = new System.Drawing.Size(1240, 583);
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
            this.pnlfooter.Location = new System.Drawing.Point(0, 653);
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // ctrlPersonInfoWithFilter1
            // 
            this.ctrlPersonInfoWithFilter1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlPersonInfoWithFilter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlPersonInfoWithFilter1.Location = new System.Drawing.Point(3, 3);
            this.ctrlPersonInfoWithFilter1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlPersonInfoWithFilter1.Name = "ctrlPersonInfoWithFilter1";
            this.ctrlPersonInfoWithFilter1.Size = new System.Drawing.Size(1226, 494);
            this.ctrlPersonInfoWithFilter1.TabIndex = 0;
            // 
            // frmAddUpdateLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 706);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlfooter);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmAddUpdateLocalDrivingLicenseApplication";
            this.Text = "frmLocalNewDrivingLicenseApplication";
            this.Load += new System.EventHandler(this.frmAddUpdateLocalDrivingLicenseApplication_Load);
            this.tpPersonInfo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tcApplicationInfo.ResumeLayout(false);
            this.tpApplicationInfo.ResumeLayout(false);
            this.tpApplicationInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbLicenseClass)).EndInit();
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

        private System.Windows.Forms.Panel pnlTCContentFooter;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.TabControl tcApplicationInfo;
        private System.Windows.Forms.TabPage tpApplicationInfo;
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
        private Syncfusion.WinForms.ListView.SfComboBox cmbLicenseClass;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.WinForms.Controls.SfButton btnPrevious;
        private People.Controls.ctrlPersonInfoWithFilter ctrlPersonInfoWithFilter1;
        private System.Windows.Forms.Panel panel2;
        private Syncfusion.WinForms.Controls.SfButton btnNext;
    }
}