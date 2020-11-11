using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
     [TestClass]
     public class ProductTest
     {
          [TestMethod]
          public void ValidateValid()
          {
               //-- Arrange
               var product = new Product
               {
                    ProductName = "Shovel",
                    CurrentPrice = 10.00M
               };

               var expected = true;

               //-- Act
               var actual = product.Validate();

               //-- Assert
               Assert.AreEqual(expected, actual);
          }

          [TestMethod]
          public void ValidateMissingProductName()
          {
               //-- Arrange
               var product = new Product
               {
                    CurrentPrice = 10.00M
               };

               var expected = false;

               //-- Act
               var actual = product.Validate();

               //-- Assert
               Assert.AreEqual(expected, actual);
          }

          [TestMethod]
          public void MissingCurrentPrice()
          {
               //-- Arrange
               var product = new Product
               {
                    ProductName = "Shovel"
               };

               var expected = false;

               //-- Act
               var actual = product.Validate();

               //-- Assert
               Assert.AreEqual(expected, actual);
          }
     }
}
