using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebsite2.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        EquipMaintSys1Entities db = new EquipMaintSys1Entities();
        private Employee user = new Employee();
        //public Employee currentUser = new Employee();

        protected void Page_Load(object sender, EventArgs e)
        {

        }// end Page_Load

        //private void CreateALog(int userID, string category, string description)
        //            try
        //            {
        //                {
        //            Logs Logs = new Logs();
        //            Logs.userID = userID;
        //            Logs.category = category;
        //            Logs.description = description;
        //            db.logs.Add(Logs);
        //            int success = db.SaveChanges();
        //            if(success == 0)
        //                    {
        //                    lblSuccess.Text = "Error Creating Logs.";
        //                    }// end IF

        //        }// end Try
        //            catch (Exception ex)
        //            { 
        //               lblSuccess.Text = "Error in database" + ex.
        //            }// end Catch

        //          }// end CreateLog


        protected void BtnLogin_Click(object sender, EventArgs e)
        {
        bool authenticated = false;
        var userName = TbxUsername.Text.Trim();
        var passwd = TbxPassword.Text.Trim();
        
            foreach (var userRecord in db.Employees.Where(t => t.Username == userName && t.Phrase == passwd))
                {
                user = userRecord;
                authenticated = true;
                //CreateALog(user.UserID, "Login", "User " + " authenticated successfully.");
                break;
                ((MasterPage)this.Master).currentUser = this.user;
            }// end foreach

            if (authenticated)
                {
                //((MasterPage)this.Master).currentUser = this.user;
                Response.Redirect("~/Pages/Home.aspx");
                }// end if
            else
                {
                lblSuccess.Text = "Problem logging in, try again.";
                //ErrorMessage.Visible = true;
                }// end else



        }// end BtnLogin_Click








    }// end class
}// namespace