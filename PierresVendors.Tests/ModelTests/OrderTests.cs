using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;
using System;
using System.Collections.Generic;

namespace PierresVendors.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    // 1st test
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order(300, "old fashioneds", "5.14.21");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    // 2nd test
    [TestMethod]
    public void GetDeliveryDate_ReturnsOrderDeliveryDate_String()
    {
      string deliveryDate = "5.14.21";
      Order newOrder = new Order(300, "old fashioneds", deliveryDate);
      string result = newOrder.DeliveryDate;
      Assert.AreEqual(deliveryDate, result);
    }

    // 3rd test
    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      // Arrange
      int quantity = 300;
      int quantity2 = 150;
      string item = "old fashioneds";
      string deliveryDate = "5.14.21";
      Order newOrder = new Order(quantity, item, deliveryDate);
      Order newOrder2 = new Order(quantity2, item, deliveryDate);
      List<Order> orderList = new List<Order> { newOrder, newOrder2 };
      
      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(orderList, result);
    }
  }
}