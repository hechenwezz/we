using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.COM
{
    public class CheckIn
    {
        public Guid Id { set; get; }
        public string RoomNumber { set; get; }
        public string GuestName { set; get; }
        public DateTime Date { set; get; }
        public string IdentityCardNumber { set; get; }
        public string Address { set; get; }
        public string TelephoneNumber { set; get; }

    }
}
