using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;
using System;
using System.Collections.Generic;

namespace PierresVendors.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor", "test description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      // Arrange
      string name = "test vendor";
      Vendor newVendor = new Vendor(name, "test description");
      
      // Act
      string result = newVendor.Name;

      // Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorIdAmongOtherThings_IntId()
    {
      // Arrange
      string name = "Breakneck Bistro";
      string description = "Cafeteria-service bistro; orders 5 dozen daily pastries";
      List<Order> vendorOrders = new List<Order> {};

      // Act
      int testId = 1;
      Vendor newVendor = new Vendor(name, description);

      // 
      Assert.AreEqual(testId, newVendor.Id);
    }


  }
}