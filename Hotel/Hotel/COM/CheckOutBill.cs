using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.COM
{
  public   class CheckOutBill
    {
        public Guid Id { set; get; }
        public Guid BillNumber { set; get; }
        public string RoomNumber { set; get; }
        public string GuestName { set; get; }
        public string NumberOfPeaple { set; get; }
        public decimal RoomRate { set; get; }
        public decimal ConsumptionPaid { set; get; }
        public DateTime Date { set; get; }
        public string WaiterName { set; get; }
        public Guid CheckInBillTableId { set; get; }
    }
}
