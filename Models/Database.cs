using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace ProductInventoryManagement.Models
{
    public static class Database
    {
        // Collections
        public static List<Product> productList = new List<Product>()
        {
            // Add a sample product
            new Product("Chocolate", "100% Organic", 9.99)
        };

        public static List<Batch> batchList = new List<Batch>();

        // Get product list 
        public static List<Product> GetProductList()
        {
            return productList;
        }
    }
}
