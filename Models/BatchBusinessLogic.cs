using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductInventoryManagement.Models
{
    public class BatchBusinessLogic
    {
        // Method to add a new product to batch
        public static void AddProductToBatch(int productId)
        {
            Console.WriteLine($"New product added to batch with ProductId: {productId}");
        }
    }
}