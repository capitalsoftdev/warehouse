﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDAL.DataContracts;

namespace WarehouseBL.Interfaces
{
    interface IMunitManager
    {
        IList<Munit> GetMunit();

        Munit GetMunit(int id);
    }
}
