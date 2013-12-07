using Hotel.COM;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
   public static  class LoadCheckInDataDAL
    {
       public static string sql = "select RoomNumber, GuestName, Date, IdentityCardNumber ,Address ,TelephoneNumber  from CheckInTable  order by Date asc ";
        public static List<CheckIn> loadCheckOutBillData(string sql)
        {
            List<CheckIn> list = new List<CheckIn>();
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        CheckIn checkIn = new CheckIn();
                        checkIn.RoomNumber = reader.GetString(0);
                        checkIn.GuestName = reader.GetString(1);

                        checkIn.Date = reader.GetDateTime(2);
                        checkIn.IdentityCardNumber = reader.GetString(3);
                        checkIn.Address = reader.GetString(4);
                        checkIn.TelephoneNumber = reader.GetString(5);
                       
                        list.Add(checkIn);
                    }
                }

            }
            return list;
        }
    }
   
}
