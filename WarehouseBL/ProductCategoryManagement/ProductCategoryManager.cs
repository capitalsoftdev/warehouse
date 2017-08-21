using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBL.Interfaces;
using WarehouseDAL;
using WarehouseDAL.DataContracts;

namespace WarehouseBL.ProductCategoryManagement
{
    public class ProductCategoryManager: IProductCategoryManager
    {
        public int CreateOrUpdateProductCategory(ProductCategory product)
        {
            var productCategoryAdaptor = new ProductCategoryAdaptor();

            var result = productCategoryAdaptor.CreateOrUpdateProductCategory(product);

            return result;
        }

        public int ManageProductCategory(int id, int action)
        {
            var productCategoryAdaptor = new ProductCategoryAdaptor();

            var result = productCategoryAdaptor.ManageProductCategory(id, action);

            return result;

        }

        public IList<ProductCategory> GetAllProductCategories()
        {
            var productCategoryAdaptor = new ProductCategoryAdaptor();

            var result = productCategoryAdaptor.GetAllProductCategories();

            return result;
        }

        public ProductCategory GetProductCategoryById(int id)
        {
            var productCategoryAdaptor = new ProductCategoryAdaptor();

            var result = productCategoryAdaptor.GetProductCategoryById(id);

            return result;
        }
    }
}