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
   public class VideoService
    {
        private static IVideo ivideo = DataAccess.CreateVideo();
        public static int Insert(Video video)
        {
            return ivideo.Insert(video);
        }
        public static DataTable SelectAll()
        {
            return ivideo.SelectAll();
        }
        public static DataTable SelectFlags(int Flags)
        {
            return ivideo.SelectFlags(Flags);
        }
        public static DataTable SelectVideoID(int ID)
        {
            return ivideo.SelectVideoID(ID);
        }
        public static DataTable SelectTop6()
        {
            return ivideo.SelectTop6();
        }
        public static int DeleteAct(int VideoID)
        {
            return ivideo.DeleteAct(VideoID);
        }
    }
}
