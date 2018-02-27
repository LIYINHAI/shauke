using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Video
    {
        public int VideoID { get; set; }
        public string VideoName { get; set; }
        public string VideoBrief { get; set; }
        public DateTime CreatTime { get; set; }
        public string VideoUrl { get; set; }
        public string Images { get; set; }
        public int Flag { get; set; }
    }
}
