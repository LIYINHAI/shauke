using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace IDAL
{
   public interface IAdminInfo
    {
        int Insert(AdminInfo admininfo);
        //核对信息
        SqlDataReader Login(string AdminName, string Password);
    }
}
