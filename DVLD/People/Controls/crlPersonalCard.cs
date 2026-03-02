using DVLD.Properties;
using DVLD_BusinessLayer;
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


       


       
        public clsPerson GetPersonInfo()
        {
      
            clsPerson person = new clsPerson();

            person.FirstName = txtFirstName.Text.Trim();
            person.SecondName = txtSecName.Text.Trim();
            person.ThirdName = txtThirdName.Text.Trim();
            person.LastName = txtLastName.Text.Trim();

            person.NationalNo = txtNationalNo.Text.Trim();
            person.Email = txtEmail.Text.Trim();
            person.Phone = txtPhone.Text.Trim();
            person.Address = txtAddress.Text.Trim();
            
            person.Gendor = rbMale.Checked ? (short)0 : (short)1;

         
            if (dtDateOfBirth.Value != null)
            {
                person.DateOfBirth = (DateTime)dtDateOfBirth.Value;
            }

            if (cmbCountry.SelectedValue != null)
            {
                person.NationalityCountryID = (int)cmbCountry.SelectedValue;
            }

        
            if (pbPersonPicture.ImageLocation != null)
            {
                person.ImagePath =Path.GetFileName( pbPersonPicture.ImageLocation);
            }
            else
            {
                person.ImagePath = ""; 
            }

           
            return person;
        }

        
        //public clsPerson LoadPersonData(int PersonID)
        //{
            
        //}
        private void _SetErrorProvider(Control ctrl, string errorMessage)
        {
            ctrl.Validating+= (s, e) =>
             {
                 if (string.IsNullOrWhiteSpace(ctrl.Text))
                 {
                     errorProvider1.SetError(ctrl, errorMessage);
                 }
                 else
                 {
                     errorProvider1.SetError(ctrl, string.Empty);
                 }
             };

        }

        private void _DefaultValue()
        {

            dtDateOfBirth.MaxDateTime = DateTime.Now.AddYears(-18).Date;
            dtDateOfBirth.MinDateTime = new DateTime(1900, 1, 1).Date;
            rbMale.Checked = true;
            cmbCountry.SelectedIndex = 175;

           

        }
        private void _SetErrorProviderWithEmail(Control ctrl, string errorMessage)
        {
            ctrl.Validating+= (s, e) =>
            {
                //if (string.IsNullOrWhiteSpace(ctrl.Text))
                //{
                //    errorProvider1.SetError(ctrl, string.Empty);
                //}
                //else
                //{

                //    errorProvider1.SetError(ctrl, errorMessage);

                //}

                if ((ctrl.Text.Contains($"@") && ctrl.Text.EndsWith(".com", StringComparison.OrdinalIgnoreCase)) || string.IsNullOrWhiteSpace(ctrl.Text))
                {
                    errorProvider1.SetError(ctrl, string.Empty);


                }
                else
                {
                    errorProvider1.SetError(ctrl, errorMessage);
                }
            };

        }


        private void LinkUnderlineWithTextBox(TextBox txt, Panel pnl)
        {
            pnl.BackColor = Color.Gray;
            // عند الضغط داخل التيكست بوكس (Enter)
            txt.Enter += (s, e) =>
            {
                pnl.BackColor = Color.DodgerBlue;
                pnl.Height = 2; // تسميك الخط قليلاً عند التركيز
            };


            txt.Leave += (s, e) =>
            {
                pnl.BackColor = Color.Gray;
                pnl.Height = 1;
            };
        }
        private void LinkUnderlineWithRadioButton(RadioButton rb, Panel pnl)
        {


            pnl.BackColor = Color.Gray;
            // عند الضغط داخل التيكست بوكس (Enter)
            rb.CheckedChanged += (s, e) =>
            {
                if (rb.Checked)
                {
                    pnl.BackColor = Color.DodgerBlue; // اللون الأزرق الذي اخترته في تصميمك
                    pnl.Height = 2; // تسميك الخط قليلاً عند التركيز
                }
                else
                {
                    pnl.BackColor = Color.Gray;
                    pnl.Height = 1;
                }
            };


        }

        private void LinkUnderlineWithComboBox(SfComboBox cb, Panel pnl)
        {
            pnl.BackColor = Color.Gray;
            // عند الضغط داخل التيكست بوكس (Enter)
            cb.Enter += (s, e) =>
            {
                pnl.BackColor = Color.DodgerBlue; // اللون الأزرق الذي اخترته في تصميمك
                pnl.Height = 2; // تسميك الخط قليلاً عند التركيز
            };
            // عند ترك التيكست بوكس (Leave)
            cb.Leave += (s, e) =>
            {
                pnl.BackColor = Color.Gray; // العودة للرمادي
                pnl.Height = 1; // تقليل السمك
            };
        }
        private void LinkUnderlineWithDateTimePicker(SfDateTimeEdit dtp, Panel pnl)
        {
            pnl.BackColor = Color.Gray;
            // عند الضغط داخل التيكست بوكس (Enter)
            dtp.Enter += (s, e) =>
            {
                pnl.BackColor = Color.DodgerBlue; // اللون الأزرق الذي اخترته في تصميمك
                pnl.Height = 2; // تسميك الخط قليلاً عند التركيز
            };
            // عند ترك التيكست بوكس (Leave)
            dtp.Leave += (s, e) =>
            {
                pnl.BackColor = Color.Gray; // العودة للرمادي
                pnl.Height = 1; // تقليل السمك
            };
        }
        private void _SetupUIforUnderlineEffect()
        {
            LinkUnderlineWithTextBox(txtFirstName, pnlFirstname);
            LinkUnderlineWithTextBox(txtSecName, pnlSecondName);
            LinkUnderlineWithTextBox(txtThirdName, pnlThirdName);
            LinkUnderlineWithTextBox(txtLastName, pnlLastName);
            LinkUnderlineWithTextBox(txtPhone, pnlPhone);
            LinkUnderlineWithTextBox(txtEmail, pnlEmail);
            LinkUnderlineWithTextBox(txtNationalNo, pnlNationalNo);

            LinkUnderlineWithRadioButton(rbMale, pnlMale);
            LinkUnderlineWithRadioButton(rbFemale, pnlFemale);
            LinkUnderlineWithComboBox(cmbCountry, pnlCountry);
            LinkUnderlineWithDateTimePicker(dtDateOfBirth, pnlDate);

        }

        private void _SetErrorProvederEffect()
        {
            _SetErrorProvider(txtFirstName, "First Name is required.");
            _SetErrorProvider(txtSecName, "Second Name is required.");
            _SetErrorProvider(txtLastName, "Last Name is required.");
            _SetErrorProvider(txtPhone, "Phone Number is Required");
            _SetErrorProvider(txtAddress, "Address is Required");
            // _SetErrorProvider(txtNationalNo, "National Number is Required");
            _SetErrorProviderWithEmail(txtEmail, "Please enter a valid email address.");
        }

        private void _CopyImageToProjectFolder()


        {

            if (pbPersonPicture.ImageLocation == null)
            {
                return;
            }
            string CurrentDirectory = Application.StartupPath;
            string ProjectFolder = @"..\..\..\Resources\ProfilePictures";
            string FullPathDes = Path.GetFullPath(Path.Combine(CurrentDirectory, ProjectFolder));
            string SourceFilePath = string.Empty;


           
            
                SourceFilePath = openFileDialog1.FileName;
                string Extention = Path.GetExtension(SourceFilePath);
                string UniqueFileName = $"{Guid.NewGuid().ToString()}{Extention}";
                if (!Directory.Exists(FullPathDes))
                {
                    Directory.CreateDirectory(FullPathDes);


                }

                string DestinationFilePath = Path.Combine(FullPathDes, UniqueFileName);
                File.Copy(SourceFilePath, DestinationFilePath);

                pbPersonPicture.ImageLocation = DestinationFilePath;
            
        }
        public crlPersonalCard()
        {
            InitializeComponent();
        }


        private void crlPersonalCard_Load(object sender, EventArgs e)
        {
            DataTable dtCountries = clsCountry.GetAllCountries();
            cmbCountry.DataSource = dtCountries;
            cmbCountry.DisplayMember = "CountryName";
            cmbCountry.ValueMember = "CountryID";
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

                _CopyImageToProjectFolder();

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
            if (clsPerson.IsPersonExist(txtNationalNo.Text.Trim()))

            {
                errorProvider1.SetError(txtNationalNo, "This National Number already exists.");
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
    }
}
