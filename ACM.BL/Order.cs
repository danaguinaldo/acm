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
        
          }

          public Order(int orderNumber)
          {
               OrderNumber = orderNumber;
          }

          public int OrderNumber { get; private set; }

          public DateTimeOffset? OrderDate { get; set; }
          
          /// <summary>
          /// Validate current order.
          /// </summary>
          /// <returns></returns>
          public bool Validate()
          {
               var isValid = true;

               if (OrderDate == null) isValid = false;

               return isValid;
          }
     }
}
