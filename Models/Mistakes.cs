using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
  public  class Mistakes
    {
        public int MisID { get; set; }
        public int UserID { get; set; }
        public int ObID { get; set; }
        public DateTime MisTime { get; set; }
    }
}
