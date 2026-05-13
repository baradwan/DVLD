namespace DVLD.Applications.ApplicationTypes
{
    partial class frmEditApplicationTypes
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
            System.Windows.Forms.Label lblAppTypeIDTitle;
            this.lblfrmEditAppTypesHeader = new System.Windows.Forms.Label();
            this.pnlConfirmPass = new System.Windows.Forms.Panel();
            this.txtAppTypeFees = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.txtAppTypeTitle = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblAppTypeFeesTitle = new System.Windows.Forms.Label();
            this.lblAppTypeTitle01 = new System.Windows.Forms.Label();
            this.lblAppTypeIDValue = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.btnSave = new Syncfusion.WinForms.Controls.SfButton();
            this.pnlFooter = new System.Windows.Forms.Panel();
            lblAppTypeIDTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtAppTypeFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAppTypeTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblfrmEditAppTypesHeader
            // 
            this.lblfrmEditAppTypesHeader.AutoSize = true;
            this.lblfrmEditAppTypesHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblfrmEditAppTypesHeader.ForeColor = System.Drawing.Color.DarkRed;
            this.lblfrmEditAppTypesHeader.Location = new System.Drawing.Point(114, 55);
            this.lblfrmEditAppTypesHeader.Name = "lblfrmEditAppTypesHeader";
            this.lblfrmEditAppTypesHeader.Size = new System.Drawing.Size(611, 65);
            this.lblfrmEditAppTypesHeader.TabIndex = 0;
            this.lblfrmEditAppTypesHeader.Text = "Update Application Types";
            // 
            // pnlConfirmPass
            // 
            this.pnlConfirmPass.BackColor = System.Drawing.Color.Blue;
            this.pnlConfirmPass.Location = new System.Drawing.Point(482, 537);
            this.pnlConfirmPass.Margin = new System.Windows.Forms.Padding(6);
            this.pnlConfirmPass.Name = "pnlConfirmPass";
            this.pnlConfirmPass.Size = new System.Drawing.Size(336, 2);
            this.pnlConfirmPass.TabIndex = 49;
            // 
            // txtAppTypeFees
            // 
            this.txtAppTypeFees.BackColor = System.Drawing.Color.White;
            this.txtAppTypeFees.BeforeTouchSize = new System.Drawing.Size(336, 35);
            this.txtAppTypeFees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAppTypeFees.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppTypeFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAppTypeFees.Location = new System.Drawing.Point(480, 489);
            this.txtAppTypeFees.Margin = new System.Windows.Forms.Padding(6);
            this.txtAppTypeFees.Name = "txtAppTypeFees";
            this.txtAppTypeFees.Size = new System.Drawing.Size(336, 35);
            this.txtAppTypeFees.TabIndex = 48;
            this.txtAppTypeFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtAppTypeFees_Validating);
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.Blue;
            this.pnlPassword.Location = new System.Drawing.Point(391, 444);
            this.pnlPassword.Margin = new System.Windows.Forms.Padding(6);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(513, 2);
            this.pnlPassword.TabIndex = 47;
            // 
            // txtAppTypeTitle
            // 
            this.txtAppTypeTitle.BackColor = System.Drawing.Color.White;
            this.txtAppTypeTitle.BeforeTouchSize = new System.Drawing.Size(336, 35);
            this.txtAppTypeTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAppTypeTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppTypeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAppTypeTitle.Location = new System.Drawing.Point(384, 404);
            this.txtAppTypeTitle.Margin = new System.Windows.Forms.Padding(6);
            this.txtAppTypeTitle.Name = "txtAppTypeTitle";
            this.txtAppTypeTitle.Size = new System.Drawing.Size(518, 35);
            this.txtAppTypeTitle.TabIndex = 46;
            this.txtAppTypeTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtAppTypeTitle_Validating);
            // 
            // lblAppTypeFeesTitle
            // 
            this.lblAppTypeFeesTitle.AutoSize = true;
            this.lblAppTypeFeesTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTypeFeesTitle.Location = new System.Drawing.Point(0, 479);
            this.lblAppTypeFeesTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAppTypeFeesTitle.Name = "lblAppTypeFeesTitle";
            this.lblAppTypeFeesTitle.Size = new System.Drawing.Size(112, 45);
            this.lblAppTypeFeesTitle.TabIndex = 43;
            this.lblAppTypeFeesTitle.Text = "Fees : ";
            // 
            // lblAppTypeIDTitle
            // 
            lblAppTypeIDTitle.AutoSize = true;
            lblAppTypeIDTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAppTypeIDTitle.Location = new System.Drawing.Point(0, 306);
            lblAppTypeIDTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblAppTypeIDTitle.Name = "lblAppTypeIDTitle";
            lblAppTypeIDTitle.Size = new System.Drawing.Size(301, 45);
            lblAppTypeIDTitle.TabIndex = 42;
            lblAppTypeIDTitle.Text = "Application Type : ";
            // 
            // lblAppTypeTitle01
            // 
            this.lblAppTypeTitle01.AutoSize = true;
            this.lblAppTypeTitle01.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTypeTitle01.Location = new System.Drawing.Point(0, 396);
            this.lblAppTypeTitle01.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAppTypeTitle01.Name = "lblAppTypeTitle01";
            this.lblAppTypeTitle01.Size = new System.Drawing.Size(376, 45);
            this.lblAppTypeTitle01.TabIndex = 41;
            this.lblAppTypeTitle01.Text = "Application Type Title : ";
            // 
            // lblAppTypeIDValue
            // 
            this.lblAppTypeIDValue.AutoSize = true;
            this.lblAppTypeIDValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTypeIDValue.Location = new System.Drawing.Point(581, 306);
            this.lblAppTypeIDValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAppTypeIDValue.Name = "lblAppTypeIDValue";
            this.lblAppTypeIDValue.Size = new System.Drawing.Size(56, 45);
            this.lblAppTypeIDValue.TabIndex = 50;
            this.lblAppTypeIDValue.Text = "00";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(408, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(252, 81);
            this.btnClose.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.LightGray;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(672, 13);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(252, 81);
            this.btnSave.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 622);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(6);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(948, 117);
            this.pnlFooter.TabIndex = 51;
            // 
            // frmEditApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 739);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.lblAppTypeIDValue);
            this.Controls.Add(this.pnlConfirmPass);
            this.Controls.Add(this.txtAppTypeFees);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.txtAppTypeTitle);
            this.Controls.Add(this.lblAppTypeFeesTitle);
            this.Controls.Add(lblAppTypeIDTitle);
            this.Controls.Add(this.lblAppTypeTitle01);
            this.Controls.Add(this.lblfrmEditAppTypesHeader);
            this.Name = "frmEditApplicationTypes";
            this.Text = "frmEditApplicationTypes";
            this.Load += new System.EventHandler(this.frmEditApplicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAppTypeFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAppTypeTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfrmEditAppTypesHeader;
        private System.Windows.Forms.Panel pnlConfirmPass;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtAppTypeFees;
        private System.Windows.Forms.Panel pnlPassword;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtAppTypeTitle;
        private System.Windows.Forms.Label lblAppTypeFeesTitle;
        private System.Windows.Forms.Label lblAppTypeTitle01;
        private System.Windows.Forms.Label lblAppTypeIDValue;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pnlFooter;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private Syncfusion.WinForms.Controls.SfButton btnSave;
    }
}