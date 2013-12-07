using Hotel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BLL
{
   public static  class UpdateRoomBLL
    {
       public static void updateRoomIsFull(string RoomNumber)
       {
           UpdateRoomDAL.updateRoom(UpdateRoomDAL .sql1 , RoomNumber);

       }

       public static void updateRoomIsEmpty(string RoomNumber)
       {
           UpdateRoomDAL.updateRoom(UpdateRoomDAL.sql2, RoomNumber);

       }
    }
}
