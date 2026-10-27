using DVLD.Tests.Test_Appointment;
using DVLD_BusinessLayer;
using DVLD_Global.Events;
using Syncfusion.WinForms.DataGrid.Interactivity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Events;

using DVLD.Licenses.Local_License;

namespace DVLD.Applications.Local_Driving_License
{
    public partial class ctrlListLocalDriving : UserControl
    {
        public event Action<int> CountApplicationsChanged;
        public event Action<int> OnApplicationSelected;
      public int CountApplications { get; private set; }
        private enFilterOption _ModeFilter = enFilterOption.None;
        private DataTable _dtList;
        public ctrlListLocalDriving()
        {
            InitializeComponent();


           // cmsApplications.Opening -= cmsApplications_Opening;

            dvgList.ContextMenuStrip = null;
            dvgList.RecordContextMenu = cmsApplications;
            dvgList.ContextMenuOpening += dvgList_ContextMenuOpening;
        }

        public enum enFilterOption
        {
            None = 0,
            LDLAppID = 1,
            NationalNo = 2,
            FullName = 3,
            ClassName = 4
        }

        private void _SetupDataGridUI()
        {
            dvgList.Style.CellStyle.HorizontalAlignment = HorizontalAlignment.Left;
            if (dvgList.Columns.Count == 0)
                return;

            dvgList.Columns["LocalDrivingLicenseApplicationID"].HeaderText = "L.D.L App ID";

            dvgList.Columns["ClassName"].HeaderText = "Driving Class";

            dvgList.Columns["NationalNo"].HeaderText = "National No";

            dvgList.Columns["FullName"].HeaderText = "Full Name";

            dvgList.Columns["ApplicationDate"].HeaderText = "Application Date";

            dvgList.Columns["PassedTestCount"].HeaderText = "Passed Tests";

            dvgList.Columns["Status"].HeaderText = "Status";

            dvgList.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;

        }

        private void _LoadFiltersOptions()
        {
            string[] FilterText =
            {
        "None",
        "L.D.L App ID",
        "National No",
        "Full Name",
        "Class Name"
    };

            cmbFilter.DataSource = FilterText;
            cmbFilter.SelectedIndex = 0;
        }
        private void dvgList_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {
            ////////////////////
            var row = SelectionHelper.GetRecordAtRowIndex(
                dvgList, e.RowIndex) as DataRowView;

            if (row == null)
            {
                e.Cancel = true;
                return;
            }

            dvgList.CurrentItem = row;

            int id = Convert.ToInt32(
                row["LocalDrivingLicenseApplicationID"]);


            //////////////////
            clsLocalDrivingLicenseApplication application =
                clsLocalDrivingLicenseApplication.Find(id);



            if (application == null)
            {
                e.Cancel = true;
                return;
            }

            _UpdateScheduleTestMenuState(application);
        }
        private void _LoadStatusFilterOptions()
        {
            string[] StatusFilterText =
            {
        "All",
        "New",
        "Cancelled",
        "Completed"
    };

            cbStatusFilter.DataSource = StatusFilterText;
            cbStatusFilter.SelectedIndex = 0;
        }
        private string _GetBuilderFilterString()
        {
            enFilterOption filter = (enFilterOption)cmbFilter.SelectedIndex;

            if (filter == enFilterOption.None || string.IsNullOrWhiteSpace(txtSearch.Text))
                return "";

            string filterColumn = "";
            string value = txtSearch.Text.Trim();

            switch (filter)
            {
                case enFilterOption.LDLAppID:
                    filterColumn = "LocalDrivingLicenseApplicationID";
                    break;

                case enFilterOption.NationalNo:
                    filterColumn = "NationalNo";
                    break;

                case enFilterOption.FullName:
                    filterColumn = "FullName";
                    break;

                case enFilterOption.ClassName:
                    filterColumn = "ClassName";
                    break;
            }

            if (filter == enFilterOption.LDLAppID)
                return $"[{filterColumn}] = {value}";

            return $"[{filterColumn}] LIKE '%{value}%'";
        }

        private string _GetBuilderStatusFilterString()
        {
            string selectedStatus = cbStatusFilter.Text;

            if (selectedStatus == "All")
                return "";

            return $"[Status] = '{selectedStatus}'";
        }

        private void _ApplyFilter()
        {
            if (_dtList == null)
                return;

            List<string> filters = new List<string>();

            string searchFilter = _GetBuilderFilterString();
            string statusFilter = _GetBuilderStatusFilterString();

            if (!string.IsNullOrEmpty(searchFilter))
                filters.Add(searchFilter);

            if (!string.IsNullOrEmpty(statusFilter))
                filters.Add(statusFilter);

            _dtList.DefaultView.RowFilter = string.Join(" AND ", filters);

            CountApplications = _dtList.DefaultView.Count;
            CountApplicationsChanged?.Invoke(CountApplications);
        }

        private int GetCurrentLocalDrivingLicenseApplicationID()
        {
            if (dvgList.CurrentItem != null)
            {
                DataRowView selectedRow = dvgList.CurrentItem as DataRowView;

                if (selectedRow != null)
                {
                    //return Convert.ToInt32(
                    //    selectedRow["LocalDrivingLicenseApplicationID"]);

                    int id = Convert.ToInt32(
            selectedRow["LocalDrivingLicenseApplicationID"]);

                    System.Diagnostics.Debug.WriteLine(
                        $"Current Application from GET ID: {id}");

                    return id;
                }
            }

            return -1;
        }
        public void RefreshList()   
        {
            _dtList = clsLocalDrivingLicenseApplication.ListAllLocalDrivingLicenseApplications();

            _dtList = _dtList.DefaultView.ToTable(
    false,
    "LocalDrivingLicenseApplicationID",
    "ClassName",
    "NationalNo",
    "FullName",
    "ApplicationDate",
    "PassedTestCount",
    "Status");
            dvgList.DataSource = _dtList;
            CountApplications = _dtList.Rows.Count;
            CountApplicationsChanged?.Invoke(CountApplications);
        }

