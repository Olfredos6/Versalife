// Software Name:       VERSALIFE MEDICAL SYSTEMS
// Software Code:       FP6-IST-511368
// Development Version: Beta Version 1.0
// Developed By:        VERSALIFE MEDICAL SYSTEMS (PTY)LTD
// Contact:             Support@versalife.co.za
// Development Date:    April 2016


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VERSALIFE_MEDICAL
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
            Application.Run(new frmLogin());
        }
    }
}
