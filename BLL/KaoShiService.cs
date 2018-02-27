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
  public  class KaoShiService
    {
        private static IKaoShi ikaoshi = DataAccess.CreateKaoShi();
        public static int Insert(KaoShi kaoshi)
        {
            return ikaoshi.Insert(kaoshi);
        }
        public static SqlDataReader SelectKaoShi(int PageID,int UserID)
        {
            return ikaoshi.SelectKaoShi(PageID,UserID);
        }
    }
}
