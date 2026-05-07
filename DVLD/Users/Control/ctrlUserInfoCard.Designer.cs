namespace DVLD.Users.Control
{
    partial class ctrlUserInfoCard
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
            this.pnlPersonInfoCard = new System.Windows.Forms.Panel();
            this.crlShowPersonInformation1 = new DVLD.People.Controls.crlShowPersonInformation();
            this.gbUserLoginInfo = new System.Windows.Forms.GroupBox();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblIsActiveTittle = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUserIDTitle = new System.Windows.Forms.Label();
            this.lblUserNameTitle = new System.Windows.Forms.Label();
            this.pnlPersonInfoCard.SuspendLayout();
            this.gbUserLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPersonInfoCard
            // 
            this.pnlPersonInfoCard.Controls.Add(this.crlShowPersonInformation1);
            this.pnlPersonInfoCard.Location = new System.Drawing.Point(0, 0);
            this.pnlPersonInfoCard.Name = "pnlPersonInfoCard";
            this.pnlPersonInfoCard.Size = new System.Drawing.Size(711, 411);
            this.pnlPersonInfoCard.TabIndex = 0;
            // 
            // crlShowPersonInformation1
            // 
            this.crlShowPersonInformation1.AutoSize = true;
            this.crlShowPersonInformation1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.crlShowPersonInformation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crlShowPersonInformation1.Location = new System.Drawing.Point(0, 0);
            this.crlShowPersonInformation1.Name = "crlShowPersonInformation1";
            this.crlShowPersonInformation1.Size = new System.Drawing.Size(711, 411);
            this.crlShowPersonInformation1.TabIndex = 0;
            // 
            // gbUserLoginInfo
            // 
            this.gbUserLoginInfo.BackColor = System.Drawing.Color.White;
            this.gbUserLoginInfo.Controls.Add(this.lblIsActive);
            this.gbUserLoginInfo.Controls.Add(this.lblIsActiveTittle);
            this.gbUserLoginInfo.Controls.Add(this.lblUserName);
            this.gbUserLoginInfo.Controls.Add(this.lblUserID);
            this.gbUserLoginInfo.Controls.Add(this.lblUserIDTitle);
            this.gbUserLoginInfo.Controls.Add(this.lblUserNameTitle);
            this.gbUserLoginInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbUserLoginInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUserLoginInfo.Location = new System.Drawing.Point(0, 412);
            this.gbUserLoginInfo.Name = "gbUserLoginInfo";
            this.gbUserLoginInfo.Size = new System.Drawing.Size(718, 99);
            this.gbUserLoginInfo.TabIndex = 1;
            this.gbUserLoginInfo.TabStop = false;
            this.gbUserLoginInfo.Text = "User Login Info";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.Location = new System.Drawing.Point(580, 54);
            this.lblIsActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(39, 20);
            this.lblIsActive.TabIndex = 146;
            this.lblIsActive.Text = "???";
            // 
            // lblIsActiveTittle
            // 
            this.lblIsActiveTittle.AutoSize = true;
            this.lblIsActiveTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActiveTittle.Location = new System.Drawing.Point(487, 54);
            this.lblIsActiveTittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsActiveTittle.Name = "lblIsActiveTittle";
            this.lblIsActiveTittle.Size = new System.Drawing.Size(93, 20);
            this.lblIsActiveTittle.TabIndex = 145;
            this.lblIsActiveTittle.Text = "Is Active : ";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(377, 54);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(39, 20);
            this.lblUserName.TabIndex = 144;
            this.lblUserName.Text = "???";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(181, 54);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(39, 20);
            this.lblUserID.TabIndex = 143;
            this.lblUserID.Text = "???";
            // 
            // lblUserIDTitle
            // 
            this.lblUserIDTitle.AutoSize = true;
            this.lblUserIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDTitle.Location = new System.Drawing.Point(95, 54);
            this.lblUserIDTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserIDTitle.Name = "lblUserIDTitle";
            this.lblUserIDTitle.Size = new System.Drawing.Size(86, 20);
            this.lblUserIDTitle.TabIndex = 142;
            this.lblUserIDTitle.Text = "User ID : ";
            // 
            // lblUserNameTitle
            // 
            this.lblUserNameTitle.AutoSize = true;
            this.lblUserNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameTitle.Location = new System.Drawing.Point(281, 54);
            this.lblUserNameTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserNameTitle.Name = "lblUserNameTitle";
            this.lblUserNameTitle.Size = new System.Drawing.Size(96, 20);
            this.lblUserNameTitle.TabIndex = 141;
            this.lblUserNameTitle.Text = "Username:";
            // 
            // ctrlUserInfoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbUserLoginInfo);
            this.Controls.Add(this.pnlPersonInfoCard);
            this.Name = "ctrlUserInfoCard";
            this.Size = new System.Drawing.Size(718, 511);
            this.pnlPersonInfoCard.ResumeLayout(false);
            this.pnlPersonInfoCard.PerformLayout();
            this.gbUserLoginInfo.ResumeLayout(false);
            this.gbUserLoginInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPersonInfoCard;
        private System.Windows.Forms.GroupBox gbUserLoginInfo;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lblIsActiveTittle;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblUserIDTitle;
        private System.Windows.Forms.Label lblUserNameTitle;
        private People.Controls.crlShowPersonInformation crlShowPersonInformation1;
    }
}
