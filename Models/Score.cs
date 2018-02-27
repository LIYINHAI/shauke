using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Score
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int KaoJuanID { get; set; }
        public int Scores { get; set; }
        public string UserName { get; set; }
        public int Sum { get; set; }
    }
}
