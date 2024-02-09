using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductInventoryManagement.Controllers
{
    public class InventoryManagementController : Controller
    {
        // GET: InventoryManagement
        public ActionResult Index()
        {
            return View();
        }
    }
}