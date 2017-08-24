using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDAL.DataContracts;
using WarehouseBL.Interfaces;
using WarehouseDAL;

namespace WarehouseBL.RoleGroupManagement
{
    public class RoleGroupManager : IRoleGroupMangaer
    {
        public int CreateOrUpdateRoleGroup(RoleGroup roleGroup)
        {
            RoleGroupAdapter roleGroupAdapter = new RoleGroupAdapter();
            return roleGroupAdapter.CreateOrUpdateRole(roleGroup);
        }

        public int DisableRoleGroup(int id)
        {
            RoleAdapter roleAdapter = new RoleAdapter();
            return roleAdapter.Disable(id);
        }

        public RoleGroup GetRoleGroupById(int id)
        {
            RoleGroupAdapter roleGroupAdapter = new RoleGroupAdapter();

            return roleGroupAdapter.GetRoleGroup(id);
        }

        public IList<RoleGroup> GetRoleGroups()
        {
            RoleGroupAdapter roleGroupAdapter = new RoleGroupAdapter();

            return roleGroupAdapter.GetRoleGroup();
        }
    }
}
