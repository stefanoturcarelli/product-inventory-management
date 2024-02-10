using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductInventoryManagement.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        // Login page
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProductRegistration
        // Action to redirect to the form to Add a new Product
        public ActionResult ProductRegistrationForm()
        {
            return RedirectToAction("Index", "ProductRegistration");
        }
    }
}