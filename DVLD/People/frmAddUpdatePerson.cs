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

        private void crlPersonalCard1_Load(object sender, EventArgs e)
        {
           
        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _AcceptButtons();
        }

       
    }
}
