using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;
using IDAL;
using DALFactory;
namespace BLL
{
   public class MistakesService
    {
        private static IMistakes imistakes = DataAccess.CreateMistakes();
        public static int Insert(Mistakes mistakes)
        {
            return imistakes.Insert(mistakes);
        }
        public static SqlDataReader  SelectMistakes(int UserID)
        {
            return imistakes.SelectMistakes(UserID);
        }

    }
}
