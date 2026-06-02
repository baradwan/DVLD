using DVLD.Applications.Local_Driving_License;
using DVLD.Global;
using DVLD.Login;
using DVLD.Main;
using DVLD.Main.Controls;
using DVLD.Users;
using DVLD_BusinessLayer;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.Core;
using Syncfusion.WinForms.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmMain  :SfForm
    {
        private object tableLayoutPanel;
        bool isCollapsed = true;
        
        private const int AnimationStep = 10;
        private  int NormalSize =0;
           int fullHeight=0;

        private ctrlAccountSetting _ctrlAccountSetting;
        private ctrlAppDrivingLicenseService _ctrlDrivingLicenseService;
        private ctrlManageApplication _ctrlManageApplications;
        frmLogin _frmLogin;
        
        public frmMain(frmLogin frm)

        {
            
            InitializeComponent();



            Syncfusion.WinForms.Controls.SfSkinManager.LoadAssembly(typeof(Syncfusion.WinForms.Themes.Office2019Theme).Assembly);
            Syncfusion.WinForms.Controls.SfSkinManager.SetTheme(this, "Office2019Colorful");

            _frmLogin = frm;


        }


        private void EnableDoubleBuffering()
        {
            // تفعيل الـ DoubleBuffered للـ Form نفسه
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.DoubleBuffer |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            // إذا كان لديك Panel رئيسي يحتوي على الـ Controls (مثلاً panel2)
            // نقوم بتفعيل الـ DoubleBuffered له عبر الـ Reflection لأنها Protected property في الـ Panel الافتراضي
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, pnlAppContainer, new object[] { true });
        }

        private void OptimizeSidebarButtons()
        {
            // مصفوفة تحتوي على أزرار القائمة الجانبية لتطبيق الإعدادات عليها دفعة واحدة (DRY Principle)
            SfButton[] sidebarButtons = { btnApplication, btnPeople, btnDriver, btnUser, btnAccountSetting };

            foreach (var button in sidebarButtons)
            {
                if (button == null) continue;

                // إلغاء رسم خط التركيز (Focus Rectangle) المزعج عند النقر
                //  button.ShowFocusRect = false;

                // تفعيل الأنماط المتقدمة للتخصيص


                //button.Style.HoverBorder = new Pen(Color.FromArgb(0, 120, 212)); // لون الحواف عند المرور
                //button.Style.PressedBorder = new Pen(Color.FromArgb(0, 90, 158));

                // تخصيص الألوان لتتناسب مع الخلفية الداكنة للقائمة الجانبية (FromArgb(30, 40, 55))
                button.Style.BackColor = Color.Transparent; // اللون الافتراضي شفاف ليندمج مع الـ Panel
                button.Style.ForeColor = Color.White;

                // تأثير الـ Hover (عند مرور الماوس فوق الزر) -> إضاءة خفيفة للخلفية
                button.Style.HoverBackColor = Color.FromArgb(50, 65, 85);
                button.Style.HoverForeColor = Color.FromArgb(0, 120, 212); // تغيير لون النص لـ الأزرق اللامع

                // تأثير الـ Pressed (عند النقر)
                button.Style.PressedBackColor = Color.FromArgb(70, 85, 105);
                button.Style.PressedForeColor = Color.White;

                // محاذاة النص والأيقونة بشكل احترافي (Padding)
                button.Padding = new Padding(15, 0, 0, 0);
                button.TextAlign = ContentAlignment.MiddleLeft;
            }
        }


        private void _HideAllSubMenus()
        {
            pnlAppDrivingLicenseContainer.Visible = false;
        }
        private void _LoadView(UserControl control, string title, Image image)
        {
            if (control == null)
                return;

            lblTitle.Text = title;
            pictureBox2.Image = image;

            if (pnlMainViewContent.Controls.Count > 0 &&
                pnlMainViewContent.Controls[0] == control)
            {
                return;
            }

            pnlMainViewContent.Controls.Clear();

            if (control.Parent != null)
                control.Parent.Controls.Remove(control);

            control.Dock = DockStyle.Fill;
            pnlMainViewContent.Controls.Add(control);

            pnlMainViewHeader.Visible = true;
            pnlMainViewContent.Visible = true;
        }

        private Image GetIcon(string fileName)
        {
            string projectPath = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName;

            string iconPath = Path.Combine(projectPath,"Resources","Icons",fileName);

            return Image.FromFile(iconPath);
        }

        private ctrlAccountSetting _GetAccountSettingControl()
        {
            if (_ctrlAccountSetting == null)
            {
                _ctrlAccountSetting = new ctrlAccountSetting();
                _ctrlAccountSetting.OnUserSignOut +=AccountSeeting_Signout;
            }

            return _ctrlAccountSetting;
        }
        private ctrlManageApplication _GetManageApplicationsControl()
        {
            if (_ctrlManageApplications == null)
                _ctrlManageApplications = new ctrlManageApplication();

            return _ctrlManageApplications;
        }

        private ctrlAppDrivingLicenseService _GetDrivingLicenseServiceControl()
        {
            if (_ctrlDrivingLicenseService == null)
            {
                _ctrlDrivingLicenseService = new ctrlAppDrivingLicenseService();
            }

            return _ctrlDrivingLicenseService;
        }
        // EVENTS ////
        /////////////
        private void frmMain_Load(object sender, EventArgs e)
        {
           

            Color primaryBlue = Color.FromArgb(2, 132, 199);
            Color hoverBlue = Color.FromArgb(3, 105, 161);

            clsUICustomization.SetupButtonsHoverEffect(pnlAppContainer, primaryBlue, hoverBlue);
            fullHeight = clsUICustomization.GetFullHeightOfControls(pnlAppContainer);
            NormalSize = pnlAppContainer.Height;

            //OptimizeSidebarButtons();
            //EnableDoubleBuffering();
        }

        private void AccountSeeting_Signout()
        {
            DialogResult result = MessageBox.Show(
       "Are you sure you want to sign out?",
       "Confirm Sign Out",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;
            _frmLogin.Show();
            this.Close();
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {

            Form frm= new frmPeople();
            frm.ShowDialog();
        }


        private void btnUser_Click(object sender, EventArgs e)
        {
            frmListUser frm = new frmListUser();
            frm.ShowDialog();

        }

        private void btnApplication_Click(object sender, EventArgs e)
        {
           clsUICustomization.ToggleAnimation(pnlAppContainer, fullHeight, NormalSize, AnimationStep, true, () => { isCollapsed = false; });

        }


       

        private void btnDrivingLicensesServices_Click(object sender, EventArgs e)
        {
            _HideAllSubMenus();

            _LoadView(_GetDrivingLicenseServiceControl(), "Driving License Services", GetIcon("driving-license.png"));

            //pnlAppDrivingLicenseContainer.Visible = true;
            //ctrlAppDrivingLicenseService.Visible = true;

        }

        private void btnManageApp_Click(object sender, EventArgs e)
        {
            _HideAllSubMenus();

            _LoadView(_GetManageApplicationsControl(), "Manage Applications", GetIcon("talent.png"));

        }

        private void btnAccountSetting_Click(object sender, EventArgs e)
        {

            _HideAllSubMenus();     
            _LoadView(_GetAccountSettingControl(), "Account Settings", GetIcon("AccountSetting.png"));

            //  pnlAccountSetting.Visible = true;   
        }

        private void ctrlAccountSetting1_Load(object sender, EventArgs e)
        {


        }

        private void btnManageAppTypes_Click(object sender, EventArgs e)
        {
            
        }
    }
}
