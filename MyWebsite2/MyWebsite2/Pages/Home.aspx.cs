using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebsite2.Pages
{
    public partial class Home : System.Web.UI.Page
    {
        Employee user = new Employee();


        protected void Page_Load(object sender, EventArgs e)
        {
            // Retrieve user details from a session saved in the login file
            Employee user = (Employee)Session["currentUser"];

            // Build the login message
            string foreName = user.First_Name;
            string surName = user.Surname;
            string userName = user.Username;
            string welcomeMessage = "Welcome " + foreName + " " + surName + ". Please select an option";
            lblDetails.Text = welcomeMessage;
        }// end Page_Load



        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Pages/Login.aspx");
        }// end btnLogout_Click




    }// end class Home
}// end namespace