        private void _UpdateScheduleTestMenuState(clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication) {

            if (LocalDrivingLicenseApplication == null)
                return;

            bool passedVision = LocalDrivingLicenseApplication.DoesPassTestType(
        clsTestType.enTestType.VisionTest);

            bool passedWritten = LocalDrivingLicenseApplication.DoesPassTestType(
                clsTestType.enTestType.WrittenTest);

            bool passedStreet = LocalDrivingLicenseApplication.DoesPassTestType(
                clsTestType.enTestType.StreetTest);

            bool isActiveApplication =
                LocalDrivingLicenseApplication.Application.Status ==
                clsApplication.enApplicationStatus.New;

            // Determine which tests can be scheduled.
            bool canScheduleVision = isActiveApplication && !passedVision;

            bool canScheduleWritten =
                isActiveApplication && passedVision && !passedWritten;

            bool canScheduleStreet =
                isActiveApplication && passedVision && passedWritten && !passedStreet;
            
            ScheduleTestsMenue.Enabled =
                canScheduleVision || canScheduleWritten || canScheduleStreet;


            if (ScheduleTestsMenue.Enabled)
            {
                // Update menu items.
                scheduleVisionTestToolStripMenuItem.Enabled = canScheduleVision;
                scheduleWrittenTestToolStripMenuItem.Enabled = canScheduleWritten;
                scheduleStreetTestToolStripMenuItem.Enabled = canScheduleStreet;

                // Enable the parent menu if at least one test can be scheduled.
            }


        }
        private void _ScheduleTest(clsTestType.enTestType TestTypeID)
        {
            int LocalDrivingLicenseApplicationID = GetCurrentLocalDrivingLicenseApplicationID();

            if (LocalDrivingLicenseApplicationID == -1)
                return;
            frmListTestAppointment frm = new frmListTestAppointment( LocalDrivingLicenseApplicationID, TestTypeID);

            frm.ShowDialog();
        }


        /////////////////////// EVENTS /////////////////
        private void ctrlListLocalDriving_Load(object sender, EventArgs e)
        {

            _SetupDataGridUI();
            RefreshList();
            _LoadFiltersOptions();
            _LoadStatusFilterOptions();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            _ApplyFilter();
        }

        private void cbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            bool isNoneFilter = (enFilterOption)cmbFilter.SelectedIndex == enFilterOption.None;
            txtSearch.ReadOnly = isNoneFilter;

            txtSearch.Clear();
            errorProvider1.SetError(txtSearch, "");

            if (!isNoneFilter)
            {
                txtSearch.Focus();
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ModeFilter = (enFilterOption)cmbFilter.SelectedIndex;

            bool isNumericFilter =
                _ModeFilter == enFilterOption.LDLAppID;

            if (!isNumericFilter)
            {
                errorProvider1.SetError(txtSearch, string.Empty);
                return;
            }

            errorProvider1.SetError(txtSearch, string.Empty);

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtSearch, "Please enter a valid numeric value.");
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAddUpdateLocalDrivingLicenseApplication frm = new frmAddUpdateLocalDrivingLicenseApplication(GetCurrentLocalDrivingLicenseApplicationID());
            frm.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenseApplicationInfo frm = new frmLocalDrivingLicenseApplicationInfo(GetCurrentLocalDrivingLicenseApplicationID());

            frm.ShowDialog();
        }

        private void DeleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure do want to delete this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int LocalDrivingLicenseApplicationID = GetCurrentLocalDrivingLicenseApplicationID();

            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication =
                clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseApplicationID);

            if (LocalDrivingLicenseApplication == null)
            {                MessageBox.Show("Application was not found.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                return;
            }
                if (LocalDrivingLicenseApplication.DeleteLocalDrivingLicenseApplication())
                {
                clsLDLApplicationEvents.NotifyLocalDrivingLicenseApplicationDeleted(LocalDrivingLicenseApplicationID);
                    MessageBox.Show("Application Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    
                }
                else
                {                MessageBox.Show("Could not delete application. Other data may depend on it.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            
            }
        }

        private void CancelApplicaitonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
         }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestType.enTestType.VisionTest);
        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestType.enTestType.WrittenTest);
        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestType.enTestType.StreetTest);
         
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueDriverLicenseFirstTime frm = new frmIssueDriverLicenseFirstTime(GetCurrentLocalDrivingLicenseApplicationID());
            frm.LicenseIssued += OnLicenseIssued;
            frm.ShowDialog();
        }

        private void OnLicenseIssued(int LicenseID)
        {
            RefreshList();
        }
        //private void cmsApplications_Opening(object sender, CancelEventArgs e)
        //{

        //    //clsLocalDrivingLicenseApplication LDLApp = clsLocalDrivingLicenseApplication.Find(GetCurrentLocalDrivingLicenseApplicationID());
        //    //            _UpdateScheduleTestMenuState(LDLApp);


        //    var row = SelectionHelper.GetRecordAtRowIndex(
        // dvgList, e.RowIndex) as DataRowView;

        //    if (row == null)
        //    {
        //        e.Cancel = true;
        //        return;
        //    }

        //    dvgList.CurrentItem = row;

        //    int id = Convert.ToInt32(
        //        row["LocalDrivingLicenseApplicationID"]);

        //    var application =
        //        clsLocalDrivingLicenseApplication.Find(id);

        //    if (application == null)
        //    {
        //        e.Cancel = true;
        //        return;
        //    }

        //    _UpdateScheduleTestMenuState(application);
        //}
    }
}
