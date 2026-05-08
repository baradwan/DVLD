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
    public partial class frmShowPerson : Form
    {

     
        public frmShowPerson()
        {

            InitializeComponent();
        }
       private int _PersonID = -1;
        public frmShowPerson(int PersonID)
        {

            InitializeComponent();
            _PersonID=PersonID;
        }
        
      

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           frmAddUpdatePerson frmUpdate=new frmAddUpdatePerson(_PersonID);
            frmUpdate.PersonSaved += FrmUpdate_PersonSaved;
            frmUpdate.ShowDialog();
           
        }

        private void FrmUpdate_PersonSaved(clsPerson person)
        {
            crlShowPersonInformation1.LoadPersonInformation(person);
            _PersonID = person.PersonID;
        }

        private void frmShowPerson_Load(object sender, EventArgs e)
        {
            if (_PersonID>-1)
            crlShowPersonInformation1.LoadPersonInformation(_PersonID);
        }

        private void crlShowPersonInformation1_Load(object sender, EventArgs e)
        {

        }
    }
}
