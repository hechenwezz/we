using Hotel.COM;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
   public static  class AddCheckInBillDAL
    {
       private static string sql = "insert into CheckInBillTable values(@Id,@BillNumber,@RoomNumber,@GuestName,@NumberOfPeaple,@RoomRate,@AmountPaid,@Date,@WaiterName)";
       public static void addCheckInBill(CheckInBill checkInBill)
       {
            

      
            SqlParameter[] pams = new SqlParameter[]
           {
               new SqlParameter ("@Id",checkInBill.Id ),
               new SqlParameter ("@BillNumber",checkInBill.BillNumber),
               new SqlParameter ("@RoomNumber",checkInBill.RoomNumber  ),
               new SqlParameter ("@GuestName",checkInBill.GuestName   ),            
               new SqlParameter ("@NumberOfPeaple",checkInBill.NumberOfPeaple  ),  
               new SqlParameter ("@RoomRate",checkInBill.RoomRate   ), 
               new SqlParameter ("@AmountPaid",checkInBill.AmountPaid ), 
                 new SqlParameter ("@Date",checkInBill.Date  ),   
                 new SqlParameter ("@WaiterName",checkInBill.WaiterName  ), 
          };
            SqlHelper.ExecuteNonQuery(AddCheckInBillDAL.sql, pams);
       }
    }
}
