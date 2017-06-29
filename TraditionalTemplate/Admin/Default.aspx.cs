using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MGas.Admin
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void imgbtnReports_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Admin/Default.aspx");
        }

        protected void imgbtnFeedbacks_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Admin/Default.aspx");
        }

        protected void imgbtnUserManagement_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Admin/Default.aspx");
        }
    }
}