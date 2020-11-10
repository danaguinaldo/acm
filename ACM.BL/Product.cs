using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
     public class Product
     {
          public Product()
          {

          }

          public Product(int productId)
          {
               ProductId = productId;
          }

          public string ProductName { get; set; }
          public string Description { get; set; }
          public double CurrentPrice { get; set; }
          public int ProductId { get; private set; }
          
          /// <summary>
          /// Validates current product.
          /// </summary>
          /// <returns></returns>
          public bool Validate()
          {
               var isValid = true;
               if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
               if (string.IsNullOrWhiteSpace(Description)) isValid = false;

               return isValid;
          }

          /// <summary>
          /// Retrieve defined product.
          /// </summary>
          /// <param name="productId"></param>
          /// <returns></returns>
          public Product Retrieve(int productId)
          {
               // Code to retrieve defined product.

               return new Product();
          }

          /// <summary>
          /// Retrieve ALL products.
          /// </summary>
          /// <returns></returns>
          public List<Product> Retrieve()
          {
               // Code to retrieve all products

               return new List<Product>();
          }

          /// <summary>
          /// Saves defined product.
          /// </summary>
          /// <returns></returns>
          public bool Save()
          {
               return true;
          }
     }
}
