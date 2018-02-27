using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Models;
using System.Data.SqlClient;

namespace IDAL
{
    public interface ILeavewords
    {
        int InsertLeavewords(Leavewords words);
        DataTable SelectLeavewords(int VideoID);
        DataTable SelectAllLeavewords();
        int DeleteLeavewords(int LeaveID);
    }
}
