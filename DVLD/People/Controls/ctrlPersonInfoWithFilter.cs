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

namespace DVLD.People.Controls
{
    public partial class ctrlPersonInfoWithFilter : UserControl
    {

        public event Action<int> OnPersonSelected;
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(PersonID); // Raise the event with the parameter
            }
        }

        public int PersonID
        {
            get { return crlShowPersonInformation1.PersonID; }
        }
        public ctrlPersonInfoWithFilter()
        {
            InitializeComponent();
        }
        public enum enFilterOption
        {
            
            PersonID = 0,
            NationalNo = 1,
          
        }

    enFilterOption ModeFilter;

        DataTable _dtPeople;
        private void _LoadFilterOptions()
        {
            string[] FilterText = {
        
        "Person ID",
        "National No.",
       
                };


            cmbFilter.DataSource = FilterText;
            cmbFilter.SelectedIndex = 0;
        }


        
        private void _SearchPersonWithFilter()
        {


            if(ModeFilter==enFilterOption.PersonID)
            {
                crlShowPersonInformation1.LoadPersonInformation(Convert.ToInt32(txtSearch.Text.Trim()));
            }else
                {
             
                crlShowPersonInformation1.LoadPersonInformation(txtSearch.Text.Trim());
            }

            if (OnPersonSelected!=null)
                OnPersonSelected(crlShowPersonInformation1.PersonID);
        }




        /// EVENTS  /// ////////////////

        private void crlShowPersonInformation1_Load(object sender, EventArgs e)
        {
            _LoadFilterOptions();

        }

       
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            ModeFilter = (enFilterOption)cmbFilter.SelectedIndex;
            bool isNumericFilter =
      ModeFilter == enFilterOption.PersonID; 

   

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
            //txtSearch.Enabled = ((enFilterOption)cmbFilter.SelectedIndex != enFilterOption.None);

            txtSearch.Clear();
            errorProvider1.SetError(txtSearch, "");

            if (txtSearch.Enabled)
            {
                txtSearch.Focus();
            }

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson AddNew =new frmAddUpdatePerson();
            AddNew.DataBack+= DataBackEvent;
            AddNew.ShowDialog();
        }
        private void DataBackEvent(object sender, clsPerson Person)
        {
            // Handle the data received


            cmbFilter.SelectedIndex = 1;
            txtSearch.Text = Person.PersonID.ToString();
            crlShowPersonInformation1.LoadPersonInformation(Person);
        }
        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                errorProvider1.SetError(txtSearch, "Please enter a value to search."); return;
            }
            _SearchPersonWithFilter();
        }
    }
}
