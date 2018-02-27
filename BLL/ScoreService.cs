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
   public class ScoreService
    {
        private static IScore iscore = DataAccess.CreateScore();
        public static int Insert(Score score)
        {
            return iscore.Insert(score);
        }
        public static DataTable SelectAll(int UserID)
        {
            return iscore.SelectAll(UserID);
        }
        public static SqlDataReader SelectScore(int UserID,int KaoJuanID)
        {
            return iscore.SelectScore(UserID,KaoJuanID);
        }
    }
}
