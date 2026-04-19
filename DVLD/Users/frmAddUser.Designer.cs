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
            this.ctrlPersonInfoWithFilter1 = new DVLD.People.Controls.ctrlPersonInfoWithFilter();
            this.SuspendLayout();
            // 
            // ctrlPersonInfoWithFilter1
            // 
            this.ctrlPersonInfoWithFilter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlPersonInfoWithFilter1.Location = new System.Drawing.Point(0, 0);
            this.ctrlPersonInfoWithFilter1.Name = "ctrlPersonInfoWithFilter1";
            this.ctrlPersonInfoWithFilter1.Size = new System.Drawing.Size(2024, 1113);
            this.ctrlPersonInfoWithFilter1.TabIndex = 0;
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2024, 1113);
            this.Controls.Add(this.ctrlPersonInfoWithFilter1);
            this.Name = "frmAddUser";
            this.Text = "frmAddUser";
            this.ResumeLayout(false);

        }

        #endregion

        private People.Controls.ctrlPersonInfoWithFilter ctrlPersonInfoWithFilter1;
    }
}