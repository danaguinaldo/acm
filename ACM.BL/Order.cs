using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
     public class Order
     {
          public Order()
          {
               OrderDate = DateTime.Today;
          }

          public DateTime OrderDate { get; set; }
          public bool Validate()
          {
               var isValid = true;

               if (OrderDate != DateTime.Today) isValid = false;

               return isValid;
          }
     }
}
