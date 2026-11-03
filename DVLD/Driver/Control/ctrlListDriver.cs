using DVLD.Licenses;
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

namespace DVLD.Driver.Control
{
    public partial class ctrlListDriver : UserControl
    {
        public event Action<int> CountDriversChanged;
        public event Action<int> OnDriverSelected;

      
        private DataTable _dtList;

        private enum enFilterOption
        {
            None = 0,
            DriverID = 1,
            PersonID = 2,
            NationalNo = 3,
            FullName = 4

        }
        private enFilterOption _ModeFilter = enFilterOption.None;
       
        public ctrlListDriver()
        {
            InitializeComponent();
        }


        private void _LoadFiltersOptions()
        {
            string[] FilterText =
            {
            "None",
            "Driver ID",
            "Person ID",
            "National No.",
            "Full Name"
        };

            cmbFilter.DataSource = FilterText;
            cmbFilter.SelectedIndex = 0;
        }

        private void _SetupDataGridUI()
        {
            dvgList.Style.CellStyle.HorizontalAlignment = HorizontalAlignment.Left;
            if (dvgList.Columns.Count == 0)
                return;

            dvgList.Columns["DriverID"].HeaderText = "Driver ID";
            dvgList.Columns["DriverID"].Width = 110;

            dvgList.Columns["PersonID"].HeaderText = "Person ID";
            
            dvgList.Columns["NationalNo"].HeaderText = "National No.";
            dvgList.Columns["FullName"].HeaderText = "Full Name";
            dvgList.Columns["CreatedDate"].HeaderText = "Created Date";
            dvgList.Columns["NumberOfActiveLicenses"].HeaderText = "Active Licenses";

            dvgList.AutoSizeColumnsMode =
                Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
        }

        private void _RefreshDriversList()
        {
            _dtList = clsDriver.GetAllDrivers();

            _dtList = _dtList.DefaultView.ToTable(false,
                "FullName",
                "DriverID",
                "PersonID",
                "NationalNo",
                "CreatedDate",
                "NumberOfActiveLicenses");

            dvgList.DataSource = _dtList;

            
            CountDriversChanged?.Invoke(_dtList.Rows.Count);
        }

        private string _GetBuilderFilterString()
        {
            _ModeFilter = (enFilterOption)cmbFilter.SelectedIndex;
            string FilterColumn = "";

            if (_ModeFilter == enFilterOption.None ||
                string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                return "";
            }

            switch (_ModeFilter)
            {
                case enFilterOption.DriverID: FilterColumn = "DriverID"; break;
                case enFilterOption.PersonID: FilterColumn = "PersonID"; break;
                case enFilterOption.NationalNo: FilterColumn = "NationalNo"; break;
                case enFilterOption.FullName: FilterColumn = "FullName"; break;
            }

            string SearchText = txtSearch.Text.Trim();

            if (_ModeFilter == enFilterOption.DriverID ||
                _ModeFilter == enFilterOption.PersonID)
            {
                return $"[{FilterColumn}] = {SearchText}";
            }

            return $"[{FilterColumn}] LIKE '%{SearchText.Replace("'", "''")}%'";
        }

        private void _ApplyFilter()
        {
            if (_dtList == null)
                return;

            _dtList.DefaultView.RowFilter = _GetBuilderFilterString();

            CountDriversChanged?.Invoke(_dtList.DefaultView.Count);
        }

        private void ctrlListDriver_Load(object sender, EventArgs e)
        {
            clsPersonEvents.PersonUpdated += OnPersonUpdated;
            _RefreshDriversList();
            _SetupDataGridUI();
            _LoadFiltersOptions();
        }
        private int GetCurrentPersonID()
        {

            if (dvgList.CurrentItem != null)
            {
                DataRowView selectedRow = dvgList.CurrentItem as DataRowView;

                if (selectedRow != null)
                {
                    return Convert.ToInt32(selectedRow["PersonID"]);


                }
            }
            return -1;
        }
        private void OnPersonUpdated(int PersonID)
        {
            _RefreshDriversList();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
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
      _ModeFilter == enFilterOption.PersonID ||

      _ModeFilter == enFilterOption.DriverID;

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

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.V)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                errorProvider1.SetError(txtSearch, "Paste is disabled for this field!");
            }
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if ((enFilterOption)cmbFilter.SelectedIndex == enFilterOption.None)
            {
                errorProvider1.SetError(txtSearch, "Please select a filter option first.");
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPerson frm=new frmShowPerson(GetCurrentPersonID());
            frm.ShowDialog();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(GetCurrentPersonID());
            frm.ShowDialog();
        }
    }


}

