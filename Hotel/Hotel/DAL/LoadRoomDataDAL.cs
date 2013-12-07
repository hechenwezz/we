using Hotel.COM;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
   public static  class LoadRoomDataDAL
    {
       public static string sql1 = "select RoomNumber, RoomType, RoomRate ,RoomState from RoomTable  order by RoomState ,RoomNumber asc ";
       public static string sql2 = "select RoomNumber, RoomType, RoomRate ,RoomState from RoomTable  order by RoomNumber asc ";
       public static List<RoomShow>loadRoomData(string sql) 
       {
           List<RoomShow> list = new List<RoomShow>();
           using (SqlDataReader reader = SqlHelper.ExecuteReader(sql))
           {
               if (reader.HasRows)
               {
                   while (reader.Read())
                   {
                       RoomShow room = new RoomShow();
                       room.RoomNumber = reader.GetString(0);
                       room.RoomType = reader.GetString(1);
                       room.RoomRate = reader.GetDecimal(2);
                       room.RoomState = reader.GetString(3);
                       list.Add(room);
                   }
               }

           }
           return list;
       }
       
  
    }
}
