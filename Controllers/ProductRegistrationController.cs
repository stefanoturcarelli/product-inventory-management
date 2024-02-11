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

        public ActionResult AddNewRecord(string ProductName, string Description, double Price, int BatchQuantity, DateTime BatchEntryDate)
        {
            Database database = new Database();

            List<Product> productsList = database.GetProductsList();

            List<Batch> batchList = database.GetBatchList();

            MergedRecord m = new MergedRecord(ProductName, Description, Price, BatchQuantity, BatchEntryDate);

            // Add fields to their respective records

            Product product = new Product(m.ProductName, m.Description, m.Price);

            productsList.Add(product);

            Batch batch = new Batch(product.ProductId, BatchQuantity, BatchEntryDate);

            batchList.Add(batch);

            return RedirectToAction("Index");
        }
    }
}