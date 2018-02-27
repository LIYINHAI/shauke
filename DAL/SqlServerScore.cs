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
    public class SqlServerScore : IScore
    {
        public int Insert(Score score)
        {
            string sql = "insert into Score values(@UserID,@KaoJuanID,@Scores,@UserName,@Sum)";
            SqlParameter[] sp = new SqlParameter[]
            {
               new SqlParameter("@UserID",score.UserID),
               new SqlParameter("@KaoJuanID",score.KaoJuanID),
               new SqlParameter("@Scores",score.Scores),
               new SqlParameter("@UserName",score.UserName),
               new SqlParameter("@Sum",score.Sum)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectAll(int UserID)
        {
            string sql = "select* from Score a left join KaoJuan b on a.KaoJuanID = b.KaoJuanID  where a.UserID = @UserID ";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@UserID",UserID)
            };
            return DBHelper.GetFillData(sql, sp);
        }

        public SqlDataReader SelectScore(int UserID, int KaoJuanID)
        {
            
            string sql = "select* from Score a left join  KaoJuan b on a.KaoJuanID = b.KaoJuanID left join UserInfo c on a.UserID = c.UserID  where a.UserID=@UserID and a.KaoJuanID =@KaoJuanID ";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@UserID",UserID),
                new SqlParameter("@KaoJuanID",KaoJuanID)
            };
            return DBHelper.GetDataReader(sql, sp);
        }
    }
}
