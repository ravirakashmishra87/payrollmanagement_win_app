using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using DataAccess.Models;

namespace PayrollerManager
{
    public partial class frmLogin : Form
    {
        private Form MDIMain;
        public frmLogin()
        {
            InitializeComponent();
        }
        public frmLogin(Form MDIContainer)
        {
            InitializeComponent();
            MDIMain = MDIContainer;


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtloginid.Text))
            {
                MessageBox.Show("Please enter login Id.", "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtloginid.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Please enter password.", "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtpassword.Focus();
                return;
            }

            try
            {
                string password = txtpassword.Text.Trim();
                // string password = txtpassword.Text.Trim();

                this.Cursor = Cursors.WaitCursor;

                employeeDetailsModel userdetails = entity.Authenticate(txtloginid.Text.Trim(), txtpassword.Text.Trim());
                if (userdetails == null)
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Invalid login id or password.", "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (userdetails.EMPLOYEEIID >0)
                {
                    MDIMain objMdiForm = (MDIMain)this.Owner;
                    objMdiForm.USERID = userdetails.EMPLOYEEIID;
                    objMdiForm.LOGINID = userdetails.LOGINID;
                    objMdiForm.FIRSTNAME = userdetails.FNAME;
                    objMdiForm.LASTNAME = userdetails.LNAME;

                    objMdiForm.Show();
                    this.Close();
                }
                else
                {

                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Invalid login id or password.", "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message, "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
