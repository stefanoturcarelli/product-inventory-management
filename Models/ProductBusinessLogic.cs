using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductInventoryManagement.Models
{
    public class ProductBusinessLogic
    {

        // Create inventory list with products to be displayed
        public static List<Product> productList = new List<Product>()
        {
            // Add a sample product
            new Product("Chocolate", "100% Organic", 9.99)
        };


        // Method to add a product to the inventory list
        public bool AddProduct(Product product)
        {
            productList.Add(product);

            return true;
        }
    }
}