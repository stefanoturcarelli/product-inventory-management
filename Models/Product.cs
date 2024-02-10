using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductInventoryManagement.Models
{
    /// <summary>
    /// Product class representing a product item
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Static instance of AutoIncrement class to manage product IDs
        /// 
        /// readonly modifier researched from 
        /// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/readonly
        /// </summary>
        private static readonly AutoIncrement _productIdState = new AutoIncrement();


        // Properties of the product
        public int ProductId { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        // Constructor
        public Product(string name, string description, double price)
        {
            ProductId = _productIdState.GenerateId();
            Name = name;
            Description = description;
            Price = price;
        }
    }
}