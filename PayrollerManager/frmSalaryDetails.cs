using DataAccess.Models;
using SelectPdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollerManager
{
    public partial class frmSalaryDetails : BaseForm
    {
        public frmSalaryDetails()
        {
            InitializeComponent();
        }
        public int EMPLOYEEIID { get; set; }
        public int LOGGEDINUSERID { get; set; }
        public bool MODIFYMODE { get; set; }
        public string EMPLOYEECODE { get; set; }
        public List<employeeSalaryDetailsModel> employeeSalaryModelList { get; set; }

        employeeSalaryDetailsModel objemployeeSalarydetails;
        int Salaryid = 0;
        private void SalaryDetails_Load(object sender, EventArgs e)
        {
            try
            {
                //if (!MODIFYMODE)
                //{
                //    objemployeeSalarydetails = new employeeSalaryDetailsModel();
                //}
                this.Text = $"Salary details - {EMPLOYEECODE}";
                dgSalary.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 240, 228);
                dgSalary.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(174, 174, 174);
                dgSalary.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(221, 221, 221);
                dgSalary.RowHeadersWidth = 21;
                dgSalary.AllowUserToAddRows = false;
                dgSalary.AllowUserToDeleteRows = false;

                dgSalary.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
                dgSalary.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgSalary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                FillSalary();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message, "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFetchSalary_Click(object sender, EventArgs e)
        {
            try
            {
                employeeSalaryDetailsModel employeesalary = entity.FetchEmployeeSalary(EMPLOYEEIID);

                //Salary details
                txtDays.Text = Convert.ToString(employeesalary.DAYS);
                txtBasic.Text = Convert.ToString(employeesalary.BASIC);
                txtHRA.Text = Convert.ToString(employeesalary.HRA);
                txtAllowances.Text = Convert.ToString(employeesalary.ALLOWANCE);
                txtConv.Text = Convert.ToString(employeesalary.CONV);
                txtGross.Text = Convert.ToString(employeesalary.GROSS);
                txtEmployeePF.Text = Convert.ToString(employeesalary.EMPLOYEE_PF);
                txtEmployeeESIC.Text = Convert.ToString(employeesalary.EMPLOYEE_ESIC);
                txtEmployeePT.Text = Convert.ToString(employeesalary.EMPLOYEE_PT);
                txtEmployeeDeduction.Text = Convert.ToString(employeesalary.EMPLOYEE_DEDUCTION);
                txtNetSalary.Text = Convert.ToString(employeesalary.NETSALARY);
                txtTotalSalary.Text = Convert.ToString(employeesalary.TOTAL);
                txtEmployerPF.Text = Convert.ToString(employeesalary.EMPLOYER_PF);
                txtEmployerESIC.Text = Convert.ToString(employeesalary.EMPLOYER_ESIC);
                txtTotalCTC.Text = Convert.ToString(employeesalary.TOTAL_CTC);
                //txtAdmnChrgs.Text = Convert.ToString(employeesalary.ADMN_CHRGS);
                //txtGrandTotal.Text = Convert.ToString(employeesalary.GRAND_TOTAL);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error occured Please Contact Administrator \nError - " + ex.Message, "Employee Management",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dtpSalaryPeriod.Checked)
                {
                    MessageBox.Show("Please select salary period.", "Employee Management",
                                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
                if (!MODIFYMODE && IfPeriodExist())
                {
                    MessageBox.Show("Salary details for seleted period already exist.", "Employee Management",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                objemployeeSalarydetails.PERIOD = dtpSalaryPeriod.Value;
                objemployeeSalarydetails.EMPLOYEEIID = EMPLOYEEIID;
                objemployeeSalarydetails.DAYS = Convert.ToInt32(txtDays.Text);
                objemployeeSalarydetails.BASIC = Convert.ToDecimal(txtBasic.Text);
                objemployeeSalarydetails.HRA = Convert.ToDecimal(txtHRA.Text);
                objemployeeSalarydetails.ALLOWANCE = Convert.ToDecimal(txtAllowances.Text);
                objemployeeSalarydetails.CONV = Convert.ToDecimal(txtConv.Text);
                objemployeeSalarydetails.GROSS = Convert.ToDecimal(txtGross.Text);
                objemployeeSalarydetails.EMPLOYEE_PF = Convert.ToDecimal(txtEmployeePF.Text);
                objemployeeSalarydetails.EMPLOYEE_ESIC = Convert.ToDecimal(txtEmployeeESIC.Text);
                objemployeeSalarydetails.EMPLOYEE_PT = Convert.ToDecimal(txtEmployeePT.Text);
                objemployeeSalarydetails.EMPLOYEE_DEDUCTION = Convert.ToDecimal(txtEmployeeDeduction.Text);
                objemployeeSalarydetails.NETSALARY = Convert.ToDecimal(txtNetSalary.Text);
                objemployeeSalarydetails.TOTAL = Convert.ToDecimal(txtTotalSalary.Text);
                objemployeeSalarydetails.EMPLOYER_PF = Convert.ToDecimal(txtEmployerPF.Text);
                objemployeeSalarydetails.EMPLOYER_ESIC = Convert.ToDecimal(txtEmployerESIC.Text);
                objemployeeSalarydetails.TOTAL_CTC = Convert.ToDecimal(txtTotalCTC.Text);
                //objemployeeSalarydetails.ADMN_CHRGS = Convert.ToDecimal(txtAdmnChrgs.Text);
                //objemployeeSalarydetails.GRAND_TOTAL = Convert.ToDecimal(txtGrandTotal.Text);
                objemployeeSalarydetails.REMARKS = rtbSalaryRemark.Text;

                if (!MODIFYMODE)
                {
                    objemployeeSalarydetails.CREATEDDATE = DateTime.UtcNow;
                    if (employeeSalaryModelList.Count > 0)
                    {
                        int lastuserid = employeeSalaryModelList.Max(u => u.SALARYID);
                        objemployeeSalarydetails.SALARYID = lastuserid + 1;
                    }
                    else
                    {
                        objemployeeSalarydetails.SALARYID = 1;
                    }
                    employeeSalaryModelList.Add(objemployeeSalarydetails);
                }
                else
                {
                    objemployeeSalarydetails.MODIFIEDDATE = DateTime.UtcNow;
                }

                entity.SaveSalaryData(employeeSalaryModelList);
                this.Cursor = Cursors.Default;
                MessageBox.Show("Salary details saved successfully.", "Employee Management",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                MODIFYMODE = true;
                Salaryid = objemployeeSalarydetails.SALARYID;
                FillSalary();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error occured Please Contact Administrator \nError - " + ex.Message, "Employee Management",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }
        }
        private bool IfPeriodExist()
        {
            return employeeSalaryModelList.Any(e => e.PERIOD.Month == dtpSalaryPeriod.Value.Month &&
                                                    e.PERIOD.Year == dtpSalaryPeriod.Value.Year &&
                                                    e.EMPLOYEEIID == EMPLOYEEIID);

        }

        private void FillSalary()
        {
            try
            {
                var salarydata = employeeSalaryModelList.Where(e => e.EMPLOYEEIID == EMPLOYEEIID).OrderByDescending(e => e.PERIOD).ToList();
                dgSalary.Rows.Clear();
                if (salarydata.Count > 0)
                {
                    dgSalary.Rows.Add(salarydata.Count);
                    int iRowindex = 0;
                    foreach (var sal in salarydata)
                    {
                        dgSalary.Rows[iRowindex].Cells["SALARYID"].Value = sal.SALARYID;
                        dgSalary.Rows[iRowindex].Cells["PERIOD"].Value = $"{ sal.PERIOD.ToMonthName()} - { sal.PERIOD.Year}";
                        iRowindex++;
                    }
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

        private void dgSalary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetSalary();
        }
        private void GetSalary()
        {
            this.Cursor = Cursors.WaitCursor;
            if (dgSalary.CurrentCell != null)
            {
                MODIFYMODE = true;
                int iRowIndex = dgSalary.CurrentCell.RowIndex;
                int IID = Convert.ToInt32(dgSalary.Rows[iRowIndex].Cells[0].Value.ToString());

                if (IID > 0)
                {
                    Salaryid = IID;
                    objemployeeSalarydetails = employeeSalaryModelList.Where(e => e.SALARYID == IID).FirstOrDefault();

                    txtDays.Text = Convert.ToString(objemployeeSalarydetails.DAYS);
                    txtBasic.Text = Convert.ToString(objemployeeSalarydetails.BASIC);
                    txtHRA.Text = Convert.ToString(objemployeeSalarydetails.HRA);
                    txtAllowances.Text = Convert.ToString(objemployeeSalarydetails.ALLOWANCE);
                    txtConv.Text = Convert.ToString(objemployeeSalarydetails.CONV);
                    txtGross.Text = Convert.ToString(objemployeeSalarydetails.GROSS);
                    txtEmployeePF.Text = Convert.ToString(objemployeeSalarydetails.EMPLOYEE_PF);
                    txtEmployeeESIC.Text = Convert.ToString(objemployeeSalarydetails.EMPLOYEE_ESIC);
                    txtEmployeePT.Text = Convert.ToString(objemployeeSalarydetails.EMPLOYEE_PT);
                    txtEmployeeDeduction.Text = Convert.ToString(objemployeeSalarydetails.EMPLOYEE_DEDUCTION);
                    txtNetSalary.Text = Convert.ToString(objemployeeSalarydetails.NETSALARY);
                    txtTotalSalary.Text = Convert.ToString(objemployeeSalarydetails.TOTAL);
                    txtEmployerPF.Text = Convert.ToString(objemployeeSalarydetails.EMPLOYER_PF);
                    txtEmployerESIC.Text = Convert.ToString(objemployeeSalarydetails.EMPLOYER_ESIC);
                    txtTotalCTC.Text = Convert.ToString(objemployeeSalarydetails.TOTAL_CTC);
                    //txtAdmnChrgs.Text = Convert.ToString(objemployeeSalarydetails.ADMN_CHRGS);
                    //txtGrandTotal.Text = Convert.ToString(objemployeeSalarydetails.GRAND_TOTAL);
                    rtbSalaryRemark.Text = objemployeeSalarydetails.REMARKS;
                    dtpSalaryPeriod.Value = objemployeeSalarydetails.PERIOD;
                }
            }
            this.Cursor = Cursors.Default;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Salaryid = 0;
            MessageBox.Show("Salary details will be fetched from employee details.", "Employee Management",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);

            objemployeeSalarydetails = new employeeSalaryDetailsModel();
            employeeSalaryDetailsModel employeesalary = entity.FetchEmployeeSalary(EMPLOYEEIID);
            MODIFYMODE = false;
            //Salary details
            txtDays.Text = Convert.ToString(employeesalary.DAYS);
            txtBasic.Text = Convert.ToString(employeesalary.BASIC);
            txtHRA.Text = Convert.ToString(employeesalary.HRA);
            txtAllowances.Text = Convert.ToString(employeesalary.ALLOWANCE);
            txtConv.Text = Convert.ToString(employeesalary.CONV);
            txtGross.Text = Convert.ToString(employeesalary.GROSS);
            txtEmployeePF.Text = Convert.ToString(employeesalary.EMPLOYEE_PF);
            txtEmployeeESIC.Text = Convert.ToString(employeesalary.EMPLOYEE_ESIC);
            txtEmployeePT.Text = Convert.ToString(employeesalary.EMPLOYEE_PT);
            txtEmployeeDeduction.Text = Convert.ToString(employeesalary.EMPLOYEE_DEDUCTION);
            txtNetSalary.Text = Convert.ToString(employeesalary.NETSALARY);
            txtTotalSalary.Text = Convert.ToString(employeesalary.TOTAL);
            txtEmployerPF.Text = Convert.ToString(employeesalary.EMPLOYER_PF);
            txtEmployerESIC.Text = Convert.ToString(employeesalary.EMPLOYER_ESIC);
            txtTotalCTC.Text = Convert.ToString(employeesalary.TOTAL_CTC);
            //txtAdmnChrgs.Text = Convert.ToString(employeesalary.ADMN_CHRGS);
            //txtGrandTotal.Text = Convert.ToString(employeesalary.GRAND_TOTAL);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {

            GetSalary();
        }

        private void toolStripDelete_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (dgSalary.CurrentCell != null)
                {
                    int iRowIndex = dgSalary.CurrentCell.RowIndex;


                    if (MessageBox.Show("Really want to delete this record?", "Employee Management", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int salaryid = Convert.ToInt32(dgSalary.Rows[iRowIndex].Cells[0].Value.ToString());


                        bool isDeleted = employeeSalaryModelList.Remove(employeeSalaryModelList.FirstOrDefault(sal => sal.SALARYID == salaryid));
                        entity.SaveSalaryData(employeeSalaryModelList);

                        if (isDeleted)
                        {
                            this.Cursor = Cursors.Default;
                            MessageBox.Show("Record deleted successfully", "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FillSalary();
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
                else
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Select salary period to be deleted..", "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("Fail to delete salary details.", "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                exceptionlog.HandleException(ex);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            if (Salaryid <= 0)
            {
                MessageBox.Show("Please select salary period or save salary details to print. ", "Employee Management",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            employeeDetailsModel employee = entity.GetEmployeeData(EMPLOYEEIID);
            employeeSalaryDetailsModel salary = entity.GetEmployeeSalaryData(Salaryid);

            employee.DAYS = salary.DAYS;
            employee.BASIC = salary.BASIC;
            employee.HRA = salary.HRA;
            employee.ALLOWANCE = salary.ALLOWANCE;
            employee.CONV = salary.CONV;
            employee.GROSS = salary.GROSS;
            employee.EMPLOYEE_PF = salary.EMPLOYEE_PF;
            employee.EMPLOYEE_ESIC = salary.EMPLOYEE_ESIC;
            employee.EMPLOYEE_PT = salary.EMPLOYEE_PT;
            employee.EMPLOYEE_DEDUCTION = salary.EMPLOYEE_DEDUCTION;
            employee.NETSALARY = salary.NETSALARY;
            employee.TOTAL = salary.TOTAL;
            employee.EMPLOYER_PF = salary.EMPLOYER_PF;
            employee.EMPLOYER_ESIC = salary.EMPLOYER_ESIC;
            employee.TOTAL_CTC = salary.TOTAL_CTC;
            //employee.ADMN_CHRGS = salary.ADMN_CHRGS;
            //employee.GRAND_TOTAL = salary.GRAND_TOTAL;
            employee.PERIOD = salary.PERIOD;
            CreateDocument(employee, "SALARY");
            this.Cursor = Cursors.Default;
        }

        private void CreateDocument(employeeDetailsModel user, string doctype)
        {
            try
            {
                string htmlString = string.Empty;
                string TxtHtmlCode = entity.GetDocumenTemplate(doctype);
                string employeename = $"{user.FNAME} {user.LNAME}";


                decimal totalearning = user.BASIC + user.HRA + user.CONV + user.ALLOWANCE;
                decimal totaldeduction = user.EMPLOYEE_PF + user.EMPLOYEE_ESIC + user.EMPLOYEE_PT;
                decimal totalSalary = totalearning - totaldeduction;

                htmlString = string.Format(TxtHtmlCode, $"{ user.PERIOD.ToMonthName()}-{ user.PERIOD.Year}", user.EMPLOYEECODE, 
                                                user.PANNO, employeename, user.UANNO, user.AADHARNO, user.ESICNO, user.LOCATION,
                                                user.DOJ.ToString("dd-MMM-yyyy"), user.BASIC, user.EMPLOYEE_PF, user.HRA, 
                                                user.EMPLOYEE_ESIC, user.CONV, user.EMPLOYEE_PT, user.ALLOWANCE,
                                                totalearning, totaldeduction, totalSalary);


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
                string salPath = $"{entity.SalarySlipPath}{user.PERIOD.ToMonthName()}_{user.PERIOD.Year}";

                // save pdf document

                if (!Directory.Exists(salPath))
                {
                    Directory.CreateDirectory(salPath);
                }
                doc.Save($"{salPath}\\Salaryslip_{user.EMPLOYEECODE}_{user.PERIOD.ToShortMonthName()}_{user.PERIOD.Year}.pdf");

                // close pdf document
                doc.Close();
                this.Cursor = Cursors.Default;
                MessageBox.Show("Document generated successfully. ", "Employee Management",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start($"{salPath}\\Salaryslip_{user.EMPLOYEECODE}_{user.PERIOD.ToShortMonthName()}_{user.PERIOD.Year}.pdf");

            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message, "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error);

                exceptionlog.HandleException(ex);
            }
        }

       
    }


}
