using System;

namespace ProductInventoryManagement.Models
{
    public class CombinedListModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int BatchId { get; set; }
        public int BatchQuantity { get; set; }
        public DateTime BatchEntryDate { get; set; }
        public int ProductId { get; internal set; }
    }
}