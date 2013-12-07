using Hotel.COM;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    public static class LoadCheckOutBillDataDAL
    {
        public static string sql = "select BillNumber, RoomNumber, GuestName, NumberOfPeaple ,RoomRate ,ConsumptionPaid ,Date ,WaiterName from CheckOutBillTable where WaiterName=@WaiterName order by Date asc ";
        public static List<CheckOutBill> loadCheckOutBillData(string sql ,string WaiterName)
        {

            List<CheckOutBill> list = new List<CheckOutBill>();
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, new SqlParameter("@WaiterName", WaiterName)))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        CheckOutBill room = new CheckOutBill();
                        room.BillNumber = reader.GetGuid(0);
                        room.RoomNumber = reader.GetString(1);
                        room.GuestName = reader.GetString(2);
                        room.NumberOfPeaple = reader.GetString(3);
                        room.RoomRate = reader.GetDecimal(4);
                        room.ConsumptionPaid = reader.GetDecimal(5);
                        room.Date = reader.GetDateTime(6);
                        room.WaiterName = reader.GetString(7);
                        list.Add(room);
                    }
                }

            }
            return list;
        }
    }
}
