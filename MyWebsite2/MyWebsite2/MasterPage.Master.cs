using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebsite2
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        EquipMaintSys1Entities db = new EquipMaintSys1Entities();
        Employee user = new Employee();

        public Employee currentUser = new Employee();

        protected void Page_Load(object sender, EventArgs e)
        {            

        }
    }
}