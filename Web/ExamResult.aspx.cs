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
    public partial class ExamResult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int userid = int.Parse(Session["UserID"].ToString());
                int kaoshiid = int.Parse(Session["KaoshiID"].ToString());
                SqlDataReader dr = ScoreService.SelectScore(userid,kaoshiid);
                dr.Read();
                lblKaoJuanName.Text = dr["KaoJuanName"].ToString();
                lblUserName.Text = dr["UserName"].ToString();
                lblsum.Text = dr["Sum"].ToString();
                lbltime.Text = DateTime.Now.ToString();
                addScore.Text = dr["Scores"].ToString();
            }
        }
    }
}