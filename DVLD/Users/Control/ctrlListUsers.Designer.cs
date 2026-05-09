namespace DVLD.Users.Control
{
    partial class ctrlListUsers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlListUsers));
            this.cmbFilter = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblFilterTitle = new System.Windows.Forms.Label();
            this.lblSearchTitle = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbIsActiveFilter = new Syncfusion.WinForms.ListView.SfComboBox();
            this.txtSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dvgList = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.cmsUsers = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswordtoolstripitem1 = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFilter)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbIsActiveFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgList)).BeginInit();
            this.cmsUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbFilter
            // 
            this.cmbFilter.AllowDropDownResize = false;
            this.cmbFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFilter.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbFilter.DisplayMember = "";
            this.cmbFilter.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbFilter.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.cmbFilter.ForeColor = System.Drawing.Color.Black;
            this.cmbFilter.Location = new System.Drawing.Point(705, 6);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(226, 26);
            this.cmbFilter.Style.DropDownButtonStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmbFilter.Style.DropDownButtonStyle.FocusedBackColor = System.Drawing.Color.Transparent;
            this.cmbFilter.Style.DropDownButtonStyle.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmbFilter.Style.DropDownButtonStyle.ImageForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmbFilter.Style.DropDownButtonStyle.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmbFilter.Style.DropDownStyle.BorderColor = System.Drawing.Color.LightGray;
            this.cmbFilter.Style.EditorStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbFilter.Style.EditorStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.cmbFilter.Style.EditorStyle.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.cmbFilter.Style.EditorStyle.ForeColor = System.Drawing.Color.Black;
            this.cmbFilter.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.cmbFilter.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbFilter.Style.TokenStyle.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.cmbFilter.TabIndex = 3;
            this.cmbFilter.TabStop = false;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // lblFilterTitle
            // 
            this.lblFilterTitle.AutoSize = true;
            this.lblFilterTitle.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold);
            this.lblFilterTitle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblFilterTitle.Location = new System.Drawing.Point(542, 1);
            this.lblFilterTitle.Name = "lblFilterTitle";
            this.lblFilterTitle.Size = new System.Drawing.Size(114, 31);
            this.lblFilterTitle.TabIndex = 2;
            this.lblFilterTitle.Text = "Filter by :";
            // 
            // lblSearchTitle
            // 
            this.lblSearchTitle.AutoSize = true;
            this.lblSearchTitle.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold);
            this.lblSearchTitle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSearchTitle.Location = new System.Drawing.Point(13, 1);
            this.lblSearchTitle.Name = "lblSearchTitle";
            this.lblSearchTitle.Size = new System.Drawing.Size(103, 31);
            this.lblSearchTitle.TabIndex = 1;
            this.lblSearchTitle.Text = "Search : ";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.cbIsActiveFilter);
            this.pnlHeader.Controls.Add(this.cmbFilter);
            this.pnlHeader.Controls.Add(this.lblFilterTitle);
            this.pnlHeader.Controls.Add(this.lblSearchTitle);
            this.pnlHeader.Controls.Add(this.txtSearch);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.pnlHeader.Size = new System.Drawing.Size(1247, 43);
            this.pnlHeader.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(983, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Active : ";
            // 
            // cbIsActiveFilter
            // 
            this.cbIsActiveFilter.AllowDropDownResize = false;
            this.cbIsActiveFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbIsActiveFilter.BackColor = System.Drawing.Color.Gainsboro;
            this.cbIsActiveFilter.CausesValidation = false;
            this.cbIsActiveFilter.DisplayMember = "";
            this.cbIsActiveFilter.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cbIsActiveFilter.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.cbIsActiveFilter.ForeColor = System.Drawing.Color.Black;
            this.cbIsActiveFilter.Location = new System.Drawing.Point(1083, 6);
            this.cbIsActiveFilter.Name = "cbIsActiveFilter";
            this.cbIsActiveFilter.Size = new System.Drawing.Size(86, 26);
            this.cbIsActiveFilter.Style.DropDownButtonStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbIsActiveFilter.Style.DropDownButtonStyle.FocusedBackColor = System.Drawing.Color.Transparent;
            this.cbIsActiveFilter.Style.DropDownButtonStyle.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbIsActiveFilter.Style.DropDownButtonStyle.ImageForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbIsActiveFilter.Style.DropDownButtonStyle.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbIsActiveFilter.Style.DropDownStyle.BorderColor = System.Drawing.Color.LightGray;
            this.cbIsActiveFilter.Style.EditorStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.cbIsActiveFilter.Style.EditorStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.cbIsActiveFilter.Style.EditorStyle.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.cbIsActiveFilter.Style.EditorStyle.ForeColor = System.Drawing.Color.Black;
            this.cbIsActiveFilter.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.cbIsActiveFilter.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbIsActiveFilter.Style.TokenStyle.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.cbIsActiveFilter.TabIndex = 4;
            this.cbIsActiveFilter.TabStop = false;
            this.cbIsActiveFilter.SelectedIndexChanged += new System.EventHandler(this.cbIsActiveFilter_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.AccessibleDescription = "";
            this.txtSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "Email"});
            this.txtSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSearch.BeforeTouchSize = new System.Drawing.Size(100, 18);
            this.txtSearch.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.CausesValidation = false;
            this.txtSearch.CornerRadius = 6;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSearch.FarImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.FarImage")));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(140, 4);
            this.txtSearch.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtSearch.MinimumSize = new System.Drawing.Size(16, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(374, 33);
            this.txtSearch.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.txtSearch.TabIndex = 0;
            this.txtSearch.ThemeName = "Metro";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dvgList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 597);
            this.panel1.TabIndex = 4;
            // 
            // dvgList
            // 
            this.dvgList.AccessibleName = "Table";
            this.dvgList.AllowEditing = false;
            this.dvgList.AllowGrouping = false;
            this.dvgList.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.dvgList.ContextMenuStrip = this.cmsUsers;
            this.dvgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgList.HeaderRowHeight = 45;
            this.dvgList.Location = new System.Drawing.Point(0, 0);
            this.dvgList.Name = "dvgList";
            this.dvgList.PreviewRowHeight = 56;
            this.dvgList.RowHeaderWidth = 20D;
            this.dvgList.RowHeight = 45;
            this.dvgList.Size = new System.Drawing.Size(1247, 597);
            this.dvgList.Style.AddNewRowStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dvgList.Style.BorderColor = System.Drawing.Color.White;
            this.dvgList.Style.DragPreviewRowStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dvgList.Style.DragPreviewRowStyle.RowCountIndicatorTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dvgList.Style.HeaderStyle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dvgList.TabIndex = 3;
            this.dvgList.Text = " ";
            // 
            // cmsUsers
            // 
            this.cmsUsers.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.AddNewUserToolStripMenuItem1,
            this.toolStripSeparator1,
            this.deleteToolStripMenuItem,
            this.editToolStripMenuItem,
            this.ChangePasswordtoolstripitem1,
            this.toolStripSeparator2,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem,
            this.toolStripMenuItem4,
            this.toolStripMenuItem9});
            this.cmsUsers.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.cmsUsers.Name = "contextMenuStripEx1";
            this.cmsUsers.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmsUsers.Size = new System.Drawing.Size(214, 380);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.ShowDetailes;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(213, 38);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // AddNewUserToolStripMenuItem1
            // 
            this.AddNewUserToolStripMenuItem1.Image = global::DVLD.Properties.Resources.icons8_add_administrator_50;
            this.AddNewUserToolStripMenuItem1.Name = "AddNewUserToolStripMenuItem1";
            this.AddNewUserToolStripMenuItem1.Size = new System.Drawing.Size(213, 38);
            this.AddNewUserToolStripMenuItem1.Text = "Add New User";
            this.AddNewUserToolStripMenuItem1.Click += new System.EventHandler(this.AddNewUserToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DVLD.Properties.Resources.delete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(213, 38);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD.Properties.Resources.people__2_;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(213, 38);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // ChangePasswordtoolstripitem1
            // 
            this.ChangePasswordtoolstripitem1.Name = "ChangePasswordtoolstripitem1";
            this.ChangePasswordtoolstripitem1.Size = new System.Drawing.Size(213, 38);
            this.ChangePasswordtoolstripitem1.Text = " Change Password";
            this.ChangePasswordtoolstripitem1.Click += new System.EventHandler(this.ChangePasswordtoolstripitem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(210, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::DVLD.Properties.Resources.mail;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(213, 38);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = global::DVLD.Properties.Resources.call;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(213, 38);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(213, 38);
            this.toolStripMenuItem4.Text = " ";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(213, 38);
            this.toolStripMenuItem9.Text = " ";
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
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Image = global::DVLD.Properties.Resources.icons8_add_administrator_50;
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(297, 42);
            this.addNewPersonToolStripMenuItem.Text = "Add New Person";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::DVLD.Properties.Resources.ShowDetailes;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(297, 42);
            this.toolStripMenuItem2.Text = "Show Details";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(297, 42);
            this.toolStripMenuItem3.Text = " ";
            // 
            // ctrlListUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.Name = "ctrlListUsers";
            this.Size = new System.Drawing.Size(1247, 640);
            this.Load += new System.EventHandler(this.crtlListUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbFilter)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbIsActiveFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgList)).EndInit();
            this.cmsUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.ListView.SfComboBox cmbFilter;
        private System.Windows.Forms.Label lblFilterTitle;
        private System.Windows.Forms.Label lblSearchTitle;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSearch;
        private System.Windows.Forms.Panel pnlHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cbIsActiveFilter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dvgList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx cmsUsers;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewUserToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private Syncfusion.Windows.Forms.Tools.toolstripitem ChangePasswordtoolstripitem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
    }
}
