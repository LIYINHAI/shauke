using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data.SqlClient;
using System.Configuration;
using Models;
using System.Data;

namespace Web
{
    public partial class InterestDetail : System.Web.UI.Page
    {
        static bool visibleflag;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                ViewState["ISID"] = Convert.ToInt32(Request.QueryString["id"]);
                Listview1();  
                visibleflag = true;
            }
            ListTheme();
        }
        private void Listview1()
        {
            int id = Convert.ToInt32(ViewState["ISID"]);
            DataTable dt = InterestService.SelectISID(id);
            if (dt != null && dt.Rows.Count > 0)
            {
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
        }
        private void ListTheme()
        {
            int id = Convert.ToInt32(ViewState["ISID"]);
            DataTable dt = ThemeService.SelectISID(id);
            if (dt != null && dt.Rows.Count > 0)
            {
                Panel3.Visible = true;
                Panel4.Visible = false;
                ListView2.DataSource = dt;
                ListView2.DataBind();
            }
            else
            {
                Panel3.Visible = false;
                Panel4.Visible = true;
            }
        }
        //图片上传
        protected void btnUpload_Click(object sender, EventArgs e)

        {
            int id = Convert.ToInt32(ViewState["ISID"]);
            if (FileUpload.HasFile)//判断上传框是否有文件
            {
                bool FileOK = false;//初始化文件格式是否正确
                string FileExtension = System.IO.Path.GetExtension(FileUpload.FileName.ToLower());
                string[] allowedExtension = { ".jpg", ".jpeg", ".gif", ".png", ".bmp" };//设置允许上传的文件类型
                for (int i = 0; i < allowedExtension.Length; i++)
                {
                    if (FileExtension == allowedExtension[i])
                    {
                        FileOK = true;
                    }
                }
                if (FileOK)//文件类型正确
                {
                    try
                    {
                        string SavePath = Server.MapPath("~/images/Resumes/");//指定上传文件在服务器上的保存路径
                        if (!System.IO.Directory.Exists(SavePath))//检查服务器上是否存在这个物理路径，如果不存在则创建
                        {
                            System.IO.Directory.CreateDirectory(SavePath);
                        }
                        SavePath = SavePath + "\\" + FileUpload.FileName;
                        FileUpload.SaveAs(SavePath);
                        Session["DocAddr"] = "UploadFiles\\Documents\\" + Session["UserName"] + "\\" + FileUpload.FileName;
                        Response.Write("<script>alert('上传成功');</script>");
                        Label1.Text = "已上传文件：" + FileUpload.FileName;
                        Label2.Text = "images\\Resumes\\" + FileUpload.FileName;
                        this.btnUpload.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script>alert('上传失败');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('上传的文件格式不正确，请重新选择！');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('请选择需要上传的文件！');</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int uid = Convert.ToInt32(Session["UserID"]);
            int id = Convert.ToInt32(ViewState["ISID"]);
            try
            {
                if (Label2.Text.Trim() == "")
                {
                    Response.Write("<script>alert('照片不能为空!')</script>");
                }
                else
                {
                    Models.Theme theme = new Models.Theme();
                    theme.ISID =id;
                    theme.UserID = uid;
                    //news.AssID = 1;
                    theme.ThemeName = TextBox1.Text.Trim();
                    theme.ThemeTime = DateTime.Now;
                    theme.ThemeContent = TextBox3.Text.Trim();
                    theme.ThemeImage = Label2.Text;
                    int result = ThemeService.Insert(theme);
                    if (result >= 1)
                    {
                        Response.Write("<script>alert('发布成功!')</script>");
                    }

                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('上传失败');</script> 原因是：" + ex);
            }
        }
    }
}