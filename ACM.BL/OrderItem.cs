using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
     public class OrderItem
     {
          public OrderItem()
          {

          }

          public OrderItem(Product orderProduct, int quantity, double purchasePrice)
          {
               OrderProduct = orderProduct;
               Quantity = quantity;
               PurchasePrice = purchasePrice;
          }

          public Product OrderProduct { get; set; }
          public int Quantity { get; set; }
          public double PurchasePrice { get; set; }

          /// <summary>
          /// Validate OrderItem
          /// </summary>
          /// <returns></returns>
          public bool Validate()
          {
               var isValid = true;

               if (Quantity <= 0) isValid = false;
               if (OrderProduct == null) isValid = false;
               if (PurchasePrice <= 0) isValid = false;

               return isValid;
          }
          
          /// <summary>
          /// Retrieve defined OrderItem
          /// </summary>
          /// <returns></returns>
          public OrderItem Retrieve()
          {
               // Code to retrieve defined OrderItem

               return new OrderItem();
          }

          /// <summary>
          /// Saves Current OrderItem.
          /// </summary>
          /// <returns></returns>
          public bool Save()
          {
               // Save current OrderItem 
               
               return true;
          }
     }
}
