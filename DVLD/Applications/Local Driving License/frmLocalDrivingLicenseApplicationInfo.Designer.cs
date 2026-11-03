namespace DVLD.Applications.Local_Driving_License
{
    partial class frmLocalDrivingLicenseApplicationInfo
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
            this.ctrlAppBasicInfo1 = new DVLD.Applications.ctrlAppBasicInfo();
            this.ctrlDrivingLicenseInfo1 = new DVLD.Applications.Local_Driving_License.Control.ctrlDrivingLicenseInfo();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.SuspendLayout();
            // 
            // ctrlAppBasicInfo1
            // 
            this.ctrlAppBasicInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlAppBasicInfo1.Location = new System.Drawing.Point(0, 0);
            this.ctrlAppBasicInfo1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ctrlAppBasicInfo1.Name = "ctrlAppBasicInfo1";
            this.ctrlAppBasicInfo1.Size = new System.Drawing.Size(935, 213);
            this.ctrlAppBasicInfo1.TabIndex = 0;
            this.ctrlAppBasicInfo1.Load += new System.EventHandler(this.ctrlAppBasicInfo1_Load);
            // 
            // ctrlDrivingLicenseInfo1
            // 
            this.ctrlDrivingLicenseInfo1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrlDrivingLicenseInfo1.Location = new System.Drawing.Point(0, 230);
            this.ctrlDrivingLicenseInfo1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ctrlDrivingLicenseInfo1.Name = "ctrlDrivingLicenseInfo1";
            this.ctrlDrivingLicenseInfo1.Size = new System.Drawing.Size(935, 220);
            this.ctrlDrivingLicenseInfo1.TabIndex = 1;
            this.ctrlDrivingLicenseInfo1.Load += new System.EventHandler(this.ctrlDrivingLicenseInfo1_Load);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(782, 396);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 42);
            this.btnClose.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmLocalDrivingLicenseApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlDrivingLicenseInfo1);
            this.Controls.Add(this.ctrlAppBasicInfo1);
            this.Name = "frmLocalDrivingLicenseApplicationInfo";
            this.Text = "frmLocalDrivingLicenseApplicationInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLocalDrivingLicenseApplicationInfo_FormClosing);
            this.Load += new System.EventHandler(this.frmLocalDrivingLicenseApplicationInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlAppBasicInfo ctrlAppBasicInfo1;
        private Control.ctrlDrivingLicenseInfo ctrlDrivingLicenseInfo1;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
    }
}