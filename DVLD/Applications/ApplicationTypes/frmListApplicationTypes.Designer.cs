namespace DVLD.Applications.ApplicationTypes
{
    partial class frmListApplicationTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListApplicationTypes));
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.lblRecordTitle = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.dvgList = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.edToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFooter.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Controls.Add(this.lblRecordCount);
            this.pnlFooter.Controls.Add(this.lblRecordTitle);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 1007);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1449, 111);
            this.pnlFooter.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnClose.Location = new System.Drawing.Point(1184, 16);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(224, 71);
            this.btnClose.Style.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRecordCount.ForeColor = System.Drawing.Color.Maroon;
            this.lblRecordCount.Location = new System.Drawing.Point(339, 28);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(75, 59);
            this.lblRecordCount.TabIndex = 1;
            this.lblRecordCount.Text = "00";
            // 
            // lblRecordTitle
            // 
            this.lblRecordTitle.AutoSize = true;
            this.lblRecordTitle.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRecordTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblRecordTitle.Location = new System.Drawing.Point(67, 28);
            this.lblRecordTitle.Name = "lblRecordTitle";
            this.lblRecordTitle.Size = new System.Drawing.Size(234, 59);
            this.lblRecordTitle.TabIndex = 0;
            this.lblRecordTitle.Text = "#Records :";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(6);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1449, 183);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(374, 48);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(853, 86);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Manage Appllication Types";
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.dvgList);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 183);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.pnlContent.Size = new System.Drawing.Size(1449, 824);
            this.pnlContent.TabIndex = 4;
            // 
            // dvgList
            // 
            this.dvgList.AccessibleName = "Table";
            this.dvgList.AllowEditing = false;
            this.dvgList.AllowGrouping = false;
            this.dvgList.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.dvgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgList.HeaderRowHeight = 45;
            this.dvgList.Location = new System.Drawing.Point(0, 40);
            this.dvgList.Margin = new System.Windows.Forms.Padding(6);
            this.dvgList.Name = "dvgList";
            this.dvgList.Padding = new System.Windows.Forms.Padding(6);
            this.dvgList.PreviewRowHeight = 56;
            this.dvgList.RowHeaderWidth = 20D;
            this.dvgList.RowHeight = 45;
            this.dvgList.Size = new System.Drawing.Size(1449, 784);
            this.dvgList.Style.AddNewRowStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dvgList.Style.BorderColor = System.Drawing.Color.White;
            this.dvgList.Style.DragPreviewRowStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dvgList.Style.DragPreviewRowStyle.RowCountIndicatorTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dvgList.Style.HeaderStyle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dvgList.TabIndex = 4;
            this.dvgList.Text = " ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(16, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(200, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmsMenu
            // 
            this.cmsMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edToolStripMenuItem});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(150, 46);
            // 
            // edToolStripMenuItem
            // 
            this.edToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("edToolStripMenuItem.Image")));
            this.edToolStripMenuItem.Name = "edToolStripMenuItem";
            this.edToolStripMenuItem.Size = new System.Drawing.Size(316, 42);
            this.edToolStripMenuItem.Text = "Edit";
            this.edToolStripMenuItem.Click += new System.EventHandler(this.edToolStripMenuItem_Click);
            // 
            // frmListApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 1118);
            this.ContextMenuStrip = this.cmsMenu;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFooter);
            this.Name = "frmListApplicationTypes";
            this.Text = "frmListApplicationTypes";
            this.Load += new System.EventHandler(this.frmListApplicationTypes_Load);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label lblRecordTitle;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlContent;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dvgList;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem edToolStripMenuItem;
    }
}