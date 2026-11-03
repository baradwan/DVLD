namespace DVLD.Licenses
{
    partial class frmShowPersonLicenseHistory
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
            this.pnlHistoryTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.ctrlDriverLicense1 = new DVLD.Licenses.Control.ctrlDriverLicense();
            this.ctrlPersonInfoWithFilter1 = new DVLD.People.Controls.ctrlPersonInfoWithFilter();
            this.pnlHistoryTitle.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHistoryTitle
            // 
            this.pnlHistoryTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlHistoryTitle.Controls.Add(this.lblTitle);
            this.pnlHistoryTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHistoryTitle.Location = new System.Drawing.Point(0, 487);
            this.pnlHistoryTitle.Name = "pnlHistoryTitle";
            this.pnlHistoryTitle.Size = new System.Drawing.Size(1070, 31);
            this.pnlHistoryTitle.TabIndex = 214;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(19, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(138, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Driver Licenses";
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.ctrlDriverLicense1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 518);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1070, 333);
            this.pnlContainer.TabIndex = 215;
            // 
            // ctrlDriverLicense1
            // 
            this.ctrlDriverLicense1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlDriverLicense1.Location = new System.Drawing.Point(0, 0);
            this.ctrlDriverLicense1.Name = "ctrlDriverLicense1";
            this.ctrlDriverLicense1.Size = new System.Drawing.Size(1070, 333);
            this.ctrlDriverLicense1.TabIndex = 0;
            // 
            // ctrlPersonInfoWithFilter1
            // 
            this.ctrlPersonInfoWithFilter1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlPersonInfoWithFilter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlPersonInfoWithFilter1.Location = new System.Drawing.Point(0, 0);
            this.ctrlPersonInfoWithFilter1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlPersonInfoWithFilter1.Name = "ctrlPersonInfoWithFilter1";
            this.ctrlPersonInfoWithFilter1.Size = new System.Drawing.Size(1070, 487);
            this.ctrlPersonInfoWithFilter1.TabIndex = 0;
            this.ctrlPersonInfoWithFilter1.OnPersonSelected += new System.Action<int>(this.ctrlPersonInfoWithFilter1_OnPersonSelected);
            // 
            // frmShowPersonLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 851);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlHistoryTitle);
            this.Controls.Add(this.ctrlPersonInfoWithFilter1);
            this.Name = "frmShowPersonLicenseHistory";
            this.Text = "frmShowPersonLicenseHistory";
            this.Load += new System.EventHandler(this.frmShowPersonLicenseHistory_Load);
            this.pnlHistoryTitle.ResumeLayout(false);
            this.pnlHistoryTitle.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private People.Controls.ctrlPersonInfoWithFilter ctrlPersonInfoWithFilter1;
        private System.Windows.Forms.Panel pnlHistoryTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContainer;
        private Control.ctrlDriverLicense ctrlDriverLicense1;
    }
}