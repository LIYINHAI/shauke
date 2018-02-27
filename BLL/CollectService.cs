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
   public class CollectService
    {
        private static ICollect icollect = DataAccess.CreateCollect();
        public static int Insert(Collect collect)
        {
            return icollect.Insert(collect);
        }
        public static SqlDataReader SelectCollect(int UserID)
        {
            return icollect.SelectCollect(UserID);
        }
    }
}
