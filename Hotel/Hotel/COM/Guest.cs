using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.COM
{
  public  class Guest
    {
      public Guid Id { set; get; }
      public string Name { set; get; }
      public string IdentityCardNumber { set; get; }
      public string Sex { set; get; }
      public string Address { set; get; }
      public string TelephoneNumber { set; get; }
    }
}
