using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Models;
using DALFactory;
using IDAL;
using System.Data;

namespace BLL
{
   public class CourseService
    {
        private static ICourse icourse = DataAccess.CreateCourse();
        public static int Insert(Course course)
        {
            return icourse.Insert(course);
        }
        public static DataTable SelectAll()
        {
            return icourse.SelectAll();
        }
    }
}
