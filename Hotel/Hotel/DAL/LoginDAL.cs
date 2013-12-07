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
    /// <summary>
    /// 用户登陆
    /// </summary>
 public static class LoginDAL
    {
     /// <summary>
     /// 查询用户名在数据库中的SQL语句
     /// </summary>
     public static string sql = "select * from [UserTable] where UserName=@UserName";
     /// <summary>
     /// 用户验证
     /// </summary>
     /// <param name="sql"></param>
     /// <param name="User"></param>
     /// <returns></returns>
     public static DataTable Longin(User user )
     {
         DataTable table = SqlHelper.ExecuteDataTable(sql, new SqlParameter("@UserName", user.UserName));
         return table;
     }
    }
}
