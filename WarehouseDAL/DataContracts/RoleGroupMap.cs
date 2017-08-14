using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseDAL.DataContracts
{
    public class RoleGroupMap
    {
        private int roleGroupId;
        private int roleId;
        public int RoleGroupId { get { return this.roleGroupId; } set { this.roleGroupId = value; } }
        public int RoleId { get { return this.roleId; } set { this.roleId = value; } }
    }
}
