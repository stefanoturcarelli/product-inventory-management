using ProductInventoryManagement.Models;
using System;
using System.Collections.Generic;
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

        public ActionResult AddProduct(string ProductName, string Description, double Price)
        {
            ProductBusinessLogic productBusinessLogic = new ProductBusinessLogic();

            Product product = new Product(ProductName, Description, Price);

            if (productBusinessLogic.AddProduct(product))
            {
                return RedirectToAction("Index");
            }

            return null;
        }
    }
}