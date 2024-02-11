using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductInventoryManagement.Models
{
    public class ProductBusinessLogic
    {
        // Get the product list and add a new product to it
        public bool AddProduct(Product product)
        {
            Database database = new Database();

            List<Product> products = database.GetProductsList();

            products.Add(product);

            return true;
        }
    }
}