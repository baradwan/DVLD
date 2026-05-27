using DVLD_Global;
using Syncfusion.WinForms.Input;
using Syncfusion.WinForms.ListView;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Global
{
    public static class clsUICustomization
    {

        public static void LinkUnderlineWithTextBox(TextBox txt, Panel pnl)
        {

            LinkUnderlineWithTextBox(txt, pnl, Color.DodgerBlue, Color.Gray);
        }
        public static void LinkUnderlineWithTextBox(TextBox txt, Panel pnl, Color EnterColor)
        {

            LinkUnderlineWithTextBox(txt, pnl, EnterColor, Color.Gray);
        }
        public static void LinkUnderlineWithTextBox(TextBox txt, Panel pnl, Color EnterColor, Color LeaveColor)
        {
            pnl.BackColor = LeaveColor;
            // عند الضغط داخل التيكست بوكس (Enter)
            txt.Enter += (s, e) =>
            {
                pnl.BackColor = EnterColor;
                pnl.Height = 2; // تسميك الخط قليلاً عند التركيز
            };


            txt.Leave += (s, e) =>
            {
                pnl.BackColor = LeaveColor;
                pnl.Height = 1;
            };
        }
        public static void LinkUnderlineWithRadioButton(RadioButton rb, Panel pnl)
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

        public static void LinkUnderlineWithComboBox(SfComboBox cb, Panel pnl)
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
        public static void LinkUnderlineWithDateTimePicker(SfDateTimeEdit dtp, Panel pnl)
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
        //public static bool SetErrorProvider(  Control ctrl, ErrorProvider errorProvider, bool Condition,string errorMessage)
        //{
        //   // ctrl.Validating += (s, e) =>
        //    {
        //        if (Condition)
        //        {

        //            errorProvider.SetError(ctrl, errorMessage);

        //        }
        //        else
        //            errorProvider.SetError(ctrl, string.Empty);
        //    };
        //    return !Condition;
        //}

        public static bool SetErrorProviderAndReturnValidity(Control ctrl, ErrorProvider errorProvider, bool hasError, string errorMessage)
        {
            errorProvider.SetError(ctrl, hasError ? errorMessage : string.Empty);
            return !hasError;
        }

        public static void SetOptionalEmailErrorProvider(Control ctrl, ErrorProvider errorProvider, string errorMessage)
        {
            ctrl.Validating += (s, e) =>
            {
                if (!string.IsNullOrWhiteSpace(ctrl.Text) &&
                    !clsnValidation.IsEmailValid(ctrl.Text))
                {
                    errorProvider.SetError(ctrl, errorMessage);
                }
                else
                {
                    errorProvider.SetError(ctrl, string.Empty);
                }
            };
        }


        public static int GetFullHeightOfControls(Control control)
        {
            int fullHeight = 10;
            foreach (Control ctrl in control.Controls)
            {
                fullHeight += ctrl.Height;
            }
            return fullHeight;
        }
        public static int GetFullWidthOfControls(Control control)
        {
            int fullWidth = 10;
            foreach (Control ctrl in control.Controls)
            {
                fullWidth += ctrl.Width;
            }
            return fullWidth;
        }

        public static void SetupButtonsHoverEffect(Control container, Color defaultColor, Color hoverColor)
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

        public static void ToggleAnimation(Control target, int fullSize, int NormalSize, int step, bool isVertical, Action onFinished)
        {
            Timer timer = new Timer { Interval = 10 };
            bool isExpanding;

            if (isVertical)
                isExpanding = target.Height <= NormalSize;
            else
                isExpanding = target.Width <= NormalSize;

            timer.Tick += (s, e) =>
            {
                if (isVertical)
                {
                    // ===== EXPAND =====
                    if (isExpanding)
                    {
                        target.Height += step;

                        if (target.Height >= fullSize)
                        {
                            target.Height = fullSize;

                            timer.Stop();
                            timer.Dispose();

                            onFinished?.Invoke();
                        }
                    }

                    // ===== COLLAPSE =====
                    else
                    {
                        target.Height -= step;

                        if (target.Height <= NormalSize)
                        {
                            target.Height = NormalSize;

                            timer.Stop();
                            timer.Dispose();

                            onFinished?.Invoke();
                        }
                    }
                }
                else
                {
                    // ===== EXPAND =====
                    if (isExpanding)
                    {
                        target.Width += step;

                        if (target.Width >= fullSize)
                        {
                            target.Width = fullSize;

                            timer.Stop();
                            timer.Dispose();

                            onFinished?.Invoke();
                        }
                    }

                    // ===== COLLAPSE =====
                    else
                    {
                        target.Width -= step;

                        if (target.Width <= NormalSize)
                        {
                            target.Width = NormalSize;

                            timer.Stop();
                            timer.Dispose();

                            onFinished?.Invoke();
                        }
                    }
                }
            };

            timer.Start();
        }
    }
}
