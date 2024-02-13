using System.Collections.Generic;

namespace ProductInventoryManagement.Models
{
    public class ProductBusinessLogic
    {
        readonly Database db = new Database();

        public bool AddProductToProductList(Product product)
        {
            List<Product> productList = db.GetProductsList();

            productList.Add(product);

            return true;
        }
    }
}