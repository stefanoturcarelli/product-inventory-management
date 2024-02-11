using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        public List<CombinedListModel> GetCombinedList()
        {
            List<Product> productList = db.GetProductsList();
            List<Batch> batchList = db.GetBatchList();

            var combinedList = productList.Join(batchList,
                product => product.ProductId,
                batch => batch.ProductId,
                (product, batch) => new CombinedListModel
                {
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    BatchId = batch.BatchId,
                    BatchQuantity = batch.BatchQuantity,
                    BatchEntryDate = batch.BatchEntryDate,
                }).ToList();

            return combinedList;
        }
    }
}