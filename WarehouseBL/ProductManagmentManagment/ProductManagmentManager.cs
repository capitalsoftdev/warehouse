using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBL.Interfaces;
using WarehouseDAL;
using WarehouseDAL.DataContracts;

namespace WarehouseBL.ProductManagmentManagment
{
    public class ProductManagmentManager : IProductManagmentManager
    {
        public IList<ProductManagment> GetItem(int id, int userId, int productId)
        {
            var productMan = new ProductManagmentAdapter();
            return productMan.GetItem(id, userId, productId);
            
        }

        public int DeleteItem(int id)
        {
            var productMan = new ProductManagmentAdapter();
            return productMan.DeleteItem(id);
        }

        public int CreateOrUpdate(ProductManagment prMn)
        {
            var productMan = new ProductManagmentAdapter();
            return productMan.CreateOrUpdate(prMn);
        }
    }
}
