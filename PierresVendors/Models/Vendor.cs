using System;
using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Vendor
  {
    public string Name;
    public string Description;
    public int Id { get; set; }
    public List<Order> Orders { get; set; }
    private static List<Vendor> _vendors = new List<Vendor> {};

    public Vendor(string name, string description)
    {
      Id = 5;
      Name = name;
      Description = "ain't nothin' to see here";
      // Orders = "mmmmmmmhmm";
    }

  }
}