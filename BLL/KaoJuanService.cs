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
    public class KaoJuanService
    {
        private static IKaoJuan ikaojuan = DataAccess.CreateKaoJuan();
        public static int Insert(KaoJuan kaojuan)
        {
            return ikaojuan.Insert(kaojuan);
        }
        public static DataTable SelectAll()
        {
            return ikaojuan.SelectAll();
        }
        public static SqlDataReader SelectKaoJuan(int KaoJuanID)
        {
            return ikaojuan.SelectKaoJuan(KaoJuanID);
        }
        public static SqlDataReader SelectKaoJuanTop1()
        {
            return ikaojuan.SelectKaoJuanTop1();
        }
    }
}
