using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.COM
{
   public  class OperationLog
    {
       public Guid Id { set; get; }
       public string UserName { set; get; }
       public string OperationDescribe { set; get; }
       public DateTime OperationDate { set; get; }
    }
}
