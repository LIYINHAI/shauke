using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using IDAL;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class SqlServerAdminInfo : IAdminInfo
    {

        //存数据库
        public int Insert(AdminInfo admininfo)
        {
            string sql = "insert into AdminInfo values(@AdminID,@AdminName,@Password)";
            SqlParameter[] sp = new SqlParameter[] {new SqlParameter("@AdminID",admininfo.AdminID),
                                                  new SqlParameter ("@AdminName",admininfo.AdminName),
                                                  new SqlParameter("@Password",admininfo.Password)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
        //核对信息
        public SqlDataReader Login(string AdminName, string Password)
        {
            string sql = "select * from AdminInfo where AdminName=@AdminName and Password=@Password";
            SqlParameter[] sp = new SqlParameter[] {new SqlParameter("@AdminName",AdminName),
                                                 new SqlParameter("@Password",Password)};
            return DBHelper.GetDataReader(sql,sp); 
        }
       

    }
}
