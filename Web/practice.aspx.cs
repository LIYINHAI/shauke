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
using DAL;

namespace Web
{
    public partial class practice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindKaoJuan();
               
            }
        }
        private void BindKaoJuan()
        {
            DataTable dt = KaoJuanService.SelectAll();
            if (dt != null && dt.Rows.Count != 0)
            {
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
        }
       
       
       
    }
}