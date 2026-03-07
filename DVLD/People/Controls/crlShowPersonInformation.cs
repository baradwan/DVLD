using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        public crlShowPersonInformation()
        {
            InitializeComponent();
        }
  

       
        public void LoadPersonInformation(int PersonID)
        {
           

            _Person = clsPerson.Find(PersonID);
            if (_Person == null)
            {
                MessageBox.Show("No Person with ID = " + _PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                _ResetInfo();
                return;
            }
            _PersonID = PersonID;
            _FillPersonInformation();



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
            pbPersonalProfile.ImageLocation = null; // Clear any displayed image
        }
        private void _FillPersonInformation()
        {
            // Check if the _Person object is null before accessing its properties.
           

            _PersonID = _Person.PersonID;
            lblPersonIDValue.Text = _PersonID.ToString();
            lblFullNameValue.Text = $"{_Person.FirstName} {_Person.SecondName} {_Person.ThirdName} {_Person.LastName}";
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
            if (!string.IsNullOrWhiteSpace(_Person.ImagePath))
            {
                pbPersonalProfile.ImageLocation = _Person.ImagePath;
            }
            else
            {
                // Set a default image based on gender if no specific image is provided.
                // Assuming `Properties.Resources.Male` and `Properties.Resources.Female` exist.
                pbPersonalProfile.Image = _Person.Gendor == 0 ? Properties.Resources.Male : Properties.Resources.Female;
            }
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
