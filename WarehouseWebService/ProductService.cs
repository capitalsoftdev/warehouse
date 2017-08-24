using System.Collections.Generic;
using System.Linq;
using WarehouseBL.ProductManagement;
using WarehouseWebService.DataContracts;

namespace WarehouseWebService
{
    public partial class WarehouseService
    {
        public int CreateOrUpdateProduct(Product product)
        {
            var productManager = new ProductManager();

            return  productManager.CreateOrUpdateProduct(product.ToDALProduct());
        }

        public int DisableProduct(int id)
        {
            var productManager = new ProductManager();

            return productManager.DisableProduct(id);
        }

        public IList<Product> GetProducts()
        {
            var productManager = new ProductManager();

            return productManager.GetProduct().Select(p => p.ToServiceProduct()).ToList();
        }

        public Product GetProduct(int id)
        {
            var productManager = new ProductManager();

            return productManager.GetProduct(id).ToServiceProduct();
        }

        public IList<Product> GetActiveProduct()
        {
            var productManager = new ProductManager();

            return productManager.GetActiveProduct().Select(p => p.ToServiceProduct()).ToList();
            
        }
    }
}
