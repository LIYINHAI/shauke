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
    public partial class ShowPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //获取试卷ID 
                int id = int.Parse(Request.QueryString["id"].ToString());
                int UserID = int.Parse(Session["UserID"].ToString());
                SqlDataReader dr = KaoShiService.SelectKaoShi(id, UserID);
                if (dr.Read())
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('你已经参加过这个考试了不能重复参加考试！');location='practice.aspx'</script>");

                }
                else
                {
                    GetPager();
                    //获取试卷
                }
            }
        }
        private void GetPager()
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            //客观题
            SqlDataReader dr = KaoJuanService.SelectKaoJuan(id);
            dr.Read();
            lblKaoJuanName.Text = dr["KaoJuanName"].ToString();
            Label15.Text = dr["PageFen"].ToString();
            SqlDataReader dr2 = ZuJuanService.SelectZuJuan(id);
            GridView1.DataSource = dr2;
            GridView1.DataBind();
        }

        protected void Button1_ServerClick1(object sender, EventArgs e)
        {
            //获取考卷ID
            int KaoJuanId = int.Parse(Request.QueryString["id"].ToString());
            int sum = 0;  //初始化对的信息 默认为0个
            int Score = 0; //初始化分数的信息 默认为0分
            int singlemark = int.Parse(((Label)GridView1.Rows[0].FindControl("Label4")).Text);//每一道单选题的分数
            foreach (GridViewRow dr in GridView1.Rows)

            //遍历每一行的数据
            {
                string str = "";
                if (((RadioButton)dr.FindControl("RadioButton1")).Checked)
                {
                    str = "A";
                }
                else if (((RadioButton)dr.FindControl("RadioButton2")).Checked)
                {
                    str = "B";
                }
                else if (((RadioButton)dr.FindControl("RadioButton3")).Checked)
                {
                    str = "C";
                }
                else if (((RadioButton)dr.FindControl("RadioButton4")).Checked)
                {
                    str = "D";
                }
                //逐个 判断 某一个单选框是否选中 即  选择的答案 ABCD  哪一个
                if (((Label)dr.FindControl("Label3")).Text.Trim() == str)
                //用户选择的答案 和正确答案 对比
                {
                    sum = sum + 1;
                    Score = Score + singlemark;
                    //分数 增加
                    string title = ((Label)dr.FindControl("Label2")).Text.Trim();
                    int fid = int.Parse(((Label)dr.FindControl("Label111")).Text.Trim());
                    UserPage up = new UserPage();
                    up.Fid = fid;
                    up.Title = title;
                    up.UserID = int.Parse(Session["UserID"].ToString());
                    up.KaoJuanID = KaoJuanId;
                    up.UserAns = str;
                    UserPageService.Insert(up);
                    //将信息再插入到 用户试卷题目表里
                }
                else
                {

                    string title = ((Label)dr.FindControl("Label2")).Text.Trim();
                    int fid = int.Parse(((Label)dr.FindControl("Label111")).Text.Trim());
                    UserPage up = new UserPage();
                    up.Fid = fid;
                    up.Title = title;
                    up.UserID = int.Parse(Session["UserID"].ToString());
                    up.KaoJuanID = KaoJuanId;
                    up.UserAns = str;
                    UserPageService.Insert(up);
                    Mistakes Mt = new Mistakes();
                    Mt.UserID = int.Parse(Session["UserID"].ToString());
                    Mt.ObID = fid;
                    Mt.MisTime = DateTime.Now;
                    MistakesService.Insert(Mt);
                    //将信息再插入到 用户试卷题目表和错题表里
                }
                int id = int.Parse(Request.QueryString["id"].ToString());
                Session["KaoshiID"] = id;
                string UserName = Session["UserName"].ToString();
                //插入到 分数表 和 学生考试表              
                Score sc = new Score();
                sc.UserID = int.Parse(Session["UserID"].ToString());
                sc.KaoJuanID = id;
                sc.Scores = Score;
                sc.UserName = UserName;
                sc.Sum = sum;
                int j = ScoreService.Insert(sc);
                KaoShi ks = new KaoShi();
                ks.PageID = id;
                ks.UserID = int.Parse(Session["UserID"].ToString());
                int i = KaoShiService.Insert(ks);
                if (i >= 1 && j >=1)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('答题成功！查看成绩！！');location='ExamResult.aspx'</script>");
                }
            }
        }
    }
}