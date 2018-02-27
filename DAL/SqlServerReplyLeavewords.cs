using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Models;
using IDAL;

namespace DAL
{
    public class SqlServerReplyLeavewords
    {
        public int InsertReplyLeavewords(ReplyLeavewords Replywords)
        {
            string sql = "insert into ReplyLeavewords(LeaveID,UserID,ReplyLeaContent,ReplyLeaTime) values(@LeaveID,@UserID,@ReplyContent,@ReplyTime)";
            SqlParameter[] sp = new SqlParameter[]
                {
                    new SqlParameter("@LeaveID",Replywords.LeaveID),
                    new SqlParameter("@UserID",Replywords.UserID),
                    new SqlParameter("@ReplyContent",Replywords.ReplyLeaContent),
                    new SqlParameter("@ReplyTime",Replywords.ReplyLeaTime)
                };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
        public DataTable SelectReplyLeavewords(int LeaveID)
        {
            string sql = "select ReplyLeavewords.*,a.UserName as 回复人,b.UserName as 被回复人 from UserInfo a,UserInfo b,ReplyLeavewords,Leavewords where a.UserID=ReplyLeavewords.UserID and b.UserID=Leavewords.UserID and ReplyLeavewords.LeaveID=Leavewords.LeaveID and Leavewords.LeaveID=@LeaveID";
            SqlParameter[] para = { new SqlParameter("@LeaveID", LeaveID) };
            return DBHelper.GetFillData(sql, para);
        }
        public DataTable SelectAllReplyLeavewords()
        {
            string sql = "select ReplyLeavewords.*,a.UserName as 回复者,b.UserName as 被回复者 from UserInfo a,UserInfo b,ReplyLeavewords,Leavewords where a.UserID=ReplyLeavewords.UserID and b.UserID=Leavewords.UserID and ReplyLeavewords.LeaveID=Leavewords.LeaveID ";
            return DBHelper.GetFillData(sql);
        }
        public int DeleteReplyLeavewords(int ReplyLeaID)
        {
            string sql = "delete from ReplyLeavewords where ReplyLeaID=@ReplyLeaID";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ReplyLeaID",ReplyLeaID)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
    }
}
