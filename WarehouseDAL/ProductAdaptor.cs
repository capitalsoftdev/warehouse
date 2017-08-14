using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseDAL
{
    class ProductAdaptor
    {
        
        public int CreateOrUpdateProduct(Product product)
        {
            return 0;
        }

        public IList<Product> GetProduct()
        {
            return new List<Product>();
        }

        public Product GetProduct(int id)
        {
            return new Product();
        }


    }
}
