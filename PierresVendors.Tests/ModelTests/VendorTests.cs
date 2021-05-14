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
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor", "test description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "test vendor";
      Vendor newVendor = new Vendor(name, "test description");
      string result = newVendor.Name;
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

      // Assert
      Assert.AreEqual(testId, newVendor.Id);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      // Arrange
      string name = "RAAAAANDY'S ROCKSTARS";
      string description = "Up-tempo energy drink specialist; orders 300 daily old fashioneds; avoid direct interaction";
      string name2 = "Broder Nord";
      string description2 = "upscale cafe; orders 2 weekly sourdough starters";
      Vendor newVendor1 = new Vendor(name, description);
      Vendor newVendor2 = new Vendor(name2, description2);

      // Act
      List<Vendor> vendorsList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();

      // Assert
      CollectionAssert.AreEqual(vendorsList, result);
    }


  }
}