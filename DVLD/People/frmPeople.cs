using DVLD.People;
using DVLD_BusinessLayer;
using DVLD_Global;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmPeople : Form
    {
        public enum enFilterOption
        {
            None = 0,
            PersonID = 1,
            NationalNo = 2,
            FirstName = 3,
            SecondName = 4,
            ThirdName = 5,
            LastName = 6,
            Nationality = 7,
            Gender = 8,
            Phone = 9,
            Email = 10
        }

        public enFilterOption ModeFilter=enFilterOption.None;

        private  DataTable  _dtPeople;
        
        private void _setupDataGridUI() {

            dvgListPeople.Style.CellStyle.HorizontalAlignment = HorizontalAlignment.Left;

            
           
            }
        private void _LoadFilterOptions()
        {
            string[] FilterText = {
        "None",
        "Person ID",
        "National No.",
        "First Name",
        "Second Name",
        "Third Name",
        "Last Name",
        "Nationality",
        "Gender",
        "Phone",
        "Email"
    };
            cmbFilter.DataSource = FilterText;
            cmbFilter.SelectedIndex = 0;
        }

      
        private void _RefreshPeopleList()
        {
            _dtPeople= clsPerson.ListAllPeople();
            dvgListPeople.DataSource = _dtPeople;
        }

        private void _SearchPeopleWithFilter()
        {
            //DataView dvPeople = _dtPeople.DefaultView;
            ModeFilter = (enFilterOption)cmbFilter.SelectedIndex;
            string FilterColumn = "";

            if (ModeFilter == enFilterOption.None || string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                _dtPeople.DefaultView.RowFilter = "";
                _RefreshPeopleList();
                return;
            }
            switch (ModeFilter)
            {
                case enFilterOption.PersonID: FilterColumn = "PersonID"; break;
                case enFilterOption.NationalNo: FilterColumn = "NationalNo"; break;
                case enFilterOption.FirstName: FilterColumn = "FirstName"; break;
                case enFilterOption.SecondName: FilterColumn = "SecondName"; break;
                case enFilterOption.ThirdName: FilterColumn = "ThirdName"; break;
                case enFilterOption.LastName: FilterColumn = "LastName"; break;
                case enFilterOption.Nationality: FilterColumn = "CountryName"; break;
                case enFilterOption.Gender: FilterColumn = "Gender"; break;
                case enFilterOption.Phone: FilterColumn = "Phone"; break;
                case enFilterOption.Email: FilterColumn = "Email"; break;
                default: FilterColumn = "None"; break;
            }
            if (ModeFilter == enFilterOption.PersonID)
            {


                try
                {
                    _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtSearch.Text.Trim());

                }
                catch (Exception)
                {

                    throw;
                }


               

            }
            else {

                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtSearch.Text.Trim());
            }
            dvgListPeople.DataSource = _dtPeople.DefaultView;
        }
          
        public frmPeople()
        {
         
            InitializeComponent();
        }

        
       
        private void Form1_Load(object sender, EventArgs e)
        {
            _setupDataGridUI();
            _LoadFilterOptions();
               _RefreshPeopleList();




        }

        private void btnPeopleAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frmAddPerson = new frmAddUpdatePerson();
            frmAddPerson.ShowDialog();
           
            _RefreshPeopleList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _SearchPeopleWithFilter();
        }

        private void sfDataGrid1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitlePeople_Click(object sender, EventArgs e)
        {

        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
                
            
                        // Enable or disable the search textbox based on the selected filter option which is not None
            txtSearch.Enabled = ((enFilterOption)cmbFilter.SelectedIndex != enFilterOption.None);
           
            txtSearch.Clear(); 
            errorProvider1.SetError(txtSearch, "");




        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            ModeFilter= (enFilterOption)cmbFilter.SelectedIndex;
            bool isNumericFilter =
      ModeFilter == enFilterOption.PersonID ||
     
      ModeFilter == enFilterOption.Phone;

            if (!isNumericFilter)
            { errorProvider1.SetError(txtSearch, string.Empty);
                return;
            }
                

            errorProvider1.SetError(txtSearch, string.Empty);

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtSearch, "Please enter a valid numeric value.");
                  


            }
                
        }

        private void txtSearch_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
           
                
            }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control&&e.KeyCode==Keys.V)
            {
                e.Handled = true; 
                e.SuppressKeyPress = true;
                errorProvider1.SetError(txtSearch, "Paste is disabled for this field!");
            }
        }

        private void cmbFilter_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
    }

