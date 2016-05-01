using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;

namespace VERSALIFE_MEDICAL
{
    public class frmLoginGenerics
    {
        /**********************************************************************/
        /*** What follows is the thread fucntion controlling the Status LED ***/
        /*******              BALUKIDI NEHEMIE @ VERSALIFE              *******/
        /*******              Friday 14 of April 2016                   *******/
        /**********************************************************************/

        static string con = ConfigurationManager.ConnectionStrings["connectToVersalife"].ConnectionString;


        public static Thread connectivityTest = new Thread(() => {
            drawStatusLED(Color.Yellow);
            SqlConnection connect = new SqlConnection(con);
            drawStatusLED(Color.Yellow);
            while (true)
            {
                drawStatusLED(Color.Yellow);
                try
                {
                    connect.Open();
                    drawStatusLED(Color.LawnGreen);
                    connect.Close();
                }
                catch
                {
                    drawStatusLED(Color.Red);
                }
                Thread.Sleep(5000);
            }
        });


        public static void drawStatusLED(Color color)
        {
            try
            {
                Form.ActiveForm.CreateGraphics().DrawEllipse(new Pen(color, 4), new Rectangle(4, 262, 4, 4));
            }
            catch {
                //The Login Form is not the active OS window anymore
            }
        }

        /**********************************************************************/
        /**********************************************************************/
    }
}
