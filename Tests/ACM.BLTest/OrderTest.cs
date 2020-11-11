using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
     [TestClass]
     public class OrderTest
     {
          [TestMethod]
          public void ValidateValid()
          {
               //-- Arrange
               var order = new Order
               { 
                    OrderDate = DateTime.Today
               };

               var expected = true;
               //-- Act
               var actual = order.Validate();

               //-- Assert
               Assert.AreEqual(actual, expected);
          }
     }
}
