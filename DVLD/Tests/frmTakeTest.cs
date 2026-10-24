using DVLD_BusinessLayer;
using DVLD_Global.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Tests
{
    public partial class frmTakeTest : Form
    {
        private int _testAppointmentID = -1;
        private clsTestType.enTestType _testTypeID;
        private int _TestID = -1;
        private clsTest _Test;
        public frmTakeTest(int testAppointmentID, clsTestType.enTestType testTypeID)
        {
            InitializeComponent();
            _testAppointmentID = testAppointmentID;
            _testTypeID = testTypeID;
        }

        private void _LoadTakeTest() {


            if (_TestID == -1)
            {
                _Test = new clsTest();
                btnSave.Enabled = true;
                return;
            }

            _Test = clsTest.Find(_TestID);

            if (_Test == null)
            {
                MessageBox.Show("Test not found.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnSave.Enabled = false;
                pnlTakeTest.Enabled = false;
                return;
            }

            if (_Test.TestResult)
                rbPass.Checked = true;
            else
                rbFail.Checked = true;
            txtNotes.Text = _Test.Notes;
            pnlWarning.Visible = true;
             lblUserMessage.Visible = true;
            pnlTakeTest.Enabled = false;

            btnSave.Enabled = false;
        }
        private void frmTakeTest_Load(object sender, EventArgs e)
        {

            ctrlScheduledTest1.TestTypeID = _testTypeID;
            ctrlScheduledTest1.LoadInfo(_testAppointmentID);
            _TestID = ctrlScheduledTest1.TestID;
            _LoadTakeTest();
        }

        private bool _Save() {

            if (_TestID != -1)
                return false;

            _Test.TestAppointmentID = _testAppointmentID;
            _Test.TestResult = rbPass.Checked;
            _Test.Notes = txtNotes.Text.Trim();
            _Test.CreatedByUserID = clsCurrentUser.User.userID;

            if (!_Test.Save())
                return false;

            _TestID = _Test.TestID;
            clsTestEvents.NotifyTestSaved(ctrlScheduledTest1.LocalDrivingLicenseAppID);
                
            return true;

            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save?.",
                        "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            if (_Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctrlScheduledTest1.UpdateTestID(_TestID);
                pnlTakeTest.Enabled = false;
                btnSave.Enabled = false;

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
