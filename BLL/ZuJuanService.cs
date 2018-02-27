using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Models;
using IDAL;
using DALFactory;

namespace BLL
{
  public class ZuJuanService
    {
        private static IZuJuan izujuan = DataAccess.CreateZuJuan();
        public static int Insert(ZuJuan zujuan)
        {
            return izujuan.Insert(zujuan);
        }

        public static SqlDataReader SelectZuJuan(int KaoJuanID)
        {
            return izujuan.SelectZuanJuan(KaoJuanID);
        }
    }
}
