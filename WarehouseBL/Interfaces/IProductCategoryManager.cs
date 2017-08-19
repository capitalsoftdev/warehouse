using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDAL.DataContracts;

namespace WarehouseBL.Interfaces
{
    interface IProductCategoryManager
    {
        int CreateOrUpdateProductCategory(ProductCategory product);

        IList<ProductCategory> GetAllProductCategories();

        ProductCategory GetProductCategoryById(int id);

        int ManageProductCategory(int id, int action);
    }
}
