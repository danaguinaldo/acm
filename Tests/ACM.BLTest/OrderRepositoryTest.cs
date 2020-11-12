using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
     [TestClass]
     public class OrderRepositoryTest
     {
          [TestMethod]
          public void RetrieveValid()
          {
               //-- Arrange
               var orderRepository = new OrderRepository();
               var expected = new Order
               {
                    OrderDate = new DateTimeOffset(DateTime.Today)
               };

               //-- Act
               var actual = orderRepository.Retrieve(10);

               //-- Assert
               Assert.AreEqual(actual.OrderDate, expected.OrderDate);
          }
     }
}
