using Hotel.COM;
using Hotel.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BLL
{
  public static   class UseUserNameSelectUserBLL
    {
      public static DataTable useUserNameSelectUser(User user)
      {
          return UseUserNameSelectUserDAL.useUserNameSelectUser(user);
      }
    }
}
