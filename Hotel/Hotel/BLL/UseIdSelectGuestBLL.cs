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
   public static  class UseIdSelectGuestBLL
    {
       public static DataTable useIdSelectGuest(Guest guest)
       {
           return UseIdSelectGuestDAL.useIdSelectGuest(guest);
       }
    }
}
