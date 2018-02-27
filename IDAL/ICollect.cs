using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Models;
namespace IDAL
{
   public interface ICollect
    {
        //存表的信息
        int Insert(Collect collect);
        //展现表的信息
        SqlDataReader SelectCollect(int UserID);
    }
}
