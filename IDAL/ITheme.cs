using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Models;
namespace IDAL
{
  public interface ITheme
    {
        //存表的信息
        int Insert(Theme theme);
        //展现表的信息
        DataTable SelectAll();
        //更新用户编号
        int UpdataTheme(int UserID);
        //更新话题内容
        int UpdataTheme(string ThemeContent);
        //选择兴趣小组ID
        DataTable SelectISID(int ISID);
        //选择兴趣小组ID
        DataTable SelectThemeID(int ThemeID);
    }
}
