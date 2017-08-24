using System.Collections.Generic;
using System.Linq;
using WarehouseBL.RoleGroupManagement;
using WarehouseWebService.DataContracts;

namespace WarehouseWebService
{
    public partial class WarehouseService
    {
        public int CreateOrUpdateRoleGroup(RoleGroup roleGroup)
        {
            var roleGroupManager = new RoleGroupManager();

            return roleGroupManager.CreateOrUpdateRoleGroup(roleGroup.ToDALRoleGroup());
        }

        public RoleGroup GetRoleGroupById(int id)
        {
            var roleGroupManager = new RoleGroupManager();

            return roleGroupManager.GetRoleGroupById(id).ToServiceRoleGroup();
        }

        public IList<RoleGroup> GetRoleGroups()
        {
            var roleGroupManager = new RoleGroupManager();

            return roleGroupManager.GetRoleGroups().Select(p => p.ToServiceRoleGroup()).ToList();
        }

        public int DisableRoleGroup(int id)
        {
            var roleGroupManager = new RoleGroupManager();

            return roleGroupManager.DisableRoleGroup(id);
        }
    }
}
