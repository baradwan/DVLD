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

namespace DVLD.Tests.Test_Appointment
{
    public partial class frmListTestAppointment : Form
    {
        
        private int _CountApplications=0;
        private DataTable _dtList;
        private int _LocalDrivingLicenseApplicationID;
        private clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest;

        
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

        private void _RefreshList()
        {
            _dtList = clsTestAppointment.GetApplicationTestAppointmentsPerTestType(_LocalDrivingLicenseApplicationID, _TestTypeID);
            
            _dtList = _dtList.DefaultView.ToTable(
                                    false,
                                    "TestAppointmentID",
                                    "AppointmentDate",
                                    "PaidFees",
                                    "IsLocked");

            dvgList.DataSource = _dtList;
            _CountApplications = _dtList.Rows.Count;
            lblRecordValue.Text = _CountApplications.ToString();

        }
        private void _SetupDataGridUI()
        {
            dvgList.Style.CellStyle.HorizontalAlignment = HorizontalAlignment.Left;
            if (dvgList.Columns.Count == 0)
                return;

            dvgList.Columns["TestAppointmentID"].HeaderText = "Test Appointment ID";

            dvgList.Columns["AppointmentDate"].HeaderText = "Appointment Date";

            dvgList.Columns["PaidFees"].HeaderText = "Paid Fees";

            dvgList.Columns["IsLocked"].HeaderText = "Is Locked";

            

            dvgList.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;

        }


        private void OnAppointmentSaved(int localDrivingLicenseAppID)
        {
            if (localDrivingLicenseAppID != _LocalDrivingLicenseApplicationID)
                return;

            _RefreshList();
        }

        private int GetCurrentTestAppointmentID()
        {
            if (dvgList.CurrentItem != null)
            {
                DataRowView selectedRow = dvgList.CurrentItem as DataRowView;

                if (selectedRow != null)
                {
                    return Convert.ToInt32(
                        selectedRow["TestAppointmentID"]);
                }
            }

            return -1;
        }
        //////////// EVENTS ///////////////////
        ///

        public frmListTestAppointment(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestType)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestTypeID = TestType;


        }

        private void frmListTestAppointment_Load(object sender, EventArgs e)
        {
         int AppID = clsLocalDrivingLicenseApplication.Find(_LocalDrivingLicenseApplicationID).Application.ApplicationID;
            ctrlDrivingLicenseInfo1.LoadLocalDrivingLicenseAppInfo(_LocalDrivingLicenseApplicationID);
            ctrlAppBasicInfo1.LoadApplicationInfo(AppID);
            _SetupDataGridUI();
            _RefreshList();
            _UpdateTestTypeUI();


        }
        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            frmScheduleTest frm = new frmScheduleTest(_LocalDrivingLicenseApplicationID, _TestTypeID);
            frm.AppointmentSaved += OnAppointmentSaved;
            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScheduleTest frm = new frmScheduleTest(_LocalDrivingLicenseApplicationID, _TestTypeID, GetCurrentTestAppointmentID());
            frm.AppointmentSaved += OnAppointmentSaved;
            frm.ShowDialog();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTakeTest frm = new frmTakeTest(GetCurrentTestAppointmentID(),_TestTypeID);
            frm.ShowDialog();

        }

        private void ctrlAppBasicInfo1_Load(object sender, EventArgs e)
        {

        }

        private void ctrlDrivingLicenseInfo1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
