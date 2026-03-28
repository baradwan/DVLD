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

namespace DVLD.Users.Control
{
    public partial class ctrlListUsers : UserControl
    {
        private int _CountUsers = 0;
        public int CountUsers { get; private set; }
        public ctrlListUsers()
        {
            InitializeComponent();

            
        }

        public event Action<int>CountUsersChanged;
        public enum enFilterOption
        {
            None = 0,
            PersonID = 1,
           UserID = 2,
            FullName = 3,
            UserName = 4
           
           
        }

        public enum enIsActiveFilterOption
        {
            All = 0,
            Yes = 1,
            No = 2
        }


        public enFilterOption ModeFilter = enFilterOption.None;

        private DataTable _dtList;

        private void _setupDataGridUI()
        {

            dvgList.Style.CellStyle.HorizontalAlignment = HorizontalAlignment.Left;
            if (dvgList.Columns.Count == 0)
                return;
            
           
                // Setting Header Texts and Widths using String Keys for Safety

                dvgList.Columns["UserID"].HeaderText = "User ID";
                dvgList.Columns["UserID"].Width = 110;

                dvgList.Columns["PersonID"].HeaderText = "Person ID.";
                dvgList.Columns["PersonID"].Width = 120;

                dvgList.Columns["FullName"].HeaderText = "Full Name";
                dvgList.Columns["FullName"].Width = 120;

                dvgList.Columns["UserName"].HeaderText = "Username";
                dvgList.Columns["UserName"].Width = 140;

                dvgList.Columns["IsActive"].HeaderText = "Is Active";
                dvgList.Columns["IsActive"].Width = 120;

              

                // Pro-Tip: Make the Email column fill the remaining space to avoid gray areas
                dvgList.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            


        }
        private void _LoadFiltersOptions()
        {
            string[] FilterText = {
        "None",
        "Person ID",
        "User ID",
        "Full Name",
        "Username"
      
                };


            cmbFilter.DataSource = FilterText;
            cmbFilter.SelectedIndex = 0;

            string[] IsActiveFilterText = {
        "All",
        "Yes",
        "No"
        

                };

            cbIsActiveFilter.DataSource = IsActiveFilterText;
            cbIsActiveFilter.SelectedIndex = 0;

        }


        private void _RefreshUsersList()
        {
            _dtList = clsUser.ListAllUser();
                                               
            dvgList.DataSource = _dtList;
            CountUsers = _dtList.Rows.Count;
            CountUsersChanged?.Invoke(CountUsers);
        }

       

        private string _GetBuilderFilterString() {



            ModeFilter = (enFilterOption)cmbFilter.SelectedIndex;
            string FilterColumn = "";
          

            if (ModeFilter == enFilterOption.None  || string.IsNullOrWhiteSpace(txtSearch.Text))
            {

                return "";
            }

            switch (ModeFilter)
            {
                case enFilterOption.PersonID: FilterColumn = "PersonID"; break;
                case enFilterOption.UserID: FilterColumn = "UserID"; break;
                case enFilterOption.UserName: FilterColumn = "UserName"; break;
                case enFilterOption.FullName: FilterColumn = "FullName"; break;

                default: FilterColumn = "None"; break;
            }
            if (ModeFilter == enFilterOption.PersonID || ModeFilter == enFilterOption.UserID)
            {
                return $"[{FilterColumn}]={txtSearch.Text.Trim()}";

            }
            else
            {

                return   $"[{FilterColumn}] LIKE '%{txtSearch.Text.Trim()}%'";
            }
            

        }
        private string _GetBuilderActiveFilterString()
        {
            
            enIsActiveFilterOption IsActiveFilterOption = (enIsActiveFilterOption)cbIsActiveFilter.SelectedIndex;


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
            CountUsers = _dtList.DefaultView.Count;
            CountUsersChanged?.Invoke(CountUsers);


        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilter();


        }

        private void crtlListUsers_Load(object sender, EventArgs e)
        {
            _setupDataGridUI();
            _RefreshUsersList();
          
            _LoadFiltersOptions();
            
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Enabled = ((enFilterOption)cmbFilter.SelectedIndex != enFilterOption.None);
          
            txtSearch.Clear();
            errorProvider1.SetError(txtSearch, "");

            if (txtSearch.Enabled)
            {
                txtSearch.Focus();
            }

            
        }

        private void cbIsActiveFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            ModeFilter = (enFilterOption)cmbFilter.SelectedIndex;
            bool isNumericFilter =
      ModeFilter == enFilterOption.PersonID ||

      ModeFilter == enFilterOption.UserID;

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
    }
    
}
