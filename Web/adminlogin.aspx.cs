using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using BLL;
namespace Web
{
    public partial class adminlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            string Name = UserName.Text.Trim();
            string paw = Password.Text.Trim();
            try
            {
                SqlDataReader UserDr = AdminInfoService.Login(Name,paw);
                if (UserDr.Read())
                {
                    //Session["AdminName"] = UserName.Text;
                    //Session["AdminID"] = UserDr["AdminID"].ToString();
                    Label1.Text = "登陆成功";
                    Response.Redirect("admin/adminer.aspx");
                }
                else
                {
                    Label1.Text = "用户名或密码错误";
                    Password.Text = "";
                    Password.Focus();
                }

            }
            catch (Exception ex)
            {
                Response.Write("错误原因：" + ex);
            }
        }
    }
}