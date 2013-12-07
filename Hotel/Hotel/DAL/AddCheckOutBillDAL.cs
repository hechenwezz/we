using Hotel.COM;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
   public static  class AddCheckOutBillDAL
    {
       private static string sql = "insert into CheckOutBillTable values(@Id,@BillNumber,@RoomNumber,@GuestName,@NumberOfPeaple,@RoomRate,@ConsumptionPaid,@Date,@WaiterName,@CheckInBillTableId)";
       public static void addCheckOutBill(CheckOutBill checkOutBill)
       {
            

      
            SqlParameter[] pams = new SqlParameter[]
           {
               new SqlParameter ("@Id",checkOutBill.Id ),
               new SqlParameter ("@BillNumber",checkOutBill.BillNumber),
               new SqlParameter ("@RoomNumber",checkOutBill.RoomNumber  ),
               new SqlParameter ("@GuestName",checkOutBill.GuestName   ),            
               new SqlParameter ("@NumberOfPeaple",checkOutBill.NumberOfPeaple  ),  
               new SqlParameter ("@RoomRate",checkOutBill.RoomRate   ), 
               new SqlParameter ("@ConsumptionPaid",checkOutBill.ConsumptionPaid ), 
                 new SqlParameter ("@Date",checkOutBill.Date  ),   
                 new SqlParameter ("@WaiterName",checkOutBill.WaiterName  ), 
                  new SqlParameter ("@CheckInBillTableId",checkOutBill.CheckInBillTableId  ), 
          };
            SqlHelper.ExecuteNonQuery(AddCheckOutBillDAL.sql, pams);
       }
    }
    
}
