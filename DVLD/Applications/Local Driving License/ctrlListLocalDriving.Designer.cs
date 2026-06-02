namespace DVLD.Applications.Local_Driving_License
{
    partial class ctrlListLocalDriving
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlListLocalDriving));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.cbStatusFilter = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cmbFilter = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblFilterTitle = new System.Windows.Forms.Label();
            this.lblSearchTitle = new System.Windows.Forms.Label();
            this.txtSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.dvgList = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatusFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblStatusTitle);
            this.pnlHeader.Controls.Add(this.cbStatusFilter);
            this.pnlHeader.Controls.Add(this.cmbFilter);
            this.pnlHeader.Controls.Add(this.lblFilterTitle);
            this.pnlHeader.Controls.Add(this.lblSearchTitle);
            this.pnlHeader.Controls.Add(this.txtSearch);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.pnlHeader.Size = new System.Drawing.Size(1217, 43);
            this.pnlHeader.TabIndex = 4;
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold);
            this.lblStatusTitle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblStatusTitle.Location = new System.Drawing.Point(991, 4);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(98, 31);
            this.lblStatusTitle.TabIndex = 7;
            this.lblStatusTitle.Text = "Status : ";
            // 
            // cbStatusFilter
            // 
            this.cbStatusFilter.AllowDropDownResize = false;
            this.cbStatusFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbStatusFilter.BackColor = System.Drawing.Color.Gainsboro;
            this.cbStatusFilter.CausesValidation = false;
            this.cbStatusFilter.DisplayMember = "";
            this.cbStatusFilter.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cbStatusFilter.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.cbStatusFilter.ForeColor = System.Drawing.Color.Black;
            this.cbStatusFilter.Location = new System.Drawing.Point(1096, 9);
            this.cbStatusFilter.Name = "cbStatusFilter";
            this.cbStatusFilter.Size = new System.Drawing.Size(108, 26);
            this.cbStatusFilter.Style.DropDownButtonStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbStatusFilter.Style.DropDownButtonStyle.FocusedBackColor = System.Drawing.Color.Transparent;
            this.cbStatusFilter.Style.DropDownButtonStyle.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbStatusFilter.Style.DropDownButtonStyle.ImageForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbStatusFilter.Style.DropDownButtonStyle.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbStatusFilter.Style.DropDownStyle.BorderColor = System.Drawing.Color.LightGray;
            this.cbStatusFilter.Style.EditorStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.cbStatusFilter.Style.EditorStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.cbStatusFilter.Style.EditorStyle.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.cbStatusFilter.Style.EditorStyle.ForeColor = System.Drawing.Color.Black;
            this.cbStatusFilter.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.cbStatusFilter.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbStatusFilter.Style.TokenStyle.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.cbStatusFilter.TabIndex = 6;
            this.cbStatusFilter.TabStop = false;
            this.cbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cbStatusFilter_SelectedIndexChanged);
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
            // txtSearch
            // 
            this.txtSearch.AccessibleDescription = "";
            this.txtSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "Email"});
            this.txtSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSearch.BeforeTouchSize = new System.Drawing.Size(374, 33);
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
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.dvgList);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 43);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1217, 479);
            this.pnlContent.TabIndex = 5;
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
            this.dvgList.PreviewRowHeight = 56;
            this.dvgList.RowHeaderWidth = 20D;
            this.dvgList.RowHeight = 45;
            this.dvgList.Size = new System.Drawing.Size(1217, 479);
            this.dvgList.Style.AddNewRowStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dvgList.Style.BorderColor = System.Drawing.Color.White;
            this.dvgList.Style.DragPreviewRowStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dvgList.Style.DragPreviewRowStyle.RowCountIndicatorTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dvgList.Style.HeaderStyle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dvgList.TabIndex = 4;
            this.dvgList.Text = " ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlListLocalDriving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Name = "ctrlListLocalDriving";
            this.Size = new System.Drawing.Size(1217, 522);
            this.Load += new System.EventHandler(this.ctrlListLocalDriving_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatusFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cmbFilter;
        private System.Windows.Forms.Label lblFilterTitle;
        private System.Windows.Forms.Label lblSearchTitle;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSearch;
        private System.Windows.Forms.Panel pnlContent;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dvgList;
        private System.Windows.Forms.Label lblStatusTitle;
        private Syncfusion.WinForms.ListView.SfComboBox cbStatusFilter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
