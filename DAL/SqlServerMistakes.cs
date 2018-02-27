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
    public class SqlServerMistakes : IMistakes
    {
        //存表的信息
        int IMistakes.Insert(Mistakes mistakes)
        {
            string sql = "insert into Mistakes values(@UserID,@ObID,@MisTime)";
            SqlParameter[] sp = new SqlParameter[] 
            {
               new SqlParameter("@UserID",mistakes.UserID),
               new SqlParameter ("@ObID",mistakes.ObID),
               new SqlParameter("@MisTime",mistakes.MisTime) };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

      
        public SqlDataReader SelectMistakes(int UserID)
        {
            string sql = "select* from Mistakes a  left join ObQuestion b on a.ObID = b.ObID  where a.UserID=@UserID  ";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@UserID",UserID)
            };
            return DBHelper.GetDataReader(sql, sp);
        }
    }
}
