namespace DVLD.Main.Controls
{
    partial class ctrlManageApplication
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
            this.btnLDLApllication = new Syncfusion.WinForms.Controls.SfButton();
            this.btnIDLApplication = new Syncfusion.WinForms.Controls.SfButton();
            this.SuspendLayout();
            // 
            // btnLDLApllication
            // 
            this.btnLDLApllication.BackColor = System.Drawing.Color.LightGray;
            this.btnLDLApllication.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.btnLDLApllication.Location = new System.Drawing.Point(30, 15);
            this.btnLDLApllication.Name = "btnLDLApllication";
            this.btnLDLApllication.Size = new System.Drawing.Size(277, 60);
            this.btnLDLApllication.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnLDLApllication.TabIndex = 7;
            this.btnLDLApllication.Text = "Local Driving License Applications ";
            this.btnLDLApllication.UseVisualStyleBackColor = false;
            this.btnLDLApllication.Click += new System.EventHandler(this.btnLDLApllication_Click);
            // 
            // btnIDLApplication
            // 
            this.btnIDLApplication.BackColor = System.Drawing.Color.LightGray;
            this.btnIDLApplication.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.btnIDLApplication.Location = new System.Drawing.Point(313, 15);
            this.btnIDLApplication.Name = "btnIDLApplication";
            this.btnIDLApplication.Size = new System.Drawing.Size(287, 60);
            this.btnIDLApplication.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnIDLApplication.TabIndex = 8;
            this.btnIDLApplication.Tag = " ";
            this.btnIDLApplication.Text = "International License Applications";
            this.btnIDLApplication.UseVisualStyleBackColor = false;
            // 
            // ctrlManageApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnIDLApplication);
            this.Controls.Add(this.btnLDLApllication);
            this.Name = "ctrlManageApplication";
            this.Size = new System.Drawing.Size(611, 92);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.Controls.SfButton btnLDLApllication;
        private Syncfusion.WinForms.Controls.SfButton btnIDLApplication;
    }
}
