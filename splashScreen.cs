using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TayMark_Teams
{
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }
        int second = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            ProgressBar.Left += 2;
            if (ProgressBar.Left + ProgressBar.Width > panelcenterpanel.Width + 70)
                ProgressBar.Left = 0;
            if (second == 100)
            {
                timer1.Stop(); //stops timer 
                this.Hide();//hide first form aka splash screen
                loginPage lp = new loginPage();//declare veriable lp as loginPage
                lp.ShowDialog();//shows loginPage
                this.Close(); //closes splashscreen
            }
        }
    }
}
