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

    public Order(int orderNumber, int quantity, string item, string deliveryDate)
    {
      OrderNumber = orderNumber;
      Quantity = quantity;
      Item = item;
      DeliveryDate = deliveryDate;
    }
  }
}