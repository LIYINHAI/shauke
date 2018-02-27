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
   public class ThemeService
    {
        private static ITheme itheme = DataAccess.CreateTheme();
        public static int Insert(Theme theme)
        {
            return itheme.Insert(theme);
        }
        public static DataTable SelectAll()
        {
            return itheme.SelectAll();
        }
       public static int UpdataTheme(int UserID)
        {
            return itheme.UpdataTheme(UserID);
        }
        public static int UpdataTheme(string ThemeContent)
        {
            return itheme.UpdataTheme(ThemeContent);
        }
        public static DataTable SelectISID(int ID)
        {
            return itheme.SelectISID(ID);
        }
        public static DataTable SelectThemeID(int ID)
        {
            return itheme.SelectThemeID(ID);
        }
    }
}
