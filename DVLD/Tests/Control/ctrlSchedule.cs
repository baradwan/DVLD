using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace DVLD.Tests.Control
{
    public partial class ctrlSchedule : UserControl
    {
        public event EventHandler CanSaveChanged;

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode = enMode.AddNew;
        public enum enCreationMode { FirstTimeSchedule = 0, RetakeTestSchedule = 1 };
        private enCreationMode _CreationMode = enCreationMode.FirstTimeSchedule;
        private clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest;
        private bool _CanSave = false;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApp;
        private int _LocalDrivingLicenseAppID = -1;

        private clsTestAppointment _TestAppointment;
        private int _TestAppointmentID = -1;

        public bool CanSave
        {
            get { return _CanSave; }
        }

        private void _SetCanSave(bool value)
        {
            if (_CanSave == value)
                return;

            _CanSave = value;
            CanSaveChanged?.Invoke(this, EventArgs.Empty);
        }
        private void _UpdateTestTypeUI()
        {
            switch (_TestTypeID)
            {
                case clsTestType.enTestType.VisionTest:
                    lblTitleOfTest.Text = "Vision Test";
                    pbTestPic.Image = Properties.Resources.VisionTest;
                    break;
                case clsTestType.enTestType.WrittenTest:
                    lblTitleOfTest.Text = "Written Test";
                    pbTestPic.Image = Properties.Resources.WrittenTest;
                    break;
                case clsTestType.enTestType.StreetTest:
                    lblTitleOfTest.Text = "Street Test";
                    pbTestPic.Image = Properties.Resources.StreetTest;
                    break;
               
                default:
                    lblTitleOfTest.Text = "Unknown Test Type";
                    break;
            }
        }
        public clsTestType.enTestType TestTypeID
        {
            get { return _TestTypeID; }
            set
            {
                _TestTypeID = value;
                _UpdateTestTypeUI();
            }
        }

        private void _SetDefaultDateTimePickerValue()
        {
            DateTime tomorrow = DateTime.Today.AddDays(1);

            dateTimePicker1.MinDate = tomorrow;
            dateTimePicker1.MaxDate = DateTime.Today.AddDays(120);
            dateTimePicker1.Value = tomorrow;
        }

        private void _ShowWarning(string message)
        {
            pnlWarning.Visible = true;
            lblSubTitleWarning.Text = message;
            dateTimePicker1.Enabled = false;

        }

        private void _ResetWarningUI()
        {
            pnlWarning.Visible = false;
            lblSubTitleWarning.Text = string.Empty;
            dateTimePicker1.Enabled = true;
        }

        private clsApplicationType _GetRetakeApplicationType()
        {
            return clsApplicationType.Find((int)clsApplicationType.enApplicationType.RetakeTest);
        }

        private bool _LoadLocalDrivingLicenseApp()
        {
            _LocalDrivingLicenseApp =clsLocalDrivingLicenseApplication.Find(_LocalDrivingLicenseAppID);

            if (_LocalDrivingLicenseApp == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID = " + _LocalDrivingLicenseAppID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            lblDrivingLicenseAppID.Text = _LocalDrivingLicenseApp.LocalDrivingLicenseApplicationID.ToString();
            lblDrivingClass.Text= clsLicenseClass.Find(_LocalDrivingLicenseApp.LicenseClassID).ClassName;
            lblName.Text=_LocalDrivingLicenseApp.Application.PersonName;
            lblTrial.Text = _LocalDrivingLicenseApp.TotalTrialsPerTest(_TestTypeID).ToString();
            return true;
        }

        private bool _LoadTestAppointment()
        {
            _TestAppointment = clsTestAppointment.Find(_TestAppointmentID);

            if (_TestAppointment == null)
            {
                MessageBox.Show(
                    $"Appointment with ID {_TestAppointmentID} was not found.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

               
                return false;
            }
           

            // Load saved test fees
            lblFees.Text = _TestAppointment.PaidFees.ToString();

            // Load saved appointment date
            DateTime appointmentDate = _TestAppointment.AppointmentDate;
            dateTimePicker1.MinDate = appointmentDate < DateTime.Now ? appointmentDate : DateTime.Now;

            if (appointmentDate > dateTimePicker1.MaxDate)
                dateTimePicker1.MaxDate = appointmentDate;

            dateTimePicker1.Value = appointmentDate;
            // Load retake application information

            if (_TestAppointment.RetakeTestApplicationID > 0)
            {
                _CreationMode = enCreationMode.RetakeTestSchedule;

                // [E] الرسوم المدفوعة فعلاً وليس الرسوم الحالية
                clsApplication retakeApp = clsApplication.Find(_TestAppointment.RetakeTestApplicationID);
                lblRetakeAppFees.Text = retakeApp != null ? retakeApp.PaidFees.ToString() : "0";
                lblRetakeTestAppID.Text = _TestAppointment.RetakeTestApplicationID.ToString();
            }
            else
            {
                _CreationMode = enCreationMode.FirstTimeSchedule;
                lblRetakeAppFees.Text = "0";
                lblRetakeTestAppID.Text = "N/A";
            }
        
            return true;
        }
        private void  _DetermineCreationModeStatus() {
        
             _CreationMode = _LocalDrivingLicenseApp.DoesAttendTestType(_TestTypeID)?enCreationMode.RetakeTestSchedule:enCreationMode.FirstTimeSchedule;
        }

        private void _UpdateCreationModeUI()
        {

            bool isRetake = _CreationMode == enCreationMode.RetakeTestSchedule;

            pnlRetakeTestInfo.Enabled = isRetake?true:false;
            lblTitleOfTest.Text = isRetake ? "Schedule Retake Test" : "Schedule Test";

        }

        private bool _HandleActiveTestAppointmentContsraints()
        {
            if (_Mode == enMode.AddNew && clsLocalDrivingLicenseApplication.IsThereAnActiveScheduledTest(_LocalDrivingLicenseAppID, (clsTestType.enTestType)_TestTypeID))
            {
                _ShowWarning("Warning: There is already an active scheduled test for this application and test type.");
                return false;
            }
            
            return true;

        }
        private bool _HandlePrviousTestConstraint()
        {

    

            switch (_TestTypeID)
            {
                case clsTestType.enTestType.VisionTest:
                    pnlWarning.Visible = false;
                    return true;

                case clsTestType.enTestType.WrittenTest:

                    if (!_LocalDrivingLicenseApp.DoesPassTestType(clsTestType.enTestType.VisionTest))
                    {
                        _ShowWarning("Warning: You must pass the Vision test before scheduling the Written test.");
                        return false;
                    }
                    break;

                case clsTestType.enTestType.StreetTest:
                    if (!_LocalDrivingLicenseApp.DoesPassTestType(clsTestType.enTestType.WrittenTest))
                    {
                        _ShowWarning("Warning: You must pass the Written test before scheduling the Street test.");
                        return false;
                    }

                    break;
            }

            return true;



        }
        private bool _HandleAppointmentLockedConstraint()
        {
            //if appointment is locked that means the person already sat for this test
            //we cannot update locked appointment
            if (_TestAppointment.IsLocked)
            {
                _ShowWarning("Warning: Person already sat for the test, appointment locked.");
                return false;

            }
            

            return true;
        }
     
        public void LoadInfo(int LocalDrivingLicenseApplicationID, int AppointmentID = -1)
        {
            _LocalDrivingLicenseAppID = LocalDrivingLicenseApplicationID;
            _TestAppointmentID = AppointmentID;
            _SetCanSave(false);

            if (AppointmentID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;

            _ResetWarningUI();

            if (!_LoadLocalDrivingLicenseApp())
                return;
       
          

            if (_Mode == enMode.AddNew)
            {
                _SetDefaultDateTimePickerValue();   // [O] يمنع تسرب Min/Max من Update سابق
                _TestAppointment = new clsTestAppointment();
                _DetermineCreationModeStatus();

                lblFees.Text = clsTestType.Find(_TestTypeID).TestTypeFees.ToString();

                if (_CreationMode == enCreationMode.RetakeTestSchedule)
                {
                    lblRetakeAppFees.Text = _GetRetakeApplicationType().ApplicationFees.ToString();
                    lblRetakeTestAppID.Text = "0";
                }
                else
                {
                    lblRetakeAppFees.Text = "0";
                    lblRetakeTestAppID.Text = "N/A";
                }
            }

            else
            {

                if (!_LoadTestAppointment())
                    return;
            }


            _UpdateCreationModeUI();

            lblTotal.Text = (Convert.ToDecimal(lblFees.Text) + Convert.ToDecimal(lblRetakeAppFees.Text)).ToString();


            if (!_HandleActiveTestAppointmentContsraints())
                return;

            if (!_HandleAppointmentLockedConstraint())
                return;

            if (!_HandlePrviousTestConstraint())
                return;

            _SetCanSave(true);
        }

        private bool _HandleRetakeApplication()
        {
            // Only create an application for a new Retake Test.
            if (_Mode != enMode.AddNew || _CreationMode != enCreationMode.RetakeTestSchedule)
            {
                return true;
            }

            // Prevent creating a duplicate Retake Application.
            if (_TestAppointment.RetakeTestApplicationID > 0)
            {
                return true;
            }

            clsApplication application = new clsApplication();

            DateTime now = DateTime.Now;

            application.PersonID = _LocalDrivingLicenseApp.Application.PersonID;

            application.ApplicationDate = now;

            application.ApplicationTypeID = (int)clsApplication.enApplicationType.RetakeTest;

            application.Status = clsApplication.enApplicationStatus.New;

            application.LastStatusDate = now;

            application.PaidFees = _GetRetakeApplicationType().ApplicationFees;

            application.CreatedByUserID =clsCurrentUser.User.userID;

            if (!application.Save())

            {
                _TestAppointment.RetakeTestApplicationID = -1;
                MessageBox.Show("Failed to create Retake Application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            // Keep the generated ID for future save attempts.
            _TestAppointment.RetakeTestApplicationID =application.ApplicationID;

            lblRetakeTestAppID.Text = application.ApplicationID.ToString();

            return true;
        }


        public ctrlSchedule()
        {
            InitializeComponent();
            _SetDefaultDateTimePickerValue();
        }

        public bool Save()
        {
            if (!_CanSave||_TestAppointment == null || _LocalDrivingLicenseApp == null)
                return false;

            if (!_HandleRetakeApplication())
                return false;

            // Prepare Test Appointment
            _TestAppointment.LocalDrivingLicenseApplicationID =_LocalDrivingLicenseAppID;

            _TestAppointment.TestTypeID =_TestTypeID;

            _TestAppointment.AppointmentDate = dateTimePicker1.Value;

            _TestAppointment.PaidFees =Convert.ToDecimal(lblFees.Text);
           

            bool isNew = _Mode == enMode.AddNew;

            if (isNew)
            {
                _TestAppointment.CreatedByUserID = clsCurrentUser.User.userID;
            }

            // Save Test Appointment
            if (!_TestAppointment.Save())

            {          
                MessageBox.Show( isNew ? "Failed to save the new test appointment." : "Failed to update the test appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            _Mode = enMode.Update;

            // Complete Retake Application after saving appointment.
            if (_TestAppointment.RetakeTestApplicationID > 0)
            {
                clsApplication application = clsApplication.Find(_TestAppointment.RetakeTestApplicationID);

                if (application == null || !application.ChangeStatus( clsApplication.enApplicationStatus.Completed))   
                { 
                    MessageBox.Show("Appointment saved, but failed to complete Retake Application.","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return false;
                }
            }

            return true;
        }
        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitleOfTest_Click(object sender, EventArgs e)
        {

        }
    }
}
