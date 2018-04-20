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
        Employee user = new Employee();

        protected void Page_Load(object sender, EventArgs e)
        {

        }// end Page_Load

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            bool authenticated = false;
            var userName = TbxUsername.Text.Trim();
            var passwd = TbxPassword.Text.Trim();

            //foreach (var user in db.Employee.Where( t => t.Username == userName && t.Phrase == passwd))

            foreach (var userRecord in db.Employees.Where(t => t.Username == userName && t.Phrase == passwd))

            {
                user = userRecord;
                authenticated = true;
            }// end foreach

            if (authenticated)
            {
                ((MasterPage)this.Master).currentUser = this.user;
                Response.Redirect("~/Pages/Home.aspx");
            }// end if
        }// end BtnLogin_Click








    }// end class
}// namespace