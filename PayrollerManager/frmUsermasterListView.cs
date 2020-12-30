using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccess;
using DataAccess.Models;
using System.IO;
using Newtonsoft.Json;

namespace PayrollerManager
{
    public partial class frmUsermasterListView : BaseForm
    {


        #region CONSTRUCTOR
        public frmUsermasterListView()
        {
            InitializeComponent();
            FillGrid();
        }


        #endregion

        #region OBJECT



        #endregion

        #region VARIABLES
      
        private String sLOGINID = "";
        private String sSTAFFTYPE = "";
        private Boolean bModifymode = true;
        int iRowIndex = 0;
        private Boolean bCELLCLICK = false;
        private Boolean bVIEWSTATUS = false;
        #endregion

        #region PROPERTIES
        public Int32 LOGGEDINUSERID { get; set; }
       
        public String LOGINID
        {
            get
            {
                return sLOGINID;
            }
            set
            {
                sLOGINID = value;
            }
        }

        public String STAFFTYPE
        {
            get
            {
                return sSTAFFTYPE;
            }
            set
            {
                sSTAFFTYPE = value;
            }
        }
        public Boolean MODIFYMODE
        {
            get
            {
                return bModifymode;
            }
            set
            {
                bModifymode = value;
            }
        }
        public Boolean CellClickCheck
        {
            get
            {
                return bCELLCLICK;
            }
            set
            {
                bCELLCLICK = value;
            }
        }
        public Boolean VIEWSTATUS
        {
            get
            {
                return bVIEWSTATUS;
            }
            set
            {
                bVIEWSTATUS = value;
            }
        }
        public List<employeeDetailsModel> userdetailslist { get; set; }
        #endregion

        #region FILL MASTER LIST
        public void FillGrid()
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                DGUsermaster.Rows.Clear();

                userdetailslist = entity.GetAllEmployeeData();
                if (userdetailslist != null)
                {
                    if (userdetailslist.Count > 0)
                    {
                        DGUsermaster.Rows.Add(userdetailslist.Count);
                        int iRowindex = 0;

                        foreach (var users in userdetailslist)
                        {
                            DGUsermaster.Rows[iRowindex].Cells["USERIID"].Value = users.EMPLOYEEIID;
                            DGUsermaster.Rows[iRowindex].Cells["EMPLOYEECODE"].Value = users.EMPLOYEECODE;
                            DGUsermaster.Rows[iRowindex].Cells["EMPLOYEENAME"].Value = $"{users.FNAME} {users.LNAME}";
                            DGUsermaster.Rows[iRowindex].Cells["DEPARTMENT"].Value = users.DEPARTMENT;
                            DGUsermaster.Rows[iRowindex].Cells["USERLOGINID"].Value = users.LOGINID;
                            DGUsermaster.Rows[iRowindex].Cells["USERTYPE"].Value = users.USERTYPE;
                            DGUsermaster.Rows[iRowindex].Cells["CONTACTNO"].Value = users.MOBILENO;
                            DGUsermaster.Rows[iRowindex].Cells["AADHAR"].Value = users.AADHARNO;
                            iRowindex++;
                        }
                    }
                }

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {

                MessageBox.Show("An Error occured Please Contact Administrator \nError - " + ex.Message, "Employee Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }
        }
        #endregion

        //#region GetUserData
        //private void GetUserData()
        //{

        //    userdetailslist = new List<Userdetails>();

        //    using (StreamReader r = new StreamReader(@"D:\Ravi\Personal\MCG\EmployeeManagement\Data\userdetails.json"))
        //    {
        //        string json = r.ReadToEnd();
        //        userdetailslist = JsonConvert.DeserializeObject<List<Userdetails>>(json);
        //    }

        //}
        //#endregion


        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                frmUsersDetails objUnitDetails = new frmUsersDetails(userdetailslist);
                objUnitDetails.LOGINID = LOGINID;
                objUnitDetails.LOGGEDINUSERID = LOGGEDINUSERID;
                // objUnitDetails.ListView = this;
                objUnitDetails.MODIFYMODE = false;
                objUnitDetails.ShowDialog();
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message, "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }

        }

        private void frmSietelistview_Load(object sender, EventArgs e)
        {
            try
            {

                DGUsermaster.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 240, 228);
                DGUsermaster.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(174, 174, 174);
                DGUsermaster.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(221, 221, 221);
                DGUsermaster.RowHeadersWidth = 21;
                DGUsermaster.AllowUserToAddRows = false;
                DGUsermaster.AllowUserToDeleteRows = false;

                DGUsermaster.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
                DGUsermaster.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                DGUsermaster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                SetOnChangeGenericHandler(this.Controls);

            }
            catch (Exception ex)
            {

                MessageBox.Show("An Error occured Please Contact Administrator \nError - " + ex.Message, "Employee Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            GetMasterDetails();
        }

        private void GetMasterDetails()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (DGUsermaster.CurrentCell != null)
                {
                    int iRowIndex = DGUsermaster.CurrentCell.RowIndex;
                    int IID = Convert.ToInt32(DGUsermaster.Rows[iRowIndex].Cells[0].Value.ToString());

                    if (IID > 0)
                    {
                        frmUsersDetails objfrmUnitmaster = new frmUsersDetails();
                        objfrmUnitmaster.MODIFYMODE = true;
                        objfrmUnitmaster.userdetailslist = userdetailslist;
                        objfrmUnitmaster.GetGeneralDetails(IID);
                        objfrmUnitmaster.LOGINID = LOGINID;
                        objfrmUnitmaster.LOGGEDINUSERID = LOGGEDINUSERID;
                        objfrmUnitmaster.ShowDialog();
                    }
                }
                this.Cursor = Cursors.Default;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message, "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillGrid();

        }

