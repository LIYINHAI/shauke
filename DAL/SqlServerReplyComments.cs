using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;
using IDAL;
namespace DAL
{
    public class SqlServerReplyComments : IReplyComments
    {
        //按ReplyComID删除评论
        public int  DeleteAll(int ReplyComID)
        {
            SqlParameter[] sp = { new SqlParameter("@ReplyComID", ReplyComID) };
            return DBHelper.GetExcuteNonQuery("DeleteReplyComments", System.Data.CommandType.StoredProcedure, sp);
        }

        //存表的信息
        public int Insert(ReplyComments replycomments)
        {
            string sql = "insert into ReplyComments values(@ComID,@UserID,@ReplyComContent,@ReplyComTime)";
            SqlParameter[] sp = new SqlParameter[] {
                                               new SqlParameter("@ComID",replycomments.ComID),
                                               new SqlParameter("@UserID",replycomments.UserID),
                                               new SqlParameter("@ReplyComContent",replycomments.ReplyComContent),
                                               new SqlParameter("@ReplyComTime",replycomments.ReplyComTime)};
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        //显示表的信息
        public DataTable SelectAll()
        {
            string sql = "select  * from ReplyComments order by ReplyComTime desc";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectReplyComments(int ComID)
        {
            string sql = "select ReplyComments.*,a.UserName as 回复人,b.UserName as 被回复人 from UserInfo a,UserInfo b,ReplyComments,Comments where a.UserID=ReplyComments.UserID and b.UserID=Comments.UserID and ReplyComments.ComID=Comments.ComID and Comments.ComID=@ComID";
            SqlParameter[] para = { new SqlParameter("@ComID", ComID) };
            return DBHelper.GetFillData(sql, para);
        }
        public int DeleteReplyComments(int ReplyComID)
        {
            string sql = "delete from ReplyComments where ReplyComID=@ReplyComID";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ReplyComID",ReplyComID)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
    }
}
