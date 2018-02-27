using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using System.Data.SqlClient;

namespace IDAL
{
   public interface IObQuestion
    {
        //存储表的信息
        int Insert(ObQuestion obquestion);
        //展先表的信息
        DataTable SelectAll();
        //选取五道题
        DataTable SelectFive();
        //选择十道题
        DataTable SelectTen();
        //选取十五道题
        DataTable SelectFifteen();

       
    }
}
