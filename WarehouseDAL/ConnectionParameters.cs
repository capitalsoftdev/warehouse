﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseDAL
{
    public static class ConnectionParameters
    {
        public static string ConnectionString = @"Server=DESKTOP-5I3VKAJ;Database=Warehouse; User Id=sa;Password=1234567;"; //ConfigurationManager.ConnectionStrings["LOCAL"].ConnectionString;//@""
    }
}
