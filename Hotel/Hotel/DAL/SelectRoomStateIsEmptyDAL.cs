using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
   public static  class SelectRoomStateIsEmptyDAL
    {
        /// <summary>
        /// 查询用户名在数据库中的SQL语句
        /// </summary>
       // public static string sql = "select * from RoomTable where RoomState='空'";
        /// <summary>
        /// 用户验证
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="User"></param>
        /// <returns></returns>
        public static DataTable SelectRoomStateIsEmpty()
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from RoomTable where RoomState='空'");
            return table;
        }
    }
}
