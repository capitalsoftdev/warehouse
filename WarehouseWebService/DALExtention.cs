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

        public static WarehouseDAL.DataContracts.ProductManagment ToDALProductManagment(this ProductManagment prMn)
        {
            return new WarehouseDAL.DataContracts.ProductManagment() { Id = prMn.Id, ProductId = prMn.ProductId, Quantity = prMn.Quantity, ActionDate = prMn.ActionDate, Action = prMn.Action, UserId = prMn.UserId, Reason = prMn.Reason, Price = prMn.Price, SupplierId = prMn.SupplierId, Brand = prMn.Brand, LastModifyDate = prMn.LastModifyDate, IsActive = prMn.IsActive };
        }

        public static ProductManagment ToServiceProductManagment(this WarehouseDAL.DataContracts.ProductManagment prMn)
        {
            return new ProductManagment() { Id = prMn.Id, ProductId = prMn.ProductId, Quantity = prMn.Quantity, ActionDate = prMn.ActionDate, Action = prMn.Action, UserId = prMn.UserId, Reason = prMn.Reason, Price = prMn.Price, SupplierId = prMn.SupplierId, Brand = prMn.Brand, LastModifyDate = prMn.LastModifyDate, IsActive = prMn.IsActive };

        }
    }
}
