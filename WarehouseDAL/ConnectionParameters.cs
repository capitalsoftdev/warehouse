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
        public static string ConnectionString = @"User Id=sa;Password=1234567;Data Source=DESKTOP-H1FEDPA\SQLEXPRESS;database=Warehouse;Min Pool Size=8;Max Pool Size=50;Pooling=true;Connection Lifetime=150;"; //ConfigurationManager.ConnectionStrings["DB_CONN_STRING"].ConnectionString;//@""
    }
}
