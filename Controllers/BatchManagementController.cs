using ProductInventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductInventoryManagement.Controllers
{
    public class BatchManagementController : Controller
    {
        // GET: BatchManagement
        public ActionResult Index()
        {
            return View();
        }
    }
}