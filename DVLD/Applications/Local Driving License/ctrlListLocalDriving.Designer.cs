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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlListLocalDriving));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbIsActiveFilter = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cmbFilter = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblFilterTitle = new System.Windows.Forms.Label();
            this.lblSearchTitle = new System.Windows.Forms.Label();
            this.txtSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbIsActiveFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            this.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(1171, 43);
            this.pnlHeader.TabIndex = 4;
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
            // 
            // ctrlListLocalDriving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlHeader);
            this.Name = "ctrlListLocalDriving";
            this.Size = new System.Drawing.Size(1171, 522);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbIsActiveFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.ListView.SfComboBox cbIsActiveFilter;
        private Syncfusion.WinForms.ListView.SfComboBox cmbFilter;
        private System.Windows.Forms.Label lblFilterTitle;
        private System.Windows.Forms.Label lblSearchTitle;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSearch;
    }
}
