using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseClient.Constants
{
    class ApplicationData
    {
        public static Dictionary<int, WWS.User> Users =
            new Dictionary<int, WWS.User>();

        public static Dictionary<int, WWS.Role> Roles = 
            new Dictionary<int, WWS.Role>();

        public static Dictionary<int, WWS.RoleGroup> RoleGroups =
            new Dictionary<int, WWS.RoleGroup>();

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
