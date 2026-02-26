using DVLD_BusinessLayer;
using Syncfusion.WinForms.Input;
using Syncfusion.WinForms.ListView;
using System;

using System.Drawing;

using System.Windows.Forms;


namespace DVLD.People.Controls
{
    public partial class crlPersonalCard : UserControl
    {

        public clsPerson Person = new clsPerson();


        private void _SetErrorProvider(Control ctrl, string errorMessage)
        {
            ctrl.Leave += (s, e) =>
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

            dtDateOfBirth.MaxDateTime = DateTime.Now.AddYears(-18);
            dtDateOfBirth.MinDateTime = new DateTime(1900, 1, 1);
            rbMale.Checked = true;
            //pnlMale.BackColor = Color.DodgerBlue; // اللون الأزرق الذي اخترته في تصميمك
            //pnlMale.Height = 2;


        }
        private void _SetErrorProviderWithEmail(Control ctrl, string errorMessage)
        {
            ctrl.Leave += (s, e) =>
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
           // _SetErrorProvider(txtNationalNo, "National Number is Required");
            _SetErrorProviderWithEmail(txtEmail, "Please enter a valid email address.");
        }
        public crlPersonalCard()
        {
            InitializeComponent();
        }


        private void crlPersonalCard_Load(object sender, EventArgs e)
        {
            _SetupUIforUnderlineEffect();
            _SetErrorProvederEffect();
            _DefaultValue();
        }

        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSecName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNationalNo_Leave(object sender, EventArgs e)
        {
            if (clsPerson.IsPersonExist(txtNationalNo.Text.Trim()))
            {
                errorProvider1.SetError(txtNationalNo, "This National Number already exists.");
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, string.Empty);
            }
        }

        private void txtNationalNo_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
