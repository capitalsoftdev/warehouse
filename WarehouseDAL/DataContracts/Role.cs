using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseDAL.DataContracts
{
    public class Role
    {
        private int id = -1;
        private string name;
        bool isActive = true;

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
