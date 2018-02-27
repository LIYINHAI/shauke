using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using IDAL;
using DALFactory;
using Models;

namespace BLL
{
    public class LeavewordsService
    {
        private static ILeavewords ileavewords = DataAccess.CreateLeavewords();
        public static int InsertLeavewords(Leavewords words)
        {
            return ileavewords.InsertLeavewords(words);
        }
        public static DataTable SelectLeavewords(int VideoID)
        {
            return ileavewords.SelectLeavewords(VideoID);
        }
        public static DataTable SelectAllLeavewords()
        {
            return ileavewords.SelectAllLeavewords();
        }
        public static int DeleteLeavewords(int LeaveID)
        {
            return ileavewords.DeleteLeavewords(LeaveID);
        }
    }
}
