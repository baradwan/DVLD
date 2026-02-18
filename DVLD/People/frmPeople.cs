using DVLD_Global;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Input;
using System;
using System.Drawing;
using System.Windows.Forms;
using DVLD_BusinessLayer;
using Syncfusion.WinForms.Controls;

namespace DVLD
{
    public partial class frmPeople : Form
    {
        public frmPeople()
        {
          
         
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dvgListPeople.DataSource = clsPerson.ListAllPeople();
        }

        private void btnPeopleAddPerson_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void sfDataGrid1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
