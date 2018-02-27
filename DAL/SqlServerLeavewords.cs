using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Models;

namespace DAL
{
    public class SqlServerLeavewords : ILeavewords
    {
        public int InsertLeavewords(Leavewords words)
        {
            string sql = "insert into Leavewords(UserID,VideoID,LeaveContent,LeaveTime) values(@UserID,@VideoID,@LeaveContent,@LeaveTime)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@UserID",words.UserID),
                new SqlParameter("@VideoID",words.VideoID),
                new SqlParameter("@LeaveContent",words.LeaveContent),
                new SqlParameter("@LeaveTime",words.LeaveTime)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
        public DataTable SelectLeavewords(int VideoID)
        {
            string sql = "select a.*,b.UserName from Leavewords a,UserInfo b where VideoID='" + VideoID + "' and a.UserID=b.UserID order by LeaveTime desc";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("VideoID",VideoID)
            };
            return DBHelper.GetFillData(sql, sp);
        }
        public DataTable SelectAllLeavewords()
        {
            string sql = "select a.*,b.UserName,c.VideoName from Leavewords a,UserInfo b,Video c where a.UserID=b.UserID and a.VideoID=c.VideoID";
            return DBHelper.GetFillData(sql);
        }
        public int DeleteLeavewords(int LeaveID)
        {
            string sql = "delete from ReplyLeavewords where LeaveID=@LeaveID delete from Leavewords where LeaveID=@LeaveID";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@LeaveID",LeaveID)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
    }
}
