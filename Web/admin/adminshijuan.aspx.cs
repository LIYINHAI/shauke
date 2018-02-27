using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using DAL;

namespace Web.admin
{
    public partial class adminshijuan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Get_Info();
            }
        }
        protected void GvInfo_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {


            string ID = GvInfo.DataKeys[e.RowIndex].Values[0].ToString();
            try
            {
                DBHelper.GetExcuteNonQuery("delete  from KaoJuan  where  KaoJuanID='" + ID + "'");
                DBHelper.GetExcuteNonQuery("delete  from ZuJuan  where  KaoJuanID='" + ID + "'");
                Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('删除成功！');</script>");
                GvInfo.EditIndex = -1;
                Get_Info();
            }
            catch
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('删除失败！');</script>");
            }

        }
       
        private void Get_Info()
        {
            string sql = "select  * from [KaoJuan]  where KaoJuanName like '%" + TextBox1.Text + "%' ";
            DataTable dt = DBHelper.GetFillData(sql);
            if (dt != null && dt.Rows.Count != 0)
            {
                GvInfo.DataSource = dt;
                GvInfo.DataBind();
            }
        }
        protected void GvInfo_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //鼠标移动变色
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //当鼠标放上去的时候 先保存当前行的背景颜色 并给附一颜色 
                e.Row.Attributes.Add("onmouseover", "currentcolor=this.style.backgroundColor;this.style.backgroundColor='#f6f6f6',this.style.fontWeight='';");
                //当鼠标离开的时候 将背景颜色还原的以前的颜色 
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=currentcolor,this.style.fontWeight='';");
            }
            //单击行改变行背景颜色 
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onclick", "this.style.backgroundColor='#f6f6f6'; this.style.color='buttontext';this.style.cursor='default';");
            }

        }
        protected void GvInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GvInfo.PageIndex = e.NewPageIndex;
            Get_Info();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Get_Info();

        }
    }
}