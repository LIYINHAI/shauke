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
    public class SqlServerVideo : IVideo
    {
        //存表的信息
        public int Insert(Video video)
        {
            string sql = "insert into Video values(@VideoID,@VideoName,@VideoBrief,@CreatTime)";
            SqlParameter[] sp = new SqlParameter[] {new SqlParameter("@VideoID",video.VideoID),
                                                 new SqlParameter("@VideoName",video.VideoName),
                                                 new SqlParameter("@VideoBrief",video.VideoBrief),
                                                 new SqlParameter("@CreatTime",video.CreatTime)};
            return DBHelper.GetExcuteNonQuery(sql,sp);
        }

        //展现表的信息
        public DataTable SelectAll()
        {
            string sql = "select * from Video order by CreatTime desc";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectFlags(int Flags)
        {
            string sql = "select * from Video where Flag=@Flags";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@Flags",Flags)
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }

        public DataTable SelectTop6()
        {
            string sql = "select top 6 * from Video order by CreatTime desc";
            return DBHelper.GetFillData(sql);
        }

        public DataTable SelectVideoID(int VideoID)
        {
            string sql = "select * from Video where VideoID like '" + @VideoID + "'";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@VideoID",VideoID)
            };
            return DBHelper.GetFillData(sql, sp);
        }
        public int DeleteAct(int VideoID)
        {
            string sql = "delete from Video where VideoID=@VideoID";
            SqlParameter[] sp = { new SqlParameter("@VideoID", VideoID) };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
    }
}
