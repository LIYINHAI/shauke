using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Models;
namespace IDAL
{
 public interface IReplyComments
    {
        //存表的信息
        int Insert(ReplyComments replycomments);
        //展现表的信息
        DataTable SelectAll();
        //删除评论
        int DeleteAll(int ReplyComID);
        DataTable SelectReplyComments(int ComID);
        int DeleteReplyComments(int ReplyComID);
    }
}
