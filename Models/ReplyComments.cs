using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class ReplyComments
    {
        public int ReplyComID { get; set; }
        public int ComID { get; set; }
        public int UserID { get; set; }
        public string ReplyComContent { get; set; }
        public DateTime ReplyComTime { get; set; }
    }
}
