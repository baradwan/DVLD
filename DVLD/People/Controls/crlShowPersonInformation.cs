using DVLD.Properties;
using DVLD_BusinessLayer;
using DVLD_Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.People.Controls
{
    public partial class crlShowPersonInformation : UserControl
    {
        clsPerson _Person;
        int _PersonID;

        public int PersonID
        {
            get { return _PersonID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return _Person; }
        }
        public crlShowPersonInformation()
        {
            InitializeComponent();
        }
  

       
        public void LoadPersonInformation(int PersonID)
        {
           

            _Person = clsPerson.Find(PersonID);
            if (_Person == null)
            {
                MessageBox.Show("No Person with ID = " + PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                _ResetInfo();
                return;
            }
           // _PersonID = PersonID;
            _FillPersonInformation();



        }
        public void LoadPersonInformation(string NationalNo)
        {


            _Person = clsPerson.Find(NationalNo);
            if (_Person == null)
            {
                MessageBox.Show("No Person with National No = " + NationalNo, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                _ResetInfo();
                return;
            }
            // _PersonID = PersonID;
            _FillPersonInformation();



        }
        public void LoadPersonInformation(clsPerson Person)
        {


           // _Person = clsPerson.Find(PersonID);
            if (Person == null)
            {
                MessageBox.Show("No Person data was provided.",
                           "Person Not Found",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Exclamation);
                _ResetInfo();
                return;
            }
           _Person = Person;
            _FillPersonInformation();



        }

        private void _LoadPersonImage()
        {

            if (_Person.ImagePath == null)
                return;
            if (_Person.Gendor == 0)
                pbPersonalProfile.Image = Resources.Male;
            else
                pbPersonalProfile.Image = Resources.Female;

            string ImagePath =Path.Combine(clsProjectFolderSetting.ProjectFolderPath, _Person.ImagePath);
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonalProfile.ImageLocation = ImagePath;
               

        }
        private void _ResetInfo()
        {
            // Optionally, clear the labels or show an error message if _Person is not set.
            _PersonID = -1; // Indicate no person is loaded
            lblFullNameValue.Text = "[N/A]";
            lblNationalNoValue.Text = "[N/A]";
            lblDateOfBirthValue.Text = "[N/A]";
            lblGenderValue.Text = "[N/A]";
            lblNationalityValue.Text = "[N/A]";
            lblPhoneValue.Text = "[N/A]";
            lblEmailValue.Text = "[N/A]";
            lblShortNameUnderImage.Text = "[N/A]";
            lblAddressValue.Text = "[N/A]";
            pbPersonalProfile.ImageLocation = null; // Clear any displayed image
        }
        private void _FillPersonInformation()
        {
            // Check if the _Person object is null before accessing its properties.
           

            _PersonID = _Person.PersonID;
            lblPersonIDValue.Text = _PersonID.ToString();
            lblFullNameValue.Text = _Person.FullName;
            lblShortNameUnderImage.Text = $"{_Person.FirstName} {_Person.LastName}";
            lblNationalNoValue.Text = _Person.NationalNo;
            // Format the date of birth to "dd/MM/yyyy" for consistency and readability.
            lblDateOfBirthValue.Text = _Person.DateOfBirth.ToString("dd/MM/yyyy");
            // Use a conditional (ternary) operator for gender display.
            lblGenderValue.Text = _Person.Gendor == 0 ? "Male" : "Female";

            // Retrieve and display the country name based on NationalityCountryID.
            // Add null-conditional operator to prevent potential NullReferenceException if Find returns null.
            lblNationalityValue.Text = clsCountry.Find(_Person.NationalityCountryID)?.CountryName ?? "[N/A]";

            // Display phone and email, handling potential null or empty strings gracefully.
            lblPhoneValue.Text = string.IsNullOrWhiteSpace(_Person.Phone) ? "[N/A]" : _Person.Phone;
            lblEmailValue.Text = string.IsNullOrWhiteSpace(_Person.Email) ? "[N/A]" : _Person.Email;
            lblAddressValue.Text = string.IsNullOrWhiteSpace(_Person.Address) ? "[N/A]" : _Person.Address;
            // Display the person's image if available, otherwise set a default image.
            _LoadPersonImage();
        }       

       

        private void SetupCircularPictureBox()
        {
            pbPersonalProfile.SizeMode = PictureBoxSizeMode.Zoom;

            // يفضل إزالة الإطار المربع لأننا سنقص الصورة بشكل دائري
            pbPersonalProfile.BorderStyle = BorderStyle.None;
            // حساب المنتصف بدقة
            int x = (pnlBackPrifilePic.Width - pbPersonalProfile.Width) / 2;
            int y = (pnlBackPrifilePic.Height - pbPersonalProfile.Height) / 2;

            // تعيين موقع الصورة لتكون في المنتصف
            pbPersonalProfile.Location = new Point(x, y);
            // ضبط خصائص الـ CircularPictureBox
            pbPersonalProfile.SizeMode = PictureBoxSizeMode.Zoom; // لضمان ملء الصورة داخل الدائرة
            pbPersonalProfile.BorderStyle = BorderStyle.FixedSingle; // إطار بسيط حول الصورة
            pbPersonalProfile.BackColor = Color.LightGray; // لون خلفية افتراضي في حال عدم وجود صورة
            pbPersonalProfile.Image = Properties.Resources.Male; // صورة افتراضية (تأكد من وجودها في الموارد)
                                                                 // كود لجعل حواف الصورة دائرية برمجياً
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pbPersonalProfile.Width - 1, pbPersonalProfile.Height - 1);
            pbPersonalProfile.Region = new Region(gp);

            GraphicsPath pnl = new GraphicsPath();
            pnl.AddEllipse(1,1, pnlBackPrifilePic.Width , pnlBackPrifilePic.Height );
            pnlBackPrifilePic.Region = new Region(pnl);

        }


        private void crlShowPersonInformation_Load(object sender, EventArgs e)
        {
            SetupCircularPictureBox();
          
        }

        private void pbPersonalProfile_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(pnlBackPrifilePic.BackColor, 2f))
            {
                e.Graphics.DrawEllipse(pen, 0, 0, pbPersonalProfile.Width - 1, pbPersonalProfile.Height - 1);
            }
        }

        private void pnlBackPrifilePic_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // رسم إطار ناعم بنفس لون خلفية الفورم الأساسي لإخفاء التسنن الخارجي
            using (Pen pen = new Pen(this.BackColor, 2f))
            {
                e.Graphics.DrawEllipse(pen, 0, 0, pnlBackPrifilePic.Width - 1, pnlBackPrifilePic.Height - 1);
            }
        }

      

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(PersonID);
            frm.PersonSaved += FrmUpdate_PersonSaved;
            frm.FormClosed += (s, args) =>
            {
                frm.PersonSaved -= FrmUpdate_PersonSaved;
            };
            frm.ShowDialog();
        }
      
          
           
        

        private void FrmUpdate_PersonSaved(clsPerson person)
        {
           LoadPersonInformation(person);
            
        }
    }
}
