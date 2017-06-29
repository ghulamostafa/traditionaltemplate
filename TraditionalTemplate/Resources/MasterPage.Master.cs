using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MGas.Resources
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedIn"] == null || Session["LoggedIn"].ToString() != "true")
            {
                Response.Redirect(ResolveUrl("~/Admin/UserLogin.aspx"));
            }
        }
    }
}