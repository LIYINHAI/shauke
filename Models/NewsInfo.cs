using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class NewsInfo
    {
        public int NewsID { get; set; }
        public string NewsTitle { get; set; }
        public string NewsContent { get; set; }
        public DateTime NewsTime { get; set; }
    }
}
