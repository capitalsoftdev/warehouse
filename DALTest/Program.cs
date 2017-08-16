using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDAL;
using WarehouseDAL.DataContracts;


namespace DALTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product();
            product.Munit = 5;
            product.Name = "Dianan";
            product.ProductCategoryId = 10;
            

            var productAdaptor = new ProductAdaptor();
            Console.WriteLine(productAdaptor.CreateOrUpdateProduct(product));


            IList<Product> list = productAdaptor.GetProduct();

            foreach(Product products in list)
            {
                Console.WriteLine(products);
            }

            Product productId = productAdaptor.GetProduct(1003);
            Console.WriteLine(productId);

            Console.ReadLine();
            

        }
    }
}
