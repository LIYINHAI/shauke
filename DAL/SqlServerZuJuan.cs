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
    public class SqlServerZuJuan : IZuJuan
    {
        public int Insert(ZuJuan zujuan)
        {
            string sql = "insert into ZuJuan values(@KaoJuanID,@TitleID,@Mark)";
            SqlParameter[] sp = new SqlParameter[]
            {            
               new SqlParameter("@KaoJuanID",zujuan.KaoJuanID),
               new SqlParameter("@TitleID",zujuan.TitleID),
               new SqlParameter("@Mark",zujuan.Mark)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public SqlDataReader SelectZuanJuan(int KaoJuanID)
        {
            string sql = "select c.ObID as id  , * from ZuJuan a left  join KaoJuan b on a.KaoJuanID=b.KaoJuanID left join ObQuestion c on a.TitleID=c.ObID  where b.KaoJuanID =@KaoJuanID ";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@KaoJuanID",KaoJuanID)
            };
            return DBHelper.GetDataReader(sql, sp);
        }
    }
}
