using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class employeeSalaryDetailsModel
    {
        /// <summary>
        /// Salary details
        /// </summary>

        public int EMPLOYEEIID { get; set; }
        public int SALARYID { get; set; }
        public DateTime PERIOD { get; set; }
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
        public string REMARKS { get; set; }
        public DateTime CREATEDDATE { get; set; }
        public DateTime MODIFIEDDATE { get; set; }
    }
}
