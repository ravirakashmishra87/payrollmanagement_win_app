using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollerManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            // Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "M/d/yyyy";
            Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "d/M/yyyy";
            Application.Run(new MDIMain());
        }
    }
}
