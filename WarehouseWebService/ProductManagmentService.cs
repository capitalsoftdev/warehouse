using System.Collections.Generic;
using System.Linq;
using WarehouseBL.ProductManagmentManagment;
using WarehouseWebService.DataContracts;

namespace WarehouseWebService
{
    public partial class WarehouseService
    {
        public int CreateOrUpdate(ProductManagment prMn)
        {
            var productManag = new ProductManagmentManager();
            return productManag.CreateOrUpdate(prMn.ToDALProductManagment());
        }

        public int DeleteItem(int id)
        {
            var productManag = new ProductManagmentManager();
            return productManag.DeleteItem(id);
        }

        public IList<ProductManagment> GetItem(int id, int userId, int productId)
        {
            var productManag = new ProductManagmentManager();
            return productManag.GetItem(id, userId, productId).Select(pm => pm.ToServiceProductManagment()).ToList();
        }
    }
}
