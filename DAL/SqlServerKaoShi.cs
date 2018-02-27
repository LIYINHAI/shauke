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
    public class SqlServerKaoShi : IKaoShi
    {
        public int Insert(KaoShi kaoshi)
        {
            string sql = "insert into KaoShi values(@PageID,@UserID)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@PageID",kaoshi.PageID),
                new SqlParameter("@UserID",kaoshi.UserID)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public SqlDataReader SelectKaoShi(int PageID, int UserID)
        {
            string sql = "select * from  KaoShi where PageID=@PageID and UserID=@UserID";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@PageID",PageID),
                new SqlParameter("@UserID",UserID)
            };
            return DBHelper.GetDataReader(sql, sp);
        }
    }
}
