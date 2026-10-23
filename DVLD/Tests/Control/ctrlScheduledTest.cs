using DVLD.Properties;
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
using static DVLD_BusinessLayer.clsTestType;

namespace DVLD.Tests.Control
{
    public partial class ctrlScheduledTest : UserControl
    {

        private clsTestType.enTestType _TestTypeID;
        private int _TestID = -1;
        private int _LocalDrivingLicenseAppID = -1;
        private int _testAppointmentID = -1;
        private clsTestAppointment _TestAppointment;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApp;
       
        public clsTestType.enTestType TestTypeID
        {
            get
            {
                return _TestTypeID;
            }
            set
            {
                _TestTypeID = value;
                _UpdateTestTypeUI();
            }

        }
        public int TestID
        {
            get
            {
                return _TestID;
            }
           
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
       
        private bool _LoadLocalDrivingLicenseApp()
        {
            _LocalDrivingLicenseApp = clsLocalDrivingLicenseApplication.Find(_LocalDrivingLicenseAppID);

            if (_LocalDrivingLicenseApp == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID = " + _LocalDrivingLicenseAppID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            lblDrivingLicenseAppID.Text = _LocalDrivingLicenseApp.LocalDrivingLicenseApplicationID.ToString();
            lblDrivingClass.Text = clsLicenseClass.Find(_LocalDrivingLicenseApp.LicenseClassID).ClassName;
            lblName.Text = _LocalDrivingLicenseApp.Application.PersonName;
            lblTrial.Text = _LocalDrivingLicenseApp.TotalTrialsPerTest(_TestTypeID).ToString();
            return true;
        }


        public bool LoadInfo(int testAppointmentID)
        {

            _testAppointmentID = testAppointmentID;
            _TestAppointment = clsTestAppointment.Find(_testAppointmentID);
            _LocalDrivingLicenseAppID = clsTestAppointment.Find(_testAppointmentID).LocalDrivingLicenseApplicationID;
            _TestID = _TestAppointment.TestID;
           
            if (_TestAppointment == null)
            {
                MessageBox.Show("Error: No  Appointment ID = " + _testAppointmentID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _testAppointmentID = -1;
                return false;
            }

            if (_LocalDrivingLicenseAppID == -1)
            {
                MessageBox.Show("Error: Local Driving License Application ID is not set.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
          
            if (!_LoadLocalDrivingLicenseApp())
            {
                return false;
            }

            lblDate.Text= _TestAppointment.AppointmentDate.ToString("dd/MM/yyyy");
            lblFees.Text = _TestAppointment.PaidFees.ToString("C");
            lblTestID.Text = _TestID.ToString();
            return true;
        }
        public ctrlScheduledTest()
        {
            InitializeComponent();
        }

      
    }
}
