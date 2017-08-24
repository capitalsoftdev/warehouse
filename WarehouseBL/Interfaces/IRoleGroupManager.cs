using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDAL.DataContracts;

namespace WarehouseBL.Interfaces
{
    interface IRoleGroupMangaer
    {
        RoleGroup GetRoleGroupById(int id);

        IList<RoleGroup> GetRoleGroups();
        int CreateOrUpdateRoleGroup(RoleGroup roleGroup);

        int DisableRoleGroup(int id);
    }
}
