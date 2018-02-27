using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Models;
namespace IDAL
{
 public interface IMistakes
    {
       
        int Insert(Mistakes mistakes);
        
        SqlDataReader SelectMistakes(int UserID);
    }
}
