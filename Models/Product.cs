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
        private static readonly AutoIncrement _idState = new AutoIncrement();

        // Properties of the product
        public int ProductId { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        /// <summary>
        /// Constructor to initialize a new product
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="price"></param>
        public Product(string name, string description, double price)
        {
            // Generate a new product ID using the AutoIncrement class
            ProductId = _idState.GenerateId();
            Name = name;
            Description = description;
            Price = price;
        }
    }

    /// <summary>
    /// AutoIncrement class to manage incremental IDs
    /// Researched from https://stackoverflow.com/questions/51641722/create-a-c-sharp-method-to-generate-auto-increment-id
    /// </summary>
    public class AutoIncrement
    {
        private int id = 1; // Initial ID value

        /// <summary>
        /// // Method to generate a new ID
        /// </summary>
        /// <returns>The current Id</returns>
        public int GenerateId()
        {
            return id++;
        }
    }
}