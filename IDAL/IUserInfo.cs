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
   public interface IUserInfo
    {
        //存表的信息
        int Insert(UserInfo userinfo);
        //核对信息
        SqlDataReader Login(string Name, string paw);
        //删除
        int DeleteAct(int UserID);
        //展现所有
        DataTable SelectTextAll();
    }
}
