using ProductInventoryManagement.Models;
using System.Web.Mvc;

namespace ProductInventoryManagement.Controllers
{
    public class BatchManagementController : Controller
    {
        // GET: BatchManagement
        public ActionResult Index()
        {
            MergedRecordBusinessLogic mergedBusinessLogic = new MergedRecordBusinessLogic();

            var combinedList = mergedBusinessLogic.GetCombinedList();

            return View(combinedList);
        }

        public ActionResult DeleteRecord(int productId)
        {
            Database db = new Database();

            db.GetProductsList().Remove(db.GetProductsList().Find(x => x.ProductId == productId));

            db.GetBatchList().Remove(db.GetBatchList().Find(x => x.ProductId == productId));

            return RedirectToAction("Index");
        }
    }
}