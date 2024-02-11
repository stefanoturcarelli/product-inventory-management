using ProductInventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace ProductInventoryManagement.Controllers
{
    public class BatchManagementController : Controller
    {
        // GET: BatchManagement
        public ActionResult Index()
        {
            Database database = new Database();

            var products = database.GetProductsList();

            return View(products);
        }
    }
}