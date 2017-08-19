using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBL.ProductManagmentManagment;
namespace WarehouseWebService
{
    class ProductManagmentService : IProductManagmentService
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
