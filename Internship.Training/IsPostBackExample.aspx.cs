using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Internship.Training
{
    public partial class IsPostBackExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                bindddl();
            }
            
        }

        protected void bindddl()
        {
            ListItem li1 = new ListItem("Kolhapur");
            ddlCity.Items.Add(li1);

            ListItem li2 = new ListItem("Pune");
            ddlCity.Items.Add(li2);

            ListItem li3 = new ListItem("Mumbai");
            ddlCity.Items.Add(li3);

            ListItem li4 = new ListItem("Delhi");
            ddlCity.Items.Add(li4);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}