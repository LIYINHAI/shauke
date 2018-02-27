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
    public partial class VideoDetail : System.Web.UI.Page
    {
        static bool visibleflag;
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;   
            if (!IsPostBack)
            {
                ViewState["VideoID"] = Convert.ToInt32(Request.QueryString["id"]);
                Listview1();
                //visibleflag = true;
                BindMessage();
                visibleflag = true;
            }
        }
        private void Listview1()
        {
            int id = Convert.ToInt32(ViewState["VideoID"]);
            DataTable dt = VideoService.SelectVideoID(id);
            if (dt != null && dt.Rows.Count > 0)
            {
                ListView1.DataSource = dt;
                ListView1.DataBind();             
            }
        }
        //绑定留言信息
        private void BindMessage()
        {
            //int id = Convert.ToInt32(ViewState["VideoID"]);
            int id = int.Parse(Request.QueryString["id"]);
            DataTable dt = LeavewordsService.SelectLeavewords(id);
            if (dt != null && dt.Rows.Count > 0)
            {
                MessageListView.DataSource = dt;
                MessageListView.DataBind();
            }
        }
        //找到回复按钮
        protected void lkbtnReply_Click(object sender, EventArgs e)
        {
            LinkButton bt = (LinkButton)sender;
            Panel panelreply = bt.Parent.FindControl("ReplyPanel") as Panel;
            panelreply.Visible = true;
            visibleflag = !visibleflag;
        }

        //回复留言
        protected void btnRply_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ViewState["VideoID"]);
            if (Session["UserName"] != null)
            {
                if (Page.IsValid)
                {
                    LinkButton btn = (LinkButton)sender;
                    int userid = Convert.ToInt32(Session["UserID"]);
                    ReplyLeavewords Replywords = new ReplyLeavewords();
                    Replywords.LeaveID = Int32.Parse((btn.Parent.FindControl("HiddenFieldComID") as HiddenField).Value);
                    Replywords.UserID = userid;
                    Replywords.ReplyLeaContent = ((TextBox)btn.Parent.FindControl("txtReplyContent")).Text;
                    Replywords.ReplyLeaTime = DateTime.Now;
                    int result = ReplyLeavewordsService.InsertReplyLeavewords(Replywords);
                    if (result >= 1)
                    {
                        ScriptManager.RegisterClientScriptBlock(ReplyUpdatePanel, this.GetType(), "click", "alert('回复成功')", true);
                        visibleflag = true;
                        BindMessage();

                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(ReplyUpdatePanel, this.GetType(), "click", "alert('回复失败')", true);
                    }
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(ReplyUpdatePanel, this.GetType(), "click", "alert('您必须先登录才能发表评论');", true);
                ScriptManager.RegisterStartupScript(ReplyUpdatePanel, MessageUpdatePanel.GetType(), "updateScript", "window.location.href='Login.aspx'", true);
            }
        }
        //绑定回复留言
        protected void lvComments_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                HiddenField hiddenComID = e.Item.FindControl("HiddenFieldComID") as HiddenField;
                int LeaveID = int.Parse(hiddenComID.Value);
                Repeater rpt = e.Item.FindControl("ReplyRepeater") as Repeater;
                DataTable dt = ReplyLeavewordsService.SelectReplyLeavewords(LeaveID);
                if (dt != null && dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;
                    rpt.DataBind();
                }
            }
        }
        protected void DataPager1_PreRender(object sender, EventArgs e)
        {
            if (visibleflag == true)
            {
                BindMessage();
            }
        }

        protected void btnMessage_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ViewState["VideoID"]);
            if (Session["UserName"] != null)
            {
                if (Page.IsValid)
                {
                    int userid = Convert.ToInt32(Session["UserID"]);
                    int videoid = Convert.ToInt32(Request.QueryString["VideoID"]);
                    Leavewords leavewords = new Leavewords();
                    leavewords.UserID = userid;
                    leavewords.VideoID = videoid;
                    leavewords.LeaveContent = txtMessage.Text.Trim();
                    leavewords.LeaveTime = DateTime.Now;
                    int result = LeavewordsService.InsertLeavewords(leavewords);
                    if (result >= 1)
                    {
                        ScriptManager.RegisterClientScriptBlock(MessageUpdatePanel, this.GetType(), "click", "alert('留言成功')", true);
                        BindMessage();
                        txtMessage.Text = "";
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(MessageUpdatePanel, this.GetType(), "click", "alert('留言失败')", true);
                    }
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(MessageUpdatePanel, this.GetType(), "click", "alert('您必须先登录才能发表评论');", true);
                ScriptManager.RegisterStartupScript(MessageUpdatePanel, MessageUpdatePanel.GetType(), "updateScript", "window.location.href='Login.aspx'", true);
            }
        }
    }
}