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
    public partial class frmScheduleTest : Form
    {
        public event Action<int> AppointmentSaved;
        private int _LocalDrivingLicenseApplicationID = -1;
        private clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest;
        private int _AppointmentID = -1;
        public frmScheduleTest(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID, int AppointmentID = -1)
        {
            InitializeComponent();

            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestTypeID = TestTypeID;
            _AppointmentID = AppointmentID;
           
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            ctrlSchedule1.CanSaveChanged += ctrlSchedule1_CanSaveChanged;
            ctrlSchedule1.TestTypeID = _TestTypeID;
            ctrlSchedule1.LoadInfo(_LocalDrivingLicenseApplicationID, _AppointmentID);
        }
        private void ctrlSchedule1_CanSaveChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = ctrlSchedule1.CanSave;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ctrlSchedule1.Save())
                return;
            AppointmentSaved?.Invoke(_LocalDrivingLicenseApplicationID);
            this.DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
