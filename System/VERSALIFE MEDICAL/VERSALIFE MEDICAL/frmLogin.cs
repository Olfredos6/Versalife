// Software Name:       VERSALIFE MEDICAL SYSTEMS
// Software Code:       FP6-IST-411368
// Development Version: Beta Version 1.0
// Developed By:        VERSALIFE MEDICAL SYSTEMS (PTY)LTD
// Contact:             Support@versalife.co.za
// Development Date:    April 2016


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VERSALIFE_MEDICAL
{
    public partial class frmLogin : DevComponents.DotNetBar.Office2007Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            frmLoginGenerics.connectivityTest.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmLoginGenerics.connectivityTest.Abort();
            Application.Exit();
        }
    }

}
