using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductInventoryManagement.Models
{
    public class Batch
    {
        private static readonly AutoIncrement _batchIdState = new AutoIncrement();

        public int BatchId { get; set; }
        public int ProductId { get; set; }
        public int BatchQuantity { get; set; }
        public DateTime BatchEntryDate { get; set; }

        public Batch(int productId, int batchQuantity, DateTime batchEntryDate)
        {
            BatchId = _batchIdState.GenerateId();
            ProductId = productId;
            BatchQuantity = batchQuantity;
            BatchEntryDate = batchEntryDate;
        }
    }
}