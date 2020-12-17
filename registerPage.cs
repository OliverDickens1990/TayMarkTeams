using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace TayMark_Teams
{
    public partial class registerPage : Form
    {

        // Connection 
        // Connection has a 30sec timeout to prevent the connection staying open 
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\OLIVER\DOCUMENTS\TAYMARKTEAMS.MDF;Integrated Security=True;Connect Timeout=30");
        
        public registerPage()
        {
            InitializeComponent();
        }
        private void TitlecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Connection Query
            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [user] (title, firstName, lastName, email, password) VALUES(@title,@firstName,@lastName, @email, @password)", connection);
            cmd.Parameters.AddWithValue("title", TitlecomboBox.Text.ToString());
            cmd.Parameters.AddWithValue("firstName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("lastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("email", txtEmail.Text);
            cmd.Parameters.AddWithValue("password", txtPassword.Text);
            cmd.ExecuteNonQuery();

            TitlecomboBox.SelectedItem = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            connection.Close();
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Registration Sucessful");
                this.Hide(); //closes resgisterPage
                loginPage bi = new loginPage();//declare veriable bi as bookingInterface
                bi.ShowDialog();//shows loginpage
                this.Close(); //closes registerpage
            }
            else
            {
                MessageBox.Show("The invalid details");

            }
            connection.Close();
        }






        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(txtFirstName.Text, "^[A-Z][a-zA-Z]*$").Success) { }
            
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if(!Regex.Match(txtLastName.Text, "^[A-Z][a-zA-Z]*$").Success) { }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(txtEmail.Text, @"^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {}
            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress("xyz@taymark.scot");
            }
            catch (FormatException)
            {
                // wrong e-mail address
                MessageBox.Show("Please register a @taymark email");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length < 6)
            {

            }


        }
        // This is the Clear Fields Label
        private void labelClearFields_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registerPage_Load(object sender, EventArgs e)
        {

        }
    }
}

