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
    public class SqlServerCourse : ICourse
    {
          //存数据
        public int Insert(Course course)
        {
            string sql = "insert into Course values(@CourseID,@CourseName,@TypeName)";
            SqlParameter[] sp = new SqlParameter[] {new SqlParameter("@CourseID",course.CourseID),
                                               new SqlParameter("@CourseName",course.CourseName),
                                               new SqlParameter("@TypeName",course.TypeName)};
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectAll()
        {
            //展现表信息
            string sql = "select * from Course order by CreatTime desc ";
            return DBHelper.GetFillData(sql);
        }
    }
}
