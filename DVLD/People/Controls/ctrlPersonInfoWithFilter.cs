using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.People.Controls
{
    public partial class ctrlPersonInfoWithFilter : UserControl
    {
        public ctrlPersonInfoWithFilter()
        {
            InitializeComponent();
        }
        public enum enFilterOption
        {
            
            PersonID = 1,
            NationalNo = 2,
          
        }

    enFilterOption ModeFilter;

        DataTable _dtPerson;
        private void _LoadFilterOptions()
        {
            string[] FilterText = {
        
        "Person ID",
        "National No.",
       
                };


            cmbFilter.DataSource = FilterText;
            cmbFilter.SelectedIndex = 0;
        }

        private void _SearchPeopleWithFilter()
        {
            //DataView dvPeople = _dtPeople.DefaultView;
            ModeFilter = (enFilterOption)cmbFilter.SelectedIndex;
            string FilterColumn = "";

            if ( string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                _drPerson.= "";
                // _RefreshPeopleList();
                return;
            }
            switch (ModeFilter)
            {
                case enFilterOption.PersonID: FilterColumn = "PersonID"; break;
                case enFilterOption.NationalNo: FilterColumn = "NationalNo"; break;
               
            }
            if (ModeFilter == enFilterOption.PersonID)
            {



                _drPerson.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtSearch.Text.Trim());





            }
            else
            {

                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtSearch.Text.Trim());
            }
            dvgListPeople.DataSource = _dtPeople.DefaultView;
        }


      /// EVENTS  /// ////////////////
      
        private void crlShowPersonInformation1_Load(object sender, EventArgs e)
        {
            _LoadFilterOptions();

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

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

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                errorProvider1.SetError(txtSearch, "Paste is disabled for this field!");
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Enable or disable the search textbox based on the selected filter option which is not None
            txtSearch.Enabled = ((enFilterOption)cmbFilter.SelectedIndex != enFilterOption.None);

            txtSearch.Clear();
            errorProvider1.SetError(txtSearch, "");

            if (txtSearch.Enabled)
            {
                txtSearch.Focus();
            }

        }
    }
}
