using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using System.Data.SqlClient;
using Models;
namespace Web.admin
{
    public partial class addcous : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ViewState["AssID"] = Convert.ToInt32(Request.QueryString["id2"]);
            CKFinder.FileBrowser fileBrowser = new CKFinder.FileBrowser();
            fileBrowser.BasePath = "ckfinder";  //CKFinder路径  
            fileBrowser.SetupCKEditor(CKEditorControl1);
            UnobtrusiveValidationMode =new UnobtrusiveValidationMode();
        }


        protected void btnUpload_Click(object sender, EventArgs e)
        {
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
                        string SavePath = Server.MapPath("~/Image/videoimg/");//指定上传文件在服务器上的保存路径
                        if (!System.IO.Directory.Exists(SavePath))//检查服务器上是否存在这个物理路径，如果不存在则创建
                        {
                            System.IO.Directory.CreateDirectory(SavePath);
                        }
                        SavePath = SavePath + "\\" + FileUpload.FileName;
                        FileUpload.SaveAs(SavePath);
                        Session["DocAddr"] = "UploadFiles\\Documents\\" + Session["UserName"] + "\\" + FileUpload.FileName;
                        Response.Write("<script>alert('上传成功');</script>");
                        Label2.Text = "~Image\\videoimg\\" + FileUpload.FileName;
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
            if (FileUpload1.HasFile)//判断上传框是否有文件
            {
                bool FileOK = false;//初始化文件格式是否正确
                string FileExtension = System.IO.Path.GetExtension(FileUpload1.FileName.ToLower());
                string[] allowedExtension = { ".mp4" };//设置允许上传的文件类型
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
                        string SavePath = Server.MapPath("~/video/");//指定上传文件在服务器上的保存路径
                        if (!System.IO.Directory.Exists(SavePath))//检查服务器上是否存在这个物理路径，如果不存在则创建
                        {
                            System.IO.Directory.CreateDirectory(SavePath);
                        }
                        SavePath = SavePath + "\\" + FileUpload1.FileName;
                        FileUpload1.SaveAs(SavePath);
                        Session["DocAddr"] = "UploadFiles\\Documents\\" + Session["UserName"] + "\\" + FileUpload1.FileName;
                        Response.Write("<script>alert('上传成功');</script>");
                        Label1.Text = "~video\\" + FileUpload1.FileName;
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
        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                if (Label2.Text.Trim() == "")
                {
                    Response.Write("<script>alert('照片不能为空!')</script>");
                }
                else
                {
                    Models.Video  video = new Models.Video();
                    video.VideoID = Convert.ToInt32(Request.QueryString["VideoID"]);
                    //news.AssID = 1;
                    video.VideoName = txtTitle.Text.Trim();
                    video.VideoBrief = CKEditorControl1.Text.Trim();
                    video.Images = Label2.Text;
                    video.VideoUrl = Label1.Text;
                    video.CreatTime= DateTime.Now;
                    int result = VideoService.Insert(video);
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

        protected void btnBack_Click(object sender, EventArgs e)
        {

        }
    }

}