using Hotel.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BLL
{
  public static   class UseRoomNumberSelectCheckInBillBLL
    {
      public static DataTable UseRoomNumberSelectCheckInBill(string CheckOutBillRoomNumber)
      {
         return  UseRoomNumberSelectCheckInBillDAL.UseRoomNumberSelectCheckInBill( CheckOutBillRoomNumber);
      }
    }
}
