using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDAL.DataContracts;

namespace WarehouseBL.Interfaces
{
    interface IProductManager
    {
        int CreateOrUpdateProduct(Product product);

        IList<Product> GetProduct();

        Product GetProduct(int id);

        int DisableProduct(int id);
    }
}
