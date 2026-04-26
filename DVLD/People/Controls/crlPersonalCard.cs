using DVLD.Global;
using DVLD.Properties;
using DVLD_BusinessLayer;
using DVLD_Global;
using Syncfusion.Data.Extensions;
using Syncfusion.WinForms.Input;
using Syncfusion.WinForms.ListView;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace DVLD.People.Controls
{

    public partial class crlPersonalCard : UserControl
    {
         
       // public static string ProjectFolder = @"..\..\..\Resources\ProfilePictures";
       
        enum enMode { AddNew=0, Update = 1 }
        enum enGender { Male = 0, Famale = 1 }

        enMode _Mode=enMode.AddNew;

        private int _PersonID = -1;

        public int PersonID
        {

           get { return _PersonID; }
        
            
            set {

                _PersonID = value;
                if(_PersonID!=-1)
                {
                    _Mode = enMode.Update;
                    _LoadData();
                }
            }
        }
        public clsPerson _Person;


        public crlPersonalCard()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            _Person = new clsPerson();
        }
       
        public clsPerson GetPersonInfo()
        {


            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecName.Text.Trim();
            _Person.ThirdName = txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();

            _Person.NationalNo = txtNationalNo.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();

            _Person.Gendor = rbMale.Checked ? (short)enGender.Male : (short)enGender.Famale;


            if (dtDateOfBirth.Value != null)
            {
                _Person.DateOfBirth = (DateTime)dtDateOfBirth.Value;
            }

            if (cmbCountry.SelectedValue != null)
            {
                _Person.NationalityCountryID = (int)cmbCountry.SelectedValue;
            }


            if (pbPersonPicture.ImageLocation != null)
            {
                _Person.ImagePath = Path.GetFileName(pbPersonPicture.ImageLocation);
            }
            else
            {
                _Person.ImagePath = "";
            }

             
            return _Person;
        }


       

        private void _DefaultValue()
        {

            dtDateOfBirth.MaxDateTime = DateTime.Now.AddYears(-18).Date;
            dtDateOfBirth.MinDateTime = new DateTime(1900, 1, 1).Date;
             rbMale.Checked = true;
            pbPersonPicture.Image = rbMale.Checked ? Resources.Male :Resources.Female;




        }
     

        private void _SetupUIforUnderlineEffect()
        {
            clsUICustomization.LinkUnderlineWithTextBox(txtFirstName, pnlFirstname);
            clsUICustomization.LinkUnderlineWithTextBox(txtSecName, pnlSecondName);
            clsUICustomization.LinkUnderlineWithTextBox(txtThirdName, pnlThirdName);
            clsUICustomization.LinkUnderlineWithTextBox(txtLastName, pnlLastName);
            clsUICustomization.LinkUnderlineWithTextBox(txtPhone, pnlPhone);
            clsUICustomization.LinkUnderlineWithTextBox(txtEmail, pnlEmail);
            clsUICustomization.LinkUnderlineWithTextBox(txtNationalNo, pnlNationalNo);

            clsUICustomization.LinkUnderlineWithRadioButton(rbMale, pnlMale);
            clsUICustomization.LinkUnderlineWithRadioButton(rbFemale, pnlFemale);
            clsUICustomization.LinkUnderlineWithComboBox(cmbCountry, pnlCountry);
            clsUICustomization.LinkUnderlineWithDateTimePicker(dtDateOfBirth, pnlDate);

        }

        private void _SetErrorProvederEffect()
        {
            clsUICustomization.SetErrorProvider(txtFirstName, errorProvider1,string.IsNullOrWhiteSpace(txtFirstName.Text) ,"First Name is required.");
          
            clsUICustomization.SetErrorProvider(txtSecName, errorProvider1, string.IsNullOrWhiteSpace(txtSecName.Text), "Second Name is required.");
            clsUICustomization.SetErrorProvider(txtLastName, errorProvider1, string.IsNullOrWhiteSpace(txtLastName.Text), "Last Name is required.");
            clsUICustomization.SetErrorProvider(txtPhone, errorProvider1, string.IsNullOrWhiteSpace(txtPhone.Text), "Phone Number is Required");
            clsUICustomization.SetErrorProvider(txtAddress, errorProvider1, string.IsNullOrWhiteSpace(txtAddress.Text), "Address is Required");
            // clsUICustomization.SetErrorProvider(txtNationalNo, errorProvider1, "National Number is Required");
            clsUICustomization.SetOptionalEmailErrorProvider(txtEmail, errorProvider1, "Please enter a valid email address.");
        }

       

        public bool ImageHandler()
        {
            if (_Person.ImagePath ==Path.GetFileName( pbPersonPicture.ImageLocation)  )
            {
                return true;
            }

            string fullPathOfCurrentImage = Path.GetFullPath(Path.Combine(clsProjectFolderSetting.ProjectFolderPath, _Person.ImagePath));
            if (_Person.ImagePath != pbPersonPicture.ImageLocation)
            {
                if (_Person.ImagePath != "" )
                {
                    try
                    {
                        File.Delete(fullPathOfCurrentImage);
                    }
                    catch (Exception ex)
                    {

                    }
                }

                if (pbPersonPicture.ImageLocation != null)
                {
                    string Source =pbPersonPicture.ImageLocation.ToString();
                    if (clsUtil.CopyImageToProjectFolderPathHandler(ref Source, clsProjectFolderSetting.ProjectFolderPath))
                    {
                        pbPersonPicture.ImageLocation= Source;
                        return true;
                    }

                }
               
            }

            
            return true;
        }


        private void _LoadData()
        {

            _Person = clsPerson.Find(PersonID);
            
            if (_Person == null)
            {
                MessageBox.Show("No Person with ID = " + PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            lblPersonID.Text = _Person.PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            dtDateOfBirth.Value = _Person.DateOfBirth;

            if (_Person.Gendor == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            txtAddress.Text = _Person.Address;
            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;
            cmbCountry.SelectedValue = _Person.NationalityCountryID;


            if (_Person.ImagePath != "")
            {
                pbPersonPicture.ImageLocation = Path.Combine(clsProjectFolderSetting.ProjectFolderPath, _Person.ImagePath);

            }


            llRemove.Visible = (_Person.ImagePath != "");
        }
        private void crlPersonalCard_Load(object sender, EventArgs e)
        {
            DataTable dtCountries = clsCountry.GetAllCountries();
            cmbCountry.DataSource = dtCountries;
            cmbCountry.DisplayMember = "CountryName";
            cmbCountry.ValueMember = "CountryID";
           

            DataRow[] foundRows = dtCountries.Select("CountryName = 'Saudi Arabia'");
            if (foundRows.Length > 0)
            {
                cmbCountry.SelectedValue = foundRows[0]["CountryID"];
            }
            _SetupUIforUnderlineEffect();
            _SetErrorProvederEffect();
            _DefaultValue();
          

            
        }

        
    

        
       

        private void rbMale_Click(object sender, EventArgs e)
        {
            if (pbPersonPicture.ImageLocation == null)
                pbPersonPicture.Image = Resources.Male;
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
           if(pbPersonPicture.ImageLocation==null)
            pbPersonPicture.Image = Resources.Female;
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog1.Title = "Select a Profile Picture";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // 1. Just SHOW the picture on the screen. Do NOT copy it yet!
                pbPersonPicture.ImageLocation = openFileDialog1.FileName;
                llRemove.Visible = true;
               
               

            }
           
           
        }

        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNationalNo_TextChanged(object sender, EventArgs e)
        
            
        {    

        }
        

        private void txtNationalNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNationalNo.Text))

            {

                errorProvider1.SetError(txtNationalNo, "This National Number Reqiured.");
                return;

            }
            if (txtNationalNo.Text.Trim() != _Person.NationalNo && clsPerson.IsPersonExist(txtNationalNo.Text.Trim()))

            {
                errorProvider1.SetError(txtNationalNo, "This National Number already exists.");
                e.Cancel = true;
            }
            else

            {
                errorProvider1.SetError(txtNationalNo, string.Empty);
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtPhone, "Please enter a valid numeric value.");



            }
        }

        private void lblPersonID_Click(object sender, EventArgs e)
        {

        }

        private void llRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonPicture.ImageLocation = null;
            if (rbMale.Checked)
            {
                pbPersonPicture.Image = Properties.Resources.Male;
            }
            else
            {
                pbPersonPicture.Image = Properties.Resources.Female;
            }
            llRemove.Visible = false;
        }
    }
}
