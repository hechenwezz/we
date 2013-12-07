using Hotel.COM;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
  public static   class LoadUserDataDAL
    {
      public static string sql = "select Name, IdentityCardNumber, Sex, Address ,Duty ,UserName ,Password from UserTable  order by Duty asc ";
        public static List<User> loadUserData(string sql)
        {
            List<User> list = new List<User>();
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        User user = new User();
                        user.Name  = reader.GetString(0);
                        user.IdentityCardNumber = reader.GetString(1);
                        user.Sex = reader.GetString(2);
                        user.Address = reader.GetString(3);
                        user.Duty = reader.GetString(4);
                        user.UserName = reader.GetString(5);
                        user.Password = reader.GetString(6);
                       
                        list.Add(user);
                    }
                }

            }
            return list;
        }
    }
}
