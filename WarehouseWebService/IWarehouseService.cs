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
        IList<Product> GetProduct();

        [OperationContract]
        Product GetProduct(int id);

        [OperationContract]
        int DisableProduct(int id);

        #endregion

        #region Product Management

        [OperationContract]
        IList<ProductManagment> GetItem(int id, int userId, int productId);

        [OperationContract]
        int DeleteItem(int id);

        [OperationContract]
        int CreateOrUpdate(ProductManagment prMn);

        #endregion
    }
}
