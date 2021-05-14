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
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order(01, 300, "old fashioneds", "5.14.21");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    // 2nd test
    [TestMethod]
    public void GetDeliveryDate_ReturnsOrderDeliveryDate_String()
    {
      // Arrange
      string deliveryDate = "5.14.21";
      Order newOrder = new Order(01, 300, "old fashioneds", deliveryDate);

      // Act
      string result = newOrder.DeliveryDate;

      // Assert
      Assert.AreEqual(deliveryDate, result);
    }

    // 3rd test
    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      // Arrange
      int orderNumber = 01;
      int quantity = 300;
      string item = "old fashioneds";
      string deliveryDate = "5.14.21";
      Order newOrder = new Order(orderNumber, quantity, item, deliveryDate);
      Order newOrder2 = new Order(quantity, orderNumber, item, deliveryDate);
      List<Order> orderList = new List<Order> { newOrder, newOrder2 };
      
      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(orderList, result);
    }
  }
}