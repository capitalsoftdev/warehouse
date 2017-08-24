using System.Collections.Generic;
using System.ServiceModel;
using WarehouseWebService.DataContracts;

namespace WarehouseWebService
{
    [ServiceContract(Namespace = "http://www.capitalsoft.am/api/soap/2017/08/22")]
    public interface IWarehouseService
    {
        #region Product

        [OperationContract]
        int CreateOrUpdateProduct(Product product);

        [OperationContract]
        IList<Product> GetProducts();

        [OperationContract]
        Product GetProductById(int id);

        [OperationContract]
        int DisableProduct(int id);

        [OperationContract]
        IList<Product> GetActiveProduct();

        #endregion

        #region Product Management

        [OperationContract]
        IList<ProductManagment> GetItem(int id, int userId, int productId);

        [OperationContract]
        int DeleteItem(int id);

        [OperationContract]
        int CreateOrUpdate(ProductManagment prMn);

        #endregion

        #region Role
        [OperationContract]
        int CreateOrUpdateRole(Role role);

        [OperationContract]
        IList<Role> GetRoles();

        [OperationContract]
        Role GetRoleById(int id);

        [OperationContract]
        int DisableRole(int id);
        #endregion

        #region RoleGroup
        [OperationContract]
        int CreateOrUpdateRoleGroup(RoleGroup roleGroup);

        [OperationContract]
        IList<RoleGroup> GetRoleGroups();

        [OperationContract]
        RoleGroup GetRoleGroupById(int id);

        [OperationContract]
        int DisableRoleGroup(int id);
        #endregion

        #region Munit
        IList<Munit> GetMunits();

        Munit GetMunit(int id);
        #endregion

        #region ProductCategory

        [OperationContract]
        int CreateOrUpdateProductCategory(ProductCategory product);

        [OperationContract]
        IList<ProductCategory> GetAllProductCategories();

        [OperationContract]
        ProductCategory GetProductCategoryById(int id);

        [OperationContract]
        int ManageProductCategory(int id, int action);

        #endregion
    }
}
