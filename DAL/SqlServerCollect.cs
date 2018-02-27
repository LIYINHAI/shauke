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
    public class SqlServerCollect : ICollect
    {
        //存数据
        public int Insert(Collect collect)
        {
            string sql = "insert into Collect values(@UserID,@ObID,@CtTime)";
            SqlParameter[] sp = new SqlParameter[] { 
                                                 new SqlParameter("@UserID",collect.UserID),
                                                 new SqlParameter("@ObID",collect.ObID),
                                                 new SqlParameter("@CtTime",collect.CtTime)};
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public SqlDataReader SelectCollect(int UserID)
        {
            string sql = "select* from Collect a  left join ObQuestion b on a.ObID = b.ObID  where a.UserID=@UserID  ";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@UserID",UserID)
            };
            return DBHelper.GetDataReader(sql, sp);
        }
       

    }
}
