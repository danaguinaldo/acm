using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
     public class OrderRepository
     {
          /// <summary>
          /// Retrieve defined order.
          /// </summary>
          /// <param name="orderNumber"></param>
          /// <returns></returns>
          public Order Retrieve(int orderNumber)
          {
               // Create in instance of the Order class
               // Pass in the requested Id
               Order order = new Order(orderNumber);

               // Code to retrieve defined order

               // Temp hard-code
               if (orderNumber == 10)
               {
                    order.OrderDate = new DateTimeOffset(DateTime.Today);
               }

               return order;
          }

          /// <summary>
          /// Save current order.
          /// </summary>
          /// <returns></returns>
          public bool Save(Order order)
          {
               var success = true;

               if (order.HasChanges)
               {
                    if (order.IsValid)
                    {
                         if (order.IsNew)
                         {
                              // Call an Insert Stored Procedure
                         }
                         else
                         {
                              // Call an Update Stored Procedure
                         }
                    }
                    else
                    {
                         success = false;
                    }
               }

               return success;
          }
     }
}
