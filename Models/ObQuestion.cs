using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
  public class ObQuestion
    {
        public int CourseID { get; set; }
        public int ObID { get; set; }
        public string Title { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public string Answer { get; set; }

    }
}
