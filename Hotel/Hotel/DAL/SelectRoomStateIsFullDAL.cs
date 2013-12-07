using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
  public static   class SelectRoomStateIsFullDAL

    {
      public static DataTable SelectRoomStateIsFull()
      {
          DataTable table = SqlHelper.ExecuteDataTable("select * from RoomTable where RoomState='满'");
          return table;
      }

    }
}
