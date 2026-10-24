namespace DVLD.Tests.Test_Appointment
{
    partial class frmScheduleTest
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
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlfooter = new System.Windows.Forms.Panel();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.btnSave = new Syncfusion.WinForms.Controls.SfButton();
            this.ctrlSchedule1 = new DVLD.Tests.Control.ctrlSchedule();
            this.pnlContainer.SuspendLayout();
            this.pnlfooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.pnlfooter);
            this.pnlContainer.Controls.Add(this.ctrlSchedule1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(725, 740);
            this.pnlContainer.TabIndex = 0;
            // 
            // pnlfooter
            // 
            this.pnlfooter.Controls.Add(this.btnClose);
            this.pnlfooter.Controls.Add(this.btnSave);
            this.pnlfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlfooter.Location = new System.Drawing.Point(0, 675);
            this.pnlfooter.Name = "pnlfooter";
            this.pnlfooter.Size = new System.Drawing.Size(725, 65);
            this.pnlfooter.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(447, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 42);
            this.btnClose.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.LightGray;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(588, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 42);
            this.btnSave.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlSchedule1
            // 
            this.ctrlSchedule1.Location = new System.Drawing.Point(3, 12);
            this.ctrlSchedule1.Name = "ctrlSchedule1";
            this.ctrlSchedule1.Size = new System.Drawing.Size(710, 657);
            this.ctrlSchedule1.TabIndex = 0;
            this.ctrlSchedule1.TestTypeID = DVLD_BusinessLayer.clsTestType.enTestType.VisionTest;
            // 
            // frmScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 740);
            this.Controls.Add(this.pnlContainer);
            this.Name = "frmScheduleTest";
            this.Text = "frmScheduleTest";
            this.Load += new System.EventHandler(this.frmScheduleTest_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlfooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private Control.ctrlSchedule ctrlSchedule1;
        private System.Windows.Forms.Panel pnlfooter;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private Syncfusion.WinForms.Controls.SfButton btnSave;
    }
}