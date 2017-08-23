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
        RoleGroup GetRoleGroup(int id);

        IList<RoleGroup> GetRoleGroup();
        int CreateOrUpdateRoleGroup(RoleGroup roleGroup);

        int DisableRoleGroup(int id);
    }
}
