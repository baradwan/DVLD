using DVLD.People;
using DVLD_BusinessLayer;
using DVLD_Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.Applications
{
    public partial class ctrlAppBasicInfo : UserControl
    {

        private clsApplication _App ;
       // int _AppID;
        int _LicenseID;


        public ctrlAppBasicInfo()
        {
            InitializeComponent();
        }
       
        public void LoadApplicationInfo(int AppID)
        {
            _App = clsApplication.Find(AppID);
            if (_App == null)
            {
               _ResetApplicationInfo();
                MessageBox.Show("No Application with ID = " + AppID, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            _FillAppInformation();
        }

        private void _FillAppInformation()
        {

           // _AppID = _App.ApplicationID; 
           

            lblApplicationID.Text = _App.ApplicationID.ToString();
           
            lblStatus.Text = _App.Status.ToString();
            lblFees.Text = _App.PaidFees.ToString("0.00");
            lblType.Text = _App.ApplicationTypeTitle.ToString();
            lblApplicant.Text = _App.PersonName; 
            lblDate.Text = _App.ApplicationDate.ToString("dd/MM/yyyy");
            lblStatusDate.Text = _App.LastStatusDate.ToString("dd/MM/yyyy");
            lblCreatedByUser.Text = _App.CreatedByUserName;
        
        }
        public void _ResetApplicationInfo()
        {
           // _AppID = -1;

            lblApplicationID.Text = "---";
            lblStatus.Text = "---";
            lblType.Text = "---";
            lblFees.Text = "---";
            lblApplicant.Text = "---";
            lblDate.Text = "---";
            lblStatusDate.Text = "---";
            lblCreatedByUser.Text = "---";
        }

        private void ctrlAppBasicInfo_Load(object sender, EventArgs e)
        {

        }

        private void llViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPerson frm = new frmShowPerson(_App.PersonID);
            frm.ShowDialog();

            //Refresh
           // LoadApplicationInfo(   );
        }
    }
}
