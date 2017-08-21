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
        public static string ConnectionString = @"Server=DESKTOP-3FSOTT0\SQLEXPRESS;Database=Warehouse; User Id=sa;Password=123456;"; //ConfigurationManager.ConnectionStrings["LOCAL"].ConnectionString;//@""

    }
}
