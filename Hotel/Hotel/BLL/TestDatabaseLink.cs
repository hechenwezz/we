using Hotel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BLL
{
    /// <summary>
    /// 测试数据库连接
    /// </summary>
  public static class TestDatabaseLinkBLL
    {
      /// <summary>
        ///  测试数据库连接
      /// </summary>
      /// <returns></returns>
      public static bool TestDatabaseLink()
      {
          return SqlHelper.ConnectDB();
      }
    }
}
