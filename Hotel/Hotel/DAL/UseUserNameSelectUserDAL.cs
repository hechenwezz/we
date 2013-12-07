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
  public static class UseUserNameSelectUserDAL
    {
      public static string sql = "select * from UserTable where UserName=@UserName";
        public static DataTable useUserNameSelectUser(User user)
        {
            DataTable table = SqlHelper.ExecuteDataTable(sql, new SqlParameter("@UserName", user.UserName ));
            return table;
        }
    }
}
