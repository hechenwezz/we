using Hotel.COM;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
   public static  class AddRoomDAL
    {
       private static  string sql = "insert into RoomTable values(@Id,@RoomNumber,@RoomType,@RoomRate,@RoomState)";
       public static void addRoom(Room room)
       {
           SqlParameter[] pams = new SqlParameter[]
           {
               new SqlParameter ("@Id",room.Id ),
               new SqlParameter ("@RoomNumber",room.RoomNumber),
               new SqlParameter ("@RoomType",room.RoomType ),
               new SqlParameter ("@RoomRate",room.RoomRate ),            
               new SqlParameter ("@RoomState",room.RoomState ),              
          };
           SqlHelper.ExecuteNonQuery(AddRoomDAL .sql , pams);
       }

    }
}
