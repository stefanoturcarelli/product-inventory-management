using System.Collections.Generic;

namespace ProductInventoryManagement.Models
{
    public class BatchBusinessLogic
    {
        readonly Database db = new Database();

        public bool AddNewBatchToBatchList(Batch batch)
        {
            List<Batch> batchList = db.GetBatchList();

            batchList.Add(batch);

            return true;
        }
    }
}