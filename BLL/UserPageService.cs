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
   public class UserPageService
    {
        private static IUserPage iuserpage = DataAccess.CreateUserPage();
        public static int Insert(UserPage userpage)
        {
            return iuserpage.Insert(userpage);
        }
      
        public static SqlDataReader SelectUserPage(int UserID, int KaoJuanID)
        {
            return iuserpage.SelectUserPage(UserID, KaoJuanID);
        }
    }
}
