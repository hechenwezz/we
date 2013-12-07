using Hotel.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BLL
{
  public static   class SelectRoomStateIsEmptyBLL
    {
      public static DataTable SelectRoomStateIsEmpty()
      {
          return SelectRoomStateIsEmptyDAL.SelectRoomStateIsEmpty();
      }
    }
}
