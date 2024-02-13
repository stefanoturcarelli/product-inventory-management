using System.Collections.Generic;
using System.Linq;

namespace ProductInventoryManagement.Models
{
    public class MergedRecordBusinessLogic
    {
        readonly Database db = new Database();

        public List<CombinedListModel> GetCombinedList()
        {
            List<Product> productList = db.GetProductsList();
            List<Batch> batchList = db.GetBatchList();

            var combinedList = productList.Join(batchList,
                product => product.ProductId,
                batch => batch.ProductId,
                (product, batch) => new CombinedListModel
                {
                    ProductId = product.ProductId,
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