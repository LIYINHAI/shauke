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

namespace Web.admin
{
    public partial class addshijuan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlDataReader dr;
                dr = DBHelper.GetDataReader("select * from Course");
                ddlCourse.DataSource = dr;
                ddlCourse.DataTextField = "CourseName";
                ddlCourse.DataValueField = "CourseID";
                ddlCourse.DataBind();               //绑定数据

            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            KaoJuan kj = new KaoJuan();
            kj.KaoJuanName = TextBox4.Text.Trim();
            kj.PageFen = int.Parse(TextBox5.Text.Trim());
            kj.CourseName = ddlCourse.SelectedItem.Text.Trim();
            kj.CourseID = int.Parse(ddlCourse.SelectedValue);
            KaoJuanService.Insert(kj);
            SqlDataReader dr;
            //单选题
            dr = DBHelper.GetDataReader("select top " + TextBox1.Text + "  * from ObQuestion  where   CourseID='" + ddlCourse.SelectedValue + "'   order by newid()");
            GridView1.DataSource = dr;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlDataReader sdr = KaoJuanService.SelectKaoJuanTop1();
            if (sdr.Read())
            {
                int id = int.Parse(sdr["KaoJuanID"].ToString());
                //单选题
                foreach (GridViewRow dr in GridView1.Rows)
                {
                    ZuJuan zj = new ZuJuan();
                    zj.KaoJuanID = id;
                    zj.TitleID = int.Parse(((Label)dr.FindControl("Label3")).Text);
                    zj.Mark = int.Parse(((Label)dr.FindControl("Label4")).Text);
                    ZuJuanService.Insert(zj);
                }

                Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('生成成功！');</script>");
            }
        }
    }
}