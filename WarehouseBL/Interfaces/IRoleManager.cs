using DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseBL.Interfaces
{
    interface IRoleManager
    {
        Role GetRole(int id);

        IList<Role> GetRole();
        int CreateOrUpdateRole(Role role);

        int DisableRole(int id);
    }
}
