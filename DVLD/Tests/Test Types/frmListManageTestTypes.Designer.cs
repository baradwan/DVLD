namespace DVLD.Applications.Manage_Test_Types
{
    partial class frmListManageTestTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListManageTestTypes));
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.lblRecordTitle = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.edToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.dvgList = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.pnlFooter.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsMenu.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Controls.Add(this.lblRecordCount);
            this.pnlFooter.Controls.Add(this.lblRecordTitle);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 495);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(742, 58);
            this.pnlFooter.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnClose.Location = new System.Drawing.Point(618, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 37);
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
            this.lblRecordCount.Location = new System.Drawing.Point(170, 15);
            this.lblRecordCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(39, 30);
            this.lblRecordCount.TabIndex = 1;
            this.lblRecordCount.Text = "00";
            // 
            // lblRecordTitle
            // 
            this.lblRecordTitle.AutoSize = true;
            this.lblRecordTitle.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRecordTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblRecordTitle.Location = new System.Drawing.Point(34, 15);
            this.lblRecordTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecordTitle.Name = "lblRecordTitle";
            this.lblRecordTitle.Size = new System.Drawing.Size(120, 30);
            this.lblRecordTitle.TabIndex = 0;
            this.lblRecordTitle.Text = "#Records :";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(742, 96);
            this.pnlHeader.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(230, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(304, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Manage Test Types";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(100, 96);
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
            this.cmsMenu.Size = new System.Drawing.Size(121, 42);
            // 
            // edToolStripMenuItem
            // 
            this.edToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("edToolStripMenuItem.Image")));
            this.edToolStripMenuItem.Name = "edToolStripMenuItem";
            this.edToolStripMenuItem.Size = new System.Drawing.Size(120, 38);
            this.edToolStripMenuItem.Text = "Edit";
            this.edToolStripMenuItem.Click += new System.EventHandler(this.edToolStripMenuItem_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.dvgList);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 96);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(742, 399);
            this.pnlContent.TabIndex = 7;
            // 
            // dvgList
            // 
            this.dvgList.AccessibleName = "Table";
            this.dvgList.AllowEditing = false;
            this.dvgList.AllowGrouping = false;
            this.dvgList.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.dvgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgList.HeaderRowHeight = 45;
            this.dvgList.Location = new System.Drawing.Point(0, 0);
            this.dvgList.Name = "dvgList";
            this.dvgList.Padding = new System.Windows.Forms.Padding(3);
            this.dvgList.PreviewRowHeight = 56;
            this.dvgList.RowHeaderWidth = 20D;
            this.dvgList.RowHeight = 45;
            this.dvgList.Size = new System.Drawing.Size(742, 399);
            this.dvgList.Style.AddNewRowStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dvgList.Style.BorderColor = System.Drawing.Color.White;
            this.dvgList.Style.DragPreviewRowStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dvgList.Style.DragPreviewRowStyle.RowCountIndicatorTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dvgList.Style.HeaderStyle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dvgList.TabIndex = 5;
            this.dvgList.Text = " ";
            // 
            // frmListManageTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 553);
            this.ContextMenuStrip = this.cmsMenu;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmListManageTestTypes";
            this.Text = "frmListManageTestTypes";
            this.Load += new System.EventHandler(this.frmListManageTestTypes_Load);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsMenu.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlFooter;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label lblRecordTitle;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem edToolStripMenuItem;
        private System.Windows.Forms.Panel pnlContent;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dvgList;
    }
}