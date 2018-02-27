using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Models;
namespace IDAL
{
  public interface INewsInfo
    {
        //存表的信息
        int Insert(NewsInfo newsinfo);
        //展现表的信息
        DataTable SelectAll();
        //展示前十
        DataTable SelectTop(int top);    
        //根据ID来展现
        DataTable SelectID(int NewsID);
        //删除
        int DeleteAct(int NewsID);
    }
}
