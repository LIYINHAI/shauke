using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using System.Data.SqlClient;
using System.Configuration;
using Models;

namespace Web
{
    public partial class NewsDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["NewsID"] = Convert.ToInt32(Request.QueryString["id"]);
                BindNews();

            }
            BindNewsID();
            BindElseNews();
        }
        private void BindNewsID()
        {
            //传入数据
            int nid = Convert.ToInt32(Request.QueryString["id"]);
            //实现功能
            DataTable dt = BLL.NewsInfoService.SelectID(nid);
            if (dt != null && dt.Rows.Count > 0)
            {
                NewsContentRepeater.DataSource = dt;
                NewsContentRepeater.DataBind();
            }
        }
        private void BindNews()
        {

            DataTable dt = BLL.NewsInfoService.SelectTop(1);
            if (dt != null && dt.Rows.Count > 0)
            {
                NewsContentRepeater.DataSource = dt;
                NewsContentRepeater.DataBind();
            }
        }
        private void BindElseNews()
        {
            DataTable dt = BLL.NewsInfoService.SelectTop(5);
            if (dt != null && dt.Rows.Count != 0)
            {
                ElseNewsListView.DataSource = dt;
                ElseNewsListView.DataBind();
            }
        }
    }
}