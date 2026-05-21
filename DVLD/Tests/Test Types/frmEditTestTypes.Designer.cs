namespace DVLD.Applications.Manage_Test_Types
{
    partial class frmEditTestTypes
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
            System.Windows.Forms.Label lblTestIdTitle;
            this.lblTestTypeIDValue = new System.Windows.Forms.Label();
            this.pnlConfirmPass = new System.Windows.Forms.Panel();
            this.txtTestTypeFees = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.txtTestTypeDescriptionValue = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblTestFeesTitle = new System.Windows.Forms.Label();
            this.lblTestTypesDescriptionTitle = new System.Windows.Forms.Label();
            this.lblfrmEditTestTypesHeader = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.btnSave = new Syncfusion.WinForms.Controls.SfButton();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTestTypeTitleValue = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label1 = new System.Windows.Forms.Label();
            lblTestIdTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtTestTypeFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTestTypeDescriptionValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTestTypeTitleValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTestIdTitle
            // 
            lblTestIdTitle.AutoSize = true;
            lblTestIdTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTestIdTitle.Location = new System.Drawing.Point(0, 145);
            lblTestIdTitle.Name = "lblTestIdTitle";
            lblTestIdTitle.Size = new System.Drawing.Size(113, 21);
            lblTestIdTitle.TabIndex = 54;
            lblTestIdTitle.Text = "Test Type ID : ";
            // 
            // lblTestTypeIDValue
            // 
            this.lblTestTypeIDValue.AutoSize = true;
            this.lblTestTypeIDValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestTypeIDValue.Location = new System.Drawing.Point(290, 145);
            this.lblTestTypeIDValue.Name = "lblTestTypeIDValue";
            this.lblTestTypeIDValue.Size = new System.Drawing.Size(28, 21);
            this.lblTestTypeIDValue.TabIndex = 60;
            this.lblTestTypeIDValue.Text = "00";
            // 
            // pnlConfirmPass
            // 
            this.pnlConfirmPass.BackColor = System.Drawing.Color.Blue;
            this.pnlConfirmPass.Location = new System.Drawing.Point(253, 409);
            this.pnlConfirmPass.Name = "pnlConfirmPass";
            this.pnlConfirmPass.Size = new System.Drawing.Size(168, 1);
            this.pnlConfirmPass.TabIndex = 59;
            // 
            // txtTestTypeFees
            // 
            this.txtTestTypeFees.BackColor = System.Drawing.Color.White;
            this.txtTestTypeFees.BeforeTouchSize = new System.Drawing.Size(168, 18);
            this.txtTestTypeFees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTestTypeFees.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestTypeFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTestTypeFees.Location = new System.Drawing.Point(252, 384);
            this.txtTestTypeFees.Name = "txtTestTypeFees";
            this.txtTestTypeFees.Size = new System.Drawing.Size(168, 18);
            this.txtTestTypeFees.TabIndex = 58;
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.Blue;
            this.pnlPassword.Location = new System.Drawing.Point(207, 356);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(491, 2);
            this.pnlPassword.TabIndex = 57;
            // 
            // txtTestTypeDescriptionValue
            // 
            this.txtTestTypeDescriptionValue.BackColor = System.Drawing.Color.White;
            this.txtTestTypeDescriptionValue.BeforeTouchSize = new System.Drawing.Size(168, 18);
            this.txtTestTypeDescriptionValue.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.txtTestTypeDescriptionValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTestTypeDescriptionValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestTypeDescriptionValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTestTypeDescriptionValue.Location = new System.Drawing.Point(206, 257);
            this.txtTestTypeDescriptionValue.Multiline = true;
            this.txtTestTypeDescriptionValue.Name = "txtTestTypeDescriptionValue";
            this.txtTestTypeDescriptionValue.Size = new System.Drawing.Size(492, 93);
            this.txtTestTypeDescriptionValue.TabIndex = 56;
            this.txtTestTypeDescriptionValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtTestTypeDescriptionValue_Validating);
            // 
            // lblTestFeesTitle
            // 
            this.lblTestFeesTitle.AutoSize = true;
            this.lblTestFeesTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestFeesTitle.Location = new System.Drawing.Point(12, 389);
            this.lblTestFeesTitle.Name = "lblTestFeesTitle";
            this.lblTestFeesTitle.Size = new System.Drawing.Size(55, 21);
            this.lblTestFeesTitle.TabIndex = 55;
            this.lblTestFeesTitle.Text = "Fees : ";
            // 
            // lblTestTypesDescriptionTitle
            // 
            this.lblTestTypesDescriptionTitle.AutoSize = true;
            this.lblTestTypesDescriptionTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestTypesDescriptionTitle.Location = new System.Drawing.Point(12, 269);
            this.lblTestTypesDescriptionTitle.Name = "lblTestTypesDescriptionTitle";
            this.lblTestTypesDescriptionTitle.Size = new System.Drawing.Size(184, 21);
            this.lblTestTypesDescriptionTitle.TabIndex = 53;
            this.lblTestTypesDescriptionTitle.Text = "Test Type Description : ";
            // 
            // lblfrmEditTestTypesHeader
            // 
            this.lblfrmEditTestTypesHeader.AutoSize = true;
            this.lblfrmEditTestTypesHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblfrmEditTestTypesHeader.ForeColor = System.Drawing.Color.DarkRed;
            this.lblfrmEditTestTypesHeader.Location = new System.Drawing.Point(228, 9);
            this.lblfrmEditTestTypesHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfrmEditTestTypesHeader.Name = "lblfrmEditTestTypesHeader";
            this.lblfrmEditTestTypesHeader.Size = new System.Drawing.Size(220, 32);
            this.lblfrmEditTestTypesHeader.TabIndex = 52;
            this.lblfrmEditTestTypesHeader.Text = "Update Test Types";
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
            this.btnClose.Location = new System.Drawing.Point(530, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 42);
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
            this.btnSave.Location = new System.Drawing.Point(662, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 42);
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
            this.pnlFooter.Location = new System.Drawing.Point(0, 497);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(800, 61);
            this.pnlFooter.TabIndex = 61;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(253, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 1);
            this.panel1.TabIndex = 64;
            // 
            // txtTestTypeTitleValue
            // 
            this.txtTestTypeTitleValue.BackColor = System.Drawing.Color.White;
            this.txtTestTypeTitleValue.BeforeTouchSize = new System.Drawing.Size(168, 18);
            this.txtTestTypeTitleValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTestTypeTitleValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestTypeTitleValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTestTypeTitleValue.Location = new System.Drawing.Point(252, 206);
            this.txtTestTypeTitleValue.Name = "txtTestTypeTitleValue";
            this.txtTestTypeTitleValue.Size = new System.Drawing.Size(168, 18);
            this.txtTestTypeTitleValue.TabIndex = 63;
            this.txtTestTypeTitleValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtTestTypeTitleValue_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 62;
            this.label1.Text = "Title : ";
            // 
            // frmEditTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTestTypeTitleValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTestTypeIDValue);
            this.Controls.Add(this.pnlConfirmPass);
            this.Controls.Add(this.txtTestTypeFees);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.txtTestTypeDescriptionValue);
            this.Controls.Add(this.lblTestFeesTitle);
            this.Controls.Add(lblTestIdTitle);
            this.Controls.Add(this.lblTestTypesDescriptionTitle);
            this.Controls.Add(this.lblfrmEditTestTypesHeader);
            this.Controls.Add(this.pnlFooter);
            this.Name = "frmEditTestTypes";
            this.Text = "frmEditManageTestTypes";
            this.Load += new System.EventHandler(this.frmEditTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTestTypeFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTestTypeDescriptionValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTestTypeTitleValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTestTypeIDValue;
        private System.Windows.Forms.Panel pnlConfirmPass;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTestTypeFees;
        private System.Windows.Forms.Panel pnlPassword;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTestTypeDescriptionValue;
        private System.Windows.Forms.Label lblTestFeesTitle;
        private System.Windows.Forms.Label lblTestTypesDescriptionTitle;
        private System.Windows.Forms.Label lblfrmEditTestTypesHeader;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pnlFooter;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private Syncfusion.WinForms.Controls.SfButton btnSave;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTestTypeTitleValue;
        private System.Windows.Forms.Label label1;
    }
}