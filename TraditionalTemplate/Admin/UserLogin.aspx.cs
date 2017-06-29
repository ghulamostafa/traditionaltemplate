using MGas.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MGas.Admin
{
    public partial class UserLogin : System.Web.UI.Page
    {
        myUtility ut = new myUtility();
        int result = 0;
        string message = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Login";
            if (!IsPostBack)
            {
                if (Request.QueryString.Count > 0 && Request.QueryString["Logout"].ToString() == "true")
                {
                    Session.Clear();
                }
                pnlAlert.Visible = false;
            }
            txtLoginEmail.Focus();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string mobileNumber = txtLoginEmail.Text;
            string password = txtLoginPassword.Text;
            pnlAlert.Visible = false;
            // Encryption should be done here if required.

            List<paramWithValues> paramList = new List<paramWithValues>();
            paramList.Add(new paramWithValues("@MobileNumber", mobileNumber));
            paramList.Add(new paramWithValues("@Password", password));
            paramList.Add(new paramWithValues("@UserTypeIdNo", "1"));

            //ut.runProcedureSelect("<SP_Login>", "", ref result, ref message, paramList.ToArray());

            if (result == 1)
            {
                Session.Add("MobileNumber", mobileNumber);
                Session.Add("UserTypeIdNo", "1");
                Session.Add("LoggedIn", "true");
                Response.Redirect(ResolveUrl("~/Admin/Default.aspx"));

            }
            else if (result == 0)
            {
                pnlAlert.Visible = true;
            }
        }

        protected void lbtn_Click(object sender, EventArgs e)
        {
            pnlAlert.Visible = false;
        }
    }
}