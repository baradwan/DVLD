using DVLD.Global;
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
using static DVLD_BusinessLayer.clsTestTypes;

namespace DVLD.Applications.Manage_Test_Types
{
    public partial class frmEditTestTypes : Form
    {
        public event Action TestTypeUpdated;

        private int _ID;
        private clsTestType _TestType;

        public frmEditTestTypes(int ID)
        {
            InitializeComponent();
           

            _ID = ID;
            _TestType = clsTestType.Find(ID);
        }
        private void _FillInfoInTextBoxes()
        {
            txtTestTypeTitleValue.Text = _TestType.TestTypeTitle;
            txtTestTypeDescriptionValue.Text = _TestType.TestTypeDescription;
            txtTestTypeFees.Text = _TestType.TestTypeFees.ToString();
        }

        private bool _IsFeesValid()
        {
            
            bool isFeesEmpty = string.IsNullOrWhiteSpace(txtTestTypeFees.Text);
            bool IsFeesNumbricValue = clsnValidation.IsPositiveDecimal(txtTestTypeFees.Text);
            clsUICustomization.SetErrorProviderAndReturnValidity(txtTestTypeFees, errorProvider1,
               isFeesEmpty, "Test Fees is required.");

            if (!isFeesEmpty)
                clsUICustomization.SetErrorProviderAndReturnValidity(txtTestTypeFees, errorProvider1,
              !IsFeesNumbricValue, "Test Fees Should be Numbric value .");

            return !isFeesEmpty && IsFeesNumbricValue;
        }

        private bool _IsValid()
        {
            

            bool isDescriptionEmpty =
                string.IsNullOrWhiteSpace(txtTestTypeDescriptionValue.Text);

           
            bool isTitleEmpty =
               string.IsNullOrWhiteSpace(txtTestTypeDescriptionValue.Text);

            //clsUICustomization.SetErrorProviderAndReturnValidity(
            //    txtTestTypeDescriptionValue,
            //    errorProvider1,
            //    isDescriptionEmpty,
            //    "Test Type Description is required.");




            //clsUICustomization.SetErrorProviderAndReturnValidity(
            //    txtTestTypeDescriptionValue,
            //    errorProvider1,
            //    isTitleEmpty,
            //    "Test Type Title is required.");

            return !isDescriptionEmpty && _IsFeesValid();
        }
        private void _LoadDataFromForm()
        {

            _TestType.TestTypeTitle = txtTestTypeTitleValue.Text.Trim();
            _TestType.TestTypeDescription = txtTestTypeDescriptionValue.Text.Trim();
            _TestType.TestTypeFees = Convert.ToDecimal(txtTestTypeFees.Text.Trim());
        }
        

        private void frmEditTestTypes_Load(object sender, EventArgs e)
        {
            lblTestTypeIDValue.Text = _ID.ToString();

            if (_TestType != null)
                _FillInfoInTextBoxes();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_IsValid())
            {
                MessageBox.Show("Please Fill All Required Fields.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_TestType == null)
            {
                MessageBox.Show("Save failed,There is something error .", " Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _LoadDataFromForm();

            if (_TestType.Save())
            {
                TestTypeUpdated?.Invoke();
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

        private void txtTestTypeTitleValue_Validating(object sender, CancelEventArgs e)
        {
            bool isTitleEmpty = string.IsNullOrWhiteSpace(txtTestTypeTitleValue.Text);

            clsUICustomization.SetErrorProviderAndReturnValidity(
                txtTestTypeTitleValue,
                errorProvider1,
                isTitleEmpty,
                "Test Type Title is required.");
        }

        private void txtTestTypeDescriptionValue_Validating(object sender, CancelEventArgs e)
        {
            bool isDescriptionEmpty = string.IsNullOrWhiteSpace(txtTestTypeDescriptionValue.Text);

            clsUICustomization.SetErrorProviderAndReturnValidity(
                txtTestTypeDescriptionValue,
                errorProvider1,
                isDescriptionEmpty,
                "Test Type  Description is required.");
        }
    }
    
}
