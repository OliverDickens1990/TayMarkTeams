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

        private void bookupto1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tayMarkTeamsDataSet.meeting' table. You can move, or remove it, as needed.
            this.meetingTableAdapter.Fill(this.tayMarkTeamsDataSet.meeting);
            // TODO: This line of code loads data into the 'tayMarkTeamsDataSet.meetingRoom' table. You can move, or remove it, as needed.
            this.meetingRoomTableAdapter.Fill(this.tayMarkTeamsDataSet.meetingRoom);

        }

        private void listBoxRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select name from [meetingRoom] where capacity=2", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }
    }
}
