using Hotel.COM;
using Hotel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BLL
{
   public static  class AddCheckInBLL
    {
       public static void addCheckIn(CheckIn checkIn)
       {
           AddCheckInDAL.addCheckIn(checkIn);
       }
    }
}
