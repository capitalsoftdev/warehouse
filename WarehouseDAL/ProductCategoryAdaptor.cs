using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseDAL
{
    class ProductCategoryAdaptor
    {
        

        public ProductCategory getProductCategoryById(int id)
        {

            return new ProductCategory();
        }


        public IList<ProductCategory>  getAllProductCategories()
        {
            return new List<ProductCategory>();
        }

        
    }

    public class ProductCategory
    {
        private int id;
        private string name;
        private int parentId;
    }
}
