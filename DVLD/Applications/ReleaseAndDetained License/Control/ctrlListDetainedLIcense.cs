using DVLD.Licenses;
using DVLD.Licenses.Detain_License;
using DVLD.Licenses.Local_License;
using DVLD.People;
using DVLD_BusinessLayer;
using DVLD_Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD.Users.Control.ctrlListUsers;


namespace DVLD.Applications.ReleaseAndDetained_License.Control
{
    public partial class ctrlListDetainedLIcense : UserControl
    {

        public event Action<int> CountLicensesChanged;


        private DataTable _dtList;
        private enFilterOption _ModeFilter = enFilterOption.None;

        private enum enFilterOption
        {

            None = 0,
            DetainID = 1,
            NationalNo = 2,
            FullName = 3,
            ReleaseApplicationID = 4,
            LicenseID = 5
        }
        private enum enIsReleasedFilterOption
        {
            All = 0,
            Yes = 1,
            No = 2
        }


        public ctrlListDetainedLIcense()
        {
            InitializeComponent();
            clsPersonEvents.PersonUpdated += OnPersonUpdated;
            this.Disposed += (s, e) =>
            {
                clsPersonEvents.PersonUpdated -= OnPersonUpdated;
            };

        }
        private void OnPersonUpdated(int Person)
        {
            RefreshDetainedLicensesList();
        } 

        private void _SetupDataGridUI()
        {
            dvgList.Style.CellStyle.HorizontalAlignment = HorizontalAlignment.Left;

            if (dvgList.Columns.Count == 0)
                return;

            dvgList.Columns["DetainID"].HeaderText = "Detain ID";

            dvgList.Columns["LicenseID"].HeaderText = "License ID";

            dvgList.Columns["DetainDate"].HeaderText = "Detain Date";

            dvgList.Columns["IsReleased"].HeaderText = "Is Released";

            dvgList.Columns["FineFees"].HeaderText = "Fine Fees";

            dvgList.Columns["ReleaseDate"].HeaderText = "Release Date";

            dvgList.Columns["NationalNo"].HeaderText = "National No.";

            dvgList.Columns["FullName"].HeaderText = "Full Name";

            dvgList.Columns["ReleaseApplicationID"].HeaderText = "Release App. ID";

            dvgList.AutoSizeColumnsMode =
                Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
        }

         
        private void _LoadFiltersOptions()
        {
            string[] FilterText =
            {
        "None",
        "Detain ID",
               "National No.",
        "Full Name",
        "Release Application ID",
                "License ID"
    };

            cmbFilter.DataSource = FilterText;
            cmbFilter.SelectedIndex = 0;

            string[] IsReleasedFilterText =
            {
        "All",
        "Yes",
        "No"
    };

            cmbIsReleasedFilter.DataSource = IsReleasedFilterText;
            cmbIsReleasedFilter.SelectedIndex = 0;
        }

        public void RefreshDetainedLicensesList()
        {
            _dtList = clsDetainedLicense.GetAllDetainedLicenses();

            _dtList = _dtList.DefaultView.ToTable(
                false,
                "DetainID",
                "LicenseID",
                "DetainDate",
                "IsReleased",
                "FineFees",
                "ReleaseDate",
                "NationalNo",
                "FullName",
                "ReleaseApplicationID"
            );

            dvgList.DataSource = _dtList;

            CountLicensesChanged?.Invoke(_dtList.Rows.Count);
        }

