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
    public class SqlServerKaoJuan : IKaoJuan
    {
        public int Insert(KaoJuan kaojuan)
        {
            string sql = "insert into KaoJuan values(@KaoJuanName,@PageFen,@CourseName,@CourseID)";
            SqlParameter[] sp = new SqlParameter[] 
            {
               new SqlParameter("@KaoJuanName",kaojuan.KaoJuanName),
               new SqlParameter("@PageFen",kaojuan.PageFen),
               new SqlParameter("@CourseName",kaojuan.CourseName),
               new SqlParameter("@CourseID",kaojuan.CourseID)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectAll()
        {
            string sql = "select * from KaoJuan order by KaoJuanID asc";
            return DBHelper.GetFillData(sql);
        }

        public SqlDataReader SelectKaoJuan(int KaoJuanID)
        {
            string sql = "select  * from KaoJuan where  KaoJuanID=@KaoJuanID";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@KaoJuanID",KaoJuanID)
            };
            return DBHelper.GetDataReader(sql,sp);
        }
        public SqlDataReader SelectKaoJuanTop1()
        {
            string sql = "select top 1 *  from KaoJuan    order by  KaoJuanID desc";
         
            return DBHelper.GetDataReader(sql);
        }
    }
}
