using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductInventoryManagement.Models
{
    public class Batch
    {
        private static readonly AutoIncrement _inventoryIdState = new AutoIncrement();

        public int BatchId { get; set; }
        public int ProductId { get; set; }
        public int BatchQuantity { get; set; }
        public DateTime BatchEntryDate { get; set; }

        public Batch(int productId, int stockQuantity)
        {
            BatchId = _inventoryIdState.GenerateId();
            ProductId = productId;
            BatchQuantity = stockQuantity;
        }
    }
}