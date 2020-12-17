using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TayMark_Teams
{
    public partial class bookingInterface : Form
    {
        public bookingInterface()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            // Setting Submenu to false to hide
            panelBookRoomSubmenu.Visible = false;

        }
        
        private void hideSubMenu()
        {
            // This closes the submenu for room numbers
            if (panelBookRoomSubmenu.Visible == true)
                panelBookRoomSubmenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            // creating condition if subMenu is hidden we show it
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            // display the famous Tay Mark Logo
            showSubMenu(panelBookRoomSubmenu);
        }

        private void btnRoomupto1_Click(object sender, EventArgs e)
        {
            // this opens up the bookupto1 form into our bookingInterface as a child form
            openChildForm(new bookupto1());
           
        }

        private void btnRoomupto2_Click(object sender, EventArgs e)
        {
            // this opens up the bookupto1 form into our bookingInterface as a child form
            openChildForm(new bookupto2());
           
        }

        private void btnRoomupto4_Click(object sender, EventArgs e)
        {
            // this opens up the bookupto1 form into our bookingInterface as a child form
            openChildForm(new bookupto4());
          
        }

        private void btnRoomupto8_Click(object sender, EventArgs e)
        {
            // this opens up the bookupto1 form into our bookingInterface as a child form
            openChildForm(new bookupto8());
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // this is the exit label in the bottom left of the form
            Application.Exit();
        }

        private void btnTodaysMeetings_Click(object sender, EventArgs e)
        {
            // hidesubmenu closes the booking room sizes panels from opening. 
            hideSubMenu();
            // pathway to todaysMeetings form
            openChildForm(new todaysMeetings());
        }

        private void btnRoomInfo_Click(object sender, EventArgs e)
        {
            // hidesubmenu closes the booking room sizes panels from opening. 
            hideSubMenu();
            // pathway to roominformation form
            openChildForm(new roomInformation());
        }

        private void btnYoureMeetings_Click(object sender, EventArgs e)
        {
            // hidesubmenu closes the booking room sizes panels from opening. 
            hideSubMenu();
            // pathway to yourMeetings form
            openChildForm(new yourMeeting());
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            // hidesubmenu closes the booking room sizes panels from opening. 
            hideSubMenu();
            // pathway to the Help form
            //openChildForm(new help());
        }



        // I declare i private method as a value set to null
        private Form activeForm = null;
        // This opens a single form inside the container panel
        private void openChildForm(Form childForm)
        {
            // creating a condition, if active form is different from null we close the active form
            if (activeForm != null)
                activeForm.Close();
            //save the active form open in the form variable, we do this with a child form parameter  
            activeForm = childForm;
            childForm.TopLevel = false;// this says the child form os not at the top level so it acts as a control
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill; // this fills the entire conatiner panel
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront(); //shows logo at front
            childForm.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // TODO set up logo as a home button on the booking interface
        }
    }
}
