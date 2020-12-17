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
   


    public partial class loginPage : Form
    {

        // Connection 
        // Connection has a 30sec timeout to prevent the connection staying open 
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\OLIVER\DOCUMENTS\TAYMARKTEAMS.MDF;Integrated Security=True;Connect Timeout=30");

        
        public loginPage()
        {
            InitializeComponent();
        }

        private void loginPage_Load(object sender, EventArgs e)
        {

        }
        
        // This is the Log In Button
        private void loginBtn_Click(object sender, EventArgs e)
        {
                 //Connection Query
                connection.Open();
               
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                SqlCommand cmd = new SqlCommand("select email,password from [user] where email='" + email + "'and password='" + password + "'", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login sucessful");
                    //if successful it will bring you to a new forms page
                    this.Hide(); //closes loginPage
                    bookingInterface bi = new bookingInterface();//declare veriable bi as bookingInterface
                    bi.ShowDialog();//shows bookingInterface
                    this.Close(); //closes loginPage
                }
                else
                {
                MessageBox.Show("The Email or Password you entered in incorrect");

            }
            connection.Close();
        }
        

 
        // Exit Label
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void labelRegister_Click(object sender, EventArgs e)
        {
            //moving to registration page as user cant sign in
            this.Hide();//hide this form
            registerPage rp = new registerPage();//declare veriable rp as registrationPage
            rp.ShowDialog();//shows registrationPage
            this.Close(); //closes loginPage
        }



        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void labelSkip_Click(object sender, EventArgs e)
        {
            this.Hide(); //closes loginPage
            bookingInterface bi = new bookingInterface();//declare veriable bi as bookingInterface
            bi.ShowDialog();//shows bookingInterface
            this.Close(); //closes loginPage
        }
    }
}
