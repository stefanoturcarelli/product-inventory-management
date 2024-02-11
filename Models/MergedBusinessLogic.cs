using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductInventoryManagement.Models
{
    public class MergedBusinessLogic
    {
        readonly Database db = new Database();

        public bool AddProductToProductList(Product product)
        {
            List<Product> productList = db.GetProductsList();

            productList.Add(product);

            return true;
        }

        public bool AddNewBatchToBatchList(Batch batch)
        {
            List<Batch> batchList = db.GetBatchList();

            batchList.Add(batch);

            return true;
        }
    }
}