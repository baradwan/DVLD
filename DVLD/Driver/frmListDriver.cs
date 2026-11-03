using DVLD.Users.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Driver
{
    public partial class frmListDriver : Form
    {
        public frmListDriver()
        {
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListDriver_Load(object sender, EventArgs e)
        {
            ctrlListDriver1.CountDriversChanged += _UpdateCountUserss;
         
        }

      private void _UpdateCountUserss(int Count)
        {
            lblRecordValue.Text = Count.ToString();
        }

        private void frmListDriver_FormClosed(object sender, FormClosedEventArgs e)
        {
            ctrlListDriver1.CountDriversChanged -= _UpdateCountUserss;
        }
    }
}
