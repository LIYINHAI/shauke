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
    public class SqlServerInterest : IInterest
    {
        //存信息
        public int Insert(Interest interest)
        {
            string sql = "insert into Interest values(@ISID,@UserID,@ISName,@ISBrief,@CreatTime)";
            SqlParameter[] sp = new SqlParameter[] {new SqlParameter("@ISID",interest.ISID),
                                                 new SqlParameter("@UserID",interest.UserID),
                                                 new SqlParameter ("@ISName",interest.ISName),
                                                 new SqlParameter("@ISBrief",interest.ISBrief),
                                                 new SqlParameter("@CreatTime",interest.CreatTime)};
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        //展现表信息
        public DataTable SelectAll()
        {
            string sql = "select * from Interest order by ISID  desc";
            return DBHelper.GetFillData(sql);
        }

        public DataTable SelectTop2()
        {
            string sql = "select top 2* from Interest order by ISID  desc";
            return DBHelper.GetFillData(sql);
        }

        public int UpdateInsert(int UserID)
        {
            throw new NotImplementedException();
        }

        public int UpdateInster(string IsBrief)
        {
            throw new NotImplementedException();
        }
        public DataTable SelectISID(int ISID)
        {
            string sql = "select * from Interest where ISID like '" + @ISID + "'";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ISID",ISID)
            };
            return DBHelper.GetFillData(sql, sp);
        }
    }
}
