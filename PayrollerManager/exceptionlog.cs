using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Configuration;

namespace PayrollerManager
{
    static class exceptionlog
    {
        public static readonly string exceptionpath = ConfigurationManager.AppSettings["ExceptionPath"];
        public static readonly string logpath = ConfigurationManager.AppSettings["LogPath"];

        public static void writetofile(string Content)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            string strFilePath = logpath.Replace("$", DateTime.Now.ToString("dd_MMM_yyyy"));

            if (!File.Exists(strFilePath))
                fs = File.Create(strFilePath);
            else
                sw = File.AppendText(strFilePath);
            sw = sw == null ? new StreamWriter(fs) : sw;

            sw.WriteLine(DateTime.Now.ToString() + " - " + Content);
            sw.Close();
            if (fs != null)
                fs.Close();
        }

        public static void HandleException(Exception ex)
        {
            try
            {

                FileStream fs = null;
                StreamWriter sw = null;
                string strFilePath = exceptionpath.Replace("$", DateTime.Now.ToString("dd_MMM_yyyy"));

                if (!File.Exists(strFilePath))
                    fs = File.Create(strFilePath);
                else
                    sw = File.AppendText(strFilePath);
                sw = sw == null ? new StreamWriter(fs) : sw;

                sw.WriteLine("\n************************************** Exception Log Start **************************************");
                sw.WriteLine("\n****************************************************************************************************");
                sw.WriteLine("\nDATE : ");
                sw.WriteLine("\n" + DateTime.Now.ToString());
                sw.WriteLine("\nMESSAGE : ");
                sw.WriteLine("\n" + ex.Message);
                if (ex != null && ex.InnerException != null)
                {
                    sw.WriteLine("\nINNER EXCEPTION : ");
                    sw.WriteLine("\n" + ex.InnerException.Message);
                }
                sw.WriteLine("\nStack Trace:");
                sw.WriteLine("\n" + ex.StackTrace);
                sw.WriteLine("\nSource : ");
                sw.WriteLine("\n" + ex.Source);
                sw.WriteLine("\n************************************** Exception Log End **************************************");
                sw.WriteLine("\n****************************************************************************************************");
                sw.Close();
                if (fs != null)
                    fs.Close();

            }
            catch { }
        }
    }
}
