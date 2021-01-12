using DataAccess.Models;
using SelectPdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//using Spire.Email;
//using Spire.Email.IMap;
//using Spire.Email.Smtp;

namespace PayrollerManager
{
    public partial class frmGenerateSalary : BaseForm
    {
        public frmGenerateSalary()
        {
            InitializeComponent();
        }
        public string LOGINID { get; set; }
        public int LOGGEDINUSERID { get; set; }
        public List<employeeDetailsModel> userdetailslist { get; set; }
        public List<employeeSalaryDetailsModel> employeesalarylist { get; set; }
        public Boolean CellClickCheck { get; set; }
        private bool allselectd = false;

        int iRowIndex = 0;
        private void GenerateSalary_Load(object sender, EventArgs e)
        {
            DGUsermaster.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 240, 228);
            DGUsermaster.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(174, 174, 174);
            DGUsermaster.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(221, 221, 221);
            DGUsermaster.RowHeadersWidth = 21;
            DGUsermaster.AllowUserToAddRows = false;
            DGUsermaster.AllowUserToDeleteRows = false;

            DGUsermaster.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            DGUsermaster.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // DGUsermaster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            SetOnChangeGenericHandler(this.Controls);
            employeesalarylist = entity.GetAllEmployeeSalaryData();
            FillGrid();
        }

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
                            DGUsermaster.Rows[iRowindex].Cells["EMPLOYEEID"].Value = users.EMPLOYEEIID;
                            DGUsermaster.Rows[iRowindex].Cells["EMPLOYEENAME"].Value = $"{ users.FNAME} { users.LNAME}";
                            DGUsermaster.Rows[iRowindex].Cells["EMPLOYEECODE"].Value = users.EMPLOYEECODE;
                            DGUsermaster.Rows[iRowindex].Cells["EMAILID"].Value = users.EMAILID;

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

