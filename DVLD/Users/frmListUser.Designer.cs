namespace DVLD.Users
{
    partial class frmListUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListUser));
            this.btnPeopleAddUser = new Syncfusion.WinForms.Controls.SfButton();
            this.lblTitleUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.lblRecordValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlListUsers1 = new DVLD.Users.Control.ctrlListUsers();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPeopleAddUser
            // 
            this.btnPeopleAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPeopleAddUser.AutoEllipsis = true;
            this.btnPeopleAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeopleAddUser.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.btnPeopleAddUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPeopleAddUser.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPeopleAddUser.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPeopleAddUser.Location = new System.Drawing.Point(1178, 18);
            this.btnPeopleAddUser.Name = "btnPeopleAddUser";
            this.btnPeopleAddUser.Size = new System.Drawing.Size(174, 45);
            this.btnPeopleAddUser.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(150)))), ((int)(((byte)(249)))));
            this.btnPeopleAddUser.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(150)))), ((int)(((byte)(249)))));
            this.btnPeopleAddUser.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnPeopleAddUser.Style.ForeColor = System.Drawing.Color.White;
            this.btnPeopleAddUser.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnPeopleAddUser.TabIndex = 2;
            this.btnPeopleAddUser.Text = "Add User";
            this.btnPeopleAddUser.Click += new System.EventHandler(this.btnPeopleAddUser_Click);
            // 
            // lblTitleUser
            // 
            this.lblTitleUser.AutoSize = true;
            this.lblTitleUser.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleUser.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitleUser.Location = new System.Drawing.Point(132, 9);
            this.lblTitleUser.Name = "lblTitleUser";
            this.lblTitleUser.Size = new System.Drawing.Size(231, 45);
            this.lblTitleUser.TabIndex = 1;
            this.lblTitleUser.Text = "Manage Users";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(100, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnPeopleAddUser);
            this.pnlHeader.Controls.Add(this.lblTitleUser);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1398, 80);
            this.pnlHeader.TabIndex = 1;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.ctrlListUsers1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 80);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1398, 725);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Controls.Add(this.lblRecordValue);
            this.pnlFooter.Controls.Add(this.label3);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 754);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1398, 51);
            this.pnlFooter.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnClose.Location = new System.Drawing.Point(1274, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 37);
            this.btnClose.Style.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRecordValue
            // 
            this.lblRecordValue.AutoSize = true;
            this.lblRecordValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRecordValue.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblRecordValue.Location = new System.Drawing.Point(134, 14);
            this.lblRecordValue.Name = "lblRecordValue";
            this.lblRecordValue.Size = new System.Drawing.Size(34, 25);
            this.lblRecordValue.TabIndex = 6;
            this.lblRecordValue.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Records : ";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::DVLD.Properties.Resources.ShowDetailes;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(297, 42);
            this.toolStripMenuItem2.Text = "Show Details";
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Image = global::DVLD.Properties.Resources.icons8_add_administrator_50;
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(297, 42);
            this.addNewPersonToolStripMenuItem.Text = "Add New Person";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(294, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Image = global::DVLD.Properties.Resources.people__2_;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(297, 42);
            this.toolStripMenuItem5.Text = "Edit";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Image = global::DVLD.Properties.Resources.delete;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(297, 42);
            this.toolStripMenuItem6.Text = "Delete";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(294, 6);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Image = global::DVLD.Properties.Resources.mail;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(297, 42);
            this.toolStripMenuItem7.Text = "Send Email";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Image = global::DVLD.Properties.Resources.call;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(297, 42);
            this.toolStripMenuItem8.Text = "Phone Call";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(297, 42);
            this.toolStripMenuItem3.Text = " ";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(297, 42);
            this.toolStripMenuItem4.Text = " ";
            // 
            // ctrlListUsers1
            // 
            this.ctrlListUsers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlListUsers1.Location = new System.Drawing.Point(0, 0);
            this.ctrlListUsers1.Name = "ctrlListUsers1";
            this.ctrlListUsers1.Size = new System.Drawing.Size(1398, 725);
            this.ctrlListUsers1.TabIndex = 0;
            this.ctrlListUsers1.Load += new System.EventHandler(this.ctrlListUsers1_Load);
            // 
            // frmListUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 805);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmListUser";
            this.Text = "frmListUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmListUser_FormClosing);
            this.Load += new System.EventHandler(this.frmListUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.Controls.SfButton btnPeopleAddUser;
        private System.Windows.Forms.Label lblTitleUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;
      
        private System.Windows.Forms.Panel pnlFooter;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private System.Windows.Forms.Label lblRecordValue;
        private System.Windows.Forms.Label label3;
        private Control.ctrlListUsers ctrlListUsers1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    }
}