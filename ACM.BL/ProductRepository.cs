﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
     public class ProductRepository
     {
          /// <summary>
          /// Retrieve defined product.
          /// </summary>
          /// <param name="productId"></param>
          /// <returns></returns>
          public Product Retrieve(int productId)
          {
               // Create in instance of the Product class
               // Pass in the requested Id
               Product product = new Product(productId);

               // Code to retrieve defined product.

               // Temp hard-code
               if (productId == 2)
               {
                    product.ProductName = "Sunflowers";
                    product.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers.";
                    product.CurrentPrice = 15.96M;
               }

               return product;
          }

          /// <summary>
          /// Saves defined product.
          /// </summary>
          /// <returns></returns>
          public bool Save(Product product)
          {
               var success = true;

               if (product.HasChanges)
               {
                    if (product.IsValid)
                    {
                         if (product.IsNew)
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
