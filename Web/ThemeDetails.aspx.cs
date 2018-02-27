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
    public partial class ThemeDetails : System.Web.UI.Page
    {
        static bool visibleflag;
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;          
            if (!IsPostBack)
            {
                ViewState["ThemeID"] = Convert.ToInt32(Request.QueryString["id"]);
                Listview1();
                BindComments();
                visibleflag = true;
            }

        }
        private void Listview1()
        {
            int id = Convert.ToInt32(ViewState["ThemeID"]);
            DataTable dt = ThemeService.SelectThemeID(id);
            if (dt != null && dt.Rows.Count > 0)
            {
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
        }
        public void BindComments()
        {
            int ThemeID = int.Parse(Request.QueryString["id"]);
            DataTable dt = CommentsService.SelectComments(ThemeID);
            if (dt != null && dt.Rows.Count > 0)
            {
                lvComments.DataSource = dt;
                lvComments.DataBind();
            }
        }
        protected void btnComments_Click(object sender, EventArgs e)
        {
            if (Session["UserName"] != null)
            {
                if (Page.IsValid)
                {
                    Comments comments = new Comments();
                    comments.UserID = int.Parse(Session["UserID"].ToString());
                    comments.ThemeID = int.Parse(Request.QueryString["id"]);
                    comments.ComContent = txtComments.Text;
                    comments.ComTime = DateTime.Now;
                    int result = CommentsService.Insert(comments);
                    if (result >= 1)
                    {
                        ScriptManager.RegisterClientScriptBlock(UpdatePanel2, this.GetType(), "click", "alert('评论成功！')", true);
                        BindComments();
                        txtComments.Text = "";
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(UpdatePanel2, this.GetType(), "click", "alert('评论失败！')", true);
                    }
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(UpdatePanel2, this.GetType(), "click", "alert('您必须先登录才能发表评论');", true);
                ScriptManager.RegisterStartupScript(UpdatePanel2, UpdatePanel2.GetType(), "updateScript", "window.location.href='Login.aspx'", true);
            }
        }
        protected void lbtnReply_Click(object sender, EventArgs e)
        {
            LinkButton bt = (LinkButton)sender;
            Panel panelreply = bt.Parent.FindControl("PanelReply") as Panel;
            panelreply.Visible = true;
            visibleflag = !visibleflag;
        }
        protected void lvComments_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                HiddenField hiddenComID = e.Item.FindControl("HiddenFieldComID") as HiddenField;
                int ComID = int.Parse(hiddenComID.Value);
                Repeater rpt = e.Item.FindControl("RepeaterReplyComments") as Repeater;
                DataTable dt = ReplyCommentsService.SelectReplyComments(ComID);
                if (dt != null && dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;
                    rpt.DataBind();
                }
            }
        }

        protected void btnRply_Click(object sender, EventArgs e)
        {
            if (Session["UserName"] != null)
            {
                if (Page.IsValid)
                {
                    Button btn = (Button)sender;
                    string a = ((TextBox)btn.Parent.FindControl("txtReplyContent")).Text.Trim();
                    ReplyComments replycomments = new ReplyComments();
                    replycomments.ComID = Int32.Parse((btn.Parent.FindControl("HiddenFieldComID") as HiddenField).Value);
                    replycomments.UserID = int.Parse(Session["UserID"].ToString());
                    replycomments.ReplyComContent = ((TextBox)btn.Parent.FindControl("txtReplyContent")).Text.Trim();
                    replycomments.ReplyComTime = DateTime.Now;
                    int result = ReplyCommentsService.Insert(replycomments);
                    if (result >= 1)
                    {
                        ScriptManager.RegisterClientScriptBlock(UpdatePanel1, this.GetType(), "click", "alert('回复成功！')", true);
                        visibleflag = true;
                        BindComments();
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(UpdatePanel1, this.GetType(), "click", "alert('回复失败！')", true);
                    }
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(UpdatePanel1, this.GetType(), "click", "alert('您必须先登录才能回复');", true);
                ScriptManager.RegisterStartupScript(UpdatePanel1, UpdatePanel1.GetType(), "updateScript", "window.location.href='Login.aspx'", true);

            }
        }


        //protected void btnMessage_Click(object sender, EventArgs e)
        //{
        //    if (Session["UserName"] != null)
        //    {
        //        if (Page.IsValid)
        //        {
        //            int userid = Convert.ToInt32(Session["UserID"]);
        //            int themeid = Convert.ToInt32(Request.QueryString["id"]);
        //            Comments Comments = new Comments();
        //            Comments.UserID = userid;
        //            Comments.ThemeID =themeid;
        //            Comments.ComContent = txtMessage.Text.Trim();
        //            Comments.ComTime = DateTime.Now;
        //            int result = CommentsService.Insert(Comments);
        //            if (result >= 1)
        //            {
        //                ScriptManager.RegisterClientScriptBlock(MessageUpdatePanel, this.GetType(), "click", "alert('留言成功')", true);
        //                BindMessage();
        //                txtMessage.Text = "";
        //            }
        //            else
        //            {
        //                ScriptManager.RegisterClientScriptBlock(MessageUpdatePanel, this.GetType(), "click", "alert('留言失败')", true);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        ScriptManager.RegisterClientScriptBlock(MessageUpdatePanel, this.GetType(), "click", "alert('您必须先登录才能发表评论');", true);
        //        ScriptManager.RegisterStartupScript(MessageUpdatePanel, MessageUpdatePanel.GetType(), "updateScript", "window.location.href='Login.aspx'", true);
        //    }

        //}
        //private void BindMessage()
        //{
        //    int id = Convert.ToInt32(ViewState["ThemeID"]);
        //    DataTable dt = CommentsService.SelectComments(id);
        //    if (dt != null && dt.Rows.Count > 0)
        //    {
        //        ListView1.DataSource = dt;
        //        ListView1.DataBind();
        //    }
        //}
        
    }
}