using Hotel.COM;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
  public static   class AddGuestDAL
    {
        private static string sql = "insert into GuestTable values(@Id,@Name,@IdentityCardNumber,@Sex,@Address,@TelephoneNumber)";

        public static void addGuest(Guest guest)
        {
            SqlParameter[] pams = new SqlParameter[]
           {
               new SqlParameter ("@Id",guest.Id ),
               new SqlParameter ("@Name",guest.Name ),
               new SqlParameter ("@IdentityCardNumber",guest .IdentityCardNumber  ),
               new SqlParameter ("@Sex", guest .Sex  ),            
               new SqlParameter ("@Address",guest .Address  ),  
               new SqlParameter ("@TelephoneNumber",guest .TelephoneNumber  ), 
          };
            SqlHelper.ExecuteNonQuery(AddGuestDAL.sql, pams);
        }
    }
}
