using Hotel.COM;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
   public static  class AddCheckInDAL
    {
       private static string sql = "insert into CheckInTable values(@Id,@RoomNumber,@GuestName,@Date,@IdentityCardNumber,@Address,@TelephoneNumber)";

       public static void addCheckIn(CheckIn checkIn)
        {
            SqlParameter[] pams = new SqlParameter[]
           {
               new SqlParameter ("@Id",checkIn.Id ),
               new SqlParameter ("@RoomNumber",checkIn .RoomNumber  ),
               new SqlParameter ("@GuestName",checkIn.GuestName ),
               new SqlParameter ("@Date",checkIn.Date  ),            
               new SqlParameter ("@IdentityCardNumber",checkIn.IdentityCardNumber   ),  
               new SqlParameter ("@Address",checkIn.Address   ), 
               new SqlParameter ("@TelephoneNumber",checkIn.TelephoneNumber   ), 
          };
            SqlHelper.ExecuteNonQuery(AddCheckInDAL.sql, pams);
        }
    }
}
