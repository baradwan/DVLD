namespace DVLD.People
{
    partial class frmAddUpdatePerson
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
            this.crlPersonalCard1 = new DVLD.People.Controls.crlPersonalCard();
            this.SuspendLayout();
            // 
            // crlPersonalCard1
            // 
            this.crlPersonalCard1.Location = new System.Drawing.Point(58, 50);
            this.crlPersonalCard1.Name = "crlPersonalCard1";
            this.crlPersonalCard1.Size = new System.Drawing.Size(730, 388);
            this.crlPersonalCard1.TabIndex = 0;
            // 
            // frmAddUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 582);
            this.Controls.Add(this.crlPersonalCard1);
            this.Name = "frmAddUpdatePerson";
            this.Text = "frmAddUpdatePerson";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.crlPersonalCard crlPersonalCard1;
    }
}