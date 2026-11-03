using DVLD.Licenses;
using DVLD.Licenses.International_License;
using DVLD.People;
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
using static DVLD.Users.Control.ctrlListUsers;

namespace DVLD.Applications.International_License.control
{
    public partial class ctrlListInternationalLicense : UserControl
    {
        public event Action<int> CountLicensesChanged;
        public event Action<int> OnLicenseSelected;
        private DataTable _dtList;

        private enum enFilterOption
        {
            None = 0,
            InternationalLicenseID = 1,
            ApplicationID = 2,
            DriverID = 3,
            LocalLicenseID = 4,
            IsActive = 5

        }
        private enFilterOption _ModeFilter = enFilterOption.None;

        public ctrlListInternationalLicense()
        {
            InitializeComponent();
        }


        private void _SetupDataGridUI()
        {
            dvgList.Style.CellStyle.HorizontalAlignment = HorizontalAlignment.Left;

            if (dvgList.Columns.Count == 0)
                return;

            dvgList.Columns["InternationalLicenseID"].HeaderText = "Int. License ID";

            dvgList.Columns["ApplicationID"].HeaderText = "Application ID";

            dvgList.Columns["DriverID"].HeaderText = "Driver ID";

            dvgList.Columns["IssuedUsingLocalLicenseID"].HeaderText = "Local License ID";

            dvgList.Columns["IssueDate"].HeaderText = "Issue Date";

            dvgList.Columns["ExpirationDate"].HeaderText = "Expiration Date";

            dvgList.Columns["IsActive"].HeaderText = "Is Active";

            dvgList.Columns["CreatedByUserID"].HeaderText = "Created By";

            dvgList.AutoSizeColumnsMode =
                Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
        }

        private void _LoadFiltersOptions()
        {
            string[] FilterText =
            {
        "None",
        "International License ID",
        "Application ID",
        "Driver ID",
        "Local License ID",
        "Is Active"
    };

            cmbFilter.DataSource = FilterText;
            cmbFilter.SelectedIndex = 0;


            string[] IsActiveFilterText = {
        "All",
        "Yes",
        "No"


                };

            cmbIsActiveFilter.DataSource = IsActiveFilterText;
            cmbIsActiveFilter.SelectedIndex = 0;
        }

        public void RefreshInternationalLicensesList()
        {
            _dtList = clsInternationalLicense.GetAllInternationalLicenses();

            _dtList = _dtList.DefaultView.ToTable(
                false,
                "InternationalLicenseID",
                "ApplicationID",
                "DriverID",
                "IssuedUsingLocalLicenseID",
                "IssueDate",
                "ExpirationDate",
                "IsActive",
                "CreatedByUserID"
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
                case enFilterOption.InternationalLicenseID: FilterColumn = "InternationalLicenseID"; break;
                case enFilterOption.ApplicationID: FilterColumn = "ApplicationID"; break;
                case enFilterOption.DriverID: FilterColumn = "DriverID"; break;
                case enFilterOption.LocalLicenseID: FilterColumn = "IssuedUsingLocalLicenseID"; break;
                default: FilterColumn = "None"; break;
            }


            return $"[{FilterColumn}]={txtSearch.Text.Trim()}";


        }

        private string _GetBuilderActiveFilterString()
        {

            enIsActiveFilterOption IsActiveFilterOption = (enIsActiveFilterOption)cmbIsActiveFilter.SelectedIndex;


            bool IsActiveFilter = IsActiveFilterOption == enIsActiveFilterOption.Yes;
            if (IsActiveFilterOption == enIsActiveFilterOption.All)
            {

                return "";
            }

            return $"[IsActive]={(IsActiveFilter ? 1 : 0)}";
        }


        private void _ApplyFilter()
        {
            if (_dtList == null) return;
            List<string> Filters = new List<string>();

            string searchFilter = _GetBuilderFilterString();
            string ActiveFilter = _GetBuilderActiveFilterString();
            if (!string.IsNullOrEmpty(searchFilter)) Filters.Add(searchFilter);
            if (!string.IsNullOrEmpty(ActiveFilter)) Filters.Add(ActiveFilter);

            _dtList.DefaultView.RowFilter = string.Join(" AND ", Filters);
            CountLicensesChanged?.Invoke(_dtList.DefaultView.Count);


        }

        private int GetCurrentInternationalLicenseID()
        {

            if (dvgList.CurrentItem != null)
            {
                DataRowView selectedRow = dvgList.CurrentItem as DataRowView;

                if (selectedRow != null)
                {
                    return Convert.ToInt32(selectedRow["InternationalLicenseID"]);


                }
            }
            return -1;
        }

        private int GetCurrentDriverID()
        {

            if (dvgList.CurrentItem != null)
            {
                DataRowView selectedRow = dvgList.CurrentItem as DataRowView;

                if (selectedRow != null)
                {
                    return Convert.ToInt32(selectedRow["DriverID"]);


                }
            }
            return -1;
        }

        private int _GetPersonID() {
        
        return clsDriver.Find(GetCurrentDriverID())?.PersonID ?? -1;

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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void cmbIsActiveFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtSearch, string.Empty);

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                errorProvider1.SetError(
                    txtSearch,
                    "Please enter a valid numeric value.");
            }

        
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {

            if ((enFilterOption)cmbFilter.SelectedIndex == enFilterOption.None)
            {
                errorProvider1.SetError(txtSearch, "Please select a filter option first.");
            }
        }

        private void ShowInternationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmShowInternationalLicense frm = new frmShowInternationalLicense(GetCurrentInternationalLicenseID());
            frm.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPerson frm=new frmShowPerson(_GetPersonID());
            frm.ShowDialog();
        }

        private void ShowPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonLicenseHistory frm =new frmShowPersonLicenseHistory(_GetPersonID());
            frm.ShowDialog();
        }

        private void ctrlListInternationalLicense_Load(object sender, EventArgs e)
        {
            _LoadFiltersOptions();
            _SetupDataGridUI();
            RefreshInternationalLicensesList();

        }
    }
}
