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
   public class InterestService
    {
        private static IInterest iinterest = DataAccess.CreateInterest();
        public static int Insert(Interest interest)
        {
            return iinterest.Insert(interest);
        }
        public static DataTable SelectAll()
        {
            return iinterest.SelectAll();
        }
        public static DataTable SelectTop2()
        {
            return iinterest.SelectTop2();
        }
        public static int UpdateInsert(int UserID)
        {
            return iinterest.UpdateInsert(UserID);
        }
        public static int UpdateInster(string IsBrief)
        {
            return iinterest.UpdateInster(IsBrief);
        }
        public static DataTable SelectISID(int ID)
        {
            return iinterest.SelectISID(ID);
        }
    }
}
