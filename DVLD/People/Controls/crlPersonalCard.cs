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

        private void _ApplyPlaceholderTextes() { 
        
      

        }

        // دالة احترافية لدمج التأثير البصري
        private void LinkUnderlineWithTextBox(TextBox txt, Panel pnl)
        {
            // عند الضغط داخل التيكست بوكس (Enter)
            txt.Enter += (s, e) =>
            {
                pnl.BackColor = Color.DodgerBlue; // اللون الأزرق الذي اخترته في تصميمك
                pnl.Height = 2; // تسميك الخط قليلاً عند التركيز
            };

            // عند ترك التيكست بوكس (Leave)
            txt.Leave += (s, e) =>
            {
                pnl.BackColor = Color.Gray; // العودة للرمادي
                pnl.Height = 1; // تقليل السمك
            };
        }
        public crlPersonalCard()
        {
            InitializeComponent();
        }

        
        private void crlPersonalCard_Load(object sender, EventArgs e)
        {
            LinkUnderlineWithTextBox(txtFirstName, pnlFirstname);

           
        }

        private void textBoxExt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
