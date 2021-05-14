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
    public void FirstOrderConstructor_CreatesInstanceOfOrder_Order()
    {
      // Arrange
      Order newOrder = new Order(01, 300, "old fashioneds", "5.14.21");

      // Assert
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    
  }
}