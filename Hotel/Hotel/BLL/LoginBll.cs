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
    /// <summary>
    /// 用户登陆
    /// </summary>
   public static  class LoginBll
    {
       /// <summary>
       /// 验证登陆
       /// </summary>
       /// <param name="User"></param>
       public static DataTable Login(User user)
       {
         return   LoginDAL.Longin(user );
       }
    }
}
