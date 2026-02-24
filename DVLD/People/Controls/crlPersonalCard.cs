using Syncfusion.WinForms.Input;
using Syncfusion.WinForms.ListView;
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
    public partial class crlPersonalCard : UserControl
    {

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

        private void _SetErrorProviderWithEmail(Control ctrl, string errorMessage)
        {
            ctrl.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(ctrl.Text))
                {
                    errorProvider1.SetError(ctrl, string.Empty);
                }
                else
                {
                    errorProvider1.SetError(ctrl, errorMessage);
                   
                }
            };

        }


        // دالة احترافية لدمج التأثير البصري
        private void LinkUnderlineWithTextBox(TextBox txt, Panel pnl)
        {
            pnl.BackColor = Color.Gray;
            // عند الضغط داخل التيكست بوكس (Enter)
            txt.Enter += (s,  e) =>
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
            rb.Enter += (s, e) =>
            {
                pnl.BackColor = Color.DodgerBlue; // اللون الأزرق الذي اخترته في تصميمك
                pnl.Height = 2; // تسميك الخط قليلاً عند التركيز
            };

            // عند ترك التيكست بوكس (Leave)
            rb.Leave += (s, e) =>
            {
                pnl.BackColor = Color.Gray; // العودة للرمادي
                pnl.Height = 1; // تقليل السمك
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
        private void LinkUnderlineWithDateTimePicker(SfDateTimeEdit  dtp, Panel pnl)
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
        public crlPersonalCard()
        {
            InitializeComponent();
        }

        
        private void crlPersonalCard_Load(object sender, EventArgs e)
        {
          _SetupUIforUnderlineEffect();
           _SetErrorProvider(txtFirstName, "First Name is required.");
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
    }
}
