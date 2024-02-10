using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductInventoryManagement.Models
{
    public class ProductViewModel
    {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public decimal ProductPrice { get; set; }
            public int ProductQuantity { get; set; }
            public int InventoryID { get; set; }
    }
}