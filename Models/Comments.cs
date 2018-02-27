using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Comments
    {
        public int ComID { get; set; }
        public int UserID { get; set; }
        public int ThemeID { get; set; }
        public string ComContent { get; set; }
        public DateTime ComTime { get; set; }
    }
}
