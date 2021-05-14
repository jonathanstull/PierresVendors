using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;
using System;
using System.Collections.Generic;

namespace PierresVendors.Tests
{
  [TestClass]
  public class OrderTests
  {

    [TestMethod]
    public void First_OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      // Arrange
      Order newOrder = new Order(01, 300, "old fashioneds", "5.14.21");

      // Assert
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void Second_GetDeliveryDate_ReturnsOrderDeliveryDate_String()
    {
      // Arrange
      string deliveryDate = "5.14.21";
      Order newOrder = new Order(01, 300, "old fashioneds", deliveryDate);

      // Act
      string result = newOrder.DeliveryDate;

      // Assert
      Assert.AreEqual(deliveryDate, result);
    }
  }
}