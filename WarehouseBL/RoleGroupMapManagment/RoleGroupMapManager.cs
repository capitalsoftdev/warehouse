using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBL.Interfaces;
using WarehouseDAL;
using WarehouseDAL.DataContracts;

namespace WarehouseBL.RoleGroupMapManagment
{
    class RoleGroupMapManager:IRoleGroupMapManger
    {
      public int CreateRoleGroupMap(RoleGroupMap roleGroupMap) {
            var roleGroupAdaper = new RoleGroupMapAdapter();
            return roleGroupAdaper.CreateRoleGroupMap(roleGroupMap);

        }
    }
}
