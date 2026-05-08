namespace DVLD.Users
{
    partial class frmShowUserInfo
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
            this.pnlContent = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.ctrlUserInfoCard1 = new DVLD.Users.Control.ctrlUserInfoCard();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.ctrlUserInfoCard1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(685, 510);
            this.pnlContent.TabIndex = 0;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel1.Controls.Add(this.btnClose);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 507);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(685, 54);
            this.gradientPanel1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnClose.Location = new System.Drawing.Point(504, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(152, 37);
            this.btnClose.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlUserInfoCard1
            // 
            this.ctrlUserInfoCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlUserInfoCard1.Location = new System.Drawing.Point(0, 0);
            this.ctrlUserInfoCard1.Name = "ctrlUserInfoCard1";
            this.ctrlUserInfoCard1.Size = new System.Drawing.Size(685, 510);
            this.ctrlUserInfoCard1.TabIndex = 0;
            this.ctrlUserInfoCard1.Load += new System.EventHandler(this.ctrlUserInfoCard1_Load);
            // 
            // frmShowUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 561);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.pnlContent);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmShowUserInfo";
            this.Text = "frmShowUserInfo";
            this.Load += new System.EventHandler(this.frmShowUserInfo_Load);
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private Control.ctrlUserInfoCard ctrlUserInfoCard1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
    }
}