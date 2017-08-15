using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDAL;

namespace DALTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new WarehouseDAL.DataContracts.Product();
            product.Munit = 5;
            product.Name = "Katukashka";
            product.ProductCategoryId = 5;
            

            var productAdaptor = new ProductAdaptor();
            Console.WriteLine(productAdaptor.CreateOrUpdateProduct(product));
            Console.ReadLine();


        }
    }
}
