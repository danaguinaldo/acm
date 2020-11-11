using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
     [TestClass]
     public class OrderItemTest
     {
          [TestMethod]
          public void ValidateValid()
          {
               //-- Arrange
               var orderItem = new OrderItem(new Product(), 1, 10);

               var expected = true;

               //-- Act
               var actual = orderItem.Validate();

               //-- Assert
               Assert.AreEqual(actual, expected);
          }

          [TestMethod]
          public void ProductEmpty()
          {
               //-- Arrange
               var orderItem = new OrderItem
               {
                    Quantity = 1,
                    PurchasePrice = 10
               };

               var expected = false;

               //-- Act
               var actual = orderItem.Validate();

               //-- Assert
               Assert.AreEqual(actual, expected);
          }

          [TestMethod]
          public void QuantityZero()
          {
               //-- Arrange
               var orderItem = new OrderItem
               {
                    OrderProduct = new Product(),
                    Quantity = 0,
                    PurchasePrice = 10
               };

               var expected = false;

               //-- Act
               var actual = orderItem.Validate();

               //-- Assert
               Assert.AreEqual(actual, expected);
          }

          [TestMethod]
          public void QuantityNegative()
          {
               //-- Arrange
               var orderItem = new OrderItem
               {
                    OrderProduct = new Product(),
                    Quantity = -1,
                    PurchasePrice = 10
               };

               var expected = false;

               //-- Act
               var actual = orderItem.Validate();

               //-- Assert
               Assert.AreEqual(actual, expected);
          }

          [TestMethod]
          public void PurchasePriceZero()
          {
               //-- Arrange
               var orderItem = new OrderItem
               {
                    OrderProduct = new Product(),
                    Quantity = 1,
                    PurchasePrice = 0
               };

               var expected = false;

               //-- Act
               var actual = orderItem.Validate();

               //-- Assert
               Assert.AreEqual(actual, expected);
          }

          [TestMethod]
          public void PurchasePriceNegative()
          {
               //-- Arrange
               var orderItem = new OrderItem
               {
                    OrderProduct = new Product(),
                    Quantity = 1,
                    PurchasePrice = -1
               };

               var expected = false;

               //-- Act
               var actual = orderItem.Validate();

               //-- Assert
               Assert.AreEqual(actual, expected);
          }
     }
}