        private void DGUsermaster_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerateSalary_Click(object sender, EventArgs e)
        {
            try
            {
                int iselectedcount = 0;

                if (!dtpSalaryperiod.Checked)
                {
                    MessageBox.Show("Please select salary period.", "Employee Management",
                                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                for (int irows = 0; irows < DGUsermaster.Rows.Count; irows++)
                {
                    if (Convert.ToBoolean(DGUsermaster.Rows[irows].Cells["SELECT"].Value))
                    {
                        iselectedcount++;
                        break;
                    }
                }
                if (iselectedcount == 0)
                {
                    MessageBox.Show("Please select atleast one employee.", "Employee Management",
                                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                this.Cursor = Cursors.WaitCursor;
                for (int irows = 0; irows < DGUsermaster.Rows.Count; irows++)
                {
                    if (Convert.ToBoolean(DGUsermaster.Rows[irows].Cells["SELECT"].Value))
                    {
                        if (!IfPeriodExist(Convert.ToInt32(DGUsermaster.Rows[irows].Cells["EMPLOYEEID"].Value)))
                        {
                            int lastuserid = employeesalarylist.Max(u => u.SALARYID);

                            employeeSalaryDetailsModel employeesalary = entity.FetchEmployeeSalary(Convert.ToInt32(DGUsermaster.Rows[irows].Cells["EMPLOYEEID"].Value));
                            employeesalary.SALARYID = lastuserid + 1;
                            employeesalary.PERIOD = dtpSalaryperiod.Value;
                            employeesalary.REMARKS = "Generated from email module.";
                            //Salary details
                            employeesalarylist.Add(employeesalary);

                        }
                    }
                }
                entity.SaveSalaryData(employeesalarylist);

                for (int irows = 0; irows < DGUsermaster.Rows.Count; irows++)
                {
                    if (Convert.ToBoolean(DGUsermaster.Rows[irows].Cells["SELECT"].Value))
                    {
                        if (IfPeriodExist(Convert.ToInt32(DGUsermaster.Rows[irows].Cells["EMPLOYEEID"].Value)))
                        {
                            employeeDetailsModel employee = entity.GetEmployeeData(Convert.ToInt32(DGUsermaster.Rows[irows].Cells["EMPLOYEEID"].Value));
                            employeeSalaryDetailsModel salary = GetSalaryDetails(Convert.ToInt32(DGUsermaster.Rows[irows].Cells["EMPLOYEEID"].Value));

                            if (employee != null && salary != null)
                            {
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
                                employee.PERIOD = salary.PERIOD;
                                CreateDocument(employee, "SALARY");
                            }
                        }
                    }
                }
                this.Cursor = Cursors.Default;
                MessageBox.Show("Salary slip generated successfully.", "Employee Management",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message, "Employee Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                exceptionlog.HandleException(ex);
            }
        }
        private bool IfPeriodExist(int employeeid)
        {
            return employeesalarylist.Any(e => e.PERIOD.Month == dtpSalaryperiod.Value.Month &&
                                                    e.PERIOD.Year == dtpSalaryperiod.Value.Year &&
                                                    e.EMPLOYEEIID == employeeid);

        }
        private employeeSalaryDetailsModel GetSalaryDetails(int employeeid)
        {
            return employeesalarylist.Where(e => e.EMPLOYEEIID == employeeid &&
                                                 e.PERIOD.Month == dtpSalaryperiod.Value.Month &&
                                                 e.PERIOD.Year == dtpSalaryperiod.Value.Year).FirstOrDefault();
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


            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message, "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error);

                exceptionlog.HandleException(ex);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (!allselectd)
            {
                for (int irows = 0; irows < DGUsermaster.Rows.Count; irows++)
                {

                    DGUsermaster.Rows[irows].Cells["SELECT"].Value = true;
                    allselectd = true;
                    btnSelect.Text = "Deselect all";
                }
            }
            else
            {
                for (int irows = 0; irows < DGUsermaster.Rows.Count; irows++)
                {

                    DGUsermaster.Rows[irows].Cells["SELECT"].Value = false;
                    allselectd = false;
                    btnSelect.Text = "Select all";
                }

            }
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            try
            {
                string foldername = $"{dtpSalaryperiod.Value.ToMonthName()}_{dtpSalaryperiod.Value.Year}";
                string periodname = $"{dtpSalaryperiod.Value.ToShortMonthName()}_{dtpSalaryperiod.Value.Year}";

                string Salaryperiod = $"{dtpSalaryperiod.Value.ToMonthName()}-{dtpSalaryperiod.Value.Year}";
                string salaryslipfile = string.Empty;
                string tomailid = string.Empty;
                string employeename = string.Empty;
                this.Cursor = Cursors.WaitCursor;
                for (int irows = 0; irows < DGUsermaster.Rows.Count; irows++)
                {
                    if (Convert.ToBoolean(DGUsermaster.Rows[irows].Cells["SELECT"].Value))
                    {
                        salaryslipfile = string.Empty;
                        tomailid = string.Empty;
                        employeename = Convert.ToString(DGUsermaster.Rows[irows].Cells["EMPLOYEENAME"].Value);
                        tomailid = Convert.ToString(DGUsermaster.Rows[irows].Cells["EMAILID"].Value);

                        salaryslipfile = $"{entity.SalarySlipPath}\\{foldername}\\Salaryslip_{DGUsermaster.Rows[irows].Cells["EMPLOYEECODE"].Value}_{periodname}.pdf";

                        emailsalaryslip(salaryslipfile, tomailid, Salaryperiod, employeename);
                        Thread.Sleep(1000);
                    }
                }
                this.Cursor = Cursors.Default;
                MessageBox.Show("Email sent successfully. ", "Employee Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message, "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error);

                exceptionlog.HandleException(ex);
            }
        }

        private void emailsalaryslip(string salaryslip, string toemailid, string salaryperiod, string employeename)
        {
            try
            {
                if (File.Exists(salaryslip))
                {
                    MailMessage mail = new MailMessage();

                    mail.From = new MailAddress(entity.Frommail,entity.Displayname);
                    mail.To.Add(toemailid);
                    mail.Subject = $"Salary slip for {salaryperiod}";
                    mail.Body = $"Hi {employeename},\r\nPlease find the attachment of the salary slip for {salaryperiod}.\n\n\n\nRegards";
                    
                    SmtpClient SmtpServer = new SmtpClient(entity.Host);
                    Attachment attachment = new Attachment(salaryslip);
                    mail.Attachments.Add(attachment);
                    
                    SmtpServer.Port = Convert.ToInt32(entity.Port);
                    SmtpServer.Credentials = new System.Net.NetworkCredential(entity.Frommail, entity.Password);
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);
                }


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
