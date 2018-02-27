using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using DAL;
using BLL;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication6
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                try
                {
                    UserInfo us = new UserInfo();
                    us.UserName = UserName.Text.Trim();
                    us.Password = Password.Text.Trim();
                    us.Email = Email.Text.Trim();
                    us.Phone = Phone.Text.Trim();

                    int i = UserInfoService.Insert(us);
                    if (i >= 1)
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('注册成功！');location='Login.aspx'</script>");
                    }

                }
                catch (Exception ex)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('注册失败！失败原因如下：" + ex.Message + "');</script>");
                    Response.Write("错误原因：" + ex);
                }

            }
        }
    }
    }
