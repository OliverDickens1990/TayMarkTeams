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
    public partial class bookupto2 : Form
    {
        // Connection 
        // Connection has a 30sec timeout to prevent the connection staying open 
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\OLIVER\DOCUMENTS\TAYMARKTEAMS.MDF;Integrated Security=True;Connect Timeout=30");

        public bookupto2()
        {
            InitializeComponent();
        }



        private void comboBoxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                // create a SqlCommand object for this connection
                SqlCommand command = connection.CreateCommand();
                SqlCommand cmd = new SqlCommand("Select * from [meetingRoom] Where capacity = 2");
                command.CommandType = CommandType.Text;

                // execute the command that returns a SqlDataReader
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxRoom.Items.Add(reader["name"].ToString());
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void bookupto2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tayMarkTeamsDataSetEmployees.user' table. You can move, or remove it, as needed.
            this.userTableAdapter1.Fill(this.tayMarkTeamsDataSetEmployees.user);

        }

        private void btnBook_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //listBoxEmployees.Items.Add(listViewEmployee.SelectedItem);
            //int i = 0;
            //i = listViewEmployee.SelectedIndex;
            //listViewEmployee.Items.RemoveAt(i);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //listViewEmployee.Items.Add(listBoxEmployees.SelectedItem);
           //int i = 0;
            //i = listBoxEmployees.SelectedIndex;
            //listBoxEmployees.Items.RemoveAt(i);
        }

        //REFhttps://stackoverflow.com/questions/18113278/populate-a-datagridview-with-sql-query-results
        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Connection Query
                connection.Open();

                // Set up the data source.
                SqlCommand cmd = new SqlCommand("Select title, firstName, lastName, email From user", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewEmployees.ReadOnly = true;
                dataGridViewEmployees.DataSource = dt;



            }
            catch (SqlException)
            {
                MessageBox.Show("Could not find data for data grid");
            }
            connection.Close();
        }


        private void dataGridViewEmployees_Load(object sender, EventArgs e)
        {
            try
            {
                //Connection Query
                connection.Open();

                // Set up the data source.
                SqlCommand cmd = new SqlCommand("Select title, firstName, lastName, email From meeting", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewEmployees.ReadOnly = true;
                dataGridViewEmployees.DataSource = dt;

                connection.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Could not find data for data grid");
            }

        }
    }
}
