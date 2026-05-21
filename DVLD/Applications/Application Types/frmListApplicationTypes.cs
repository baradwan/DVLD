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

namespace DVLD.Applications.ApplicationTypes
{
    public partial class frmListApplicationTypes : Form
    {
        public frmListApplicationTypes()
        {
            InitializeComponent();
        }

       private DataTable _dvgList;
        private void _SetupDataGridUI()
        {
            dvgList.Style.CellStyle.HorizontalAlignment = HorizontalAlignment.Left;

            if (dvgList.Columns.Count == 0)
                return;

            dvgList.Columns["ApplicationTypeID"].HeaderText = "ID";
            dvgList.Columns["ApplicationTypeID"].Width = 100;

            dvgList.Columns["ApplicationTypeTitle"].HeaderText = "Title";
            dvgList.Columns["ApplicationTypeTitle"].Width = 350;

            dvgList.Columns["ApplicationFees"].HeaderText = "Fees";
            dvgList.Columns["ApplicationFees"].Width = 120;

            dvgList.AutoSizeColumnsMode =
                Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            dvgList.Top = pnlHeader.Bottom + 200;
        }

        private int GetCurrentAppTypeID()
        {

            if (dvgList.CurrentItem != null)
            {
                DataRowView selectedRow = dvgList.CurrentItem as DataRowView;

                if (selectedRow != null)
                {
                    return Convert.ToInt32(selectedRow["ApplicationTypeID"]);


                }
            }
            return -1;
        }
        private void _LoadList()
        {
            _dvgList = clsApplicationType.ListAllApplicationTypes();
            dvgList.DataSource = _dvgList;
            lblRecordCount.Text = _dvgList.Rows.Count.ToString();
        }

        private void frmListApplicationTypes_Load(object sender, EventArgs e)
        {
            _SetupDataGridUI();
            _LoadList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            frmEditApplicationTypes frm = new frmEditApplicationTypes(GetCurrentAppTypeID());
            frm.AppTypeUpdated += _LoadList;
            frm.ShowDialog();
        }
    }
}
