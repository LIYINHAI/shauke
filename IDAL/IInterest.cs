using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Models;
namespace IDAL
{
    public interface IInterest
    {
        //存表的信息
        int Insert(Interest interest);
        //展现表
        DataTable SelectAll();
        //更新用户编号
        int UpdateInsert(int UserID);
        //更新小组简介
        int UpdateInster(string IsBrief);
        //选择兴趣小组ID
        DataTable SelectISID(int ISID);
        DataTable SelectTop2();
    }
}
