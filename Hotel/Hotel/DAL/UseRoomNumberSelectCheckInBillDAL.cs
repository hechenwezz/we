using Hotel.COM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
   public static  class UseRoomNumberSelectCheckInBillDAL
    {
       public static string sql = "select * from CheckInBillTable where RoomNumber=@RoomNumber";
       public static DataTable UseRoomNumberSelectCheckInBill(string CheckOutBillRoomNumber)
        {
            DataTable table = SqlHelper.ExecuteDataTable(sql, new SqlParameter("@RoomNumber", CheckOutBillRoomNumber));
            return table;
        }
    }
}
