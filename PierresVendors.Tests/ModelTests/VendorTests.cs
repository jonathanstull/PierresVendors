using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;
using System;
using System.Collections.Generic;

namespace PierresVendors.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void FirstVendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor", "test description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void SecondGetName_ReturnsName_String()
    {
      string name = "test vendor";
      Vendor newVendor = new Vendor(name, "test description");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void ThirdGetId_ReturnsVendorIdAmongOtherThings_IntId()
    {
      string name = "Breakneck Bistro";
      string description = "Cafeteria-service bistro; orders 5 dozen daily pastries";
      List<Order> vendorOrders = new List<Order> {};
      int testId = 1;
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(testId, newVendor.Id);
    }

    [TestMethod]
    public void FourthGetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name = "RAAAAANDY'S ROCKSTARS";
      string description = "Up-tempo energy drink specialist; orders 300 daily old fashioneds; avoid direct interaction";
      string name2 = "Broder Nord";
      string description2 = "upscale cafe; orders 2 weekly sourdough starters";
      Vendor newVendor1 = new Vendor(name, description);
      Vendor newVendor2 = new Vendor(name2, description2);
      List<Vendor> vendorsList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(vendorsList, result);
    }

    [TestMethod]
    public void FifthFind_ReturnsCorrectVendorById_Vendor()
    {
      // Arrange
      string name = "RAAAAANDY'S ROCKSTARS";
      string description = "Up-tempo energy drink specialist; orders 300 daily old fashioneds; avoid direct interaction";
      string name2 = "Broder Nord";
      string description2 = "upscale cafe; orders 2 weekly sourdough starters";
      
      // Act
      Vendor newVendor1 = new Vendor(name, description);
      Vendor newVendor2 = new Vendor(name2, description2);
      Vendor foundVendor = Vendor.Find(2);

      // Assert
      Assert.AreEqual(newVendor2, foundVendor);
    }

    [TestMethod]
    public void SixthAddItem_AssociatesOrderWithVendor_OrderList()
    {
      // Arrange
      int orderNumber = 01;
      int quantity = 300;
      string item = "old fashioneds";
      string deliveryDate = "5.14.21";
      Order newOrder = new Order(orderNumber, quantity, item, deliveryDate);
      List<Order> orders = new List<Order> { newOrder };
      string name = "RAAAAANDY'S ROCKSTARS";
      string description = "Up-tempo energy drink specialist; orders 300 daily old fashioneds; avoid direct interaction";
      Vendor randyAgain = new Vendor(name, description);

      // Act
      randyAgain.AddOrder(newOrder);
      List<Order> result = randyAgain.Orders;

      // Assert
      CollectionAssert.AreEqual(orders, result);
    }


  }
}