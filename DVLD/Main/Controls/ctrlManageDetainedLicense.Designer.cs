namespace DVLD.Main.Controls
{
    partial class ctrlManageDetainedLicense
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
            this.btnDetainLicense = new Syncfusion.WinForms.Controls.SfButton();
            this.btnManageDetainedLicense = new Syncfusion.WinForms.Controls.SfButton();
            this.btnReleaseDetainedLicense = new Syncfusion.WinForms.Controls.SfButton();
            this.SuspendLayout();
            // 
            // btnDetainLicense
            // 
            this.btnDetainLicense.BackColor = System.Drawing.Color.LightGray;
            this.btnDetainLicense.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.btnDetainLicense.Location = new System.Drawing.Point(312, 13);
            this.btnDetainLicense.Name = "btnDetainLicense";
            this.btnDetainLicense.Size = new System.Drawing.Size(287, 60);
            this.btnDetainLicense.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnDetainLicense.TabIndex = 10;
            this.btnDetainLicense.Tag = " ";
            this.btnDetainLicense.Text = "Detain License";
            this.btnDetainLicense.UseVisualStyleBackColor = false;
            this.btnDetainLicense.Click += new System.EventHandler(this.btnDetainLicense_Click);
            // 
            // btnManageDetainedLicense
            // 
            this.btnManageDetainedLicense.BackColor = System.Drawing.Color.LightGray;
            this.btnManageDetainedLicense.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.btnManageDetainedLicense.Location = new System.Drawing.Point(29, 13);
            this.btnManageDetainedLicense.Name = "btnManageDetainedLicense";
            this.btnManageDetainedLicense.Size = new System.Drawing.Size(277, 60);
            this.btnManageDetainedLicense.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnManageDetainedLicense.TabIndex = 9;
            this.btnManageDetainedLicense.Text = "Manage Detained License";
            this.btnManageDetainedLicense.UseVisualStyleBackColor = false;
            this.btnManageDetainedLicense.Click += new System.EventHandler(this.btnManageDetainedLicense_Click);
            // 
            // btnReleaseDetainedLicense
            // 
            this.btnReleaseDetainedLicense.BackColor = System.Drawing.Color.LightGray;
            this.btnReleaseDetainedLicense.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.btnReleaseDetainedLicense.Location = new System.Drawing.Point(605, 13);
            this.btnReleaseDetainedLicense.Name = "btnReleaseDetainedLicense";
            this.btnReleaseDetainedLicense.Size = new System.Drawing.Size(287, 60);
            this.btnReleaseDetainedLicense.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnReleaseDetainedLicense.TabIndex = 11;
            this.btnReleaseDetainedLicense.Tag = " ";
            this.btnReleaseDetainedLicense.Text = "Release Detained License";
            this.btnReleaseDetainedLicense.UseVisualStyleBackColor = false;
            this.btnReleaseDetainedLicense.Click += new System.EventHandler(this.btnReleaseDetainedLicense_Click);
            // 
            // ctrlManageDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReleaseDetainedLicense);
            this.Controls.Add(this.btnDetainLicense);
            this.Controls.Add(this.btnManageDetainedLicense);
            this.Name = "ctrlManageDetainedLicense";
            this.Size = new System.Drawing.Size(904, 89);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.Controls.SfButton btnDetainLicense;
        private Syncfusion.WinForms.Controls.SfButton btnManageDetainedLicense;
        private Syncfusion.WinForms.Controls.SfButton btnReleaseDetainedLicense;
    }
}
