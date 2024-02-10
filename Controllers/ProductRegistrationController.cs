using ProductInventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductInventoryManagement.Controllers
{
    public class ProductRegistrationController : Controller
    {
        // GET: ProductRegistration
        public ActionResult Index()
        {
            return View();
        }

        // GET: BatchManagement
        // Redirect to the index page of inventory
        public ActionResult DisplayBatchTable()
        {
            return RedirectToAction("Index", "BatchManagement");
        }
    }
}