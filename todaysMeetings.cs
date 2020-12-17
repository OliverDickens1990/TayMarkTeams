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
    public partial class todaysMeetings : Form
    {
        // Connection 
        // Connection has a 30sec timeout to prevent the connection staying open 
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\OLIVER\DOCUMENTS\TAYMARKTEAMS.MDF;Integrated Security=True;Connect Timeout=30");
        public todaysMeetings()
        {
            InitializeComponent();
        }

        private void todaysMeetings_Load(object sender, EventArgs e)
        {
            try
            {
                //Connection Query
                connection.Open();

                // Set up the data source.
                SqlCommand cmd = new SqlCommand("Select id, time, duration, room, email From meeting", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewMeetings.ReadOnly = true;
                dataGridViewMeetings.DataSource = dt;

                connection.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Could not find data for data grid");
            }

        }

        private void dataGridViewMeetings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

                
        }
        
    }
}
