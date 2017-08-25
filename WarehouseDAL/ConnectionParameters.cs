using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseDAL
{
    public static class ConnectionParameters
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["DB_CONN_STRING"].ConnectionString;//@""
    }
}
