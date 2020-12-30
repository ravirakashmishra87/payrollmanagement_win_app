using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccess;
using System.Security.Cryptography;
using DataAccess.Models;
using Newtonsoft.Json;
using System.IO;
using Microsoft.Office.Interop.Word;
using SelectPdf;
using System.Configuration;

namespace PayrollerManager
{
    public partial class frmUsersDetails : BaseForm
    {
        #region CONSTRUCTOR
        public frmUsersDetails()
        {
            InitializeComponent();
        }
        public frmUsersDetails(List<employeeDetailsModel> lstUserdetails)
        {
            InitializeComponent();
            userdetailslist = lstUserdetails;
        }


        #endregion

        #region OBJECT
        employeeDetailsModel objuserdetails;


        #endregion

        #region VARIABLES
        private Boolean bModifymode = true;
        private Boolean bDISPLAYMODE = false;

        #endregion

        #region PROPERTY

        public int LOGGEDINUSERID { get; set; }
        public String LOGINID { get; set; }
        public Boolean MODIFYMODE { get; set; }        
        public Boolean DISPLAYMODE { get; set; }
        public int SELECTEDEMPLOYEEIID { get; set; }

        public List<employeeDetailsModel> userdetailslist { get; set; }
        #endregion

        private void frmSitemaster_Load(object sender, EventArgs e)
        {
            try
            {
                if (!MODIFYMODE)
                {
                    objuserdetails = new employeeDetailsModel();
                }
                else
                { this.Text = $"Employee Details - {objuserdetails.EMPLOYEECODE}"; }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message, "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }
        }

        #region GET GENERAL DETAILS
        public void GetGeneralDetails(int userid)
        {
            try
            {
                SELECTEDEMPLOYEEIID = userid;
                objuserdetails = userdetailslist.FirstOrDefault(u => u.EMPLOYEEIID == userid);

                txtFName.Text = objuserdetails.FNAME;
                txtLName.Text = objuserdetails.LNAME;
                txtLoginID.Text = objuserdetails.LOGINID;
                ddlUsertype.Text = objuserdetails.USERTYPE;
                ddlStatus.Text = objuserdetails.STATUS;
                txtPassword.Text = objuserdetails.PASSWORD;
                txtDesignation.Text = objuserdetails.DESIGNATION;
                txtEmployeeCode.Text = objuserdetails.EMPLOYEECODE;
                txtLocation.Text = objuserdetails.LOCATION;
                txtEmpRefNo.Text = objuserdetails.REFNO;

                //Basic details
                ddlGender.Text = objuserdetails.GENDER;
                ddlMaritalStatus.Text = objuserdetails.MARITALSTATUS;
                dtpDOB.Value = objuserdetails.DOB;
                dtpJoiningDate.Value = objuserdetails.DOJ;
                txtFathername.Text = objuserdetails.FATHERNAME;
                txtMobileNo.Text = objuserdetails.MOBILENO;
                txtEmegencyContactNo.Text = objuserdetails.EMGCONTACTNO;
                txtEmailid.Text = objuserdetails.EMAILID;
                rtbAddress.Text = objuserdetails.ADDRESS;
                txtUANNo.Text = objuserdetails.UANNO;
                txtAadharNo.Text = objuserdetails.AADHARNO;
                txtPan.Text = objuserdetails.PANNO;
                txtNomineeName.Text = objuserdetails.NOMINEE;
                dtpNomineeDOB.Value = objuserdetails.NOMINEEDOB;
                txtAccountName.Text = objuserdetails.AC_NAME;
                txtAccountNumber.Text = objuserdetails.AC_NUMBER;
                txtBankName.Text = objuserdetails.BANKNAME;
                txtIFCSCode.Text = objuserdetails.IFSCCODE;
                dtpAddedTime.Value = objuserdetails.ADDEDTIME;
                txtReferrerName.Text = objuserdetails.REFERRERNAME;
                ddlAttServiceStatus.Text = objuserdetails.ATTSER_STATUS;
                txtTaskOwner.Text = objuserdetails.TASKOWNNER;
                txtESICNO.Text = objuserdetails.ESICNO;

                pbPhoto.ImageLocation = objuserdetails.PHOTO;
                PBAdharFront.ImageLocation = objuserdetails.UAD_FRONT;
                pbAadharBack.ImageLocation = objuserdetails.UAD_BACK;
                pbPAN.ImageLocation = objuserdetails.PAN;
                pbPassbook.ImageLocation = objuserdetails.PASSBOOK;
                lblResumePath.Text = objuserdetails.RESUME;

                txtDays.Text = Convert.ToString(objuserdetails.DAYS);
                txtDepartment.Text = objuserdetails.DEPARTMENT;
                txtBasic.Text = Convert.ToString(objuserdetails.BASIC);
                txtHRA.Text = Convert.ToString(objuserdetails.HRA);
                txtAllowances.Text = Convert.ToString(objuserdetails.ALLOWANCE);
                txtConv.Text = Convert.ToString(objuserdetails.CONV);
                txtGross.Text = Convert.ToString(objuserdetails.GROSS);
                txtEmployeePF.Text = Convert.ToString(objuserdetails.EMPLOYEE_PF);
                txtEmployeeESIC.Text = Convert.ToString(objuserdetails.EMPLOYEE_ESIC);
                txtEmployeePT.Text = Convert.ToString(objuserdetails.EMPLOYEE_PT);
                txtEmployeeDeduction.Text = Convert.ToString(objuserdetails.EMPLOYEE_DEDUCTION);
                txtNetSalary.Text = Convert.ToString(objuserdetails.NETSALARY);
                txtTotalSalary.Text = Convert.ToString(objuserdetails.TOTAL);
                txtEmployerPF.Text = Convert.ToString(objuserdetails.EMPLOYER_PF);
                txtEmployerESIC.Text = Convert.ToString(objuserdetails.EMPLOYER_ESIC);
                txtTotalCTC.Text = Convert.ToString(objuserdetails.TOTAL_CTC);
                //txtAdmnChrgs.Text = Convert.ToString(objuserdetails.ADMN_CHRGS);
                //txtGrandTotal.Text = Convert.ToString(objuserdetails.GRAND_TOTAL);

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtEmployeeCode.Text))
                {
                    tabControl1.SelectedTab = tabControl1.TabPages[0];
                    MessageBox.Show("Please enter employee code. ", "Employee Management",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmployeeCode.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtFName.Text))
                {
                    tabControl1.SelectedTab = tabControl1.TabPages[0];
                    MessageBox.Show("Please enter first name. ", "Employee Management",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFName.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtLoginID.Text))
                {
                    tabControl1.SelectedTab = tabControl1.TabPages[0];
                    MessageBox.Show("Please enter login id. ", "Employee Management",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLoginID.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    tabControl1.SelectedTab = tabControl1.TabPages[0];
                    MessageBox.Show("Please enter login password. ", "Employee Management",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtConfirmPwd.Text))
                {
                    tabControl1.SelectedTab = tabControl1.TabPages[0];
                    MessageBox.Show("Please enter confirm password. ", "Employee Management",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    txtConfirmPwd.Focus();
                    return;
                }

                if (txtPassword.Text.Trim() != txtConfirmPwd.Text.Trim())
                {
                    tabControl1.SelectedTab = tabControl1.TabPages[0];
                    MessageBox.Show("Password do not match.", "Employee Management",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtConfirmPwd.Focus();
                }
                if (string.IsNullOrEmpty(txtDesignation.Text))
                {
                    tabControl1.SelectedTab = tabControl1.TabPages[0];
                    MessageBox.Show("Please enter employee designation. ", "Employee Management",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDesignation.Focus();
                    return;
                }
                this.Cursor = Cursors.WaitCursor;

                if (userdetailslist == null)
                {
                    userdetailslist = new List<employeeDetailsModel>();
                    objuserdetails.EMPLOYEEIID = 1;
                }

                //login details
                objuserdetails.FNAME = txtFName.Text.Trim();
                objuserdetails.LNAME = txtLName.Text.Trim();
                objuserdetails.LOGINID = txtLoginID.Text.Trim();
                objuserdetails.PASSWORD = txtPassword.Text.Trim();
                objuserdetails.USERTYPE = ddlUsertype.Text;
                objuserdetails.STATUS = ddlStatus.Text;
                objuserdetails.EMPLOYEECODE = txtEmployeeCode.Text;
                objuserdetails.DESIGNATION = txtDesignation.Text;
                objuserdetails.LOCATION = txtLocation.Text;
                objuserdetails.REFNO = txtEmpRefNo.Text;


                //Basic details
                objuserdetails.GENDER = ddlGender.Text;
                objuserdetails.MARITALSTATUS = ddlMaritalStatus.Text;
                objuserdetails.DOB = dtpDOB.Value;
                objuserdetails.DOJ = dtpJoiningDate.Value;
                objuserdetails.FATHERNAME = txtFathername.Text;
                objuserdetails.MOBILENO = txtMobileNo.Text;
                objuserdetails.EMGCONTACTNO = txtEmegencyContactNo.Text;
                objuserdetails.EMAILID = txtEmailid.Text;
                objuserdetails.ADDRESS = rtbAddress.Text;
                objuserdetails.UANNO = txtUANNo.Text;
                objuserdetails.ESICNO = txtESICNO.Text;
                objuserdetails.AADHARNO = txtAadharNo.Text;
                objuserdetails.PANNO = txtPan.Text;
                objuserdetails.NOMINEE = txtNomineeName.Text;
                objuserdetails.NOMINEEDOB = dtpNomineeDOB.Value;
                objuserdetails.AC_NAME = txtAccountName.Text;
                objuserdetails.AC_NUMBER = txtAccountNumber.Text;
                objuserdetails.BANKNAME = txtBankName.Text;
                objuserdetails.IFSCCODE = txtIFCSCode.Text;
                objuserdetails.ADDEDTIME = dtpAddedTime.Value;
                objuserdetails.REFERRERNAME = txtReferrerName.Text;
                objuserdetails.ATTSER_STATUS = ddlAttServiceStatus.Text;
                objuserdetails.TASKOWNNER = txtTaskOwner.Text;

                //Salary details
                objuserdetails.DAYS = Convert.ToInt32(txtDays.Text);
                objuserdetails.DEPARTMENT = txtDepartment.Text;
                objuserdetails.BASIC = Convert.ToDecimal(txtBasic.Text);
                objuserdetails.HRA = Convert.ToDecimal(txtHRA.Text);
                objuserdetails.ALLOWANCE = Convert.ToDecimal(txtAllowances.Text);
                objuserdetails.CONV = Convert.ToDecimal(txtConv.Text);
                objuserdetails.GROSS = Convert.ToDecimal(txtGross.Text);
                objuserdetails.EMPLOYEE_PF = Convert.ToDecimal(txtEmployeePF.Text);
                objuserdetails.EMPLOYEE_ESIC = Convert.ToDecimal(txtEmployeeESIC.Text);
                objuserdetails.EMPLOYEE_PT = Convert.ToDecimal(txtEmployeePT.Text);
                objuserdetails.EMPLOYEE_DEDUCTION = Convert.ToDecimal(txtEmployeeDeduction.Text);
                objuserdetails.NETSALARY = Convert.ToDecimal(txtNetSalary.Text);
                objuserdetails.TOTAL = Convert.ToDecimal(txtTotalSalary.Text);
                objuserdetails.EMPLOYER_PF = Convert.ToDecimal(txtEmployerPF.Text);
                objuserdetails.EMPLOYER_ESIC = Convert.ToDecimal(txtEmployerESIC.Text);
                objuserdetails.TOTAL_CTC = Convert.ToDecimal(txtTotalCTC.Text);
                //objuserdetails.ADMN_CHRGS = Convert.ToDecimal(txtAdmnChrgs.Text);
                //objuserdetails.GRAND_TOTAL = Convert.ToDecimal(txtGrandTotal.Text);
                SaveDocuments(objuserdetails);

                if (!MODIFYMODE)
                {
                    objuserdetails.CREATEDDATE = DateTime.UtcNow;
                    int lastuserid = userdetailslist.Max(u => u.EMPLOYEEIID);
                    objuserdetails.EMPLOYEEIID = lastuserid + 1;
                    userdetailslist.Add(objuserdetails);
                    
                }
                else
                {
                    objuserdetails.MODIFIEDDATE = DateTime.UtcNow;
                }

                entity.SaveEmployeeData(userdetailslist);
                SELECTEDEMPLOYEEIID = objuserdetails.EMPLOYEEIID;
                this.Cursor = Cursors.Default;

                MessageBox.Show("Employee details saved successfully.", "Employee Management",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message, "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }
        }

        private void SaveDocuments(employeeDetailsModel user)
        {
            try
            {
                int userid = user.EMPLOYEEIID;

                if (!string.IsNullOrEmpty(lblResumePath.Text))
                {
                    if (user.RESUME != lblResumePath.Text)
                        user.RESUME = entity.SaveDocument(lblResumePath.Text, "resume", user.EMPLOYEECODE);
                }
                else
                {
                    user.RESUME = string.Empty;
                }
                if (pbPhoto.Image != null)
                {
                    if(user.PHOTO != pbPhoto.ImageLocation)
                    user.PHOTO = entity.SaveDocument(pbPhoto.ImageLocation, "photo", user.EMPLOYEECODE);
                }
                else
                { user.PHOTO = string.Empty; }

                if (PBAdharFront.Image != null)
                {
                    if(user.UAD_FRONT != PBAdharFront.ImageLocation)
                    user.UAD_FRONT = entity.SaveDocument(PBAdharFront.ImageLocation, "uidfront", user.EMPLOYEECODE);
                }
                else
                { user.UAD_FRONT = string.Empty; }

                if (pbAadharBack.Image != null)
                {
                    if (user.UAD_BACK != pbAadharBack.ImageLocation)
                        user.UAD_BACK = entity.SaveDocument(pbAadharBack.ImageLocation, "uidback", user.EMPLOYEECODE);
                }
                else
                { user.UAD_BACK = string.Empty; }

                if (pbPAN.Image != null)
                {
                    if (user.PAN != pbPAN.ImageLocation)
                        user.PAN = entity.SaveDocument(pbPAN.ImageLocation, "pan", user.EMPLOYEECODE);
                }
                else
                { user.PAN = string.Empty; }

                if (pbPassbook.Image != null)
                {
                    if (user.PASSBOOK != pbPassbook.ImageLocation)
                        user.PASSBOOK = entity.SaveDocument(pbPassbook.ImageLocation, "passbook", user.EMPLOYEECODE);
                }
                else
                { user.PASSBOOK = string.Empty; }
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

        private void btnResume_Click(object sender, EventArgs e)
        {
            lblResumePath.Text = SelectFile("Office Files|*.doc;*.docx|PDF Files|*.pdf|All files (*.*)|*.*");
        }
        private string SelectFile(string filter = "All files (*.*)|*.*")
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            try
            {


                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "d:\\Ravi\\Personal";
                    openFileDialog.Filter = filter;
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        //Read the contents of the file into a stream
                        var fileStream = openFileDialog.OpenFile();

                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            fileContent = reader.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message, "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }
            return filePath;
        }

        private void PBAdharFront_DoubleClick(object sender, EventArgs e)
        {
            PBAdharFront.ImageLocation = SelectFile("Image Files|*.jpeg;*.jpg;");
        }

        private void pbAadharBack_DoubleClick(object sender, EventArgs e)
        {
            pbAadharBack.ImageLocation = SelectFile("Image Files|*.jpeg;*.jpg;");
        }

        private void pbPAN_DoubleClick(object sender, EventArgs e)
        {
            pbPAN.ImageLocation = SelectFile("Image Files|*.jpeg;*.jpg;");
        }

        private void pbPassbook_DoubleClick(object sender, EventArgs e)
        {
            pbPassbook.ImageLocation = SelectFile("Image Files|*.jpeg;*.jpg;");
        }

        private void pbPhoto_DoubleClick(object sender, EventArgs e)
        {
            pbPhoto.ImageLocation = SelectFile("Image Files|*.jpeg;*.jpg;");
        }

        private void CreateDocument(employeeDetailsModel user, string doctype)
        {
            try
            {

                string htmlString = string.Empty;
                string TxtHtmlCode = entity.GetDocumenTemplate(doctype);
                string employeename = $"{user.FNAME} {user.LNAME}";

                if (doctype == "JOINING")
                {
                    htmlString = string.Format(TxtHtmlCode, user.REFNO, DateTime.Now.ToString("dd-MMM-yyyy"), user.FNAME, user.LNAME, user.ADDRESS, user.EMPLOYEECODE,
                       user.DESIGNATION, Convert.ToString(user.BASIC), Convert.ToString(user.HRA), Convert.ToString(user.ALLOWANCE), Convert.ToString(user.CONV),
                       Convert.ToString(user.GROSS), Convert.ToString(user.EMPLOYEE_PF), Convert.ToString(user.EMPLOYEE_ESIC),
                      Convert.ToString(user.EMPLOYEE_PT), Convert.ToString(user.NETSALARY), Convert.ToString(user.EMPLOYER_PF), Convert.ToString(user.EMPLOYER_ESIC),
                      user.TOTAL_CTC, user.DOJ.ToString("dd-MMM-yyyy"), user.LOCATION);
                }
                else
                {
                    decimal totalearning = user.BASIC + user.HRA + user.CONV + user.ALLOWANCE;
                    decimal totaldeduction = user.EMPLOYEE_PF + user.EMPLOYEE_ESIC + user.EMPLOYEE_PT;
                    decimal totalSalary = totalearning - totaldeduction;
                    htmlString = string.Format(TxtHtmlCode, $"{ DateTime.Now.ToMonthName()}-{ DateTime.Now.Year}", user.EMPLOYEECODE, user.PANNO, employeename, user.UANNO, user.AADHARNO, user.ESICNO, user.LOCATION,
                        user.DOJ.ToString("dd-MMM-yyyy"), user.BASIC, user.EMPLOYEE_PF, user.HRA, user.EMPLOYEE_ESIC, user.CONV, user.EMPLOYEE_PT, user.ALLOWANCE,
                        totalearning, totaldeduction, totalSalary);
                }

                //string baseUrl = TxtBaseUrl.Text;

                string pdf_page_size = "A4";
                PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
                    pdf_page_size, true);

                string pdf_orientation = "Portrait";
                PdfPageOrientation pdfOrientation =
                    (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
                    pdf_orientation, true);

                int webPageWidth = 1024;


                int webPageHeight = 0;


                // instantiate a html to pdf converter object
                HtmlToPdf converter = new HtmlToPdf();

                // set converter options
                converter.Options.PdfPageSize = pageSize;
                converter.Options.PdfPageOrientation = pdfOrientation;
                converter.Options.WebPageWidth = webPageWidth;
                converter.Options.WebPageHeight = webPageHeight;

                // create a new pdf document converting an url
                PdfDocument doc = converter.ConvertHtmlString(htmlString, entity.BaseUrlPath);
                string salPath = $"{entity.SalarySlipPath}{DateTime.Now.ToMonthName()}_{DateTime.Now.Year}";
                string filepath = string.Empty;
                // save pdf document
                if (doctype == "JOINING")
                {
                    filepath = $"{entity.JoiningLetterPath}\\Joining_{user.EMPLOYEECODE}.pdf";
                    doc.Save(filepath);
                }
                else
                {
                    if (!Directory.Exists(salPath))
                    {
                        Directory.CreateDirectory(salPath);
                    }
                    filepath = $"{salPath}\\Salaryslip_{user.EMPLOYEECODE}_{DateTime.Now.ToShortMonthName()}_{DateTime.Now.Year}.pdf";
                    doc.Save(filepath);
                }
                // close pdf document
                doc.Close();
                this.Cursor = Cursors.Default;
                MessageBox.Show("Document generated successfully. ", "Employee Management",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(filepath);
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message, "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                exceptionlog.HandleException(ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SELECTEDEMPLOYEEIID <= 0)
            {

                MessageBox.Show("Save the employee details first. ", "Employee Management",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.Cursor = Cursors.WaitCursor;
            objuserdetails = userdetailslist.FirstOrDefault(u => u.EMPLOYEEIID == SELECTEDEMPLOYEEIID);
            CreateDocument(objuserdetails, "JOINING");
            this.Cursor = Cursors.Default;
        }

        private void btnSalarySlip_Click(object sender, EventArgs e)
        {
            
            if (SELECTEDEMPLOYEEIID <= 0)
            {

                MessageBox.Show("Save the employee details first. ", "Employee Management",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.Cursor = Cursors.WaitCursor;
            objuserdetails = userdetailslist.FirstOrDefault(u => u.EMPLOYEEIID == SELECTEDEMPLOYEEIID);
            CreateDocument(objuserdetails, "SALARYSLIP");
            this.Cursor = Cursors.Default;
        }

       
    }
}
