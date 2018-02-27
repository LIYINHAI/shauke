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
    public class SqlServerUserPage : IUserPage
    {
        public int Insert(UserPage userpage)
        {
            string sql = "insert into UserPage values(@Fid,@Title,@UserID,@KaoJuanID,@UserAns)";
            SqlParameter[] sp = new SqlParameter[]
            {
               new SqlParameter("@Fid",userpage.Fid),
               new SqlParameter("@Title",userpage.Title),
               new SqlParameter("@UserID",userpage.UserID),
               new SqlParameter("@KaoJuanID",userpage.KaoJuanID),
               new SqlParameter("@UserAns",userpage.UserAns)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public SqlDataReader SelectUserPage(int UserID, int KaoJuanID)
        {
            string sql = "select* from UserPage a  left join ObQuestion b on a.Fid = b.ObID  where a.UserID=@UserID and a.KaoJuanID =@KaoJuanID ";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@UserID",UserID),
                new SqlParameter("@KaoJuanID",KaoJuanID)
            };
            return DBHelper.GetDataReader(sql, sp);
        }
    }
}
