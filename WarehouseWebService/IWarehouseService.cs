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

        #region Munit
        IList<Munit> GetMunits();

        Munit GetMunit(int id);
        #endregion
    }
}
