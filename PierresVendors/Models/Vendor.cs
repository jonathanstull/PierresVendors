using System;
using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Vendor
  {
    public static void ClearAll()
    {
      _vendors.Clear();
    }

    public string Name;
    public string Description;
    public int Id { get; set; }
    public List<Order> Orders { get; set; }
    private static List<Vendor> _vendors = new List<Vendor> {};

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      Orders = new List<Order> {};
      _vendors.Add(this);
      Id = _vendors.Count;
    }

  }
}