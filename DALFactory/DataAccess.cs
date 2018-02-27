using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using System.Reflection;
using System.Configuration;

namespace DALFactory
{
    public  class DataAccess
    {
        private static string AssemblyName = ConfigurationManager.AppSettings["Path"].ToString();
        private static string db = ConfigurationManager.AppSettings["DB"].ToString();
        //管理员表
        public static IAdminInfo CreateAdminInfo()
        {
            string className = AssemblyName + "." + db + "AdminInfo";
            return (IAdminInfo)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        //收藏表
        public static ICollect CreateCollect()
        {
            string className = AssemblyName + "." + db + "Collect";
            return (ICollect)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        //评论表
        public static IComments CreateComments()
        {
            string className = AssemblyName + "." + db + "Comments";
            return (IComments)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        //科目表
        public static ICourse CreateCourse()
        {
            string className = AssemblyName + "." + db + "Course";
            return (ICourse)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        //兴趣小组表
        public static IInterest CreateInterest()
        {
            string className = AssemblyName + "." + db + "Interest";
            return (IInterest)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        //错题表
        public static IMistakes CreateMistakes()
        {
            string className = AssemblyName + "." + db + "Mistakes";
            return (IMistakes)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        //新闻表
        public static INewsInfo CreateNewsInfo()
        {
            string className = AssemblyName + "." + db + "NewsInfo";
            return (INewsInfo)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        //客观题表
        public static IObQuestion CreateObQuestion()
        {
            string className = AssemblyName + "." + db + "ObQuestion";
            return (IObQuestion)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        //回复评论表
        public static IReplyComments CreateReplyComments()
        {
            string className = AssemblyName + "." + db + "ReplyComments";
            return (IReplyComments)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        ////主观题表
        //public static ISubQuestion CreateSubQuestion()
        //{
        //    string className = AssemblyName + "." + db + "SubQuestion";
        //    return (ISubQuestion)Assembly.Load(AssemblyName).CreateInstance(className);
        //}
        ////试卷表
        //public static IText CreateText()
        //{
        //    string className = AssemblyName + "." + db + "Text";
        //    return (IText)Assembly.Load(AssemblyName).CreateInstance(className);
        //}
        //兴趣话题表
        public static ITheme CreateTheme()
        {
            string className = AssemblyName + "." + db + "Theme";
            return (ITheme)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        //用户表
        public static IUserInfo CreateUserInfo()
        {
            string className = AssemblyName + "." + db + "UserInfo";
            return (IUserInfo)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        //精品课程表
        public static IVideo CreateVideo()
        {
            string className = AssemblyName + "." + db + "Video";
            return (IVideo)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        //留言板
        public static ILeavewords CreateLeavewords()
        {
            string className = AssemblyName + "." + db + "Leavewords";
            return (ILeavewords)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        //回复留言板
        public static IReplyLeavewords CreateReplyLeavewords()
        {
            string className = AssemblyName + "." + db + "ReplyLeavewords";
            return (IReplyLeavewords)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        //考卷表
        public static IKaoJuan CreateKaoJuan()
        {
            string className = AssemblyName + "." + db + "KaoJuan";
            return (IKaoJuan)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        //考试表
        public static IKaoShi CreateKaoShi()
        {
            string className = AssemblyName + "." + db + "KaoShi";
            return (IKaoShi)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        //分数表
        public static IScore CreateScore()
        {
            string className = AssemblyName + "." + db + "Score";
            return (IScore)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        //用户试卷表
        public static IUserPage CreateUserPage()
        {
            string className = AssemblyName + "." + db + "UserPage";
            return (IUserPage)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        //组卷表
        public static IZuJuan CreateZuJuan()
        {
            string className = AssemblyName + "." + db + "ZuJuan";
            return (IZuJuan)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
