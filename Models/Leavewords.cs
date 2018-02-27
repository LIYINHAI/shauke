using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Leavewords
    {
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
        public int VideoID
        {
            get;
            set;
        }
        public string LeaveContent
        {
            get;
            set;
        }
        public DateTime LeaveTime
        {
            get;
            set;
        }
    }
}
