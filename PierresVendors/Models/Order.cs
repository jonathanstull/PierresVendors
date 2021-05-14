using System;
using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Order
  {
    public static void ClearAll()
    {
      _orders.Clear();
    }

    public int OrderNumber { get; set; }
    public int Quantity { get; set; }
    public string Item { get; set; }
    public string DeliveryDate { get; set; }
    private static List<Order> _orders = new List<Order> {};

    public Order(int quantity, string item, string deliveryDate)
    {
      Quantity = quantity;
      Item = item;
      DeliveryDate = deliveryDate;
      OrderNumber = _orders.Count;
      _orders.Add(this);
    }

    public static List<Order> GetAll()
    {
      return _orders;
    }
  }
}