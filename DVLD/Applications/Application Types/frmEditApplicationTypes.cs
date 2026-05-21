using DVLD.Global;
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

namespace DVLD.Applications.ApplicationTypes
{
    
    public partial class frmEditApplicationTypes : Form
    {
        public  event Action AppTypeUpdated;

        private int _ID;
        private clsApplicationType _AppType;
        public frmEditApplicationTypes(int ID)
        {
            InitializeComponent();

            _ID = ID;
            _AppType = clsApplicationType.Find(ID);
            
        }

        private void _FillInfoInTextBoxes()
        {
            txtAppTypeTitle.Text = _AppType.ApplicationTypeTitle;
            txtAppTypeFees.Text = _AppType.ApplicationFees.ToString();
        }
        private bool _IsFeesValid() {

            bool isFeesEmpty = string.IsNullOrWhiteSpace(txtAppTypeFees.Text);
            bool IsFeesNumbricValue= clsnValidation.IsPositiveDecimal(txtAppTypeFees.Text);
            clsUICustomization.SetErrorProviderAndReturnValidity(txtAppTypeFees, errorProvider1,
               isFeesEmpty, "Application Fees is required.");

            if(!isFeesEmpty)
                clsUICustomization.SetErrorProviderAndReturnValidity(txtAppTypeFees, errorProvider1,
              !IsFeesNumbricValue, "Application Fees Should be Numbric value .");

            return !isFeesEmpty && IsFeesNumbricValue;
        }
     
        private bool _IsValid() { 

        bool isTitleEmpty = string.IsNullOrWhiteSpace(txtAppTypeTitle.Text);
          

            //clsUICustomization.SetErrorProviderAndReturnValidity(txtAppTypeTitle, errorProvider1,
            //    isTitleEmpty, "Application Type Title is required.");

                       
            return !isTitleEmpty && _IsFeesValid();
        }

        private void _LoadDataFromForm() {
        
            _AppType.ApplicationTypeTitle = txtAppTypeTitle.Text.Trim();
            _AppType.ApplicationFees=Convert.ToDecimal(txtAppTypeFees.Text.Trim());
        }

        private void frmEditApplicationTypes_Load(object sender, EventArgs e)
        {
            lblAppTypeIDValue.Text = _ID.ToString();

            if (_AppType != null)
            _FillInfoInTextBoxes();


        }

        private void txtAppTypeTitle_Validating(object sender, CancelEventArgs e)
        {
          
            clsUICustomization.SetErrorProviderAndReturnValidity(txtAppTypeTitle, errorProvider1, 
                string.IsNullOrWhiteSpace(txtAppTypeTitle.Text), "Application Type Title is required.");

        }

        private void txtAppTypeFees_Validating(object sender, CancelEventArgs e)
        {
            _IsFeesValid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_IsValid())
            {
                MessageBox.Show("Please Fill All Required Fields.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(_AppType== null)
            {
                MessageBox.Show("Save failed,There is something error .", " Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _LoadDataFromForm();

            if (_AppType.Save())
            {
                AppTypeUpdated?.Invoke();
                MessageBox.Show(
                   "Saved changed successfully.",
                   "Success",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Save failed,There is something error .", " Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
