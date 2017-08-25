using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseClient.WWS;

namespace WarehouseClient.Constants
{
    class ApplicationData
    {
        public static Dictionary<int, User> Users =
            new Dictionary<int, User>();

        public static Dictionary<int, WarehouseDAL.DataContracts.Role> Roles = 
            new Dictionary<int, WarehouseDAL.DataContracts.Role>();

        public static Dictionary<int, WarehouseDAL.DataContracts.RoleGroup> RoleGroups =
            new Dictionary<int, WarehouseDAL.DataContracts.RoleGroup>();

        public static Dictionary<int, WarehouseDAL.DataContracts.ProductCategory> ProductCategory = 
            new Dictionary<int, WarehouseDAL.DataContracts.ProductCategory>();

        public static Dictionary<int, WarehouseDAL.DataContracts.Product> Products = 
            new Dictionary<int, WarehouseDAL.DataContracts.Product>();

        public static Dictionary<int, WarehouseDAL.DataContracts.Munit> Munits =
            new Dictionary<int, WarehouseDAL.DataContracts.Munit>();
    }

    public enum ActionProduct
    {
        Acceptance = 1, //mutq
        Ouptut , // elq
        WriteOff  //dur grum
    }
}
