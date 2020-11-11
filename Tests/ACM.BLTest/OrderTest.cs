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
               var order = new Order(1);

               var expected = true;
               //-- Act
               var actual = order.Validate();

               //-- Assert
               Assert.AreEqual(actual, expected);
          }

          [TestMethod]
          public void OrderNumberNegativeNumber()
          {
               //-- Arrange
               var order = new Order(-1);

               var expected = false;

               //-- Act
               var actual = order.Validate();

               //-- Assert
               Assert.AreEqual(actual, expected);
          }

          [TestMethod]
          public void OrderNumberMissing()
          {
               //-- Arrange
               var order = new Order();

               var expected = false;

               //-- Act
               var actual = order.Validate();

               //-- Assert
               Assert.AreEqual(actual, expected);
          }
     }
}
