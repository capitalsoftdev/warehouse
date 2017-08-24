using WarehouseDAL.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseBL.Interfaces
{
    interface IRoleManager
    {
        Role GetRoleById(int id);

        IList<Role> GetRoles();
        int CreateOrUpdateRole(Role role);

        int DisableRole(int id);
    }
}
