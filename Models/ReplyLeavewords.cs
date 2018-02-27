using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ReplyLeavewords
    {
        public int ReplyLeaID
        {
            get;
            set;
        }
        public int LeaveID
        {
            get;
            set;
        }
        public int UserID
        {
            get;
            set;
        }
        public string ReplyLeaContent
        {
            get;
            set;
        }
        public DateTime ReplyLeaTime
        {
            get;
            set;
        }
    }
}
