using DVLD.People.Controls;
using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.People
{
    public partial class frmAddUpdatePerson : Form
    {

     

        private void _AcceptButtons()
        {
            this.AcceptButton = btnSave;
            this.CancelButton = btnClose;
        }

        public frmAddUpdatePerson()
        {
            InitializeComponent();
        }

     

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _AcceptButtons();
        }

        private void crl1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsPerson Person = crlPersonalInfo.GetPersonInfo();
           
            if (Person.Save())
            {
                MessageBox.Show("Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                   MessageBox.Show("Failed to Save", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
