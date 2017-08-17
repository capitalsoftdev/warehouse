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

           /* var product = new WarehouseDAL.DataContracts.Product();
=======
            var product = new Product();
>>>>>>> 62237971cf0e43e3df3d6c127a2d88b7d76db6a8
            product.Munit = 5;
            product.Name = "Dianan";
            product.ProductCategoryId = 5;
            

            var productAdaptor = new ProductAdaptor();
            Console.WriteLine(productAdaptor.CreateOrUpdateProduct(product));
<<<<<<< HEAD
            Console.ReadLine();*/

            //var roleGroupMap = new WarehouseDAL.DataContracts.RoleGroupMap();
            //roleGroupMap.RoleGroupId = 3;
            //roleGroupMap.RoleId = 4;

            //var roleGroupMapAdapter = new RoleGroupMapAdapter();
            //roleGroupMapAdapter.CreateRoleGroupMap(roleGroupMap);

            var productCategory = new WarehouseDAL.DataContracts.ProductCategory();
            productCategory.Id = 9;
            productCategory.ParentId = 11;
            productCategory.Name = "Grich";
        

            var productCategoryAdaptor = new ProductCategoryAdaptor();
            var result = productCategoryAdaptor.CreateOrUpdateProductCategory(productCategory);

          
            Console.WriteLine(result);

            IList<ProductCategory> list = productCategoryAdaptor.GetAllProductCategories();
            int n = 1;

            foreach (ProductCategory products in list)
            {
                // Console.WriteLine(n++);
                Console.WriteLine($"Id={products.Id}, name= {products.Name}");
            }

            ProductCategory productId = productCategoryAdaptor.GetProductCategoryById(1);
            Console.WriteLine(productId.Id);



            //IList<Product> list = productAdaptor.GetProduct();

            //foreach (Product products in list)
            //{
            //    Console.WriteLine(products);
            //}

            //Product productId = productAdaptor.GetProduct(1003);
            //Console.WriteLine(productId);


            Console.ReadLine();


        }
    }
}
