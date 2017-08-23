using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseClient.Constants
{
     class ApplicationData
    {
        public static Dictionary<int, WarehouseDAL.DataContracts.User> Users = new Dictionary<int, WarehouseDAL.DataContracts.User>();
        public static Dictionary<int, WarehouseDAL.DataContracts.Role> Roles = new Dictionary<int, WarehouseDAL.DataContracts.Role>();
        public static Dictionary<int, WarehouseDAL.DataContracts.ProductCategory> ProductCategory = new Dictionary<int, WarehouseDAL.DataContracts.ProductCategory>();
        public static Dictionary<int, WarehouseDAL.DataContracts.Product> Products = new Dictionary<int, WarehouseDAL.DataContracts.Product>();
    }

    public enum ActionProduct
    {
        Acceptance = 1, //mutq
        Ouptut , // elq
        WriteOff  //dur grum
    }
}
