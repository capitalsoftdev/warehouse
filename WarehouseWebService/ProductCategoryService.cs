using System.Collections.Generic;
using System.Linq;
using WarehouseBL.ProductCategoryManagement;
using WarehouseWebService.DataContracts;

namespace WarehouseWebService
{
    public partial class WarehouseService
    {
        public int CreateOrUpdateProductCategory(ProductCategory productCategory)
        {
            var productCategoryManager = new ProductCategoryManager();

            return productCategoryManager.CreateOrUpdateProductCategory(productCategory.ToDALProductCategory());
        }

        public int ManageProductCategory(int id,int action)
        {
            var productCategoryManager = new ProductCategoryManager();

            return productCategoryManager.ManageProductCategory(id, action);
        }

        public IList<ProductCategory> GetAllProductCategories()
        {
            var productCategoryManager = new ProductCategoryManager();

            return productCategoryManager.GetAllProductCategories().Select(p => p.ToServiceProductCategory()).ToList();
        }

        public ProductCategory GetProductCategoryById(int id)
        {
            var productCategoryManager = new ProductCategoryManager();

            return productCategoryManager.GetProductCategoryById(id).ToServiceProductCategory();
           
        }
    }
}
