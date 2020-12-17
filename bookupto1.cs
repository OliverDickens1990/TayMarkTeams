using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TayMark_Teams
{
    public partial class bookupto1 : Form
    {

        // Connection 
        // Connection has a 30sec timeout to prevent the connection staying open 
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\OLIVER\DOCUMENTS\TAYMARKTEAMS.MDF;Integrated Security=True;Connect Timeout=30");


        public bookupto1()
        {
            InitializeComponent();
        }


    }
}
