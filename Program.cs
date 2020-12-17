using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TayMark_Teams
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

            //this is the first form that runs
            Application.Run(new splashScreen());
            //Application.Run(new loginPage()); //testing purposes
            //Application.Run(new bookingInterface()); //testing purposes
        }



    }
}
