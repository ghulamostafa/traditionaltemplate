using MGas.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MGas.Resources.UserControl
{
    public partial class mSearchPanel : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        myUtility ut = new myUtility();
        int result = 0;
        string message = "";

        DataSet ds = new DataSet();

        #region Properties

        private string _CustomGrid = "";

        public string CustomGrid
        {
            get { return _CustomGrid; }
            set { _CustomGrid = value; }
        }

        private string _Description;
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        private string _IdNo;
        public string IdNo
        {
            get { return _IdNo; }
            set { _IdNo = value; }
        }

        private string _Title;
        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        public string HeadingText
        {
            get { return lblHeading.Text; }
            set { lblHeading.Text = value; }
        }

        private string _SearchVal;
        public string SearchVal
        {
            get { return _SearchVal; }
            set { _SearchVal = value; }
        }

        private string _StoredProcedure;
        public string StoredProcedure
        {
            get { return _StoredProcedure; }
            set { _StoredProcedure = value; }
        }

        #endregion

        #region Events
        public event ItemSelectedEventHandler ItemSelected;
        public delegate void ItemSelectedEventHandler(object sender, EventArgs e);
        #endregion

        #region Methods

        protected void lbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        protected void gvSearchPanel_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ItemSelect")
            {
                dynamic rowIndex = (int.Parse(e.CommandArgument.ToString()) - 1) % gvSearchPanel.PageSize;

                IdNo = ((Label)gvSearchPanel.Rows[rowIndex].FindControl("lblgvIdNo")).Text;
                Description = ((Label)gvSearchPanel.Rows[rowIndex].FindControl("lblgvTitleAR")).Text;
                Title = ((Label)gvSearchPanel.Rows[rowIndex].FindControl("lblgvTitle")).Text;

                if (ItemSelected != null)
                {
                    ItemSelected(this, e);
                }
                gvSearchPanel.DataSource = null;
                gvSearchPanel.DataBind();

                this.Visible = false;
            }
        }

        protected void imgbtnSearch_Click(object sender, ImageClickEventArgs e)
        {
            SearchVal = txtSearch.Text;
            if (SearchVal == null)
            {
                SearchVal = "";
            }

            List<paramWithValues> paramList = new List<paramWithValues>();
            paramList.Add(new paramWithValues("@SearchVal", SearchVal));

            //ut.ProcedureSelect(StoredProcedure, ds, paramList.ToArray());
            ut.runProcedureSelect(StoredProcedure, "", ref result, ref message, ref ds, paramList.ToArray());

            gvSearchPanel.DataSource = ds.Tables[0];
            gvSearchPanel.DataBind();

            gvSearchPanel.Visible = true;
        }
        
        #endregion
    }
}