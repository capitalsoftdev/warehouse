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
            var prMn = new ProductManagment();
            var prMnAdaptor = new ProductManagmentAdapter();


            //Console.WriteLine(prMnAdaptor.DeleteItem(12));

            //IList<WarehouseDAL.DataContracts.ProductManagment> list = prMnAdaptor.GetItem(0, 0, 1);
            //foreach (WarehouseDAL.DataContracts.ProductManagment l in list)
            //{
            //    Console.WriteLine(l);
            //}

            //prMn.Id = 17;
            //prMn.ProductId = 545;
            //prMn.Quantity = 88852;
            //prMn.ActionDate = new DateTime(2021, 06, 4);
            //prMn.Action = 4;
            //prMn.UserId = 5;
            //prMn.Reason = "readgdfhcgj";
            //prMn.Price = 545;
            //prMn.SupplierId = 4;
            //prMn.Brand = "brandsfgdsghg";
        //    prMn.LastModifyDate = new DateTime(2014, 04, 22);
            //prMn.IsActive = true;

      //      Console.WriteLine(prMnAdaptor.GetItem(0, 0, 7));
            foreach(var elem in prMnAdaptor.GetItem(0, 6, 0))
            {
                Console.WriteLine(elem.ProductId);
            }
            Console.ReadLine(); 

        }
    }
}
