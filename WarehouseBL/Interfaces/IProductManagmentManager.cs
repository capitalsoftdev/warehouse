using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDAL.DataContracts;

namespace WarehouseBL.Interfaces
{
    interface IProductManagmentManager
    {
        IList<ProductManagment> GetItem(int id, int userId, int productId);
        int DeleteItem(int id);

        int CreateOrUpdate(ProductManagment prMn);
    }
}
