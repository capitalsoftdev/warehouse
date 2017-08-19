using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseWebService
{
    public static class DALExtention
    {
        public static WarehouseDAL.DataContracts.Product ToDALProduct(this Product product)
        {
            return new WarehouseDAL.DataContracts.Product() { Id = product.Id, Name = product.Name, ProductCategoryId = product.ProductCategoryId, Munit = product.Munit, IsActive = product.IsActive };
        }

        public static Product ToServiceProduct(this WarehouseDAL.DataContracts.Product product)
        {
            return new Product() { Id = product.Id, Name = product.Name, ProductCategoryId = product.ProductCategoryId, Munit = product.Munit, IsActive = product.IsActive };
        }
    }
}
