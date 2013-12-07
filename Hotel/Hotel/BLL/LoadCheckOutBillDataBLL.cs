using Hotel.COM;
using Hotel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BLL
{
   public static class LoadCheckOutBillDataBLL
    {
       public static List<CheckOutBill> loadCheckOutBillData(string WaiterName)
       {
           return LoadCheckOutBillDataDAL.loadCheckOutBillData(LoadCheckOutBillDataDAL.sql, WaiterName);
       }
    }
}
