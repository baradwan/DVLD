using DVLD.Licenses.International_License;
using DVLD.Licenses.Local_License;
using DVLD_BusinessLayer;
using Syncfusion.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses.Control
{
    public partial class ctrlDriverLicense : UserControl
    {
        private int _DriverID = -1;
        private clsDriver _Driver;
        private DataTable _dtDriverLocalLicensesHistory;
        private DataTable _dtDriverInternationalLicensesHistory;

        public ctrlDriverLicense()
        {
            InitializeComponent();
        }


        private void _LoadLocalLicenseInfo()
        {

            _dtDriverLocalLicensesHistory = clsDriver.GetDriverLicenses(_DriverID);


            dvgLocalLicensesHistory.DataSource = _dtDriverLocalLicensesHistory;
            lblLocalLicensesRecords.Text = dvgLocalLicensesHistory.Rows.Count.ToString();

            if (dvgLocalLicensesHistory.Rows.Count > 0)
            {
                dvgLocalLicensesHistory.Columns[0].HeaderText = "Lic.ID";
                dvgLocalLicensesHistory.Columns[0].Width = 110;

                dvgLocalLicensesHistory.Columns[1].HeaderText = "App.ID";
                dvgLocalLicensesHistory.Columns[1].Width = 110;

                dvgLocalLicensesHistory.Columns[2].HeaderText = "Class Name";
                dvgLocalLicensesHistory.Columns[2].Width = 270;

                dvgLocalLicensesHistory.Columns[3].HeaderText = "Issue Date";
                dvgLocalLicensesHistory.Columns[3].Width = 170;

                dvgLocalLicensesHistory.Columns[4].HeaderText = "Expiration Date";
                dvgLocalLicensesHistory.Columns[4].Width = 170;

                dvgLocalLicensesHistory.Columns[5].HeaderText = "Is Active";
                dvgLocalLicensesHistory.Columns[5].Width = 110;

            }
        }
        private void _LoadInternationalLicenseInfo()
        {

           _dtDriverInternationalLicensesHistory = clsInternationalLicense.GetDriverInternationalLicenses(_DriverID);


            dgvInternationalLicensesHistory.DataSource = _dtDriverInternationalLicensesHistory;
            lblInternationalLicensesRecords.Text = dgvInternationalLicensesHistory.Rows.Count.ToString();

            if (dgvInternationalLicensesHistory.Rows.Count > 0)
            {
                dgvInternationalLicensesHistory.Columns[0].HeaderText = "Int.License ID";
                dgvInternationalLicensesHistory.Columns[0].Width = 160;

                dgvInternationalLicensesHistory.Columns[1].HeaderText = "Application ID";
                dgvInternationalLicensesHistory.Columns[1].Width = 130;

                dgvInternationalLicensesHistory.Columns[2].HeaderText = "L.License ID";
                dgvInternationalLicensesHistory.Columns[2].Width = 130;

                dgvInternationalLicensesHistory.Columns[3].HeaderText = "Issue Date";
                dgvInternationalLicensesHistory.Columns[3].Width = 180;

                dgvInternationalLicensesHistory.Columns[4].HeaderText = "Expiration Date";
                dgvInternationalLicensesHistory.Columns[4].Width = 180;

                dgvInternationalLicensesHistory.Columns[5].HeaderText = "Is Active";
                dgvInternationalLicensesHistory.Columns[5].Width = 120;

            }
        }

        public void LoadInfo(int DriverID)
        {
            _DriverID = DriverID;
            _Driver = clsDriver.Find(_DriverID);
            if (_Driver == null)
            {

                MessageBox.Show("Driver not found.", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _LoadLocalLicenseInfo();
         _LoadInternationalLicenseInfo();

        }

        public void LoadInfoByPersonID(int PersonID)
        {

            _Driver = clsDriver.FindByPersonID(PersonID);
            if (_Driver == null)
            {
                MessageBox.Show("Driver not found.", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _DriverID = _Driver.DriverID;
            _LoadLocalLicenseInfo();
           _LoadInternationalLicenseInfo();
        }
        public void Clear()
        {
            _dtDriverLocalLicensesHistory.Clear();
            _dtDriverInternationalLicensesHistory.Clear();


        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = Convert.ToInt32(dvgLocalLicensesHistory.CurrentRow.Cells["LicenseID"].Value);
            frmShowLicenseInfo frm = new frmShowLicenseInfo(LicenseID);
            frm.ShowDialog();
        }

        private void InternationalLicenseHistorytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowInternationalLicense frm =
                new frmShowInternationalLicense(Convert.ToInt32(dgvInternationalLicensesHistory.CurrentRow.Cells["InternationalLicenseID"].Value));
            frm.ShowDialog();
        }
    }
}
