using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MGas.Resources.UserControl
{
    public partial class mPopupDisplay : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This method takes input the data that to be displayed on the Modal Popup
        /// </summary>
        /// <param name="text"></param>
        public void SetDisplayText(string text)
        {
            lblPopupDisplayMain.Text = text;
        }

        protected void lbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}