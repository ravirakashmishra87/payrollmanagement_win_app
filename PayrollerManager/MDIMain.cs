using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollerManager
{
    public partial class MDIMain : Form
    {
      
        public int USERID { get; set; }
        public string LOGINID { get; set; }
        public string FIRSTNAME { get; set; }
        public string  LASTNAME { get; set; }
        public string DOCUMENTFILE { get; set; }
        public string DATAFILE { get; set; }

        public MDIMain()
        {
            InitializeComponent();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Load_Login();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message, "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form childForm in MdiChildren)
                {
                    childForm.Close();
                }
                loginToolStripMenuItem.Enabled = true;
                logoutToolStripMenuItem.Enabled = false;

                DisableMenus();
                Load_Login();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message, "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        #region LOAD MDI FORM
        private void MDIMain_Load(object sender, EventArgs e)
        {
            DisableMenus();
            Load_Login();
        }

        #endregion
               
        #region LOAD LOGIN FUNCTION
        private void Load_Login()
        {
            try
            {
                frmLogin objLogin = new frmLogin((Form)this);
                objLogin.ShowDialog(this);

                if (USERID > 0)
                {
                    loginToolStripMenuItem.Enabled = false;
                    logoutToolStripMenuItem.Enabled = true;
                    EnableMenus();

                }
                else
                {
                    logoutToolStripMenuItem.Enabled = false;
                    DisableMenus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message, "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }
        }
        #endregion

        private void DisableMenus()
        {
            try
            {
                USERID = 0;
                //lblLoginBy.Text = "";
                ////timer1.Stop();
                //lblClock.Text = "";

                staffToolStripMenuItem.Enabled = false;
                EmployeeSalaryMenu.Enabled = false;
                //menustripDispatch.Enabled = false;
                //MenuUpload.Enabled = false;
                //menuDelivery.Enabled = false;
                //companyMenu.Enabled = false;
                //ReportMenu.Enabled = false;
                //menu_search.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message, "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }
        }

        private void EnableMenus()
        {
            try
            {

                staffToolStripMenuItem.Enabled = true;
                EmployeeSalaryMenu.Enabled = true;
                //menu_search.Enabled = P_SEARCH;
                //ReportMenu.Enabled = P_REPORT;
                //menustripDispatch.Enabled = true;
                //MenuUpload.Enabled = true;
                //menuDelivery.Enabled = true;
                //companyMenu.Enabled = true;




                //var timeZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                //// lblClock.Text = TimeZoneInfo.ConvertTime(DateTime.Now, timeZone).ToString("dddd, dd MMMM yyyy");
                //lblLoginBy.Text = $"Welcome :{FIRSTNAME} {LASTNAME}     {TimeZoneInfo.ConvertTime(DateTime.Now, timeZone).ToString("dddd, dd MMMM yyyy")}";

            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message, "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
             frmUsermasterListView objMaster = new frmUsermasterListView();
            //frmUsersDetails objMaster = new frmUsersDetails();
            objMaster.LOGINID = LOGINID;
            objMaster.LOGGEDINUSERID = USERID;
            objMaster.MdiParent = this;
            objMaster.Show();
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeSalaryMenu_Click(object sender, EventArgs e)
        {
            

        }

        private void salaryDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserSalaryList objMaster = new frmUserSalaryList();
            objMaster.LOGINID = LOGINID;
            objMaster.LOGGEDINUSERID = USERID;
            objMaster.MdiParent = this;
            objMaster.Show();
        }

        private void emailSalarySlipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenerateSalary objMaster = new frmGenerateSalary();
            objMaster.LOGINID = LOGINID;
            objMaster.LOGGEDINUSERID = USERID;
            objMaster.MdiParent = this;
            objMaster.Show();
        }

        private void menuReports_Click(object sender, EventArgs e)
        {

        }
    }
}
