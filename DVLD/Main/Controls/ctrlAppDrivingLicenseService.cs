using DVLD.Applications.Local_Driving_License;
using DVLD.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Main
{
    public partial class ctrlAppDrivingLicenseService : UserControl
    {
        bool isCollapsed = true;

      
        int fullWidth = 0;
        int normalWidth = 0;
        public ctrlAppDrivingLicenseService()
        {
            InitializeComponent();
        }

        
        private void SetupButtonsHoverEffect(Control container, Color defaultColor, Color hoverColor)
        {
            // تعريف الألوان للنصوص (اختياري)
            Color textColor = Color.White;

            // المرور على جميع العناصر داخل الحاوية
            foreach (Control ctrl in container.Controls)
            {
                if (ctrl is Button btn) // تأكد من أن العنصر هو زر
                {
                    // ضبط الخصائص الأساسية
                    btn.BackColor = defaultColor;
                    btn.ForeColor = textColor;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0; // إزالة الحواف الافتراضية
                    btn.Cursor = Cursors.Hand;        // تغيير شكل الفأرة

                    // ربط الأحداث (Events)
                    btn.MouseEnter += (s, e) => btn.BackColor = hoverColor;
                    btn.MouseLeave += (s, e) => btn.BackColor = defaultColor;
                }
            }
        }


        // EVENT HANDLERS////////
        //
        //

        private void ctrlAppDrivingLicenseService_Load(object sender, EventArgs e)
        {
            Color primaryBlue = Color.FromArgb(2, 132, 199); 
            Color hoverBlue = Color.FromArgb(3, 105, 161);  
            fullWidth = clsUICustomization.GetFullWidthOfControls(pnlNewDrivingLicenceSubButtons);
            normalWidth = pnlNewDrivingLicenceSubButtons.Width;
            SetupButtonsHoverEffect(pnlNewDrivingLicenceSubButtons, primaryBlue, hoverBlue);
        }

        
        private void btnNewDrivingLicense_Click(object sender, EventArgs e)
        {
           clsUICustomization.ToggleAnimation(pnlNewDrivingLicenceSubButtons, fullWidth, normalWidth, 10, false, () => { isCollapsed = false; });

        }

        private void btnLocalLicense_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicenseApplication frm = new frmAddUpdateLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }
    }
}
