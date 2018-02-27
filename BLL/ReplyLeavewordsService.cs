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
    public class ReplyLeavewordsService
    {
        private static IReplyLeavewords ireplyleavewords = DataAccess.CreateReplyLeavewords();
        public static int InsertReplyLeavewords(ReplyLeavewords Replywords)
        {
            return ireplyleavewords.InsertReplyLeavewords(Replywords);
        }
        public static DataTable SelectReplyLeavewords(int LeaveID)
        {
            return ireplyleavewords.SelectReplyLeavewords(LeaveID);
        }
        public static DataTable SelectAllReplyLeavewords()
        {
            return ireplyleavewords.SelectAllReplyLeavewords();
        }
        public static int DeleteReplyLeavewords(int ReplyLeaID)
        {
            return ireplyleavewords.DeleteReplyLeavewords(ReplyLeaID);
        }
    }
}
