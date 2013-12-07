using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.COM
{
    /// <summary>
    /// 用户类
    /// </summary>
  public class User
    {
      public Guid Id { set; get; }
      public String Name { set; get; }
      public String IdentityCardNumber { set; get; }
      public String Sex { set; get; }
      public String Address { set; get; }
      public String Duty { set; get; }
      public String UserName { set; get; }
      public String Password { set; get; }
    }
}
