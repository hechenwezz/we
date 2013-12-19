using Hotel.COM;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
  public static   class AddUserDAL
    {
        private static string sql = "insert into UserTable values(@Id,@Name,@IdentityCardNumber,@Sex,@Address,@Duty,@UserName,@Password)";

        public static void addUser(User user)
        {
            SqlParameter[] pams = new SqlParameter[]
           {
               new SqlParameter ("@Id",user.Id ),
               new SqlParameter ("@Name",user.Name ),
               new SqlParameter ("@IdentityCardNumber",user .IdentityCardNumber  ),
               new SqlParameter ("@Sex", user .Sex  ),            
               new SqlParameter ("@Address",user .Address  ),  
               new SqlParameter ("@Duty",user .Duty  ), 
               new SqlParameter ("@UserName",user .UserName  ),  
               new SqlParameter ("@Password",user .Password  ),
          };
            SqlHelper.ExecuteNonQuery(AddUserDAL.sql, pams);
        }
    }
}
