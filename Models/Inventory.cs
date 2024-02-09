using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductInventoryManagement.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public int ProductId { get; set; }
        public int StockQuantity { get; set; }

        public Inventory(int inventoryId, int productId, int stockQuantity)
        {
            InventoryId = inventoryId;
            ProductId = productId;
            StockQuantity = stockQuantity;
        }
    }
}