using System.Collections.Generic;
using System.Linq;
using WarehouseBL.RoleManagement;
using WarehouseWebService.DataContracts;

namespace WarehouseWebService
{
    public partial class WarehouseService
    {
        public int CreateOrUpdateRole(Role role)
        {
            var roleManager = new RoleManager();

            return roleManager.CreateOrUpdateRole(role.ToDALRole());
        }

        public Role GetRoleById(int id)
        {
            var roleManager = new RoleManager();

            return roleManager.GetRoleById(id).ToServiceRole();
        }

        public IList<Role> GetRoles()
        {
            var roleManager = new RoleManager();

            return roleManager.GetRoles().Select(p => p.ToServiceRole()).ToList();
        }

        public int DisableRole(int id)
        {
            var roleManager = new RoleManager();

            return roleManager.DisableRole(id);
        }
    }
}
