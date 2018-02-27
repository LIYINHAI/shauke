using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Interest
    {
        public int ISID { get; set; }
        public int UserID { get; set; }
        public string ISName { get; set; }
        public string ISBrief { get; set; }
        public DateTime CreatTime { get; set; }
        public string  Image { get; set; }
    }
}
