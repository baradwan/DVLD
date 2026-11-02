using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Driver.Control
{
    public partial class ctrlListDriver : UserControl
    {
        public event Action<int> CountDriversChanged;
        public event Action<int> OnDriverSelected;

        public int CountDrivers { get; private set; }

        private DataTable _dtList;

        private enum enFilterOption
        {
            None = 0,
            DriverID = 1,
            PersonID = 2,
            NationalNo = 3,
            FullName = 4
              
        }
        private enFilterOption _ModeFilter = enFilterOption.None;
        public ctrlListDriver()
        {
            InitializeComponent();
        }


        private void _LoadFiltersOptions()
        {
            string[] FilterText =
            {
                "None",
                "Driver ID",
                "Person ID",
                "National No.",
                "Full Name"
            };

            cmbFilter.DataSource = FilterText;
            cmbFilter.SelectedIndex = 0;
        }

        private void _SetupDataGridUI()
        {
            dvgList.Style.CellStyle.HorizontalAlignment = HorizontalAlignment.Left;
            if (dvgList.Columns.Count == 0)
                return;

            dvgList.Columns["DriverID"].HeaderText = "Driver ID";
            dvgList.Columns["PersonID"].HeaderText = "Person ID";
            dvgList.Columns["NationalNo"].HeaderText = "National No.";
            dvgList.Columns["FullName"].HeaderText = "Full Name";
            dvgList.Columns["CreatedDate"].HeaderText = "Created Date";
            dvgList.Columns["ActiveLicenses"].HeaderText = "Active Licenses";

            dvgList.AutoSizeColumnsMode =
                Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
        }

    }
}
