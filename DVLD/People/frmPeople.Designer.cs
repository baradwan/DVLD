using Syncfusion.Windows.Forms.Tools;

namespace DVLD
{
    partial class frmPeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeople));
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo2 = new Syncfusion.Windows.Forms.BannerTextInfo();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPeopleAddPerson = new Syncfusion.WinForms.Controls.SfButton();
            this.lblTitlePeople = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.dvgListPeople = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPeopleAddPerson);
            this.panel1.Controls.Add(this.lblTitlePeople);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1374, 80);
            this.panel1.TabIndex = 0;
            // 
            // btnPeopleAddPerson
            // 
            this.btnPeopleAddPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPeopleAddPerson.AutoEllipsis = true;
            this.btnPeopleAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeopleAddPerson.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.btnPeopleAddPerson.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPeopleAddPerson.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPeopleAddPerson.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPeopleAddPerson.Location = new System.Drawing.Point(1153, 18);
            this.btnPeopleAddPerson.Name = "btnPeopleAddPerson";
            this.btnPeopleAddPerson.Size = new System.Drawing.Size(174, 45);
            this.btnPeopleAddPerson.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(150)))), ((int)(((byte)(249)))));
            this.btnPeopleAddPerson.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(150)))), ((int)(((byte)(249)))));
            this.btnPeopleAddPerson.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnPeopleAddPerson.Style.ForeColor = System.Drawing.Color.White;
            this.btnPeopleAddPerson.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnPeopleAddPerson.TabIndex = 2;
            this.btnPeopleAddPerson.Text = "Add Person";
            this.btnPeopleAddPerson.Click += new System.EventHandler(this.btnPeopleAddPerson_Click);
            // 
            // lblTitlePeople
            // 
            this.lblTitlePeople.AutoSize = true;
            this.lblTitlePeople.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePeople.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitlePeople.Location = new System.Drawing.Point(132, 9);
            this.lblTitlePeople.Name = "lblTitlePeople";
            this.lblTitlePeople.Size = new System.Drawing.Size(252, 45);
            this.lblTitlePeople.TabIndex = 1;
            this.lblTitlePeople.Text = "Manage People";
            this.lblTitlePeople.Click += new System.EventHandler(this.lblTitlePeople_Click);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.panel2.Size = new System.Drawing.Size(1374, 43);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search : ";
            // 
            // txtSearch
            // 
            this.txtSearch.AccessibleDescription = "";
            this.txtSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "Email"});
            this.txtSearch.BackColor = System.Drawing.Color.Gainsboro;
            bannerTextInfo2.Color = System.Drawing.SystemColors.ControlDarkDark;
            bannerTextInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bannerTextInfo2.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode;
            bannerTextInfo2.Text = " Search by PersonID, NationalNo,Email,...";
            bannerTextInfo2.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtSearch, bannerTextInfo2);
            this.txtSearch.BeforeTouchSize = new System.Drawing.Size(374, 33);
            this.txtSearch.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.CausesValidation = false;
            this.txtSearch.CornerRadius = 6;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSearch.FarImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.FarImage")));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(140, 10);
            this.txtSearch.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtSearch.MinimumSize = new System.Drawing.Size(16, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(374, 33);
            this.txtSearch.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.txtSearch.TabIndex = 0;
            this.txtSearch.ThemeName = "Metro";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dvgListPeople
            // 
            this.dvgListPeople.AccessibleName = "Table";
            this.dvgListPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgListPeople.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.dvgListPeople.HeaderRowHeight = 45;
            this.dvgListPeople.Location = new System.Drawing.Point(0, 123);
            this.dvgListPeople.Name = "dvgListPeople";
            this.dvgListPeople.PreviewRowHeight = 56;
            this.dvgListPeople.RowHeaderWidth = 20D;
            this.dvgListPeople.RowHeight = 45;
            this.dvgListPeople.Size = new System.Drawing.Size(1384, 809);
            this.dvgListPeople.Style.AddNewRowStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dvgListPeople.Style.BorderColor = System.Drawing.Color.White;
            this.dvgListPeople.Style.DragPreviewRowStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dvgListPeople.Style.DragPreviewRowStyle.RowCountIndicatorTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dvgListPeople.Style.HeaderStyle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dvgListPeople.TabIndex = 2;
            this.dvgListPeople.Text = " ";
            this.dvgListPeople.Click += new System.EventHandler(this.sfDataGrid1_Click);
            // 
            // frmPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 923);
            this.Controls.Add(this.dvgListPeople);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmPeople";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListPeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Syncfusion.WinForms.Controls.SfButton btnPeopleAddPerson;
        private System.Windows.Forms.Label lblTitlePeople;
        private System.Windows.Forms.Panel panel2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSearch;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dvgListPeople;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
    }
}

