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
    public class SqlServerObQuestion : IObQuestion
    {
        //存表的信息
        public int Insert(ObQuestion obquestion)
        {
            string sql = "insert into ObQuestion values(@CourseID,@ObID,@Title,@AnswerA,@AnswerB,@AnswerC,@AnswerD,@Answer)";
            SqlParameter[] sp = new SqlParameter[] { new SqlParameter("@CourseID",obquestion.CourseID),
                                                 new SqlParameter("@ObID",obquestion.ObID),
                                                 new SqlParameter("@Title",obquestion.Title),
                                                 new SqlParameter("@AnswerA",obquestion.AnswerA),
                                                 new SqlParameter("@AnswerB",obquestion.AnswerB),
                                                 new SqlParameter("@AnswerC",obquestion.AnswerC),
                                                 new SqlParameter("@AnswerD",obquestion.AnswerD),
                                                 new SqlParameter("@Answer",obquestion.Answer) };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        //展现表的信息
        public DataTable SelectAll()
        {
            string sql = "select  * from ObQuestion order by ObID desc";
            return DBHelper.GetFillData(sql);
        }

        //随机选择十五个题目
        public DataTable SelectFifteen()
        {
            string sql = "select top 15 * from ObQuestion order by NEWID() ";
            return DBHelper.GetFillData(sql);
        }

        //随机选择5道题
        public DataTable SelectFive()
        {
            string sql = "select top 5 * from ObQuestion order by NEWID() ";
            return DBHelper.GetFillData(sql);
        }

        //随机选10道题
        public DataTable SelectTen()
        {
            string sql = "select top 10 * from ObQuestion order by NEWID() ";
            return DBHelper.GetFillData(sql);
        }
    }
}
