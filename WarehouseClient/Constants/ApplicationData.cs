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

        public static Dictionary<int, Role> Roles = 
            new Dictionary<int, Role>();

        public static Dictionary<int, RoleGroup> RoleGroups =
            new Dictionary<int, RoleGroup>();

        public static Dictionary<int, ProductCategory> ProductCategory = 
            new Dictionary<int, ProductCategory>();

        public static Dictionary<int, Product> Products = 
            new Dictionary<int, Product>();

        public static Dictionary<int, Munit> Munits =
            new Dictionary<int, Munit>();
    }

    public enum ActionProduct
    {
        Acceptance = 1, //mutq
        Ouptut , // elq
        WriteOff  //dur grum
    }
}
