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
   public interface IKaoJuan
    {
        int Insert(KaoJuan kaojuan);

        DataTable SelectAll();

        SqlDataReader  SelectKaoJuan(int KaoJuanID);

        SqlDataReader SelectKaoJuanTop1();

    }
}
