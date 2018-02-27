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
    public class SqlServerComments : IComments
    {
        //删除
        public int DeleteAll(int ComID)
        {
            SqlParameter[] sp = { new SqlParameter("@ComID", ComID) };
            return DBHelper.GetExcuteNonQuery("DeleteComments", System.Data.CommandType.StoredProcedure, sp);
        }
        //增加
        public int Insert(Comments comments)
        {
            string sql = "insert into Comments values(@UserID,@ThemeID,@ComContent,@ComTime)";
            SqlParameter[] sp = new SqlParameter[] {
                                                 new SqlParameter("@UserID",comments.UserID),
                                                 new SqlParameter("@ThemeID",comments.ThemeID),
                                                 new SqlParameter("ComContent",comments.ComContent),
                                                 new SqlParameter("@ComTime",comments.ComTime)};
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        //展现
        public DataTable SelectAll()
        {
            string sql = "select * from Comments order by ComTime desc";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectComments(int ThemeID)
        {
            string sql = "select a.*,b.UserName from Comments a,UserInfo b where ThemeID='" + ThemeID + "' and a.UserID=b.UserID order by ComTime desc";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("ISID",ThemeID)
            };
            return DBHelper.GetFillData(sql, sp);
        }
        //展现评论
        public DataTable SelectAllpinlun()
        {
            string sql = "select a.*,b.UserName,c.ThemeName from Comments a,UserInfo b,Theme c where a.UserID=b.UserID and a.ThemeID=c.ThemeID";
            return DBHelper.GetFillData(sql);
        }
        public int DeleteComments(int ComID)
        {
            string sql = "delete from ReplyComments where ComID=@ComID delete from Comments where ComID=@ComID";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ComID",ComID)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
    }
}
