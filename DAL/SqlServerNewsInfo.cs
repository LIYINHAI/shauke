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
    public class SqlServerNewsInfo : INewsInfo
    {
        //存表的信息
        public int Insert(NewsInfo newsinfo)
        {
            string sql = "insert into NewsInfo (NewsTitle,NewsContent,NewsTime) values(@NewsTitle,@NewsContent,@NewsTime)";
            SqlParameter[] sp = new SqlParameter[] { 
                                                 new SqlParameter("@NewsTitle",newsinfo.NewsTitle),
                                                 new SqlParameter("@NewsContent",newsinfo.NewsContent),
                                                 new SqlParameter("@NewsTime",newsinfo.NewsTime)};
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        //展现表的信息
        public DataTable SelectAll()
        {
            string sql = "select  * from NewsInfo order by NewsTime desc";
            return DBHelper.GetFillData(sql);
        }
        //根据ID来展现
        public DataTable SelectID(int NewsID)
        {
            string sql = "select  * from NewsInfo where NewsID=@NewsID";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@NewsID",NewsID)
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }
        //展现前几按照时间
        public DataTable SelectTop(int top)
        {
            string sql = "select  top " + top + " * from NewsInfo order by NewsTime desc";

            return DBHelper.GetFillData(sql);
        }
        //删除
        public int DeleteAct(int NewsID)
        {
            string sql = "delete from NewsInfo where NewsID=@NewsID";
            SqlParameter[] sp = { new SqlParameter("@NewsID", NewsID) };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
    }
}
