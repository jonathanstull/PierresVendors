using Microsoft.AspNetCore.Mvc;
using PierresVendors.Models;
using System;
using System.Collections.Generic;

namespace PierresVendors.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
  }
}