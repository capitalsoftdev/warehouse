using WarehouseWebService.DataContracts;

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

        public static WarehouseDAL.DataContracts.Munit ToDatMunit (this Munit munit)
        {
            return new WarehouseDAL.DataContracts.Munit() { Id = munit.Id, MunitName = munit.MunitName, IsActive = munit.IsActive };
        }

        public static Munit ToServiceMunit (this WarehouseDAL.DataContracts.Munit munit)
        {
            return new Munit() { Id = munit.Id, MunitName = munit.MunitName, IsActive = munit.IsActive };

        }
    }
}
