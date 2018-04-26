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
        EquipMaintSys1Entities1 db = new EquipMaintSys1Entities1();
        private Employee user = new Employee();

        protected void Page_Load(object sender, EventArgs e)
        {

        }// end Page_Load

        private int CreateALog(int userID, string category, string description)
        {
            int saveSuccess = 0;
            try
            {
                Syslog log = new Syslog();
                /*log.UserID = UserID;*/
                log.Timestamp = DateTime.Now;
                log.Category = category;
                log.Description = description;
                db.Syslogs.Add(log);
                saveSuccess = db.SaveChanges();
                if (saveSuccess == 0)
                {
                    lblSuccess.Text = "Error creating logs.";
                }
            }
            catch (Exception ex)
            {
                lblSuccess.Text = "Error in database " + ex.InnerException;
            }
            return (saveSuccess);
        }// end CreateLog


        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            int saveSuccess = 0;
            bool authenticated = false;
            var userName = TbxUsername.Text.Trim();
            var passwd = TbxPassword.Text.Trim();

                foreach (var userRecord in db.Employees.Where(t => t.Username == userName && t.Phrase == passwd))
                {
                user = userRecord;
                authenticated = true;
                }// end foreach

                saveSuccess = CreateALog(user.UserID, "Login", "User " + user.Username.ToString() + " authenticated successfully.");

                    if (authenticated && saveSuccess == 1)
                    {
                    HttpContext.Current.Session["currentUser"] = user;
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