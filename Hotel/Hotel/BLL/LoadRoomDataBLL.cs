using Hotel.COM;
using Hotel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BLL
{
   public static  class LoadRoomDataBLL
    {
       public static List<RoomShow> loadRoomData1()
       {
           return LoadRoomDataDAL.loadRoomData(LoadRoomDataDAL.sql1);
       }

       public static List<RoomShow> loadRoomData2()
       {
           return LoadRoomDataDAL.loadRoomData(LoadRoomDataDAL.sql2);
       }
    }
}
