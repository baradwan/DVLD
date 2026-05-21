using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD_BusinessLayer.clsTestTypes;

namespace DVLD.Applications.Manage_Test_Types
{
    public partial class frmListManageTestTypes : Form
    {
        private DataTable _dvgList;
        public frmListManageTestTypes()
        {
            InitializeComponent();
        }

        private void _SetupDataGridUI()
        {
            dvgList.Style.CellStyle.HorizontalAlignment = HorizontalAlignment.Left;

            if (dvgList.Columns.Count == 0)
                return;

            dvgList.Columns["TestTypeID"].HeaderText = "ID";
            dvgList.Columns["TestTypeID"].Width = 100;

            dvgList.Columns["TestTypeTitle"].HeaderText = "Title";
            dvgList.Columns["TestTypeTitle"].Width = 250;

            dvgList.Columns["TestTypeDescription"].HeaderText = "Description";
            dvgList.Columns["TestTypeDescription"].Width = 400;

            dvgList.Columns["TestTypeFees"].HeaderText = "Fees";
            dvgList.Columns["TestTypeFees"].Width = 120;

            dvgList.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;

            pnlContent.Top = pnlHeader.Bottom + 200;
        }

        private int GetCurrentTestTypeID()
        {
            if (dvgList.CurrentItem != null)
            {
                DataRowView selectedRow = dvgList.CurrentItem as DataRowView;

                if (selectedRow != null)
                    return Convert.ToInt32(selectedRow["TestTypeID"]);
            }

            return -1;
        }

        private void _LoadList()
        {
            _dvgList = clsTestType.ListAllTestTypes();

            dvgList.DataSource = _dvgList;

            lblRecordCount.Text = _dvgList.Rows.Count.ToString();
        }

        private void frmListManageTestTypes_Load(object sender, EventArgs e)
        {
            _LoadList();
            _SetupDataGridUI();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int testTypeID = GetCurrentTestTypeID();

            if (testTypeID == -1)
            {
                MessageBox.Show("Please select a test type first.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            frmEditTestTypes frm = new frmEditTestTypes(testTypeID);
            frm.TestTypeUpdated += _LoadList;

            frm.ShowDialog();
        }

        private void dvgList_Click(object sender, EventArgs e)
        {

        }
    }

}

