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

    public static List<Order> GetAll()
    {
      int orderNumber = 01;
      int quantity = 300;
      string item = "old fashioneds";
      string deliveryDate = "5.14.21";
      Order newOrder = new Order(orderNumber, quantity, item, deliveryDate);
      Order newOrder2 = new Order(quantity, orderNumber, item, deliveryDate);
      List<Order> orderList = new List<Order> { newOrder, newOrder2 };
      return orderList;
    }
  }
}