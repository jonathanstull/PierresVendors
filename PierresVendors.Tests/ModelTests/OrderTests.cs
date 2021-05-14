using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;
using System;
using System.Collections.Generic;

namespace PierresVendors.Tests
{
  [TestClass]
  public class OrderTests
  {

    // 1st test
    [TestMethod]
    public void First_OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order(01, 300, "old fashioneds", "5.14.21");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    // 2nd test
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