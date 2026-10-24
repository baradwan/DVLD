namespace DVLD.Licenses.Local_License
{
    partial class frmIssueDriverLicenseFirstTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueDriverLicenseFirstTime));
            this.pnlfooter = new System.Windows.Forms.Panel();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.btnIssue = new Syncfusion.WinForms.Controls.SfButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.ctrlDrivingLicenseInfo1 = new DVLD.Applications.Local_Driving_License.Control.ctrlDrivingLicenseInfo();
            this.ctrlAppBasicInfo1 = new DVLD.Applications.ctrlAppBasicInfo();
            this.pnlfooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlfooter
            // 
            this.pnlfooter.Controls.Add(this.btnClose);
            this.pnlfooter.Controls.Add(this.btnIssue);
            this.pnlfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlfooter.Location = new System.Drawing.Point(0, 579);
            this.pnlfooter.Name = "pnlfooter";
            this.pnlfooter.Size = new System.Drawing.Size(900, 60);
            this.pnlfooter.TabIndex = 210;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(622, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 42);
            this.btnClose.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIssue.BackColor = System.Drawing.Color.LightGray;
            this.btnIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIssue.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Location = new System.Drawing.Point(763, 6);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(126, 42);
            this.btnIssue.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnIssue.TabIndex = 10;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 497);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 211;
            this.label1.Text = "Notes:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 482);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 212;
            this.pictureBox1.TabStop = false;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(171, 466);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(491, 107);
            this.txtNote.TabIndex = 213;
            // 
            // ctrlDrivingLicenseInfo1
            // 
            this.ctrlDrivingLicenseInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlDrivingLicenseInfo1.Location = new System.Drawing.Point(0, 237);
            this.ctrlDrivingLicenseInfo1.Name = "ctrlDrivingLicenseInfo1";
            this.ctrlDrivingLicenseInfo1.Size = new System.Drawing.Size(900, 224);
            this.ctrlDrivingLicenseInfo1.TabIndex = 1;
            // 
            // ctrlAppBasicInfo1
            // 
            this.ctrlAppBasicInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlAppBasicInfo1.Location = new System.Drawing.Point(0, 0);
            this.ctrlAppBasicInfo1.Name = "ctrlAppBasicInfo1";
            this.ctrlAppBasicInfo1.Size = new System.Drawing.Size(900, 237);
            this.ctrlAppBasicInfo1.TabIndex = 0;
            // 
            // frmIssueDriverLicenseFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 639);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlfooter);
            this.Controls.Add(this.ctrlDrivingLicenseInfo1);
            this.Controls.Add(this.ctrlAppBasicInfo1);
            this.Name = "frmIssueDriverLicenseFirstTime";
            this.Text = "frmIssueDriverLicenseFirstTime";
            this.Load += new System.EventHandler(this.frmIssueDriverLicenseFirstTime_Load);
            this.pnlfooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Applications.ctrlAppBasicInfo ctrlAppBasicInfo1;
        private Applications.Local_Driving_License.Control.ctrlDrivingLicenseInfo ctrlDrivingLicenseInfo1;
        private System.Windows.Forms.Panel pnlfooter;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private Syncfusion.WinForms.Controls.SfButton btnIssue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNote;
    }
}