using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Theme
    {
        public int ThemeID { get; set; }
        public int ISID { get; set; }
        public int UserID { get; set; }
        public string ThemeName { get; set; }
        public DateTime ThemeTime { get; set; }
        public string ThemeContent { get; set; }
        public string ThemeImage { get; set; }
    }
}
