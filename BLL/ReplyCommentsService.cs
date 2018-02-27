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
   public class ReplyCommentsService
    {
        private static IReplyComments ireplycomments = DataAccess.CreateReplyComments();
        public static int Insert(ReplyComments replycomments)
        {
            return ireplycomments.Insert(replycomments);
        }
        public static DataTable SelectAll()
        {
            return ireplycomments.SelectAll();
        }
       public static int DeleteAll(int ReplyComID)
        {
            return ireplycomments.DeleteAll(ReplyComID);
        }
       public static int DeleteReplyComments(int ReplyComID)
       {
           return ireplycomments.DeleteReplyComments(ReplyComID);
       }
       public static DataTable SelectReplyComments(int ComID)
       {
           return ireplycomments.SelectReplyComments(ComID);
       }
    }
}
