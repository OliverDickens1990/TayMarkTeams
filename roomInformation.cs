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

    public partial class roomInformation : Form
    {
        // Connection 
        // Connection has a 30sec timeout to prevent the connection staying open 
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\OLIVER\DOCUMENTS\TAYMARKTEAMS.MDF;Integrated Security=True;Connect Timeout=30");
        public roomInformation()
        {
            InitializeComponent();
        }
        private void dataGridViewRoomInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewRoomInfo_Load(object sender, EventArgs e)
        {
            try
            {
                //Connection Query
                connection.Open();

                // Set up the data source.
                SqlCommand cmd = new SqlCommand(@"Select id, name, available, capacity From meetingRoom");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewRoomInfo.ReadOnly = true;
                dataGridViewRoomInfo.DataSource = dt;

                connection.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Could not find data for data grid");
            }


        }

        private void roomInformation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tayMarkTeamsDataSetRoomInformation.meetingRoom' table. You can move, or remove it, as needed.
            this.meetingRoomTableAdapter.Fill(this.tayMarkTeamsDataSetRoomInformation.meetingRoom);

        }
    }
}


