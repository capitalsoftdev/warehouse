using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WarehouseBL.ProductManagement;


namespace WarehouseWebService
{
    class ProductService : IProductService
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

        public IList<Product> GetProduct()
        {
            var productManager = new ProductManager();

            return productManager.GetProduct().Select(p => p.ToServiceProduct()).ToList();
        }

        public Product GetProduct(int id)
        {
            var productManager = new ProductManager();

            return productManager.GetProduct(id).ToServiceProduct();
        }
    }
}
