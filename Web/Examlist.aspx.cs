using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DAL;
using BLL;
using System.Data.SqlClient;
using System.Configuration;
using Models;

namespace Web
{
    public partial class Examlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int userid = int.Parse(Session["UserID"].ToString());
                int id = int.Parse(Request.QueryString["id"].ToString());
                SqlDataReader dr = UserPageService.SelectUserPage(userid, id);
                ListView1.DataSource = dr;
                ListView1.DataBind();
            }
        }
        protected void btnshou_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            int nid = Convert.ToInt32(((HiddenField)(bt.Parent.FindControl("HiddenField1"))).Value);
            Collect cl = new Collect();
            cl.UserID = int.Parse(Session["UserID"].ToString());
            cl.ObID = nid;
            cl.CtTime = DateTime.Now;
            if (CollectService.Insert(cl) >= 1)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('收藏成功!')</script>");
            }
        }
    }
}