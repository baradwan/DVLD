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

     
        private int _PersonID;
        public delegate void DataBackHandler(object sender, clsPerson Person);
        public event DataBackHandler DataBack;


        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode = enMode.AddNew;
        private void _AcceptButtons()
        {
            this.AcceptButton = btnSave;
            this.CancelButton = btnClose;
        }

        public frmAddUpdatePerson()
        {
            InitializeComponent();
           _Mode = enMode.AddNew;
        }
        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _PersonID =PersonID;
         
          
        }


        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _AcceptButtons();
            if (_Mode==enMode.Update)
            {              
                lblTitleAddUpdateForm.Text = "Update Person";
                crlPersonalInfo.PersonID = _PersonID;
            }
            else
            {
                lblTitleAddUpdateForm.Text = "Add New Person";
            }

        }

        private void crl1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please fix the errors!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

          

            if (!crlPersonalInfo.ImageHandler())
            { 

                MessageBox.Show("Please fix the errors in image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsPerson PersonToSave= crlPersonalInfo.GetPersonInfo();
           


            if (PersonToSave.Save())
            {
                crlPersonalInfo.PersonID = PersonToSave.PersonID;
                DataBack?.Invoke(this, PersonToSave);
                lblTitleAddUpdateForm.Text = "Update Person";

                _Mode = enMode.Update;
                MessageBox.Show("Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

              
              
            }
            else
            {
                MessageBox.Show("Failed to Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        

        private void lblTitleAddUpdateForm_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
