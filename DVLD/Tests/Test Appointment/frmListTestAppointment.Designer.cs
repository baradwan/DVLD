namespace DVLD.Tests.Test_Appointment
{
    partial class frmListTestAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListTestAppointment));
            this.pnlDrivingLicenseInfo = new System.Windows.Forms.Panel();
            this.ctrlDrivingLicenseInfo1 = new DVLD.Applications.Local_Driving_License.Control.ctrlDrivingLicenseInfo();
            this.pnlAppInfo = new System.Windows.Forms.Panel();
            this.ctrlAppBasicInfo1 = new DVLD.Applications.ctrlAppBasicInfo();
            this.pnlListAppointments = new System.Windows.Forms.Panel();
            this.dvgList = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNewAppointment = new System.Windows.Forms.Button();
            this.lblAppointments = new System.Windows.Forms.Label();
            this.pbTestPic = new System.Windows.Forms.PictureBox();
            this.lblTitleOfTest = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.lblRecordValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlDrivingLicenseInfo.SuspendLayout();
            this.pnlAppInfo.SuspendLayout();
            this.pnlListAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgList)).BeginInit();
            this.cmsApplications.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestPic)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDrivingLicenseInfo
            // 
            this.pnlDrivingLicenseInfo.Controls.Add(this.ctrlDrivingLicenseInfo1);
            this.pnlDrivingLicenseInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDrivingLicenseInfo.Location = new System.Drawing.Point(0, 134);
            this.pnlDrivingLicenseInfo.Name = "pnlDrivingLicenseInfo";
            this.pnlDrivingLicenseInfo.Size = new System.Drawing.Size(928, 221);
            this.pnlDrivingLicenseInfo.TabIndex = 3;
            // 
            // ctrlDrivingLicenseInfo1
            // 
            this.ctrlDrivingLicenseInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlDrivingLicenseInfo1.Location = new System.Drawing.Point(0, 0);
            this.ctrlDrivingLicenseInfo1.Name = "ctrlDrivingLicenseInfo1";
            this.ctrlDrivingLicenseInfo1.Size = new System.Drawing.Size(928, 221);
            this.ctrlDrivingLicenseInfo1.TabIndex = 0;
            this.ctrlDrivingLicenseInfo1.Load += new System.EventHandler(this.ctrlDrivingLicenseInfo1_Load);
            // 
            // pnlAppInfo
            // 
            this.pnlAppInfo.Controls.Add(this.ctrlAppBasicInfo1);
            this.pnlAppInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAppInfo.Location = new System.Drawing.Point(0, 355);
            this.pnlAppInfo.Name = "pnlAppInfo";
            this.pnlAppInfo.Size = new System.Drawing.Size(928, 229);
            this.pnlAppInfo.TabIndex = 4;
            // 
            // ctrlAppBasicInfo1
            // 
            this.ctrlAppBasicInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlAppBasicInfo1.Location = new System.Drawing.Point(0, 0);
            this.ctrlAppBasicInfo1.Name = "ctrlAppBasicInfo1";
            this.ctrlAppBasicInfo1.Size = new System.Drawing.Size(928, 229);
            this.ctrlAppBasicInfo1.TabIndex = 0;
            this.ctrlAppBasicInfo1.Load += new System.EventHandler(this.ctrlAppBasicInfo1_Load);
            // 
            // pnlListAppointments
            // 
            this.pnlListAppointments.Controls.Add(this.dvgList);
            this.pnlListAppointments.Controls.Add(this.panel1);
            this.pnlListAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListAppointments.Location = new System.Drawing.Point(0, 584);
            this.pnlListAppointments.Name = "pnlListAppointments";
            this.pnlListAppointments.Size = new System.Drawing.Size(928, 258);
            this.pnlListAppointments.TabIndex = 5;
            // 
            // dvgList
            // 
            this.dvgList.AccessibleName = "Table";
            this.dvgList.AllowEditing = false;
            this.dvgList.AllowGrouping = false;
            this.dvgList.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.dvgList.ContextMenuStrip = this.cmsApplications;
            this.dvgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgList.HeaderRowHeight = 45;
            this.dvgList.Location = new System.Drawing.Point(0, 39);
            this.dvgList.Name = "dvgList";
            this.dvgList.PreviewRowHeight = 56;
            this.dvgList.RowHeaderWidth = 20D;
            this.dvgList.RowHeight = 45;
            this.dvgList.Size = new System.Drawing.Size(928, 219);
            this.dvgList.Style.AddNewRowStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dvgList.Style.BorderColor = System.Drawing.Color.White;
            this.dvgList.Style.DragPreviewRowStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dvgList.Style.DragPreviewRowStyle.RowCountIndicatorTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dvgList.Style.HeaderStyle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dvgList.TabIndex = 5;
            this.dvgList.Text = " ";
            // 
            // cmsApplications
            // 
            this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.cmsApplications.Name = "contextMenuStrip1";
            this.cmsApplications.Size = new System.Drawing.Size(152, 76);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(151, 36);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("takeTestToolStripMenuItem.Image")));
            this.takeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(151, 36);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAddNewAppointment);
            this.panel1.Controls.Add(this.lblAppointments);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 39);
            this.panel1.TabIndex = 1;
            // 
            // btnAddNewAppointment
            // 
            this.btnAddNewAppointment.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewAppointment.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewAppointment.Image")));
            this.btnAddNewAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewAppointment.Location = new System.Drawing.Point(794, 0);
            this.btnAddNewAppointment.Name = "btnAddNewAppointment";
            this.btnAddNewAppointment.Size = new System.Drawing.Size(122, 39);
            this.btnAddNewAppointment.TabIndex = 1;
            this.btnAddNewAppointment.Text = "  Add New";
            this.btnAddNewAppointment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewAppointment.UseVisualStyleBackColor = true;
            this.btnAddNewAppointment.Click += new System.EventHandler(this.btnAddNewAppointment_Click);
            // 
            // lblAppointments
            // 
            this.lblAppointments.AutoSize = true;
            this.lblAppointments.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointments.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAppointments.Location = new System.Drawing.Point(19, 0);
            this.lblAppointments.Name = "lblAppointments";
            this.lblAppointments.Size = new System.Drawing.Size(144, 25);
            this.lblAppointments.TabIndex = 0;
            this.lblAppointments.Text = "Appointments : ";
            // 
            // pbTestPic
            // 
            this.pbTestPic.BackColor = System.Drawing.Color.Transparent;
            this.pbTestPic.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbTestPic.Image = ((System.Drawing.Image)(resources.GetObject("pbTestPic.Image")));
            this.pbTestPic.Location = new System.Drawing.Point(0, 0);
            this.pbTestPic.Name = "pbTestPic";
            this.pbTestPic.Size = new System.Drawing.Size(181, 134);
            this.pbTestPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTestPic.TabIndex = 0;
            this.pbTestPic.TabStop = false;
            // 
            // lblTitleOfTest
            // 
            this.lblTitleOfTest.AutoSize = true;
            this.lblTitleOfTest.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleOfTest.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTitleOfTest.Location = new System.Drawing.Point(372, 43);
            this.lblTitleOfTest.Name = "lblTitleOfTest";
            this.lblTitleOfTest.Size = new System.Drawing.Size(196, 47);
            this.lblTitleOfTest.TabIndex = 1;
            this.lblTitleOfTest.Text = "Vision Test";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTitleOfTest);
            this.pnlHeader.Controls.Add(this.pbTestPic);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(928, 134);
            this.pnlHeader.TabIndex = 2;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Controls.Add(this.lblRecordValue);
            this.pnlFooter.Controls.Add(this.label3);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 842);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(928, 51);
            this.pnlFooter.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnClose.Location = new System.Drawing.Point(804, 3);
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
            // frmListTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 893);
            this.Controls.Add(this.pnlListAppointments);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlAppInfo);
            this.Controls.Add(this.pnlDrivingLicenseInfo);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmListTestAppointment";
            this.Text = "frmListTestAppointment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmListTestAppointment_FormClosed);
            this.Load += new System.EventHandler(this.frmListTestAppointment_Load);
            this.pnlDrivingLicenseInfo.ResumeLayout(false);
            this.pnlAppInfo.ResumeLayout(false);
            this.pnlListAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgList)).EndInit();
            this.cmsApplications.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestPic)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlDrivingLicenseInfo;
        private System.Windows.Forms.Panel pnlAppInfo;
        private Applications.Local_Driving_License.Control.ctrlDrivingLicenseInfo ctrlDrivingLicenseInfo1;
        private Applications.ctrlAppBasicInfo ctrlAppBasicInfo1;
        private System.Windows.Forms.Panel pnlListAppointments;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAppointments;
        private System.Windows.Forms.Button btnAddNewAppointment;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dvgList;
        private System.Windows.Forms.PictureBox pbTestPic;
        private System.Windows.Forms.Label lblTitleOfTest;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlFooter;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private System.Windows.Forms.Label lblRecordValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}