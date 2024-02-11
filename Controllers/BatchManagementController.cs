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
           MergedBusinessLogic mergedBusinessLogic = new MergedBusinessLogic();

            var combinedList = mergedBusinessLogic.GetCombinedList();

            return View(combinedList);
        }
    }
}