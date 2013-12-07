using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.COM
{
  public class Room 
    {
      public Guid Id { set; get; }
      public string RoomNumber { set; get; }
      public string RoomType { set; get; }
      public decimal RoomRate { set; get; }
      public string RoomState { set; get; }
      
    }
}
