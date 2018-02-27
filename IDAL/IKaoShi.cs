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
  public interface IKaoShi
    {
        int Insert(KaoShi kaoshi);
       
        SqlDataReader SelectKaoShi(int PageID,int UserID);
    }
}
