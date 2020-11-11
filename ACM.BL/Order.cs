﻿using System;
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

          public Order(int orderNumber)
          {
               OrderDate = DateTime.Today;
               OrderNumber = orderNumber;
          }

          public int OrderNumber { get; private set; }

          public DateTime OrderDate { get; set; }
          
          /// <summary>
          /// Validate current order.
          /// </summary>
          /// <returns></returns>
          public bool Validate()
          {
               var isValid = true;

               if (OrderDate != DateTime.Today) isValid = false;
               if (OrderNumber <= 0) isValid = false;

               return isValid;
          }

          /// <summary>
          /// Retrieve defined order.
          /// </summary>
          /// <param name="orderNumber"></param>
          /// <returns></returns>
          public Order Retrieve(int orderNumber)
          {
               // Code to retrieve defined order

               return new Order();
          }

          /// <summary>
          /// Retrieve ALL orders for customer.
          /// </summary>
          /// <returns></returns>
          public Order Retrieve()
          {
               // Code to retrieve ALL orders.

               return new Order();
          }

          /// <summary>
          /// Save current order.
          /// </summary>
          /// <returns></returns>
          public bool Save()
          {
               return true;
          }
     }
}
