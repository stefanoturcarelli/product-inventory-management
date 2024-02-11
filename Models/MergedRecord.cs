using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductInventoryManagement.Models
{
    public class MergedRecord
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int BatchQuantity { get; set; }
        public DateTime BatchEntryDate { get; set; }

        public MergedRecord(string productName, string description, double price, int batchQuantity, DateTime batchEntryDate)
        {
            ProductName = productName;
            Description = description;
            Price = price;
            BatchQuantity = batchQuantity;
            BatchEntryDate = batchEntryDate;
        }
    }
}