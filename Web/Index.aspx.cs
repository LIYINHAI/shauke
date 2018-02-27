using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Models;
using BLL;


namespace Web
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindVideo();
                BindNews();
                BindIS();
            }
        }
        private void BindVideo()
        {
            DataTable dt = VideoService.SelectTop6();
            if (dt != null && dt.Rows.Count != 0)
            {
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
        }
        private void BindNews()
        {
            DataTable dt = NewsInfoService.SelectTop(4);
            if (dt != null && dt.Rows.Count != 0)
            {
                ListView2.DataSource = dt;
                ListView2.DataBind();
            }
        }
        private void BindIS()
        {
            DataTable dt = InterestService.SelectTop2();
            if (dt != null && dt.Rows.Count != 0)
            {
                ListView3.DataSource = dt;
                ListView3.DataBind();
            }
        }

    }
}