        private string _GetBuilderFilterString()
        {



            _ModeFilter = (enFilterOption)cmbFilter.SelectedIndex;
            string FilterColumn = "";


            if (_ModeFilter == enFilterOption.None || string.IsNullOrWhiteSpace(txtSearch.Text))
            {

                return "";
            }

            switch (_ModeFilter)
            {
                case enFilterOption.DetainID: FilterColumn = "DetainID"; break;
                case enFilterOption.LicenseID: FilterColumn = "LicenseID"; break;
                case enFilterOption.NationalNo: FilterColumn = "NationalNo"; break;
                case enFilterOption.FullName: FilterColumn = "FullName"; break;
                case enFilterOption.ReleaseApplicationID: FilterColumn = "ReleaseApplicationID"; break;
                default: FilterColumn = "None"; break;
            }

            if (_ModeFilter == enFilterOption.DetainID || _ModeFilter == enFilterOption.ReleaseApplicationID || _ModeFilter == enFilterOption.LicenseID)
            {
                return $"[{FilterColumn}]={txtSearch.Text.Trim()}";
            }
            else
                return $"[{FilterColumn}] LIKE '%{txtSearch.Text.Trim()}%'";


        }
        private string _GetBuilderIsReleasedeFilterString()
        {

            enIsActiveFilterOption IsActiveFilterOption = (enIsActiveFilterOption)cmbIsReleasedFilter.SelectedIndex;


            bool IsActiveFilter = IsActiveFilterOption == enIsActiveFilterOption.Yes;
            if (IsActiveFilterOption == enIsActiveFilterOption.All)
            {

                return "";
            }

            return $"[IsReleased]={(IsActiveFilter ? 1 : 0)}";
        }

       


        private void _ApplyFilter()
        {
            if (_dtList == null) return;
            List<string> Filters = new List<string>();

            string searchFilter = _GetBuilderFilterString();
            string IsReleasedFilter = _GetBuilderIsReleasedeFilterString();
            if (!string.IsNullOrEmpty(searchFilter)) Filters.Add(searchFilter);
            if (!string.IsNullOrEmpty(IsReleasedFilter)) Filters.Add(IsReleasedFilter);

            _dtList.DefaultView.RowFilter = string.Join(" AND ", Filters);
            CountLicensesChanged?.Invoke(_dtList.DefaultView.Count);


        }




        private string _GetNationalNo() {




            if (dvgList.CurrentItem != null)
            {
                DataRowView selectedRow = dvgList.CurrentItem as DataRowView;

                if (selectedRow != null)
                {
                    return Convert.ToString(selectedRow["NationalNo"]);


                }
            }
            return string.Empty;

        }
        private int _GetLicenseID() {




            if (dvgList.CurrentItem != null)
            {
                DataRowView selectedRow = dvgList.CurrentItem as DataRowView;

                if (selectedRow != null)
                {
                    return Convert.ToInt32(selectedRow["LicenseID"]);


                }
            }
            return -1;

        }

            

        

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void cmbFilter_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void cmbIsReleasedFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ModeFilter = (enFilterOption)cmbFilter.SelectedIndex;
            bool isNumericFilter =
      _ModeFilter == enFilterOption.DetainID ||

      _ModeFilter == enFilterOption.ReleaseApplicationID || _ModeFilter == enFilterOption.LicenseID;

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

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {

            if ((enFilterOption)cmbFilter.SelectedIndex == enFilterOption.None)
            {
                errorProvider1.SetError(txtSearch, "Please select a filter option first.");
            }
        }

        private void ctrlListDetainedLIcense_Load(object sender, EventArgs e)
        {
            _LoadFiltersOptions();
            _SetupDataGridUI();
            RefreshDetainedLicensesList();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPerson frm = new frmShowPerson(_GetNationalNo());
            frm.ShowDialog();
        }

        private void ShowPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = clsPerson.Find(_GetNationalNo()).PersonID;

            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(PersonID);
            frm.ShowDialog();
        }

        private void ShowInternationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_GetLicenseID());
            frm.ShowDialog();
        }

        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = _GetLicenseID();

            if (LicenseID <= 0)
                return;

            using (frmReleaseDetainedLicense frm =
                new frmReleaseDetainedLicense(LicenseID))
            {
                frm.LicenseReleased += RefreshDetainedLicensesList;

                frm.ShowDialog();
            }

        }
    }
}
