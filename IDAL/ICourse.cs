using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
namespace IDAL
{
    public interface ICourse
    {
        //存表的信息
        int Insert(Course course);
        //展现表的信息
        DataTable SelectAll();
    }
}
