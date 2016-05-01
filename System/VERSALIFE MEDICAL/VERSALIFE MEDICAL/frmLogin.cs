// Software Name:       VERSALIFE MEDICAL SYSTEMS
// Software Code:       FP6-IST-511368
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

using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;
using System.Threading;


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
            connectivity.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {

        }

        static string con = ConfigurationManager.ConnectionStrings["connectToVersalife"].ConnectionString;


        Thread connectivity = new Thread(() => {
            SqlConnection connect = new SqlConnection(con);
            try
            {
                connect.Open();
                MessageBox.Show("Connected","", MessageBoxButtons.OK);  
            }
            catch
            {
                MessageBox.Show("No Connection", "", MessageBoxButtons.OK);
            }
        });

    }  
     
}
