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
  public static   class UseIdSelectGuestDAL
    {
        public static string sql = "select * from GuestTable where Id=@Id";
        public static DataTable useIdSelectGuest(Guest guest)
        {
            DataTable table = SqlHelper.ExecuteDataTable(sql, new SqlParameter("@Id", guest .Id));
            return table;
        }
    }
}
