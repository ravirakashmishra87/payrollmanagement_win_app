using AutoMapper;
using DataAccess.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;



namespace PayrollerManager
{
    static class entity
    {
        public static readonly string datafile = ConfigurationManager.AppSettings["Datafile"];
        public static readonly string salaryfile = ConfigurationManager.AppSettings["Salaryfile"];
        public static readonly string documentfilePath = ConfigurationManager.AppSettings["DocumentPath"];
        public static readonly string joiningLetterFormat = ConfigurationManager.AppSettings["JoiningLetterFormat"];
        public static readonly string JoiningLetterPath = ConfigurationManager.AppSettings["JoiningLetterPath"];
        public static readonly string SalarySlipPath = ConfigurationManager.AppSettings["SalarySlipPath"];
        public static readonly string SalarySlipFormat = ConfigurationManager.AppSettings["SalarySlipFormat"];
        public static readonly string BaseUrlPath = ConfigurationManager.AppSettings["BaseUrlPath"];

        //Mail configuration
        public static readonly string Host = ConfigurationManager.AppSettings["Host"];
        public static readonly string Port = ConfigurationManager.AppSettings["Port"];
        public static readonly string Frommail = ConfigurationManager.AppSettings["Mailfrom"];
        public static readonly string Displayname = ConfigurationManager.AppSettings["Displayname"];
        public static readonly string Password = ConfigurationManager.AppSettings["Password"];

        public static readonly string Department = ConfigurationManager.AppSettings["Department"];
        public static readonly string ServiceStatus = ConfigurationManager.AppSettings["ServiceStatus"];

        public static List<employeeDetailsModel> GetAllEmployeeData()
        {
            List<employeeDetailsModel> userdetailslist = new List<employeeDetailsModel>();
            using (StreamReader r = new StreamReader(datafile))
            {
                string json = r.ReadToEnd();
                if (!string.IsNullOrEmpty(json))
                {
                    userdetailslist = JsonConvert.DeserializeObject<List<employeeDetailsModel>>(json);
                }
            }
            return userdetailslist;
        }

        public static employeeDetailsModel GetEmployeeData(int employeeid)
        {
            List<employeeDetailsModel> userdetailslist = new List<employeeDetailsModel>();
            using (StreamReader r = new StreamReader(datafile))
            {
                string json = r.ReadToEnd();
                if (!string.IsNullOrEmpty(json))
                {
                    userdetailslist = JsonConvert.DeserializeObject<List<employeeDetailsModel>>(json);
                }
            }
            return userdetailslist.FirstOrDefault(e=>e.EMPLOYEEIID == employeeid);
        }

        public static List<employeeSalaryDetailsModel> GetAllEmployeeSalaryData()
        {
            List<employeeSalaryDetailsModel> usersalarydetailslist = new List<employeeSalaryDetailsModel>();
            using (StreamReader r = new StreamReader(salaryfile))
            {
                string json = r.ReadToEnd();
                if (!string.IsNullOrEmpty(json))
                {
                    usersalarydetailslist = JsonConvert.DeserializeObject<List<employeeSalaryDetailsModel>>(json);
                }
            }
            return usersalarydetailslist;
        }

        public static employeeSalaryDetailsModel GetEmployeeSalaryData(int salaryid)
        {
            List<employeeSalaryDetailsModel> usersalarydetailslist = new List<employeeSalaryDetailsModel>();
            using (StreamReader r = new StreamReader(salaryfile))
            {
                string json = r.ReadToEnd();
                if (!string.IsNullOrEmpty(json))
                {
                    usersalarydetailslist = JsonConvert.DeserializeObject<List<employeeSalaryDetailsModel>>(json);
                }
            }
            return usersalarydetailslist.FirstOrDefault(e=>e.SALARYID == salaryid);
        }

        public static void SaveEmployeeData(List<employeeDetailsModel> userdetailslist)
        {
            string jsonwrite = JsonConvert.SerializeObject(userdetailslist.ToArray());

            //write string to file
            File.WriteAllText(datafile, jsonwrite);
        }
        public static void SaveSalaryData(List<employeeSalaryDetailsModel> employeesalarylist)
        {
            string jsonwrite = JsonConvert.SerializeObject(employeesalarylist.ToArray());

            //write string to file
            File.WriteAllText(salaryfile, jsonwrite);
        }

        public static employeeDetailsModel Authenticate(string loginid, string password)
        {
            employeeDetailsModel userdetails = new employeeDetailsModel();
            List<employeeDetailsModel> items = new List<employeeDetailsModel>();
            using (StreamReader r = new StreamReader(datafile))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<employeeDetailsModel>>(json);

                if (items != null)
                {
                    userdetails = items.Where(u => u.LOGINID.Equals(loginid) &&
                                                        u.PASSWORD.Equals(password) &&
                                                        u.STATUS.Equals("ACTIVE")).FirstOrDefault();
                }
            }
            return userdetails;
        }
       
        public static string SaveDocument(string sourcefile,string doctype,string employeecode)
        {
            string ext = Path.GetExtension(sourcefile);
            string filename = $"{employeecode}_{doctype}{ext}";
            File.Copy(sourcefile, $"{documentfilePath}{filename}",true);

            return $"{documentfilePath}{filename}";
        }

        public static void DeleteDocuments(string employeecode)
        {
            string[] docs = Directory.GetFiles(documentfilePath, $"*{employeecode}*");
            foreach (string file in docs)
            {
                File.Delete(file);
            }
        }

        public static string GetDocumenTemplate(string doctype)
        {
            string format = string.Empty;
            if (doctype == "JOINING")
            {
                using (StreamReader r = new StreamReader(joiningLetterFormat))
                {
                    format = r.ReadToEnd();

                }
            }
            else
            {
                using (StreamReader r = new StreamReader(SalarySlipFormat))
                {
                    format = r.ReadToEnd();

                }

            }
            return format;

        }

        public static employeeSalaryDetailsModel FetchEmployeeSalary(int EmployeeID)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<employeeDetailsModel, employeeSalaryDetailsModel>();
            });
            IMapper iMapper = config.CreateMapper();

            List<employeeDetailsModel> userdetailslist = GetAllEmployeeData();
            var userdetails = userdetailslist.Where(e => e.EMPLOYEEIID == EmployeeID).FirstOrDefault();
            employeeSalaryDetailsModel destination = iMapper.Map<employeeDetailsModel, employeeSalaryDetailsModel>(userdetails);
            return destination;

        }

        public static List<string> GetDetaprtment()
        {
            List<string> department = Department.Split('|').ToList();
            return department;
        }

        public static List<string> GetServiceStatus()
        {
            List<string> servicestatus = ServiceStatus.Split('|').ToList();
            return servicestatus;
        }
    }
}
