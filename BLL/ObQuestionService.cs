using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;
using IDAL;
using DALFactory;
namespace BLL
{
   public class ObQuestionService
    {
        private static IObQuestion iobquestion = DataAccess.CreateObQuestion();
       public static int Insert(ObQuestion obquestion)
        {
            return iobquestion.Insert(obquestion);
        }
        public static DataTable SelectAll()
        {
            return iobquestion.SelectAll();
        }
        public static DataTable SelectFive()
        {
            return iobquestion.SelectFive();
        }
        public static DataTable SelectTen()
        {
            return iobquestion.SelectTen();
        }
        public static DataTable SelectFifteen()
        {
            return iobquestion.SelectFifteen();
        }
    }
}
