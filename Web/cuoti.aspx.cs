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
    public partial class cuoti : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int userid = int.Parse(Session["UserID"].ToString());
                SqlDataReader dr = MistakesService.SelectMistakes(userid);
                ListView1.DataSource = dr;
                ListView1.DataBind();
            }
        }
    }
}