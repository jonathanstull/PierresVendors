using System;
using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Order
  {

    public int OrderNumber { get; set; }
    public int Quantity { get; set; }
    public string Item { get; set; }
    public string DeliveryDate { get; set; }
    private static List<Order> _orders = new List<Order> { };

    public Order(int OrderNumber, int Quantity, string Item, string DeliveryDate)
    {
      OrderNumber = 9;
      Quantity = 9;
      Item = "croissandwiches";
      DeliveryDate = "daily";
    }
  }
}