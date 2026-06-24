using DVLD.People;
using DVLD.People.Controls;
using DVLD_BusinessLayer;
using DVLD_Global;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

        public enFilterOption ModeFilter = enFilterOption.None;

        private DataTable _dtPeople;

        private void _setupDataGridUI()
        {

            dvgListPeople.Style.CellStyle.HorizontalAlignment = HorizontalAlignment.Left;
            if (_dtPeople.Columns.Count == 0)
                return;
            {
                // Setting Header Texts and Widths using String Keys for Safety

                dvgListPeople.Columns["PersonID"].HeaderText = "Person ID";
                dvgListPeople.Columns["PersonID"].Width = 110;

                dvgListPeople.Columns["NationalNo"].HeaderText = "National No.";
                dvgListPeople.Columns["NationalNo"].Width = 120;

                dvgListPeople.Columns["FirstName"].HeaderText = "First Name";
                dvgListPeople.Columns["FirstName"].Width = 120;

                dvgListPeople.Columns["SecondName"].HeaderText = "Second Name";
                dvgListPeople.Columns["SecondName"].Width = 140;

                dvgListPeople.Columns["ThirdName"].HeaderText = "Third Name";
                dvgListPeople.Columns["ThirdName"].Width = 120;

                dvgListPeople.Columns["LastName"].HeaderText = "Last Name";
                dvgListPeople.Columns["LastName"].Width = 120;

                // Displaying the caption column instead of the numeric one
                dvgListPeople.Columns["GendorCaption"].HeaderText = "Gender";
                dvgListPeople.Columns["GendorCaption"].Width = 120;

                dvgListPeople.Columns["DateOfBirth"].HeaderText = "Date Of Birth";
                dvgListPeople.Columns["DateOfBirth"].Width = 140;

                dvgListPeople.Columns["CountryName"].HeaderText = "Nationality";
                dvgListPeople.Columns["CountryName"].Width = 120;

                dvgListPeople.Columns["Phone"].HeaderText = "Phone";
                dvgListPeople.Columns["Phone"].Width = 120;

                dvgListPeople.Columns["Email"].HeaderText = "Email";

                // Pro-Tip: Make the Email column fill the remaining space to avoid gray areas
                dvgListPeople.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;

            }


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
            _dtPeople = clsPerson.ListAllPeople();
            _dtPeople = _dtPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "GendorCaption", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");
            dvgListPeople.DataSource = _dtPeople;
            lblRecordValue.Text = _dtPeople.Rows.Count.ToString();
        }

        private void _SearchPeopleWithFilter()
        {
            //DataView dvPeople = _dtPeople.DefaultView;
            ModeFilter = (enFilterOption)cmbFilter.SelectedIndex;
            string FilterColumn = "";

            if (ModeFilter == enFilterOption.None || string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                _dtPeople.DefaultView.RowFilter = "";
                // _RefreshPeopleList();
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



                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtSearch.Text.Trim());





            }
            else
            {

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
            clsPersonEvents.PersonAdded += OnPersonChanged;
            clsPersonEvents.PersonUpdated += OnPersonChanged;
            clsPersonEvents.PersonDeleted += OnPersonChanged;
            _RefreshPeopleList();
            _setupDataGridUI();
            _LoadFilterOptions();




        }
        private void OnPersonChanged(int personID)
        {
            _RefreshPeopleList();
        }
        private void btnPeopleAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frmAddPerson = new frmAddUpdatePerson();

            frmAddPerson.ShowDialog();


        }

    
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _SearchPeopleWithFilter();
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
            ModeFilter = (enFilterOption)cmbFilter.SelectedIndex;
            bool isNumericFilter =
      ModeFilter == enFilterOption.PersonID ||

      ModeFilter == enFilterOption.Phone;

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

        private void txtSearch_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {


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
 
        private void cmbFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStripEx1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dvgListPeople.CurrentItem != null)
            {
                DataRowView selectedRow = dvgListPeople.CurrentItem as DataRowView;

                if (selectedRow != null)
                {
                    int personID = Convert.ToInt32(selectedRow["PersonID"]);
                    frmShowPerson frmShowPersonDetails = new frmShowPerson(personID);
                    frmShowPersonDetails.ShowDialog();
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dvgListPeople.CurrentItem != null)
            {
                DataRowView selectedRow = dvgListPeople.CurrentItem as DataRowView;

                if (selectedRow != null)
                {
                    int personID = Convert.ToInt32(selectedRow["PersonID"]);
                    frmAddUpdatePerson frmAddUpdatePersonDetails = new frmAddUpdatePerson(personID);

                    frmAddUpdatePersonDetails.ShowDialog();
                }
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dvgListPeople.CurrentItem == null)
                return;
            DataRowView selectedRow = dvgListPeople.CurrentItem as DataRowView;

            if (selectedRow == null)
                return;
            int personID = Convert.ToInt32(selectedRow["PersonID"]);      
            if (MessageBox.Show("Are you sure you want to delete this person? This action cannot be undone.","Confirm Delete",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;


            if (clsPerson.DeletePerson(personID))
            {
                MessageBox.Show("Person deleted successfully.", "Success",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                clsPersonEvents.NotifyPersonDeleted(personID);
            }
            else
            {
                MessageBox.Show("Cannot delete this person because they are linked to other records in the system (e.g., Applications, Users, or Drivers).",
                                            "Deletion Failed",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
            }

               
            }

        private void dvgListPeople_DoubleClick(object sender, EventArgs e)
        {
            DataRowView selectedRow = dvgListPeople.CurrentItem as DataRowView;
            int personID = Convert.ToInt32(selectedRow["PersonID"]);
            Form frm = new frmShowPerson(personID);
            frm.ShowDialog();

        }

        private void frmPeople_FormClosing(object sender, FormClosingEventArgs e)
        {
            clsPersonEvents.PersonAdded -= OnPersonChanged;
            clsPersonEvents.PersonUpdated -= OnPersonChanged;
            clsPersonEvents.PersonDeleted -= OnPersonChanged;
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frmAddPerson = new frmAddUpdatePerson();
            frmAddPerson.ShowDialog();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                    "This feature is not implemented yet.",
                    "Not Implemented",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "This feature is not implemented yet.",
        "Not Implemented",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if ((enFilterOption)cmbFilter.SelectedIndex == enFilterOption.None)
            {
                errorProvider1.SetError(txtSearch, "Please select a filter option first.");
            }
        }
    }
}
    
    

