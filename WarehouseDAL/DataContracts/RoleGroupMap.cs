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
        public int RoleGroupId { get => roleGroupId; set => roleGroupId = value; }
        public int RoleId { get => roleId; set => roleId = value; }
    }
}
