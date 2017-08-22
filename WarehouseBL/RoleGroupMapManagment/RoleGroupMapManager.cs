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
  public class RoleGroupMapManager:IRoleGroupMapManger
    {
      public int CreateRoleGroupMap(RoleGroupMap roleGroupMap) {
            var roleGroupAdaper = new RoleGroupMapAdapter();
            return roleGroupAdaper.CreateRoleGroupMap(roleGroupMap);

        }
        public IList<RoleGroupMap> GetRoleGroupMap()
        {
            var roleGroupAdaptor = new RoleGroupMapAdapter();

            var result = roleGroupAdaptor.GetRoleGroupI();

            return result;
        }

    }
}
