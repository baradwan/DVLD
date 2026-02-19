using DVLD_BusinessLayer;
using DVLD_Global;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Windows.Forms;

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
            // This forces all text and numbers in the whole grid to the left side
           dvgListPeople.Style.CellStyle.HorizontalAlignment = HorizontalAlignment.Left;
       
        }

        private void btnPeopleAddPerson_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Person button clicked! Implement the logic to open the Add Person form here.");
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

        private void lblTitlePeople_Click(object sender, EventArgs e)
        {

        }
    }
}
