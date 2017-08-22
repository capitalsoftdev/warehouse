using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDAL.DataContracts;
using WarehouseBL.Interfaces;
using WarehouseDAL;

namespace WarehouseBL.RoleManagement
{
    public class RoleManager : IRoleManager
    {
        public int CreateOrUpdateRole(Role role)
        {
            RoleAdapter roleAdapter = new RoleAdapter();

            return roleAdapter.CreateOrUpdateRole(role);
        }

        public Role GetRole(int id)
        {
            RoleAdapter roleAdapter = new RoleAdapter();

            return roleAdapter.GetRole(id);
        }

        public IList<Role> GetRole()
        {
            RoleAdapter roleAdapter = new RoleAdapter();

            return roleAdapter.GetRole();
        }

        public int DisableRole(int id)
        {
            RoleAdapter roleAdapter = new RoleAdapter();
            return roleAdapter.Disable(id);
        }
    }
}
