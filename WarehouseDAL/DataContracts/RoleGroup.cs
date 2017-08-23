using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseDAL.DataContracts
{
    public class RoleGroup
    {
        private int id = -1;
        private string name;
        bool isActive;

        public RoleGroup() { }
        public RoleGroup(int id, string name, bool isActive)
        {
            this.Id = id;
            this.Name = name;
            this.IsActive = isActive;
        }

        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public bool IsActive
        {
            set { isActive = value; }
            get { return isActive; }
        }

    }
}
