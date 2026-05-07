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

        public event Action  OnPersonUpdated;
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

            frmUpdate.DataBack += frmUpdate_DataBack;
            frmUpdate.ShowDialog();
           
        }

        private void frmUpdate_DataBack(object sender, clsPerson Person)
        {

            crlShowPersonInformation1.LoadPersonInformation(Person);
          _PersonID = Person.PersonID;

            OnPersonUpdated?.Invoke();
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
