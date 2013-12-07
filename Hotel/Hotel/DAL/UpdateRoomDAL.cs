using Hotel.COM;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
  public static   class UpdateRoomDAL
    {
        /// <summary>
        /// 更新Room表
        /// </summary>
      public static  string sql1 = "Update RoomTable Set RoomState='满' where RoomNumber=@RoomNumber";
      public static string sql2 = "Update RoomTable Set RoomState='空' where RoomNumber=@RoomNumber";
      public static string updateRoomDataSql = "Update RoomTable Set RoomNumber=@RoomNumber ,RoomRate=@RoomRate ,RoomType=@RoomType where Id=@Id";

      public static  void updateRoom(string sql, string RoomNumber)
        {
            SqlParameter pams = new SqlParameter("@RoomNumber", RoomNumber);
            SqlHelper.ExecuteNonQuery(sql, pams);

        }
      public static void updateRoomData(string sql, Room room)
      {
          SqlParameter pams = new SqlParameter("@RoomNumber", room.RoomNumber);
          SqlHelper.ExecuteNonQuery(sql, pams);

      }
    }
}
