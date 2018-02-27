using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class web : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserName"] != null)
                {
                    PanelUserInfo.Visible = true;
                    PanelLogin.Visible = false;
                    lblUserInfo.Text = Session["UserName"].ToString();
                }
                else
                {
                    PanelLogin.Visible = true;
                    PanelUserInfo.Visible = false;

                }
            }
        }
        protected void lbtnLoginOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Index.aspx");
        }
    }
}