        #region PREVIOUS BUTTON CLIECK EVENT
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGUsermaster.CurrentCell == null) return;

                int rowindex = DGUsermaster.CurrentCell.RowIndex;
                int colindex = DGUsermaster.CurrentCell.ColumnIndex;
                if (rowindex > 0)
                {

                    DGUsermaster.Rows[rowindex - 1].Cells[colindex].Selected = true;
                }
                else
                {
                    DGUsermaster.Rows[DGUsermaster.Rows.Count - 1].Cells[colindex].Selected = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("An Error occured Please Contact Administrator \nError - " + ex.Message, "Employee Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }
        }
        #endregion

        #region NEXT BUTTON CLIECK EVENT
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGUsermaster.CurrentCell == null) return;

                int rowindex = DGUsermaster.CurrentCell.RowIndex;
                int colindex = DGUsermaster.CurrentCell.ColumnIndex;
                if (rowindex < DGUsermaster.Rows.Count - 1)
                {

                    DGUsermaster.Rows[rowindex + 1].Cells[colindex].Selected = true;
                }
                else
                {
                    DGUsermaster.Rows[0].Cells[colindex].Selected = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("An Error occured Please Contact Administrator \nError - " + ex.Message, "Employee Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }
        }
        #endregion

        #region DELETE BATCH
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (DGUsermaster.CurrentCell != null)
                {
                    int iRowIndex = DGUsermaster.CurrentCell.RowIndex;


                    if (MessageBox.Show("Really want to delete this record?", "Employee Management", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int employeeid = Convert.ToInt32(DGUsermaster.Rows[iRowIndex].Cells[0].Value.ToString());
                        string employeecode = Convert.ToString(DGUsermaster.Rows[iRowIndex].Cells[1].Value);
                        //Userdetails user = userdetailslist.FirstOrDefault(u => u.EMPLOYEEIID == userid);
                        // bool isDeleted = userdetailslist.Remove(userdetailslist.FirstOrDefault(u => u.EMPLOYEEIID == employeeid));
                        // user.STATUS = "INACTIVE";
                        // entity.SaveEmployeeData(userdetailslist);
                        bool isDeleted = true;
                        if (isDeleted)
                        {
                            entity.DeleteDocuments(employeecode);
                            this.Cursor = Cursors.Default;
                            MessageBox.Show("Record deleted successfully", "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FillGrid();
                        }
                        else
                        {
                            this.Cursor = Cursors.Default;
                            MessageBox.Show("This record is in use cannot delete this record.", "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                    else
                    {
                        this.Cursor = Cursors.Default;
                        return;
                    }

                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("Fail to delete, as it is already in use in other document.", "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                exceptionlog.HandleException(ex);
            }
        }
        #endregion

        private void txtSearchText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tmr_Search.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message, "Employee Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }
        }

        private void tmr_Search_Tick(object sender, EventArgs e)
        {
            try
            {
                tmr_Search.Enabled = false;
                int SelectedColumnIndex = 1;
                if (CellClickCheck == true)
                {
                    SelectedColumnIndex = DGUsermaster.CurrentCell.ColumnIndex;
                }
                else
                {
                    SelectedColumnIndex = 1;
                }
                ShowSelectedItemInGrid(ref DGUsermaster, SelectedColumnIndex, txtSearchText.Text, (Control)lblSearchColumn);

                for (int i = 0; i < DGUsermaster.Rows.Count; i++)
                {
                    if (DGUsermaster.Rows[i].Cells[SelectedColumnIndex].Value != null && DGUsermaster.Rows[i].Cells[SelectedColumnIndex].Value.ToString().ToUpper().Contains(txtSearchText.Text.Trim().ToUpper()))
                    {
                        DGUsermaster.Rows[i].Selected = true;
                        DGUsermaster.FirstDisplayedScrollingRowIndex = i;
                        iRowIndex = i;
                        iRowIndex++;
                        DGUsermaster.CurrentCell = DGUsermaster[SelectedColumnIndex, i];
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message,
                    "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            String sSourceString = "";
            int iColIndex = 0;
            try
            {

                if (CellClickCheck == true)
                {
                    iColIndex = DGUsermaster.CurrentCell.ColumnIndex;
                }
                else
                {
                    iColIndex = 1;
                }
                int i = 0;

                for (i = iRowIndex; i < DGUsermaster.Rows.Count; i++)
                {
                    sSourceString = txtSearchText.Text; ;
                    if (DGUsermaster.Rows[i].Cells[iColIndex].Value.ToString().ToUpper().Contains(txtSearchText.Text.Trim().ToUpper()))
                    {
                        DGUsermaster.Rows[i].Selected = true;
                        DGUsermaster.FirstDisplayedScrollingRowIndex = i;
                        iRowIndex = i;
                        iRowIndex++;
                        return;
                    }
                }
                MessageBox.Show("No more occurances found. Search will continue from top.", "Employee Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                iRowIndex = 0;
                DGUsermaster.Rows[0].Selected = true;
                DGUsermaster.FirstDisplayedScrollingRowIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message, "Employee Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }
        }

        private void DGUnitmasterlistview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CellClickCheck = true;
                ShowSelectedItemInGrid(ref DGUsermaster, DGUsermaster.CurrentCell.ColumnIndex,
                    txtSearchText.Text, (Control)lblSearchColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message, "Employee Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }
        }

        private void DGUnitmasterlistview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GetMasterDetails();

        }




    }
}
