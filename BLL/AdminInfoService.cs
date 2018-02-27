using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Models;
using IDAL;
using DALFactory;
using System.Data;
namespace BLL
{
   public class AdminInfoService
    {
        private static IAdminInfo iadmininfo = DataAccess.CreateAdminInfo();
        public static int Insert(AdminInfo admininfo)
        {
            return iadmininfo.Insert(admininfo);
        }
        public static SqlDataReader Login(string AdminName, string Password)
        {
            return iadmininfo.Login(AdminName, Password);
        }
    }
}
