using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;


using Syncfusion.WinForms.Themes;
using Syncfusion.WinForms.Core;
using DVLD.Users;
using DVLD_BusinessLayer;
using DVLD.Global;


namespace DVLD
{
    public partial class frmMain  :SfForm
    {
        private object tableLayoutPanel;
        bool isCollapsed = true;
        
        private const int AnimationStep = 20;
        private  int NormalSize =0;
           int fullHeight=0;
        clsUser _User = new clsUser();
        public frmMain()

        {
            
            InitializeComponent();



            Syncfusion.WinForms.Controls.SfSkinManager.LoadAssembly(typeof(Syncfusion.WinForms.Themes.Office2019Theme).Assembly);
            Syncfusion.WinForms.Controls.SfSkinManager.SetTheme(this, "Office2019Colorful");




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
           clsUICustomization.ToggleAnimation(pnlAppContainer, fullHeight, NormalSize, 10, true, () => { isCollapsed = false; });

        }


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

       

        private void btnDrivingLicensesServices_Click(object sender, EventArgs e)
        {
            pnlAppDrivingLicenseContainer.Visible = true;
        }
    }
}
