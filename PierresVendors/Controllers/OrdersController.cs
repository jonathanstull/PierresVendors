using Microsoft.AspNetCore.Mvc;
using PierresVendors.Models;
using System;
using System.Collections.Generic;

namespace PierresVendors.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/vendors/{id}/orders/new")]
    public ActionResult New(int id)
    {
      Vendor currentVendor = Vendor.Find(id);
      return View(currentVendor);
    }

    
  }
}