using System.Collections.Generic;

namespace ProductInventoryManagement.Models
{
    public class Database
    {
        // Collections
        public static List<Product> productList = new List<Product>();

        public static List<Batch> batchList = new List<Batch>();

        public List<Product> GetProductsList()
        {
            return productList;
        }

        public List<Batch> GetBatchList()
        {
            return batchList;
        }
    }
}
