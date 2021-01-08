using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class employeeDetailsModel
    {
        /// <summary>
        /// Login details
        /// </summary>
        public int EMPLOYEEIID { get; set; }
        public string FNAME { get; set; }
        public string LNAME { get; set; }
        public string LOGINID { get; set; }
        public string PASSWORD { get; set; }
        public string  USERTYPE { get; set; }
        public string STATUS { get; set; }
        public string EMPLOYEECODE { get; set; }
        public string  DESIGNATION { get; set; }
        public string  LOCATION { get; set; }
        public string REFNO { get; set; }
        public string ESICNO { get; set; }
        public string DEPARTMENT { get; set; }

        /// <summary>
        /// Basic details
        /// </summary>
        public string GENDER { get; set; }
        public string MARITALSTATUS { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string FATHERNAME { get; set; }
        public string MOBILENO { get; set; }
        public string EMGCONTACTNO { get; set; }
        public string EMAILID { get; set; }
        public string ADDRESS { get; set; }
        public string UANNO { get; set; }
        public string AADHARNO { get; set; }
        public string PANNO { get; set; }
        public string NOMINEE { get; set; }
        public DateTime NOMINEEDOB { get; set; }
        public string AC_NAME { get; set; }
        public string AC_NUMBER { get; set; }
        public string BANKNAME { get; set; }
        public string IFSCCODE { get; set; }
        public DateTime ADDEDTIME { get; set; }
        public string REFERRERNAME { get; set; }
        public string ATTSER_STATUS { get; set; }
        public string TASKOWNNER { get; set; }

        /// <summary>
        /// Documents detail
        /// </summary>
        public string PHOTO { get; set; }
        public string RESUME { get; set; }
        public string UAD_FRONT { get; set; }
        public string UAD_BACK { get; set; }
        public string PAN { get; set; }
        public string PASSBOOK { get; set; }


        /// <summary>
        /// Salary details
        /// </summary>
        public int DAYS { get; set; }        
        public decimal BASIC { get; set; }
        public decimal HRA { get; set; }
        public decimal ALLOWANCE { get; set; }
        public decimal CONV { get; set; }
        public decimal GROSS { get; set; }
        public decimal EMPLOYEE_PF { get; set; }
        public decimal EMPLOYEE_ESIC { get; set; }
        public decimal EMPLOYEE_PT { get; set; }
        public decimal EMPLOYEE_DEDUCTION { get; set; }
        public decimal NETSALARY { get; set; }
        public decimal TOTAL { get; set; }
        public decimal EMPLOYER_PF { get; set; }
        public decimal EMPLOYER_ESIC { get; set; }
        public decimal TOTAL_CTC { get; set; }
        public decimal ADMN_CHRGS { get; set; }
        public decimal GRAND_TOTAL { get; set; }
        public DateTime PERIOD { get; set; }
        public DateTime CREATEDDATE { get; set; }
        public DateTime MODIFIEDDATE { get; set; }

    }
}
