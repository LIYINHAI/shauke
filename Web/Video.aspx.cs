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
    public partial class Video : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindImages();
        }
        private void BindImages()
        {
            DataTable dt = VideoService.SelectAll();
            if (dt != null && dt.Rows.Count > 0)
            {
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
        }

        protected void quanbu_Click(object sender, EventArgs e)
        {
            BindImages();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int Flag = 1;
            DataTable dt = BLL.VideoService.SelectFlags(Flag);
            if (dt != null && dt.Rows.Count != 0)
            {
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int Flag = 2;
            DataTable dt = BLL.VideoService.SelectFlags(Flag);
            if (dt != null && dt.Rows.Count != 0)
            {
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int Flag = 3;
            DataTable dt = BLL.VideoService.SelectFlags(Flag);
            if (dt != null && dt.Rows.Count != 0)
            {
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            ListView1.DataBind(); //绑定ListView  
            int d = DDPager.TotalRowCount; //DataPager总行数  
            totalRows.InnerText = d.ToString(); //总行数(总条数)  

            int Var_DataPager = Convert.ToInt32(Math.Ceiling(System.Convert.ToDouble(DDPager.TotalRowCount) /

            DDPager.MaximumRows));//总页数  
            if (Var_DataPager > 1) //如果总页数大于1  
            {
                int pageIndex = DDPager.StartRowIndex / DDPager.PageSize + 1;//当前页码  
                totalPage.InnerText = pageIndex + "/" + Var_DataPager;//  当前页/总页数  
            }
            else
            {
                totalPage.InnerText = Var_DataPager.ToString(); //显示第一页  
            }
        }
    }
}