using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBL.Interfaces;
using WarehouseDAL;
using WarehouseDAL.DataContracts;

namespace WarehouseBL.ProductManagement
{
    public class ProductManager : IProductManager
    {
        public int CreateOrUpdateProduct(Product product)
        {
            var productAdaptor = new ProductAdaptor();

            var result = productAdaptor.CreateOrUpdateProduct(product);

            return result;
        }

        public int DisableProduct(int id)
        {
            var productAdaptor = new ProductAdaptor();

            var result = productAdaptor.DisableProduct(id);

            return result;
            
        }

        public IList<Product> GetActiveProduct()
        {
            var productAdaptor = new ProductAdaptor();

            var result = productAdaptor.GetActiveProduct();

            return result;
        }

        public IList<Product> GetProduct()
        {
            var productAdaptor = new ProductAdaptor();

            var result = productAdaptor.GetProduct();

            return result;
        }

        public Product GetProduct(int id)
        {
            var productAdaptor = new ProductAdaptor();

            var result = productAdaptor.GetProduct(id);

            return result;
        }

    }
}
